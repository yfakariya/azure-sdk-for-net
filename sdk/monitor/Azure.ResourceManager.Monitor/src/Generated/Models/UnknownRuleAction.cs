// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The UnknownRuleAction. </summary>
    internal partial class UnknownRuleAction : AlertRuleAction
    {
        /// <summary> Initializes a new instance of <see cref="UnknownRuleAction"/>. </summary>
        /// <param name="odataType"> specifies the type of the action. There are two types of actions: RuleEmailAction and RuleWebhookAction. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownRuleAction(string odataType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(odataType, serializedAdditionalRawData)
        {
            OdataType = odataType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownRuleAction"/> for deserialization. </summary>
        internal UnknownRuleAction()
        {
        }
    }
}
