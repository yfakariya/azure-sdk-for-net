// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Models
{
    public partial class WebPubSubKeys : IUtf8JsonSerializable, IJsonModel<WebPubSubKeys>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebPubSubKeys>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WebPubSubKeys>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebPubSubKeys>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebPubSubKeys)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PrimaryKey))
            {
                writer.WritePropertyName("primaryKey"u8);
                writer.WriteStringValue(PrimaryKey);
            }
            if (Optional.IsDefined(SecondaryKey))
            {
                writer.WritePropertyName("secondaryKey"u8);
                writer.WriteStringValue(SecondaryKey);
            }
            if (Optional.IsDefined(PrimaryConnectionString))
            {
                writer.WritePropertyName("primaryConnectionString"u8);
                writer.WriteStringValue(PrimaryConnectionString);
            }
            if (Optional.IsDefined(SecondaryConnectionString))
            {
                writer.WritePropertyName("secondaryConnectionString"u8);
                writer.WriteStringValue(SecondaryConnectionString);
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

        WebPubSubKeys IJsonModel<WebPubSubKeys>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebPubSubKeys>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WebPubSubKeys)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebPubSubKeys(document.RootElement, options);
        }

        internal static WebPubSubKeys DeserializeWebPubSubKeys(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> primaryKey = default;
            Optional<string> secondaryKey = default;
            Optional<string> primaryConnectionString = default;
            Optional<string> secondaryConnectionString = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryKey"u8))
                {
                    primaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryKey"u8))
                {
                    secondaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryConnectionString"u8))
                {
                    primaryConnectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryConnectionString"u8))
                {
                    secondaryConnectionString = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WebPubSubKeys(primaryKey.Value, secondaryKey.Value, primaryConnectionString.Value, secondaryConnectionString.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WebPubSubKeys>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebPubSubKeys>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(WebPubSubKeys)} does not support '{options.Format}' format.");
            }
        }

        WebPubSubKeys IPersistableModel<WebPubSubKeys>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WebPubSubKeys>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeWebPubSubKeys(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(WebPubSubKeys)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WebPubSubKeys>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
