//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#nullable enable

using Shared.Models;

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"
#pragma warning disable 3016 // Disable "CS3016 Arrays as attribute arguments is not CLS-compliant"

namespace Transact.Microservice.GenericConfig
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.14.5.0 (NJsonSchema v10.5.2.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial interface IGenericConfigService
    {
        /// <summary>Retrieves the details of application configuration</summary>
        /// <param name="configName">Indicates unique config name present inside the configuration group</param>
        /// <param name="groupId">Indicates unique identifier of the configuration group</param>
        /// <param name="versionId">Indicates optional search string to retrieve the selected version of artefact. If version id is not sent, retrieves the latest version of the configuration</param>
        /// <returns>Searches and retrieves the configuration schema based on the groupId and configuration name</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Configuration> GetConfigByNameAsync(string configName, string groupId, string? versionId);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the details of application configuration</summary>
        /// <param name="configName">Indicates unique config name present inside the configuration group</param>
        /// <param name="groupId">Indicates unique identifier of the configuration group</param>
        /// <param name="versionId">Indicates optional search string to retrieve the selected version of artefact. If version id is not sent, retrieves the latest version of the configuration</param>
        /// <returns>Searches and retrieves the configuration schema based on the groupId and configuration name</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<Configuration> GetConfigByNameAsync(string configName, string groupId, string? versionId, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Updates the configuration details</summary>
        /// <param name="groupId">Indicates unique identifier represents a unique configuration group.</param>
        /// <param name="configName">Indicates unique config name of the configuration maintained under the specified configuration group</param>
        /// <param name="body">Request body consisting of the ConfigurationInput details along with the version</param>
        /// <returns>Displays the updated record as response which consists of ID, name, version and the updated record details.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<ConfigurationRecord> ModifyConfigurationAsync(string groupId, string configName, ConfigurationInput? body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Updates the configuration details</summary>
        /// <param name="groupId">Indicates unique identifier represents a unique configuration group.</param>
        /// <param name="configName">Indicates unique config name of the configuration maintained under the specified configuration group</param>
        /// <param name="body">Request body consisting of the ConfigurationInput details along with the version</param>
        /// <returns>Displays the updated record as response which consists of ID, name, version and the updated record details.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<ConfigurationRecord> ModifyConfigurationAsync(string groupId, string configName, ConfigurationInput? body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Creates a new application configuration</summary>
        /// <param name="groupId">Indicates unique identifier of the configuration group</param>
        /// <param name="configName">Indicates unique config name present inside the configuration group</param>
        /// <param name="body">Request body consisting of the Configuration details</param>
        /// <returns>Displays the created record as response which consists of ID, name, version and the updated record details.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<ConfigurationRecord> AddconfigurationAsync(string groupId, string configName, Configuration? body);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Creates a new application configuration</summary>
        /// <param name="groupId">Indicates unique identifier of the configuration group</param>
        /// <param name="configName">Indicates unique config name present inside the configuration group</param>
        /// <param name="body">Request body consisting of the Configuration details</param>
        /// <returns>Displays the created record as response which consists of ID, name, version and the updated record details.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<ConfigurationRecord> AddconfigurationAsync(string groupId, string configName, Configuration? body, System.Threading.CancellationToken cancellationToken);
    
        /// <summary>Retrieves the application configuration details for a specified configuration groupid.</summary>
        /// <param name="groupId">Indicates unique identifier of the configuration group</param>
        /// <param name="versionId">Indicates optional search string to retrieve the selected version of artefact. If version id is not sent, retrieves the latest version of the document</param>
        /// <returns>Searches and retrieves the configuration schema of all the configNames present inside a group based on the groupId</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<ConfigurationRecord>> GetConfigurationsAsync(string groupId, string? versionId);
    
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Retrieves the application configuration details for a specified configuration groupid.</summary>
        /// <param name="groupId">Indicates unique identifier of the configuration group</param>
        /// <param name="versionId">Indicates optional search string to retrieve the selected version of artefact. If version id is not sent, retrieves the latest version of the document</param>
        /// <returns>Searches and retrieves the configuration schema of all the configNames present inside a group based on the groupId</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        System.Threading.Tasks.Task<System.Collections.Generic.ICollection<ConfigurationRecord>> GetConfigurationsAsync(string groupId, string? versionId, System.Threading.CancellationToken cancellationToken);
    
    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ConfigurationData 
    {
        /// <summary>Base64-encoded contents of the configuration data</summary>
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public byte[] Data { get; set; }= default!;
    
        /// <summary>Configuration format</summary>
        [System.Text.Json.Serialization.JsonPropertyName("configType")]
        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public ConfigurationDataConfigType ConfigType { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [System.Text.Json.Serialization.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ConfigurationRecord 
    {
        /// <summary>Idenfier to indicate the configuration record.</summary>
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; }= default!;
    
        /// <summary>Indicates the name of the configuration</summary>
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }= default!;
    
        /// <summary>Indicates the version of the configuration</summary>
        [System.Text.Json.Serialization.JsonPropertyName("version")]
        public string Version { get; set; }= default!;
    
        /// <summary>Consists of entire details of configuration data</summary>
        [System.Text.Json.Serialization.JsonPropertyName("configData")]
        public ConfigurationData ConfigData { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [System.Text.Json.Serialization.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class Configuration 
    {
        /// <summary>Idenfier to indicate the configuration</summary>
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; }= default!;
    
        /// <summary>Indicates the name of the configuration</summary>
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name { get; set; }= default!;
    
        /// <summary>Indicates the version of the configuration</summary>
        [System.Text.Json.Serialization.JsonPropertyName("version")]
        public string Version { get; set; }= default!;
    
        /// <summary>Consists of entire details of configuration data</summary>
        [System.Text.Json.Serialization.JsonPropertyName("configData")]
        public ConfigurationData ConfigData { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [System.Text.Json.Serialization.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ConfigurationInput 
    {
        /// <summary>Indicates the version of the configuration</summary>
        [System.Text.Json.Serialization.JsonPropertyName("version")]
        public string Version { get; set; }= default!;
    
        /// <summary>Consists of entire details of configuration data</summary>
        [System.Text.Json.Serialization.JsonPropertyName("configData")]
        public ConfigurationData ConfigData { get; set; }= default!;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [System.Text.Json.Serialization.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    /// <summary>List of configuration records</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class ConfigruationRecords : System.Collections.ObjectModel.Collection<ConfigurationRecord>
    {
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v13.0.0.0)")]
    public enum ConfigurationDataConfigType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"properties")]
        Properties = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"json")]
        Json = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"xml")]
        Xml = 2,
    
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016