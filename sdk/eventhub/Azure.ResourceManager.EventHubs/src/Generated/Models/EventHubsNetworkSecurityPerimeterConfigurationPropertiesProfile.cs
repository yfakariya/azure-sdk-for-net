// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    /// <summary> Information about current network profile. </summary>
    public partial class EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile
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

        /// <summary> Initializes a new instance of <see cref="EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile"/>. </summary>
        internal EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile()
        {
            AccessRules = new ChangeTrackingList<EventHubsNspAccessRule>();
        }

        /// <summary> Initializes a new instance of <see cref="EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile"/>. </summary>
        /// <param name="name"> Name of the resource. </param>
        /// <param name="accessRulesVersion"> Current access rules version. </param>
        /// <param name="accessRules"> List of Access Rules. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile(string name, string accessRulesVersion, IReadOnlyList<EventHubsNspAccessRule> accessRules, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            AccessRulesVersion = accessRulesVersion;
            AccessRules = accessRules;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the resource. </summary>
        public string Name { get; }
        /// <summary> Current access rules version. </summary>
        public string AccessRulesVersion { get; }
        /// <summary> List of Access Rules. </summary>
        public IReadOnlyList<EventHubsNspAccessRule> AccessRules { get; }
    }
}
