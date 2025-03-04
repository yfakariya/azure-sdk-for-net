// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary> Optional settings to control how fields are processed when using a configured Azure Cosmos DB resource. </summary>
    public partial class AzureCosmosDBFieldMappingOptions
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

        /// <summary> Initializes a new instance of <see cref="AzureCosmosDBFieldMappingOptions"/>. </summary>
        /// <param name="vectorFieldNames"> The names of fields that represent vector data. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vectorFieldNames"/> is null. </exception>
        public AzureCosmosDBFieldMappingOptions(IEnumerable<string> vectorFieldNames)
        {
            Argument.AssertNotNull(vectorFieldNames, nameof(vectorFieldNames));

            VectorFieldNames = vectorFieldNames.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AzureCosmosDBFieldMappingOptions"/>. </summary>
        /// <param name="vectorFieldNames"> The names of fields that represent vector data. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureCosmosDBFieldMappingOptions(IList<string> vectorFieldNames, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VectorFieldNames = vectorFieldNames;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AzureCosmosDBFieldMappingOptions"/> for deserialization. </summary>
        internal AzureCosmosDBFieldMappingOptions()
        {
        }

        /// <summary> The names of fields that represent vector data. </summary>
        public IList<string> VectorFieldNames { get; }
    }
}
