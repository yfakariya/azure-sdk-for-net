// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class GetUserTablesOracleTaskInput : IUtf8JsonSerializable, IJsonModel<GetUserTablesOracleTaskInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GetUserTablesOracleTaskInput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GetUserTablesOracleTaskInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetUserTablesOracleTaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GetUserTablesOracleTaskInput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("connectionInfo"u8);
            writer.WriteObjectValue(ConnectionInfo);
            writer.WritePropertyName("selectedSchemas"u8);
            writer.WriteStartArray();
            foreach (var item in SelectedSchemas)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
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

        GetUserTablesOracleTaskInput IJsonModel<GetUserTablesOracleTaskInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetUserTablesOracleTaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GetUserTablesOracleTaskInput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGetUserTablesOracleTaskInput(document.RootElement, options);
        }

        internal static GetUserTablesOracleTaskInput DeserializeGetUserTablesOracleTaskInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OracleConnectionInfo connectionInfo = default;
            IList<string> selectedSchemas = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectionInfo"u8))
                {
                    connectionInfo = OracleConnectionInfo.DeserializeOracleConnectionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("selectedSchemas"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    selectedSchemas = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GetUserTablesOracleTaskInput(connectionInfo, selectedSchemas, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GetUserTablesOracleTaskInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetUserTablesOracleTaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GetUserTablesOracleTaskInput)} does not support '{options.Format}' format.");
            }
        }

        GetUserTablesOracleTaskInput IPersistableModel<GetUserTablesOracleTaskInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GetUserTablesOracleTaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGetUserTablesOracleTaskInput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GetUserTablesOracleTaskInput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GetUserTablesOracleTaskInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
