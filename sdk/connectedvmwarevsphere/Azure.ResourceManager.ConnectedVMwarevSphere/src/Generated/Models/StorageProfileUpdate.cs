// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> Specifies the storage settings for the virtual machine disks. </summary>
    internal partial class StorageProfileUpdate
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

        /// <summary> Initializes a new instance of <see cref="StorageProfileUpdate"/>. </summary>
        public StorageProfileUpdate()
        {
            Disks = new ChangeTrackingList<VMwareVirtualDiskUpdate>();
        }

        /// <summary> Initializes a new instance of <see cref="StorageProfileUpdate"/>. </summary>
        /// <param name="disks"> Gets or sets the list of virtual disks associated with the virtual machine. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageProfileUpdate(IList<VMwareVirtualDiskUpdate> disks, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Disks = disks;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the list of virtual disks associated with the virtual machine. </summary>
        public IList<VMwareVirtualDiskUpdate> Disks { get; }
    }
}
