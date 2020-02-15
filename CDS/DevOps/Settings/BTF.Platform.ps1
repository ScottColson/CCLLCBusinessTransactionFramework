
param (
    [Parameter(Mandatory)]
    [ValidateNotNullOrEmpty()]
    [hashtable]
    $CrmConnectionParameters,

    [ValidateSet("Managed","Unmanaged")]
    [string]
    $PackageType = "Unmanaged"
)

$scriptsRoot = Split-Path -Parent $PSScriptRoot
$projectRoot = Split-Path -Parent $scriptsRoot
$solutionExt = if($PackageType -eq "Managed") { "_managed" }

@{  
	ExportSolutions = [PSCustomObject]@{
        CrmConnectionParameters = $CrmConnectionParameters
        Solutions = @(
            [PSCustomObject]@{
                SolutionName = 'CCLLCBTFPlatform'
                Managed = $false
                ZipFile = "$projectRoot\temp\export\CCLLC.BTF.Platform.zip"
            },
            [PSCustomObject]@{
                SolutionName = 'CCLLCBTFPlatform'
                Managed = $true
                ZipFile = "$projectRoot\temp\export\CCLLC.BTF.Platform_managed.zip"
            }
        )
    }
  
	ExtractSolutions = @(
        [PSCustomObject]@{
            ZipFile = "$projectRoot\temp\export\CCLLC.BTF.Platform.zip"
            MappingXmlFile = "$projectRoot\CCLLC.BTF.Platform.CDSSolution\CCLLC.BTF.Platform.Mappings.xml"
            PackageType = 'Both' # Unmanaged, Managed, Both
            Folder = "$projectRoot\CCLLC.BTF.Platform.CDSSolution\Solution"
        }
    ) 
	
  
    ExtractedSolutions = @(
        [PSCustomObject]@{
            Folder = "$projectRoot\CCLLC.BTF.Platform.CDSSolution\Solution"
            MappingXmlFile = "$projectRoot\CCLLC.BTF.Platform.CDSSolution\CCLLC.BTF.Platform.Mappings.xml"
            PackageType = $PackageType
            ZipFile = "$projectRoot\temp\packed\CCLLC.BTF.Platform$solutionExt.zip"
        }
    )
	
    CrmPackageDefinition = @(
        [PSCustomObject]@{            
            SolutionZipFiles = @(
                "$projectRoot\temp\packed\CCLLC.BTF.Platform$solutionExt.zip"
            )
        }
    ) 
	
    CrmPackageDeploymentDefinition = [PSCustomObject]@{
        CrmConnectionParameters = $CrmConnectionParameters
    }
}