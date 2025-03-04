// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Maintenance.Models
{
    /// <summary> Input properties for patching a Windows machine. </summary>
    public partial class MaintenanceWindowsPatchSettings
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

        /// <summary> Initializes a new instance of <see cref="MaintenanceWindowsPatchSettings"/>. </summary>
        public MaintenanceWindowsPatchSettings()
        {
            KbNumbersToExclude = new ChangeTrackingList<string>();
            KbNumbersToInclude = new ChangeTrackingList<string>();
            ClassificationsToInclude = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="MaintenanceWindowsPatchSettings"/>. </summary>
        /// <param name="kbNumbersToExclude"> Windows KBID to be excluded for patching. </param>
        /// <param name="kbNumbersToInclude"> Windows KBID to be included for patching. </param>
        /// <param name="classificationsToInclude"> Classification category of patches to be patched. </param>
        /// <param name="isExcludeKbsRebootRequired"> Exclude patches which need reboot. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MaintenanceWindowsPatchSettings(IList<string> kbNumbersToExclude, IList<string> kbNumbersToInclude, IList<string> classificationsToInclude, bool? isExcludeKbsRebootRequired, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KbNumbersToExclude = kbNumbersToExclude;
            KbNumbersToInclude = kbNumbersToInclude;
            ClassificationsToInclude = classificationsToInclude;
            IsExcludeKbsRebootRequired = isExcludeKbsRebootRequired;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Windows KBID to be excluded for patching. </summary>
        public IList<string> KbNumbersToExclude { get; }
        /// <summary> Windows KBID to be included for patching. </summary>
        public IList<string> KbNumbersToInclude { get; }
        /// <summary> Classification category of patches to be patched. </summary>
        public IList<string> ClassificationsToInclude { get; }
        /// <summary> Exclude patches which need reboot. </summary>
        public bool? IsExcludeKbsRebootRequired { get; set; }
    }
}
