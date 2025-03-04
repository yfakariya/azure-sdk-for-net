// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Query approved plans response. </summary>
    public partial class QueryApprovedPlansDetails
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

        /// <summary> Initializes a new instance of <see cref="QueryApprovedPlansDetails"/>. </summary>
        internal QueryApprovedPlansDetails()
        {
            SubscriptionIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="QueryApprovedPlansDetails"/>. </summary>
        /// <param name="planId"> Plan id. </param>
        /// <param name="subscriptionIds"> Approved subscription ids list. In case all subscriptions are approved for a plan, allSubscriptions flag is true and list is empty ( else flag is set to false). In case both subscriptions list is empty and allSubscriptions flag is false, the plan is not approved for any subscription. </param>
        /// <param name="allSubscriptions"> Indicates whether all subscriptions are approved for this plan. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QueryApprovedPlansDetails(string planId, IReadOnlyList<string> subscriptionIds, bool? allSubscriptions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PlanId = planId;
            SubscriptionIds = subscriptionIds;
            AllSubscriptions = allSubscriptions;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Plan id. </summary>
        public string PlanId { get; }
        /// <summary> Approved subscription ids list. In case all subscriptions are approved for a plan, allSubscriptions flag is true and list is empty ( else flag is set to false). In case both subscriptions list is empty and allSubscriptions flag is false, the plan is not approved for any subscription. </summary>
        public IReadOnlyList<string> SubscriptionIds { get; }
        /// <summary> Indicates whether all subscriptions are approved for this plan. </summary>
        public bool? AllSubscriptions { get; }
    }
}
