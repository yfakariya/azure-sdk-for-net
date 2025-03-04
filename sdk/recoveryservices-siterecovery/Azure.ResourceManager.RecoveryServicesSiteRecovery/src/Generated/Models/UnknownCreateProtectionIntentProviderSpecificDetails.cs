// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The UnknownCreateProtectionIntentProviderSpecificDetails. </summary>
    internal partial class UnknownCreateProtectionIntentProviderSpecificDetails : SiteRecoveryCreateProtectionIntentProviderDetail
    {
        /// <summary> Initializes a new instance of <see cref="UnknownCreateProtectionIntentProviderSpecificDetails"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownCreateProtectionIntentProviderSpecificDetails(string instanceType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, serializedAdditionalRawData)
        {
            InstanceType = instanceType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownCreateProtectionIntentProviderSpecificDetails"/> for deserialization. </summary>
        internal UnknownCreateProtectionIntentProviderSpecificDetails()
        {
        }
    }
}
