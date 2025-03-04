// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningInstanceTypeSchema : IUtf8JsonSerializable, IJsonModel<MachineLearningInstanceTypeSchema>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningInstanceTypeSchema>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningInstanceTypeSchema>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningInstanceTypeSchema>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningInstanceTypeSchema)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(NodeSelector))
            {
                if (NodeSelector != null)
                {
                    writer.WritePropertyName("nodeSelector"u8);
                    writer.WriteStartObject();
                    foreach (var item in NodeSelector)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("nodeSelector");
                }
            }
            if (Optional.IsDefined(Resources))
            {
                writer.WritePropertyName("resources"u8);
                writer.WriteObjectValue(Resources);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        MachineLearningInstanceTypeSchema IJsonModel<MachineLearningInstanceTypeSchema>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningInstanceTypeSchema>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningInstanceTypeSchema)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningInstanceTypeSchema(document.RootElement, options);
        }

        internal static MachineLearningInstanceTypeSchema DeserializeMachineLearningInstanceTypeSchema(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> nodeSelector = default;
            Optional<MachineLearningInstanceTypeSchemaResources> resources = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nodeSelector"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        nodeSelector = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    nodeSelector = dictionary;
                    continue;
                }
                if (property.NameEquals("resources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resources = MachineLearningInstanceTypeSchemaResources.DeserializeMachineLearningInstanceTypeSchemaResources(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningInstanceTypeSchema(Optional.ToDictionary(nodeSelector), resources.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningInstanceTypeSchema>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningInstanceTypeSchema>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningInstanceTypeSchema)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningInstanceTypeSchema IPersistableModel<MachineLearningInstanceTypeSchema>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningInstanceTypeSchema>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningInstanceTypeSchema(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningInstanceTypeSchema)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningInstanceTypeSchema>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
