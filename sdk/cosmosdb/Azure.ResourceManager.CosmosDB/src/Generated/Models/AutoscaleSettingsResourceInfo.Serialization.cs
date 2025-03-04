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
    public partial class AutoscaleSettingsResourceInfo : IUtf8JsonSerializable, IJsonModel<AutoscaleSettingsResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutoscaleSettingsResourceInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AutoscaleSettingsResourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleSettingsResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoscaleSettingsResourceInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("maxThroughput"u8);
            writer.WriteNumberValue(MaxThroughput);
            if (Optional.IsDefined(AutoUpgradePolicy))
            {
                writer.WritePropertyName("autoUpgradePolicy"u8);
                writer.WriteObjectValue(AutoUpgradePolicy);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetMaxThroughput))
            {
                writer.WritePropertyName("targetMaxThroughput"u8);
                writer.WriteNumberValue(TargetMaxThroughput.Value);
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

        AutoscaleSettingsResourceInfo IJsonModel<AutoscaleSettingsResourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleSettingsResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoscaleSettingsResourceInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutoscaleSettingsResourceInfo(document.RootElement, options);
        }

        internal static AutoscaleSettingsResourceInfo DeserializeAutoscaleSettingsResourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int maxThroughput = default;
            Optional<AutoUpgradePolicyResourceInfo> autoUpgradePolicy = default;
            Optional<int> targetMaxThroughput = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxThroughput"u8))
                {
                    maxThroughput = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("autoUpgradePolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoUpgradePolicy = AutoUpgradePolicyResourceInfo.DeserializeAutoUpgradePolicyResourceInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("targetMaxThroughput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetMaxThroughput = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AutoscaleSettingsResourceInfo(maxThroughput, autoUpgradePolicy.Value, Optional.ToNullable(targetMaxThroughput), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutoscaleSettingsResourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleSettingsResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutoscaleSettingsResourceInfo)} does not support '{options.Format}' format.");
            }
        }

        AutoscaleSettingsResourceInfo IPersistableModel<AutoscaleSettingsResourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleSettingsResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutoscaleSettingsResourceInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutoscaleSettingsResourceInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutoscaleSettingsResourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
