// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class ManagementEventAggregationCondition : IUtf8JsonSerializable, IJsonModel<ManagementEventAggregationCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagementEventAggregationCondition>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagementEventAggregationCondition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementEventAggregationCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementEventAggregationCondition)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Operator))
            {
                writer.WritePropertyName("operator"u8);
                writer.WriteStringValue(Operator.Value.ToSerialString());
            }
            if (Optional.IsDefined(Threshold))
            {
                writer.WritePropertyName("threshold"u8);
                writer.WriteNumberValue(Threshold.Value);
            }
            if (Optional.IsDefined(WindowSize))
            {
                writer.WritePropertyName("windowSize"u8);
                writer.WriteStringValue(WindowSize.Value, "P");
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

        ManagementEventAggregationCondition IJsonModel<ManagementEventAggregationCondition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementEventAggregationCondition>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagementEventAggregationCondition)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagementEventAggregationCondition(document.RootElement, options);
        }

        internal static ManagementEventAggregationCondition DeserializeManagementEventAggregationCondition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MonitorConditionOperator> @operator = default;
            Optional<double> threshold = default;
            Optional<TimeSpan> windowSize = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operator"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @operator = property.Value.GetString().ToMonitorConditionOperator();
                    continue;
                }
                if (property.NameEquals("threshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    threshold = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("windowSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    windowSize = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagementEventAggregationCondition(Optional.ToNullable(@operator), Optional.ToNullable(threshold), Optional.ToNullable(windowSize), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagementEventAggregationCondition>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementEventAggregationCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagementEventAggregationCondition)} does not support '{options.Format}' format.");
            }
        }

        ManagementEventAggregationCondition IPersistableModel<ManagementEventAggregationCondition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagementEventAggregationCondition>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagementEventAggregationCondition(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagementEventAggregationCondition)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagementEventAggregationCondition>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
