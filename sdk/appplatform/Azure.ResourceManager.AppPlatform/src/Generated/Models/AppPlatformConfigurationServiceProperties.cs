// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Application Configuration Service properties payload. </summary>
    public partial class AppPlatformConfigurationServiceProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AppPlatformConfigurationServiceProperties"/>. </summary>
        public AppPlatformConfigurationServiceProperties()
        {
            Instances = new ChangeTrackingList<AppPlatformConfigurationServiceInstance>();
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformConfigurationServiceProperties"/>. </summary>
        /// <param name="provisioningState"> State of the Application Configuration Service. </param>
        /// <param name="resourceRequests"> The requested resource quantity for required CPU and Memory. </param>
        /// <param name="instances"> Collection of instances belong to Application Configuration Service. </param>
        /// <param name="settings"> The settings of Application Configuration Service. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppPlatformConfigurationServiceProperties(AppPlatformConfigurationServiceProvisioningState? provisioningState, AppPlatformConfigurationServiceRequirements resourceRequests, IReadOnlyList<AppPlatformConfigurationServiceInstance> instances, AppPlatformConfigurationServiceSettings settings, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProvisioningState = provisioningState;
            ResourceRequests = resourceRequests;
            Instances = instances;
            Settings = settings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> State of the Application Configuration Service. </summary>
        public AppPlatformConfigurationServiceProvisioningState? ProvisioningState { get; }
        /// <summary> The requested resource quantity for required CPU and Memory. </summary>
        public AppPlatformConfigurationServiceRequirements ResourceRequests { get; }
        /// <summary> Collection of instances belong to Application Configuration Service. </summary>
        public IReadOnlyList<AppPlatformConfigurationServiceInstance> Instances { get; }
        /// <summary> The settings of Application Configuration Service. </summary>
        internal AppPlatformConfigurationServiceSettings Settings { get; set; }
        /// <summary> Repositories of Application Configuration Service git property. </summary>
        public IList<AppPlatformConfigurationServiceGitRepository> ConfigurationServiceGitRepositories
        {
            get
            {
                if (Settings is null)
                    Settings = new AppPlatformConfigurationServiceSettings();
                return Settings.ConfigurationServiceGitRepositories;
            }
        }
    }
}
