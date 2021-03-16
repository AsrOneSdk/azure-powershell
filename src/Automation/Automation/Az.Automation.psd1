#
# Module manifest for module 'Az.Automation'
#
# Generated by: Microsoft Corporation
#
# Generated on: 2/26/2021
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '1.5.1'

# Supported PSEditions
CompatiblePSEditions = 'Core', 'Desktop'

# ID used to uniquely identify this module
GUID = 'ef36c942-4a71-4e19-9450-05a35843deb6'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = 'Microsoft Azure PowerShell - Automation service cmdlets for Azure Resource Manager in Windows PowerShell and PowerShell Core.

For more information on Automation, please visit the following: https://docs.microsoft.com/azure/automation/'

# Minimum version of the PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
DotNetFrameworkVersion = '4.7.2'

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# CLRVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'Az.Accounts'; ModuleVersion = '2.2.6'; })

# Assemblies that must be loaded prior to importing this module
RequiredAssemblies = 'Microsoft.Azure.Management.Automation.dll'

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
FormatsToProcess = 'Automation.format.ps1xml'

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
NestedModules = @('Microsoft.Azure.PowerShell.Cmdlets.Automation.dll')

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = @()

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = 'Get-AzAutomationHybridWorkerGroup', 
               'Remove-AzAutomationHybridWorkerGroup', 
               'Get-AzAutomationJobOutputRecord', 
               'Import-AzAutomationDscNodeConfiguration', 
               'Export-AzAutomationDscConfiguration', 
               'Export-AzAutomationDscNodeReportContent', 
               'Get-AzAutomationCertificate', 'Get-AzAutomationConnection', 
               'Get-AzAutomationCredential', 'Get-AzAutomationDscCompilationJob', 
               'Get-AzAutomationDscCompilationJobOutput', 
               'Get-AzAutomationDscNodeConfiguration', 
               'Get-AzAutomationDscNodeReport', 'Get-AzAutomationJob', 
               'Get-AzAutomationJobOutput', 'Get-AzAutomationModule', 
               'Get-AzAutomationRunbook', 'Export-AzAutomationRunbook', 
               'Get-AzAutomationSchedule', 'Get-AzAutomationScheduledRunbook', 
               'Get-AzAutomationVariable', 'Get-AzAutomationWebhook', 
               'New-AzAutomationCertificate', 'New-AzAutomationConnection', 
               'New-AzAutomationCredential', 'New-AzAutomationModule', 
               'New-AzAutomationRunbook', 'New-AzAutomationSchedule', 
               'New-AzAutomationVariable', 'New-AzAutomationWebhook', 
               'Publish-AzAutomationRunbook', 'Register-AzAutomationDscNode', 
               'Register-AzAutomationScheduledRunbook', 
               'Remove-AzAutomationCertificate', 
               'Remove-AzAutomationConnectionType', 
               'Remove-AzAutomationConnection', 'Remove-AzAutomationCredential', 
               'Remove-AzAutomationDscNodeConfiguration', 
               'Remove-AzAutomationModule', 'Remove-AzAutomationRunbook', 
               'Remove-AzAutomationSchedule', 'Remove-AzAutomationVariable', 
               'Remove-AzAutomationDscConfiguration', 'Remove-AzAutomationWebhook', 
               'Resume-AzAutomationJob', 'Set-AzAutomationCertificate', 
               'Set-AzAutomationConnectionFieldValue', 
               'Set-AzAutomationCredential', 'Set-AzAutomationModule', 
               'Set-AzAutomationRunbook', 'Import-AzAutomationRunbook', 
               'Set-AzAutomationSchedule', 'Set-AzAutomationVariable', 
               'Set-AzAutomationWebhook', 'Start-AzAutomationDscCompilationJob', 
               'Get-AzAutomationRegistrationInfo', 
               'Get-AzAutomationDscConfiguration', 'Get-AzAutomationDscNode', 
               'Get-AzAutomationDscOnboardingMetaconfig', 
               'Import-AzAutomationDscConfiguration', 'New-AzAutomationKey', 
               'Start-AzAutomationRunbook', 'Stop-AzAutomationJob', 
               'Suspend-AzAutomationJob', 'Unregister-AzAutomationDscNode', 
               'Set-AzAutomationAccount', 'Remove-AzAutomationAccount', 
               'New-AzAutomationAccount', 'Get-AzAutomationAccount', 
               'Set-AzAutomationDscNode', 
               'Unregister-AzAutomationScheduledRunbook', 
               'Start-AzAutomationDscNodeConfigurationDeployment', 
               'Stop-AzAutomationDscNodeConfigurationDeployment', 
               'Get-AzAutomationDscNodeConfigurationDeploymentSchedule', 
               'Get-AzAutomationDscNodeConfigurationDeployment', 
               'New-AzAutomationSoftwareUpdateConfiguration', 
               'New-AzAutomationUpdateManagementAzureQuery', 
               'Get-AzAutomationSoftwareUpdateConfiguration', 
               'Remove-AzAutomationSoftwareUpdateConfiguration', 
               'Get-AzAutomationSoftwareUpdateRun', 
               'Get-AzAutomationSoftwareUpdateMachineRun', 
               'New-AzAutomationSourceControl', 'Get-AzAutomationSourceControl', 
               'Remove-AzAutomationSourceControl', 
               'Update-AzAutomationSourceControl', 
               'Start-AzAutomationSourceControlSyncJob', 
               'Get-AzAutomationSourceControlSyncJob', 
               'Get-AzAutomationSourceControlSyncJobOutput'

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = 'Import-AzAutomationModule'

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
        Tags = 'Azure','ResourceManager','ARM','Automation'

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/azps-license'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = '* Fixed te issue that complex object cannot be serialized correctly. [#14431]'

        # Prerelease string of this module
        # Prerelease = ''

        # Flag to indicate whether the module requires explicit user acceptance for install/update/save
        # RequireLicenseAcceptance = $false

        # External dependent modules of this module
        # ExternalModuleDependencies = @()

    } # End of PSData hashtable

 } # End of PrivateData hashtable

# HelpInfo URI of this module
# HelpInfoURI = ''

# Default prefix for commands exported from this module. Override the default prefix using Import-Module -Prefix.
# DefaultCommandPrefix = ''

}

