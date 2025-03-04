// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Results of network configuration diagnostic on the target resource. </summary>
    public partial class NetworkConfigurationDiagnosticResponse
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

        /// <summary> Initializes a new instance of <see cref="NetworkConfigurationDiagnosticResponse"/>. </summary>
        internal NetworkConfigurationDiagnosticResponse()
        {
            Results = new ChangeTrackingList<NetworkConfigurationDiagnosticResult>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkConfigurationDiagnosticResponse"/>. </summary>
        /// <param name="results"> List of network configuration diagnostic results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkConfigurationDiagnosticResponse(IReadOnlyList<NetworkConfigurationDiagnosticResult> results, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Results = results;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of network configuration diagnostic results. </summary>
        public IReadOnlyList<NetworkConfigurationDiagnosticResult> Results { get; }
    }
}
