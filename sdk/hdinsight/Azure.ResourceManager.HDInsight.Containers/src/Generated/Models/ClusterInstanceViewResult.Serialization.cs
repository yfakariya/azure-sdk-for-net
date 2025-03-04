// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class ClusterInstanceViewResult : IUtf8JsonSerializable, IJsonModel<ClusterInstanceViewResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterInstanceViewResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ClusterInstanceViewResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterInstanceViewResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterInstanceViewResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("status"u8);
            writer.WriteObjectValue(Status);
            writer.WritePropertyName("serviceStatuses"u8);
            writer.WriteStartArray();
            foreach (var item in ServiceStatuses)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
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

        ClusterInstanceViewResult IJsonModel<ClusterInstanceViewResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterInstanceViewResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterInstanceViewResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterInstanceViewResult(document.RootElement, options);
        }

        internal static ClusterInstanceViewResult DeserializeClusterInstanceViewResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            ClusterInstanceViewStatus status = default;
            IReadOnlyList<HDInsightServiceStatus> serviceStatuses = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("status"u8))
                        {
                            status = ClusterInstanceViewStatus.DeserializeClusterInstanceViewStatus(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("serviceStatuses"u8))
                        {
                            List<HDInsightServiceStatus> array = new List<HDInsightServiceStatus>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(HDInsightServiceStatus.DeserializeHDInsightServiceStatus(item));
                            }
                            serviceStatuses = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ClusterInstanceViewResult(name, status, serviceStatuses, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClusterInstanceViewResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterInstanceViewResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClusterInstanceViewResult)} does not support '{options.Format}' format.");
            }
        }

        ClusterInstanceViewResult IPersistableModel<ClusterInstanceViewResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterInstanceViewResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClusterInstanceViewResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterInstanceViewResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterInstanceViewResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
