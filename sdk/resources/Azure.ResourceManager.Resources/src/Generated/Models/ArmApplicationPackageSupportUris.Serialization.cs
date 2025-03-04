// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ArmApplicationPackageSupportUris : IUtf8JsonSerializable, IJsonModel<ArmApplicationPackageSupportUris>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ArmApplicationPackageSupportUris>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ArmApplicationPackageSupportUris>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmApplicationPackageSupportUris>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmApplicationPackageSupportUris)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AzurePublicCloudUri))
            {
                writer.WritePropertyName("publicAzure"u8);
                writer.WriteStringValue(AzurePublicCloudUri.AbsoluteUri);
            }
            if (Optional.IsDefined(AzureGovernmentUri))
            {
                writer.WritePropertyName("governmentCloud"u8);
                writer.WriteStringValue(AzureGovernmentUri.AbsoluteUri);
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

        ArmApplicationPackageSupportUris IJsonModel<ArmApplicationPackageSupportUris>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmApplicationPackageSupportUris>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ArmApplicationPackageSupportUris)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeArmApplicationPackageSupportUris(document.RootElement, options);
        }

        internal static ArmApplicationPackageSupportUris DeserializeArmApplicationPackageSupportUris(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> publicAzure = default;
            Optional<Uri> governmentCloud = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicAzure"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    publicAzure = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("governmentCloud"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    governmentCloud = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ArmApplicationPackageSupportUris(publicAzure.Value, governmentCloud.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ArmApplicationPackageSupportUris>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmApplicationPackageSupportUris>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ArmApplicationPackageSupportUris)} does not support '{options.Format}' format.");
            }
        }

        ArmApplicationPackageSupportUris IPersistableModel<ArmApplicationPackageSupportUris>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ArmApplicationPackageSupportUris>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeArmApplicationPackageSupportUris(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ArmApplicationPackageSupportUris)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ArmApplicationPackageSupportUris>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
