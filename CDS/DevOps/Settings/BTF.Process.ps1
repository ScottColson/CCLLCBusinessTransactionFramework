
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
	# ExportSolutions is used by export.ps1. Defines the managed and unmanaged solution(s) to export
	# and the location to place the exported zip files.
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
  
	# ExtractSolutions is used by export.ps1. Defines the location of the solution zip file
	# to expand and the location in the repository to place the metadata.
	ExtractSolutions = @(
        [PSCustomObject]@{
            ZipFile = "$projectRoot\temp\export\CCLLC.BTF.Process.zip"
            MappingXmlFile = "$projectRoot\CCLLC.BTF.Process.CDSSolution\CCLLC.BTF.Process.Mappings.xml"
            PackageType = 'Both' # Unmanaged, Managed, Both
            Folder = "$projectRoot\CCLLC.BTF.Process.CDSSolution\Solution"
        }) 
	
	# ExtractData is used by export.ps1. Defines the name of the data zip file to expand and the 
	# location in the repostiory to place the data.
    ExtractData = [PSCustomObject]@{
        ZipFile = "$projectRoot\temp\export\BTFProcessMetaData.zip"
        Folder = "$projectRoot\CCLLC.BTF.Process.CDSSolution\MetaData"
    }
	
	# ExtractedSolutions is used by import.ps1. Defines location of solution metadata in repository and the 
	# zip file(s) created as part of the packing process. Multiple solutions can be packed as part of the 
	# same process.
    ExtractedSolutions = @(
        [PSCustomObject]@{
            Folder = "$projectRoot\CCLLC.BTF.Process.CDSSolution\Solution"
            MappingXmlFile = "$projectRoot\CCLLC.BTF.Process.CDSSolution\CCLLC.BTF.Process.Mappings.xml"
            PackageType = $PackageType
            ZipFile = "$projectRoot\temp\packed\CCLLC.BTF.Process$solutionExt.zip"
        },
		[PSCustomObject]@{
            Folder = "$projectRoot\CCLLC.BTF.Revenue.CDSSolution\Solution"
            MappingXmlFile = "$projectRoot\CCLLC.BTF.Revenue.CDSSolution\CCLLC.BTF.Revenue.Mappings.xml"
            PackageType = "Managed"
            ZipFile = "$projectRoot\temp\packed\CCLLC.BTF.Revenue_managed.zip"
        },
		[PSCustomObject]@{
            Folder = "$projectRoot\CCLLC.BTF.Platform.CDSSolution\Solution"
            MappingXmlFile = "$projectRoot\CCLLC.BTF.Platform.CDSSolution\CCLLC.BTF.Platform.Mappings.xml"
            PackageType = "Managed"
            ZipFile = "$projectRoot\temp\packed\CCLLC.BTF.Platform_managed.zip"
        })
	
	# ExtractedData is used by import.ps1. Defines location of data in repository and the zip file created as 
	# part of the data packing proceess.
    ExtractedData = [PSCustomObject]@{
        Folder = "$projectRoot\CCLLC.BTF.Process.CDSSolution\MetaData"
        ZipFile = "$projectRoot\temp\packed\CCLLC.BTF.Process.MetaData.zip"
    }
	
	# CrmPackageDefinition is used by import.ps1. Defines the solutions and data that will be incluced 
	# in the solution.
    CrmPackageDefinition = @(
        [PSCustomObject]@{   
			DataZipFile = "$projectRoot\temp\packed\CCLLC.BTF.Process.MetaData.zip"		
            SolutionZipFiles = @(
				"$projectRoot\temp\packed\CCLLC.BTF.Platform_managed.zip",
				"$projectRoot\temp\packed\CCLLC.BTF.Revenue_managed.zip",
                "$projectRoot\temp\packed\CCLLC.BTF.Process$solutionExt.zip")			
        }
    ) 
	
	# CrmPackageDeploymentDefinition is used by import.ps1. Provides instructions to the package deployer utility to select and import 
    # a package.
    CrmPackageDeploymentDefinition = [PSCustomObject]@{
        CrmConnectionParameters = $CrmConnectionParameters
    }
}