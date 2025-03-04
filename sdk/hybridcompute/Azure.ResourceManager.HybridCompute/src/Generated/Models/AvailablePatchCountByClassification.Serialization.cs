// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridCompute.Models
{
    public partial class AvailablePatchCountByClassification : IUtf8JsonSerializable, IJsonModel<AvailablePatchCountByClassification>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvailablePatchCountByClassification>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AvailablePatchCountByClassification>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailablePatchCountByClassification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvailablePatchCountByClassification)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Security))
            {
                writer.WritePropertyName("security"u8);
                writer.WriteNumberValue(Security.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Critical))
            {
                writer.WritePropertyName("critical"u8);
                writer.WriteNumberValue(Critical.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Definition))
            {
                writer.WritePropertyName("definition"u8);
                writer.WriteNumberValue(Definition.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(UpdateRollup))
            {
                writer.WritePropertyName("updateRollup"u8);
                writer.WriteNumberValue(UpdateRollup.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(FeaturePack))
            {
                writer.WritePropertyName("featurePack"u8);
                writer.WriteNumberValue(FeaturePack.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ServicePack))
            {
                writer.WritePropertyName("servicePack"u8);
                writer.WriteNumberValue(ServicePack.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Tools))
            {
                writer.WritePropertyName("tools"u8);
                writer.WriteNumberValue(Tools.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Updates))
            {
                writer.WritePropertyName("updates"u8);
                writer.WriteNumberValue(Updates.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Other))
            {
                writer.WritePropertyName("other"u8);
                writer.WriteNumberValue(Other.Value);
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

        AvailablePatchCountByClassification IJsonModel<AvailablePatchCountByClassification>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailablePatchCountByClassification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AvailablePatchCountByClassification)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvailablePatchCountByClassification(document.RootElement, options);
        }

        internal static AvailablePatchCountByClassification DeserializeAvailablePatchCountByClassification(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> security = default;
            Optional<int> critical = default;
            Optional<int> definition = default;
            Optional<int> updateRollup = default;
            Optional<int> featurePack = default;
            Optional<int> servicePack = default;
            Optional<int> tools = default;
            Optional<int> updates = default;
            Optional<int> other = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("security"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    security = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("critical"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    critical = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("definition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    definition = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("updateRollup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updateRollup = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("featurePack"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    featurePack = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("servicePack"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    servicePack = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("tools"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tools = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("updates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updates = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("other"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    other = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AvailablePatchCountByClassification(Optional.ToNullable(security), Optional.ToNullable(critical), Optional.ToNullable(definition), Optional.ToNullable(updateRollup), Optional.ToNullable(featurePack), Optional.ToNullable(servicePack), Optional.ToNullable(tools), Optional.ToNullable(updates), Optional.ToNullable(other), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AvailablePatchCountByClassification>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailablePatchCountByClassification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AvailablePatchCountByClassification)} does not support '{options.Format}' format.");
            }
        }

        AvailablePatchCountByClassification IPersistableModel<AvailablePatchCountByClassification>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AvailablePatchCountByClassification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAvailablePatchCountByClassification(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AvailablePatchCountByClassification)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AvailablePatchCountByClassification>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
