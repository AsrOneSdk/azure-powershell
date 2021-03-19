namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.PowerShell;

    /// <summary>Represents a server to be updated.</summary>
    [System.ComponentModel.TypeConverter(typeof(ServerForUpdateTypeConverter))]
    public partial class ServerForUpdate
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.ServerForUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdate" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdate DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ServerForUpdate(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.ServerForUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdate" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdate DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ServerForUpdate(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ServerForUpdate" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdate FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.ServerForUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ServerForUpdate(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.ISkuAutoGenerated) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.SkuAutoGeneratedTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesForUpdate) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.ServerPropertiesForUpdateTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.ServerForUpdateTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).SkuName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).SkuTier = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.SkuTier) content.GetValueForProperty("SkuTier",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).SkuTier, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.SkuTier.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).MaintenanceWindow = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IMaintenanceWindow) content.GetValueForProperty("MaintenanceWindow",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).MaintenanceWindow, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.MaintenanceWindowTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).StorageProfile = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IStorageProfileAutoGenerated) content.GetValueForProperty("StorageProfile",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).StorageProfile, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.StorageProfileAutoGeneratedTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).AdministratorLoginPassword = (System.Security.SecureString) content.GetValueForProperty("AdministratorLoginPassword",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).AdministratorLoginPassword, (object ss) => (System.Security.SecureString)ss);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).HaEnabled = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HaEnabledEnum?) content.GetValueForProperty("HaEnabled",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).HaEnabled, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HaEnabledEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).MaintenanceWindowCustomWindow = (string) content.GetValueForProperty("MaintenanceWindowCustomWindow",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).MaintenanceWindowCustomWindow, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).StorageProfileBackupRetentionDay = (int?) content.GetValueForProperty("StorageProfileBackupRetentionDay",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).StorageProfileBackupRetentionDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).StorageProfileStorageMb = (int?) content.GetValueForProperty("StorageProfileStorageMb",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).StorageProfileStorageMb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).MaintenanceWindowStartHour = (int?) content.GetValueForProperty("MaintenanceWindowStartHour",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).MaintenanceWindowStartHour, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).MaintenanceWindowStartMinute = (int?) content.GetValueForProperty("MaintenanceWindowStartMinute",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).MaintenanceWindowStartMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).MaintenanceWindowDayOfWeek = (int?) content.GetValueForProperty("MaintenanceWindowDayOfWeek",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).MaintenanceWindowDayOfWeek, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.ServerForUpdate"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ServerForUpdate(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).Sku = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.ISkuAutoGenerated) content.GetValueForProperty("Sku",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).Sku, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.SkuAutoGeneratedTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerPropertiesForUpdate) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.ServerPropertiesForUpdateTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).Location = (string) content.GetValueForProperty("Location",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).Location, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).Tag = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateTags) content.GetValueForProperty("Tag",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).Tag, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.ServerForUpdateTagsTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).SkuName = (string) content.GetValueForProperty("SkuName",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).SkuName, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).SkuTier = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.SkuTier) content.GetValueForProperty("SkuTier",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).SkuTier, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.SkuTier.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).MaintenanceWindow = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IMaintenanceWindow) content.GetValueForProperty("MaintenanceWindow",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).MaintenanceWindow, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.MaintenanceWindowTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).StorageProfile = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IStorageProfileAutoGenerated) content.GetValueForProperty("StorageProfile",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).StorageProfile, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.StorageProfileAutoGeneratedTypeConverter.ConvertFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).AdministratorLoginPassword = (System.Security.SecureString) content.GetValueForProperty("AdministratorLoginPassword",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).AdministratorLoginPassword, (object ss) => (System.Security.SecureString)ss);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).HaEnabled = (Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HaEnabledEnum?) content.GetValueForProperty("HaEnabled",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).HaEnabled, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HaEnabledEnum.CreateFrom);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).MaintenanceWindowCustomWindow = (string) content.GetValueForProperty("MaintenanceWindowCustomWindow",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).MaintenanceWindowCustomWindow, global::System.Convert.ToString);
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).StorageProfileBackupRetentionDay = (int?) content.GetValueForProperty("StorageProfileBackupRetentionDay",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).StorageProfileBackupRetentionDay, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).StorageProfileStorageMb = (int?) content.GetValueForProperty("StorageProfileStorageMb",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).StorageProfileStorageMb, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).MaintenanceWindowStartHour = (int?) content.GetValueForProperty("MaintenanceWindowStartHour",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).MaintenanceWindowStartHour, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).MaintenanceWindowStartMinute = (int?) content.GetValueForProperty("MaintenanceWindowStartMinute",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).MaintenanceWindowStartMinute, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).MaintenanceWindowDayOfWeek = (int?) content.GetValueForProperty("MaintenanceWindowDayOfWeek",((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20200214Preview.IServerForUpdateInternal)this).MaintenanceWindowDayOfWeek, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Represents a server to be updated.
    [System.ComponentModel.TypeConverter(typeof(ServerForUpdateTypeConverter))]
    public partial interface IServerForUpdate

    {

    }
}