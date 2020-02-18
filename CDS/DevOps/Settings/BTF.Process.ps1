
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
                SolutionName = 'CCLLCBTFProcess'
                Managed = $false
                ZipFile = "$projectRoot\temp\export\CCLLC.BTF.Process.zip"
            },
            [PSCustomObject]@{
                SolutionName = 'CCLLCBTFProcess'
                Managed = $true
                ZipFile = "$projectRoot\temp\export\CCLLC.BTF.Process_managed.zip"
            }
        )
    }
  
	ExtractSolutions = @(
        [PSCustomObject]@{
            ZipFile = "$projectRoot\temp\export\CCLLC.BTF.Process.zip"
            MappingXmlFile = "$projectRoot\CCLLC.BTF.Process.CDSSolution\CCLLC.BTF.Process.Mappings.xml"
            PackageType = 'Both' # Unmanaged, Managed, Both
            Folder = "$projectRoot\CCLLC.BTF.Process.CDSSolution\Solution"
        }
    ) 
	
  
    ExtractedSolutions = @(
        [PSCustomObject]@{
            Folder = "$projectRoot\CCLLC.BTF.Process.CDSSolution\Solution"
            MappingXmlFile = "$projectRoot\CCLLC.BTF.Process.CDSSolution\CCLLC.BTF.Process.Mappings.xml"
            PackageType = $PackageType
            ZipFile = "$projectRoot\temp\packed\CCLLC.BTF.Process$solutionExt.zip"
        }
    )
	
    CrmPackageDefinition = @(
        [PSCustomObject]@{            
            SolutionZipFiles = @(
                "$projectRoot\temp\packed\CCLLC.BTF.Process$solutionExt.zip"
            )
        }
    ) 
	
    CrmPackageDeploymentDefinition = [PSCustomObject]@{
        CrmConnectionParameters = $CrmConnectionParameters
    }
}