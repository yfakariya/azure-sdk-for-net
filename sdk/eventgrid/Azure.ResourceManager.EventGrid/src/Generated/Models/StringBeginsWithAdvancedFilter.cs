// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> StringBeginsWith Advanced Filter. </summary>
    public partial class StringBeginsWithAdvancedFilter : AdvancedFilter
    {
        /// <summary> Initializes a new instance of <see cref="StringBeginsWithAdvancedFilter"/>. </summary>
        public StringBeginsWithAdvancedFilter()
        {
            Values = new ChangeTrackingList<string>();
            OperatorType = AdvancedFilterOperatorType.StringBeginsWith;
        }

        /// <summary> Initializes a new instance of <see cref="StringBeginsWithAdvancedFilter"/>. </summary>
        /// <param name="operatorType"> The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others. </param>
        /// <param name="key"> The field/property in the event based on which you want to filter. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="values"> The set of filter values. </param>
        internal StringBeginsWithAdvancedFilter(AdvancedFilterOperatorType operatorType, string key, IDictionary<string, BinaryData> serializedAdditionalRawData, IList<string> values) : base(operatorType, key, serializedAdditionalRawData)
        {
            Values = values;
            OperatorType = operatorType;
        }

        /// <summary> The set of filter values. </summary>
        public IList<string> Values { get; }
    }
}
