// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class PhysicalPartitionThroughputInfoResource : IUtf8JsonSerializable, IJsonModel<PhysicalPartitionThroughputInfoResource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PhysicalPartitionThroughputInfoResource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PhysicalPartitionThroughputInfoResource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PhysicalPartitionThroughputInfoResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PhysicalPartitionThroughputInfoResource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(Throughput))
            {
                writer.WritePropertyName("throughput"u8);
                writer.WriteNumberValue(Throughput.Value);
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

        PhysicalPartitionThroughputInfoResource IJsonModel<PhysicalPartitionThroughputInfoResource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PhysicalPartitionThroughputInfoResource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PhysicalPartitionThroughputInfoResource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePhysicalPartitionThroughputInfoResource(document.RootElement, options);
        }

        internal static PhysicalPartitionThroughputInfoResource DeserializePhysicalPartitionThroughputInfoResource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            Optional<double> throughput = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("throughput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    throughput = property.Value.GetDouble();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PhysicalPartitionThroughputInfoResource(id, Optional.ToNullable(throughput), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PhysicalPartitionThroughputInfoResource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PhysicalPartitionThroughputInfoResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PhysicalPartitionThroughputInfoResource)} does not support '{options.Format}' format.");
            }
        }

        PhysicalPartitionThroughputInfoResource IPersistableModel<PhysicalPartitionThroughputInfoResource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PhysicalPartitionThroughputInfoResource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePhysicalPartitionThroughputInfoResource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PhysicalPartitionThroughputInfoResource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PhysicalPartitionThroughputInfoResource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
