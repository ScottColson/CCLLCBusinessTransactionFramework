param (
    # The connection parameters for the target organization
    [Parameter(Mandatory)]
    [ValidateSet("DEV_1","DEV_2","BTF_Test")] # update this list based on files in the CrmConnectionParameters folder
    [string]
    $CrmConnectionName,

    # The settings for the actions performed during the import
    [Parameter(Mandatory)]
    [ValidateSet("BTF.Process","BTF.Platform","BTF.Revenue")] # update this list based on files in the ImportSettings folder
    [string]
    $ImportSettings,

    [ValidateSet("Managed","Unmanaged")]
    [string]
    $PackageType = "Unmanaged",   

    # The available actions to perform during the import
    [ValidateSet("All","Compress-CrmData","Compress-CrmSolution","New-CrmPackage","Invoke-ImportCrmPackage","Solutions")]
    [string[]]
    $Actions = "All"
)

$global:ErrorActionPreference = "Stop"

$CrmConnectionParameters = & "$PSScriptRoot\CrmConnectionParameters\$CrmConnectionName.ps1"

$settings = & "$PSScriptRoot\Settings\$ImportSettings.ps1" -CrmConnectionParameters $CrmConnectionParameters -PackageType $PackageType

if($settings.CrmOrganizationProvisionDefinition -and $CrmConnectionParameters.ServerUrl -eq 'http://dyn365.contoso.com' -and ("All" -in $Actions -or 'Restore-CrmRemoteOrganization' -in $Actions)) {
    $settings.CrmOrganizationProvisionDefinition | Restore-CrmRemoteOrganization -Force:$OverwriteOrganization
}

if($settings.ExtractedData -and ("All" -in $Actions -or 'Compress-CrmData' -in $Actions -or 'Data' -in $Actions)) {
    $settings.ExtractedData | Compress-CrmData
}

if($settings.ExtractedSolutions -and ("All" -in $Actions -or 'Compress-CrmSolution' -in $Actions -or 'Solutions' -in $Actions)) {
    $settings.ExtractedSolutions | Compress-CrmSolution
}

# remove data file from definition if doing only solutions
if($settings.CrmPackageDefinition -and  'Solutions' -in $Actions) {
	For ($i=0; $i -lt $settings.CrmPackageDefinition.Length; $i++) {
		$settings.CrmPackageDefinition[$i].PSObject.Properties.Remove("DataZipFile")
    }
}

if($settings.CrmPackageDefinition -and ("All" -in $Actions -or 'New-CrmPackage' -in $Actions -or 'Solutions' -in $Actions)) {
    $settings.CrmPackageDefinition | New-CrmPackage
}

if($settings.CrmPackageDeploymentDefinition -and ("All" -in $Actions -or 'Invoke-ImportCrmPackage' -in $Actions -or 'Solutions' -in $Actions)) {
    $settings.CrmPackageDeploymentDefinition | Invoke-ImportCrmPackage
}