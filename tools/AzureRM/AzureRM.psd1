#
# Module manifest for module 'PSGet_AzureRM'
#
# Generated by: Microsoft Corporation
#
# Generated on: 11/3/2017
#

@{

# Script module or binary module file associated with this manifest.
RootModule = '.\AzureRM.psm1'

# Version number of this module.
ModuleVersion = '5.0.1'

# Supported PSEditions
# CompatiblePSEditions = @()

# ID used to uniquely identify this module
GUID = 'b433e830-b479-4f7f-9c80-9cc6c28e1b51'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Azure Resource Manager Module'

# Minimum version of the Windows PowerShell engine required by this module
PowerShellVersion = '3.0'

# Name of the Windows PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the Windows PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.5.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
CLRVersion = '4.0'

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'AzureRM.Profile'; RequiredVersion = '4.0.0'; }, 
               @{ModuleName = 'Azure.Storage'; RequiredVersion = '4.0.0'; }, 
               @{ModuleName = 'AzureRM.AnalysisServices'; RequiredVersion = '0.5.0'; }, 
               @{ModuleName = 'Azure.AnalysisServices'; RequiredVersion = '0.5.0'; }, 
               @{ModuleName = 'AzureRM.ApiManagement'; RequiredVersion = '5.0.1'; }, 
               @{ModuleName = 'AzureRM.ApplicationInsights'; RequiredVersion = '0.1.0'; }, 
               @{ModuleName = 'AzureRM.Automation'; RequiredVersion = '4.0.0'; }, 
               @{ModuleName = 'AzureRM.Backup'; RequiredVersion = '4.0.1'; }, 
               @{ModuleName = 'AzureRM.Batch'; RequiredVersion = '4.0.1'; }, 
               @{ModuleName = 'AzureRM.Billing'; RequiredVersion = '0.14.0'; }, 
               @{ModuleName = 'AzureRM.Cdn'; RequiredVersion = '4.0.0'; }, 
               @{ModuleName = 'AzureRM.CognitiveServices'; RequiredVersion = '0.9.0'; }, 
               @{ModuleName = 'AzureRM.Compute'; RequiredVersion = '4.0.1'; }, 
               @{ModuleName = 'AzureRM.Consumption'; RequiredVersion = '0.3.0'; }, 
               @{ModuleName = 'AzureRM.ContainerInstance'; RequiredVersion = '0.1.0'; }, 
               @{ModuleName = 'AzureRM.ContainerRegistry'; RequiredVersion = '0.3.0'; }, 
               @{ModuleName = 'AzureRM.DataFactories'; RequiredVersion = '4.0.1'; }, 
               @{ModuleName = 'AzureRM.DataFactoryV2'; RequiredVersion = '0.3.0'; }, 
               @{ModuleName = 'AzureRM.DataLakeAnalytics'; RequiredVersion = '4.0.0'; }, 
               @{ModuleName = 'AzureRM.DataLakeStore'; RequiredVersion = '5.0.0'; }, 
               @{ModuleName = 'AzureRM.DevTestLabs'; RequiredVersion = '4.0.0'; }, 
               @{ModuleName = 'AzureRM.Dns'; RequiredVersion = '4.0.0'; }, 
               @{ModuleName = 'AzureRM.EventGrid'; RequiredVersion = '0.2.0'; }, 
               @{ModuleName = 'AzureRM.EventHub'; RequiredVersion = '0.5.0'; }, 
               @{ModuleName = 'AzureRM.HDInsight'; RequiredVersion = '4.0.1'; }, 
               @{ModuleName = 'AzureRM.Insights'; RequiredVersion = '4.0.0'; }, 
               @{ModuleName = 'AzureRM.IoTHub'; RequiredVersion = '3.0.0'; }, 
               @{ModuleName = 'AzureRM.KeyVault'; RequiredVersion = '4.0.1'; }, 
               @{ModuleName = 'AzureRM.LogicApp'; RequiredVersion = '4.0.0'; }, 
               @{ModuleName = 'AzureRM.MachineLearning'; RequiredVersion = '0.16.0'; }, 
               @{ModuleName = 'AzureRM.MachineLearningCompute'; RequiredVersion = '0.2.0'; }, 
               @{ModuleName = 'AzureRM.MarketplaceOrdering'; RequiredVersion = '0.2.0'; }, 
               @{ModuleName = 'AzureRM.Media'; RequiredVersion = '0.8.0'; }, 
               @{ModuleName = 'AzureRM.Network'; RequiredVersion = '5.0.0'; }, 
               @{ModuleName = 'AzureRM.NotificationHubs'; RequiredVersion = '4.0.0'; }, 
               @{ModuleName = 'AzureRM.OperationalInsights'; RequiredVersion = '4.0.0'; }, 
               @{ModuleName = 'AzureRM.PowerBIEmbedded'; RequiredVersion = '4.0.0'; }, 
               @{ModuleName = 'AzureRM.RecoveryServices'; RequiredVersion = '4.0.1'; }, 
               @{ModuleName = 'AzureRM.RecoveryServices.Backup'; RequiredVersion = '4.0.1'; }, 
               @{ModuleName = 'AzureRM.RecoveryServices.SiteRecovery'; RequiredVersion = '0.2.1'; }, 
               @{ModuleName = 'AzureRM.RedisCache'; RequiredVersion = '4.0.1'; }, 
               @{ModuleName = 'AzureRM.Relay'; RequiredVersion = '0.3.0'; }, 
               @{ModuleName = 'AzureRM.Resources'; RequiredVersion = '5.0.0'; }, 
               @{ModuleName = 'AzureRM.Scheduler'; RequiredVersion = '0.16.0'; }, 
               @{ModuleName = 'AzureRM.ServerManagement'; RequiredVersion = '4.0.0'; }, 
               @{ModuleName = 'AzureRM.ServiceBus'; RequiredVersion = '0.5.0'; }, 
               @{ModuleName = 'AzureRM.ServiceFabric'; RequiredVersion = '0.3.0'; }, 
               @{ModuleName = 'AzureRM.SiteRecovery'; RequiredVersion = '5.0.1'; }, 
               @{ModuleName = 'AzureRM.Sql'; RequiredVersion = '4.0.1'; }, 
               @{ModuleName = 'AzureRM.Storage'; RequiredVersion = '4.0.1'; }, 
               @{ModuleName = 'AzureRM.StreamAnalytics'; RequiredVersion = '4.0.1'; }, 
               @{ModuleName = 'AzureRM.Tags'; RequiredVersion = '4.0.0'; }, 
               @{ModuleName = 'AzureRM.TrafficManager'; RequiredVersion = '4.0.0'; }, 
               @{ModuleName = 'AzureRM.UsageAggregates'; RequiredVersion = '4.0.0'; }, 
               @{ModuleName = 'AzureRM.Websites'; RequiredVersion = '4.0.0'; })

