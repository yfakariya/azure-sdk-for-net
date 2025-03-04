// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Volume group properties. </summary>
    public partial class NetAppVolumeGroupMetadata
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

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeGroupMetadata"/>. </summary>
        public NetAppVolumeGroupMetadata()
        {
            GlobalPlacementRules = new ChangeTrackingList<NetAppVolumePlacementRule>();
        }

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeGroupMetadata"/>. </summary>
        /// <param name="groupDescription"> Group Description. </param>
        /// <param name="applicationType"> Application Type. </param>
        /// <param name="applicationIdentifier"> Application specific identifier. </param>
        /// <param name="globalPlacementRules"> Application specific placement rules for the volume group. </param>
        /// <param name="deploymentSpecId"> Application specific identifier of deployment rules for the volume group. </param>
        /// <param name="volumesCount"> Number of volumes in volume group. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppVolumeGroupMetadata(string groupDescription, NetAppApplicationType? applicationType, string applicationIdentifier, IList<NetAppVolumePlacementRule> globalPlacementRules, string deploymentSpecId, long? volumesCount, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            GroupDescription = groupDescription;
            ApplicationType = applicationType;
            ApplicationIdentifier = applicationIdentifier;
            GlobalPlacementRules = globalPlacementRules;
            DeploymentSpecId = deploymentSpecId;
            VolumesCount = volumesCount;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Group Description. </summary>
        public string GroupDescription { get; set; }
        /// <summary> Application Type. </summary>
        public NetAppApplicationType? ApplicationType { get; set; }
        /// <summary> Application specific identifier. </summary>
        public string ApplicationIdentifier { get; set; }
        /// <summary> Application specific placement rules for the volume group. </summary>
        public IList<NetAppVolumePlacementRule> GlobalPlacementRules { get; }
        /// <summary> Application specific identifier of deployment rules for the volume group. </summary>
        public string DeploymentSpecId { get; set; }
        /// <summary> Number of volumes in volume group. </summary>
        public long? VolumesCount { get; }
    }
}
