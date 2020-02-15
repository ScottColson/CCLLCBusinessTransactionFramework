
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
                SolutionName = 'CCLLCBTFRevenue'
                Managed = $false
                ZipFile = "$projectRoot\temp\export\CCLLC.BTF.Revenue.zip"
            },
            [PSCustomObject]@{
                SolutionName = 'CCLLCBTFRevenue'
                Managed = $true
                ZipFile = "$projectRoot\temp\export\CCLLC.BTF.Revenue_managed.zip"
            }
        )
    }
  
	ExtractSolutions = @(
        [PSCustomObject]@{
            ZipFile = "$projectRoot\temp\export\CCLLC.BTF.Revenue.zip"
            MappingXmlFile = "$projectRoot\CCLLC.BTF.Revenue.CDSSolution\CCLLC.BTF.Revenue.Mappings.xml"
            PackageType = 'Both' # Unmanaged, Managed, Both
            Folder = "$projectRoot\CCLLC.BTF.Revenue.CDSSolution\Solution"
        }
    ) 
	
  
    ExtractedSolutions = @(
        [PSCustomObject]@{
            Folder = "$projectRoot\CCLLC.BTF.Revenue.CDSSolution\Solution"
            MappingXmlFile = "$projectRoot\CCLLC.BTF.Revenue.CDSSolution\CCLLC.BTF.Revenue.Mappings.xml"
            PackageType = $PackageType
            ZipFile = "$projectRoot\temp\packed\CCLLC.BTF.Revenue$solutionExt.zip"
        }
    )
	
    CrmPackageDefinition = @(
        [PSCustomObject]@{            
            SolutionZipFiles = @(
                "$projectRoot\temp\packed\CCLLC.BTF.Revenue$solutionExt.zip"
            )
        }
    ) 
	
    CrmPackageDeploymentDefinition = [PSCustomObject]@{
        CrmConnectionParameters = $CrmConnectionParameters
    }
}