# Assemblies that must be loaded prior to importing this module
# RequiredAssemblies = @()

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
# FormatsToProcess = @()

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
# NestedModules = @()

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = @()

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = @()

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = @()

# DSC resources to export from this module
# DscResourcesToExport = @()

# List of all modules packaged with this module
# ModuleList = @()

# List of all files packaged with this module
# FileList = @()

# Private data to pass to the module specified in RootModule/ModuleToProcess. This may also contain a PSData hashtable with additional module metadata used by PowerShell.
PrivateData = @{

    PSData = @{

        # Tags applied to this module. These help with module discovery in online galleries.
        # Tags = @()

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/azps-license'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = '## 2017.11.10 - Version 5.0.1
* Fixed assembly loading issue that caused some cmdlets to fail when executing in the following modules:
    - AzureRM.ApiManagement
    - AzureRM.Backup
    - AzureRM.Batch
    - AzureRM.Compute
    - AzureRM.DataFactories
    - AzureRM.HDInsight
    - AzureRM.KeyVault
    - AzureRM.RecoveryServices
    - AzureRM.RecoveryServices.Backup
    - AzureRM.RecoveryServices.SiteRecovery
    - AzureRM.RedisCache
    - AzureRM.SiteRecovery
    - AzureRM.Sql
    - AzureRM.Storage
    - AzureRM.StreamAnalytics'

        # External dependent modules of this module
        # ExternalModuleDependencies = ''

    } # End of PSData hashtable
    
 } # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

