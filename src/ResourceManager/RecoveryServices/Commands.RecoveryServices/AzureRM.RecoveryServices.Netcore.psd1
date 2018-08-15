#
# Module manifest for module 'AzureRM.RecoveryServices'
#
# Generated by: Microsoft Corporation
#
# Generated on: 3/13/2018
#

@{

# Script module or binary module file associated with this manifest.
# RootModule = ''

# Version number of this module.
ModuleVersion = '0.13.1'

# Supported PSEditions
CompatiblePSEditions = 'Core'

# ID used to uniquely identify this module
GUID = '5af71f43-17ca-45bd-b534-34524b801ade'

# Author of this module
Author = 'Microsoft Corporation'

# Company or vendor of this module
CompanyName = 'Microsoft Corporation'

# Copyright statement for this module
Copyright = 'Microsoft Corporation. All rights reserved.'

# Description of the functionality provided by this module
Description = '[PowerShell .Net Core] Microsoft Azure PowerShell - RecoveryServices cmdlets for Azure Resource Manager'

# Minimum version of the Windows PowerShell engine required by this module
PowerShellVersion = '5.1'

# Name of the Windows PowerShell host required by this module
# PowerShellHostName = ''

# Minimum version of the Windows PowerShell host required by this module
# PowerShellHostVersion = ''

# Minimum version of Microsoft .NET Framework required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# DotNetFrameworkVersion = ''

# Minimum version of the common language runtime (CLR) required by this module. This prerequisite is valid for the PowerShell Desktop edition only.
# CLRVersion = ''

# Processor architecture (None, X86, Amd64) required by this module
# ProcessorArchitecture = ''

# Modules that must be imported into the global environment prior to importing this module
RequiredModules = @(@{ModuleName = 'AzureRM.Profile.Netcore'; ModuleVersion = '0.13.1'; })

# Assemblies that must be loaded prior to importing this module
RequiredAssemblies = '.\Microsoft.Azure.Commands.RecoveryServices.Backup.Models.dll', 
    '.\Microsoft.Azure.Management.RecoveryServices.Backup.dll', 
    '.\Microsoft.Azure.Commands.RecoveryServices.Backup.Helpers.dll', 
    '.\Microsoft.Azure.Commands.RecoveryServices.Backup.Logger.dll', 
    '.\Microsoft.Azure.Commands.RecoveryServices.Backup.Providers.dll', 
    '.\Microsoft.Azure.Commands.RecoveryServices.Backup.ServiceClientAdapter.dll',
    '.\Microsoft.Azure.Management.RecoveryServices.dll', 
    '.\Microsoft.Azure.Management.RecoveryServices.siteRecovery.dll', 
    '.\Security.Cryptography.dll'

# Script files (.ps1) that are run in the caller's environment prior to importing this module.
# ScriptsToProcess = @()

# Type files (.ps1xml) to be loaded when importing this module
# TypesToProcess = @()

# Format files (.ps1xml) to be loaded when importing this module
FormatsToProcess = '.\Microsoft.Azure.Commands.RecoveryServices.Backup.format.ps1xml'

# Modules to import as nested modules of the module specified in RootModule/ModuleToProcess
NestedModules = @('.\Microsoft.Azure.Commands.RecoveryServices.ARM.dll',
    '.\Microsoft.Azure.Commands.RecoveryServices.Backup.dll',
	'.\Microsoft.Azure.Commands.RecoveryServices.siteRecovery.dll')

# Functions to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no functions to export.
FunctionsToExport = @()

# Cmdlets to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no cmdlets to export.
CmdletsToExport = 'Get-AzureRmRecoveryServicesBackupProperty', 
    'Get-AzureRmRecoveryServicesVault', 
    'Get-AzureRmRecoveryServicesVaultSettingsFile', 
    'New-AzureRmRecoveryServicesVault', 
    'Remove-AzureRmRecoveryServicesVault', 
    'Set-AzureRmRecoveryServicesBackupProperties', 
    'Set-AzureRmRecoveryServicesVaultContext',
    'Backup-AzureRmRecoveryServicesBackupItem', 
    'Get-AzureRmRecoveryServicesBackupManagementServer', 
    'Get-AzureRmRecoveryServicesBackupContainer', 
    'Unregister-AzureRmRecoveryServicesBackupContainer', 
    'Disable-AzureRmRecoveryServicesBackupProtection', 
    'Enable-AzureRmRecoveryServicesBackupProtection', 
    'Get-AzureRmRecoveryServicesBackupItem', 
    'Get-AzureRmRecoveryServicesBackupJob', 
    'Get-AzureRmRecoveryServicesBackupJobDetails', 
    'Stop-AzureRmRecoveryServicesBackupJob', 
    'Wait-AzureRmRecoveryServicesBackupJob', 
    'Get-AzureRmRecoveryServicesBackupProtectionPolicy', 
    'Get-AzureRmRecoveryServicesBackupRetentionPolicyObject', 
    'Get-AzureRmRecoveryServicesBackupSchedulePolicyObject', 
    'New-AzureRmRecoveryServicesBackupProtectionPolicy', 
    'Remove-AzureRmRecoveryServicesBackupProtectionPolicy', 
    'Set-AzureRmRecoveryServicesBackupProtectionPolicy', 
    'Get-AzureRmRecoveryServicesBackupRecoveryPoint', 
    'Restore-AzureRmRecoveryServicesBackupItem', 
    'Unregister-AzureRmRecoveryServicesBackupManagementServer', 
    'Get-AzureRmRecoveryServicesBackupRPMountScript', 
    'Disable-AzureRmRecoveryServicesBackupRPMountScript',
	'Edit-AzureRmRecoveryServicesAsrRecoveryPlan', 
    'Get-AzureRmRecoveryServicesAsrAlertSetting', 
    'Get-AzureRmRecoveryServicesAsrEvent', 
    'Get-AzureRmRecoveryServicesAsrFabric', 
    'Get-AzureRmRecoveryServicesAsrJob', 
    'Get-AzureRmRecoveryServicesAsrNetwork', 
    'Get-AzureRmRecoveryServicesAsrNetworkMapping', 
    'Get-AzureRmRecoveryServicesAsrPolicy', 
    'Get-AzureRmRecoveryServicesAsrProtectableItem', 
    'Get-AzureRmRecoveryServicesAsrProtectionContainer', 
    'Get-AzureRmRecoveryServicesAsrProtectionContainerMapping', 
    'Get-AzureRmRecoveryServicesAsrRecoveryPlan', 
    'Get-AzureRmRecoveryServicesAsrRecoveryPoint', 
    'Get-AzureRmRecoveryServicesAsrReplicationProtectedItem', 
    'Get-AzureRmRecoveryServicesAsrServicesProvider', 
    'Get-AzureRmRecoveryServicesAsrStorageClassification', 
    'Get-AzureRmRecoveryServicesAsrStorageClassificationMapping', 
    'Get-AzureRmRecoveryServicesAsrVaultContext', 
    'Get-AzureRmRecoveryServicesAsrvCenter', 
    'Import-AzureRmRecoveryServicesAsrVaultSettingsFile', 
    'New-AzureRmRecoveryServicesAsrFabric', 
    'New-AzureRmRecoveryServicesAsrNetworkMapping', 
    'New-AzureRmRecoveryServicesAsrPolicy', 
    'New-AzureRmRecoveryServicesAsrProtectableItem', 
    'New-AzureRmRecoveryServicesAsrProtectionContainer', 
    'New-AzureRmRecoveryServicesAsrProtectionContainerMapping', 
    'New-AzureRmRecoveryServicesAsrRecoveryPlan', 
    'New-AzureRmRecoveryServicesAsrReplicationProtectedItem', 
    'New-AzureRmRecoveryServicesAsrStorageClassificationMapping', 
    'New-AzureRmRecoveryServicesAsrvCenter', 
    'New-AzureRmRecoveryServicesAsrAzureToAzureDiskReplicationConfig', 
    'Remove-AzureRmRecoveryServicesAsrFabric', 
    'Remove-AzureRmRecoveryServicesAsrNetworkMapping', 
    'Remove-AzureRmRecoveryServicesAsrPolicy', 
    'Remove-AzureRmRecoveryServicesAsrProtectionContainer', 
    'Remove-AzureRmRecoveryServicesAsrProtectionContainerMapping', 
    'Remove-AzureRmRecoveryServicesAsrRecoveryPlan', 
    'Remove-AzureRmRecoveryServicesAsrReplicationProtectedItem', 
    'Remove-AzureRmRecoveryServicesAsrServicesProvider', 
    'Remove-AzureRmRecoveryServicesAsrStorageClassificationMapping', 
    'Remove-AzureRmRecoveryServicesAsrvCenter', 
    'Restart-AzureRmRecoveryServicesAsrJob', 
    'Resume-AzureRmRecoveryServicesAsrJob', 
    'Set-AzureRmRecoveryServicesAsrAlertSetting', 
    'Set-AzureRmRecoveryServicesAsrReplicationProtectedItem', 
    'Set-AzureRmRecoveryServicesAsrVaultContext', 
    'Start-AzureRmRecoveryServicesAsrApplyRecoveryPoint', 
    'Start-AzureRmRecoveryServicesAsrCommitFailoverJob', 
    'Start-AzureRmRecoveryServicesAsrPlannedFailoverJob', 
    'Start-AzureRmRecoveryServicesAsrResynchronizeReplicationJob', 
    'Start-AzureRmRecoveryServicesAsrSwitchProcessServerJob', 
    'Start-AzureRmRecoveryServicesAsrTestFailoverCleanupJob', 
    'Start-AzureRmRecoveryServicesAsrTestFailoverJob', 
    'Start-AzureRmRecoveryServicesAsrUnplannedFailoverJob', 
    'Stop-AzureRmRecoveryServicesAsrJob', 
    'Update-AzureRmRecoveryServicesAsrMobilityService', 
    'Update-AzureRmRecoveryServicesAsrNetworkMapping', 
    'Update-AzureRmRecoveryServicesAsrPolicy', 
    'Update-AzureRmRecoveryServicesAsrProtectionDirection', 
    'Update-AzureRmRecoveryServicesAsrRecoveryPlan', 
    'Update-AzureRmRecoveryServicesAsrServicesProvider', 
    'Update-AzureRmRecoveryServicesAsrvCenter'

# Variables to export from this module
# VariablesToExport = @()

# Aliases to export from this module, for best performance, do not use wildcards and do not delete the entry, use an empty array if there are no aliases to export.
AliasesToExport = 'Get-AzureRmRecoveryServicesBackupProperties'

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
        Tags = 'Azure', 'ResourceManager', 'ARM', 'RecoveryServices'

        # A URL to the license for this module.
        LicenseUri = 'https://aka.ms/azps-license'

        # A URL to the main website for this project.
        ProjectUri = 'https://github.com/Azure/azure-powershell'

        # A URL to an icon representing this module.
        # IconUri = ''

        # ReleaseNotes of this module
        ReleaseNotes = 'Initial Release'

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

