// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicWsdlService : IUtf8JsonSerializable, IJsonModel<LogicWsdlService>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogicWsdlService>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LogicWsdlService>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWsdlService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicWsdlService)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(QualifiedName))
            {
                writer.WritePropertyName("qualifiedName"u8);
                writer.WriteStringValue(QualifiedName);
            }
            if (Optional.IsCollectionDefined(EndpointQualifiedNames))
            {
                writer.WritePropertyName("EndpointQualifiedNames"u8);
                writer.WriteStartArray();
                foreach (var item in EndpointQualifiedNames)
                {
                    writer.WriteStringValue(item);
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

        LogicWsdlService IJsonModel<LogicWsdlService>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWsdlService>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicWsdlService)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicWsdlService(document.RootElement, options);
        }

        internal static LogicWsdlService DeserializeLogicWsdlService(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> qualifiedName = default;
            Optional<IReadOnlyList<string>> endpointQualifiedNames = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("qualifiedName"u8))
                {
                    qualifiedName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("EndpointQualifiedNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    endpointQualifiedNames = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LogicWsdlService(qualifiedName.Value, Optional.ToList(endpointQualifiedNames), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LogicWsdlService>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWsdlService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LogicWsdlService)} does not support '{options.Format}' format.");
            }
        }

        LogicWsdlService IPersistableModel<LogicWsdlService>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicWsdlService>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLogicWsdlService(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LogicWsdlService)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LogicWsdlService>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
