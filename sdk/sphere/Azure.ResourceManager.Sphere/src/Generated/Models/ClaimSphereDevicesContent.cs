// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Sphere.Models
{
    /// <summary> Request to the action call to bulk claim devices. </summary>
    public partial class ClaimSphereDevicesContent
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

        /// <summary> Initializes a new instance of <see cref="ClaimSphereDevicesContent"/>. </summary>
        /// <param name="deviceIdentifiers"> Device identifiers of the devices to be claimed. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deviceIdentifiers"/> is null. </exception>
        public ClaimSphereDevicesContent(IEnumerable<string> deviceIdentifiers)
        {
            Argument.AssertNotNull(deviceIdentifiers, nameof(deviceIdentifiers));

            DeviceIdentifiers = deviceIdentifiers.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ClaimSphereDevicesContent"/>. </summary>
        /// <param name="deviceIdentifiers"> Device identifiers of the devices to be claimed. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClaimSphereDevicesContent(IList<string> deviceIdentifiers, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DeviceIdentifiers = deviceIdentifiers;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ClaimSphereDevicesContent"/> for deserialization. </summary>
        internal ClaimSphereDevicesContent()
        {
        }

        /// <summary> Device identifiers of the devices to be claimed. </summary>
        public IList<string> DeviceIdentifiers { get; }
    }
}
