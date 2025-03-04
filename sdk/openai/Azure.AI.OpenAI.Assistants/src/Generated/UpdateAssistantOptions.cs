// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.OpenAI.Assistants
{
    /// <summary> The request details to use when modifying an existing assistant. </summary>
    public partial class UpdateAssistantOptions
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

        /// <summary> Initializes a new instance of <see cref="UpdateAssistantOptions"/>. </summary>
        public UpdateAssistantOptions()
        {
            Tools = new ChangeTrackingList<ToolDefinition>();
            FileIds = new ChangeTrackingList<string>();
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="UpdateAssistantOptions"/>. </summary>
        /// <param name="model"> The ID of the model to use. </param>
        /// <param name="name"> The modified name for the assistant to use. </param>
        /// <param name="description"> The modified description for the assistant to use. </param>
        /// <param name="instructions"> The modified system instructions for the new assistant to use. </param>
        /// <param name="tools"> The modified collection of tools to enable for the assistant. </param>
        /// <param name="fileIds"> The modified list of previously uploaded fileIDs to attach to the assistant. </param>
        /// <param name="metadata"> A set of up to 16 key/value pairs that can be attached to an object, used for storing additional information about that object in a structured format. Keys may be up to 64 characters in length and values may be up to 512 characters in length. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UpdateAssistantOptions(string model, string name, string description, string instructions, IList<ToolDefinition> tools, IList<string> fileIds, IDictionary<string, string> metadata, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Model = model;
            Name = name;
            Description = description;
            Instructions = instructions;
            Tools = tools;
            FileIds = fileIds;
            Metadata = metadata;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The ID of the model to use. </summary>
        public string Model { get; set; }
        /// <summary> The modified name for the assistant to use. </summary>
        public string Name { get; set; }
        /// <summary> The modified description for the assistant to use. </summary>
        public string Description { get; set; }
        /// <summary> The modified system instructions for the new assistant to use. </summary>
        public string Instructions { get; set; }
        /// <summary>
        /// The modified collection of tools to enable for the assistant.
        /// Please note <see cref="ToolDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="CodeInterpreterToolDefinition"/>, <see cref="RetrievalToolDefinition"/> and <see cref="FunctionToolDefinition"/>.
        /// </summary>
        public IList<ToolDefinition> Tools { get; }
        /// <summary> The modified list of previously uploaded fileIDs to attach to the assistant. </summary>
        public IList<string> FileIds { get; }
        /// <summary> A set of up to 16 key/value pairs that can be attached to an object, used for storing additional information about that object in a structured format. Keys may be up to 64 characters in length and values may be up to 512 characters in length. </summary>
        public IDictionary<string, string> Metadata { get; set; }
    }
}
