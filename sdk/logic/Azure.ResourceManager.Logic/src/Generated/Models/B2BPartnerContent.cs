// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The B2B partner content. </summary>
    internal partial class B2BPartnerContent
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

        /// <summary> Initializes a new instance of <see cref="B2BPartnerContent"/>. </summary>
        public B2BPartnerContent()
        {
            BusinessIdentities = new ChangeTrackingList<IntegrationAccountBusinessIdentity>();
        }

        /// <summary> Initializes a new instance of <see cref="B2BPartnerContent"/>. </summary>
        /// <param name="businessIdentities"> The list of partner business identities. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal B2BPartnerContent(IList<IntegrationAccountBusinessIdentity> businessIdentities, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BusinessIdentities = businessIdentities;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of partner business identities. </summary>
        public IList<IntegrationAccountBusinessIdentity> BusinessIdentities { get; }
    }
}
