// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.OperationalInsights;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    internal partial class LinkedServiceListResult : IUtf8JsonSerializable, IJsonModel<LinkedServiceListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LinkedServiceListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LinkedServiceListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkedServiceListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LinkedServiceListResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        LinkedServiceListResult IJsonModel<LinkedServiceListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkedServiceListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LinkedServiceListResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLinkedServiceListResult(document.RootElement, options);
        }

        internal static LinkedServiceListResult DeserializeLinkedServiceListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<OperationalInsightsLinkedServiceData>> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OperationalInsightsLinkedServiceData> array = new List<OperationalInsightsLinkedServiceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OperationalInsightsLinkedServiceData.DeserializeOperationalInsightsLinkedServiceData(item));
                    }
                    value = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LinkedServiceListResult(Optional.ToList(value), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LinkedServiceListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkedServiceListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LinkedServiceListResult)} does not support '{options.Format}' format.");
            }
        }

        LinkedServiceListResult IPersistableModel<LinkedServiceListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkedServiceListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLinkedServiceListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LinkedServiceListResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LinkedServiceListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
