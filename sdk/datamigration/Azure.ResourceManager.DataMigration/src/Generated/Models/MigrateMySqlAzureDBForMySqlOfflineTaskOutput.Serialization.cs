// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    [PersistableModelProxy(typeof(UnknownMigrateMySqlAzureDBForMySqlOfflineTaskOutput))]
    public partial class MigrateMySqlAzureDBForMySqlOfflineTaskOutput : IUtf8JsonSerializable, IJsonModel<MigrateMySqlAzureDBForMySqlOfflineTaskOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateMySqlAzureDBForMySqlOfflineTaskOutput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MigrateMySqlAzureDBForMySqlOfflineTaskOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMySqlAzureDBForMySqlOfflineTaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateMySqlAzureDBForMySqlOfflineTaskOutput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("resultType"u8);
            writer.WriteStringValue(ResultType);
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

        MigrateMySqlAzureDBForMySqlOfflineTaskOutput IJsonModel<MigrateMySqlAzureDBForMySqlOfflineTaskOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMySqlAzureDBForMySqlOfflineTaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateMySqlAzureDBForMySqlOfflineTaskOutput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateMySqlAzureDBForMySqlOfflineTaskOutput(document.RootElement, options);
        }

        internal static MigrateMySqlAzureDBForMySqlOfflineTaskOutput DeserializeMigrateMySqlAzureDBForMySqlOfflineTaskOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("resultType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "DatabaseLevelOutput": return MigrateMySqlAzureDBForMySqlOfflineTaskOutputDatabaseLevel.DeserializeMigrateMySqlAzureDBForMySqlOfflineTaskOutputDatabaseLevel(element);
                    case "ErrorOutput": return MigrateMySqlAzureDBForMySqlOfflineTaskOutputError.DeserializeMigrateMySqlAzureDBForMySqlOfflineTaskOutputError(element);
                    case "MigrationLevelOutput": return MigrateMySqlAzureDBForMySqlOfflineTaskOutputMigrationLevel.DeserializeMigrateMySqlAzureDBForMySqlOfflineTaskOutputMigrationLevel(element);
                    case "TableLevelOutput": return MigrateMySqlAzureDBForMySqlOfflineTaskOutputTableLevel.DeserializeMigrateMySqlAzureDBForMySqlOfflineTaskOutputTableLevel(element);
                }
            }
            return UnknownMigrateMySqlAzureDBForMySqlOfflineTaskOutput.DeserializeUnknownMigrateMySqlAzureDBForMySqlOfflineTaskOutput(element);
        }

        BinaryData IPersistableModel<MigrateMySqlAzureDBForMySqlOfflineTaskOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMySqlAzureDBForMySqlOfflineTaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateMySqlAzureDBForMySqlOfflineTaskOutput)} does not support '{options.Format}' format.");
            }
        }

        MigrateMySqlAzureDBForMySqlOfflineTaskOutput IPersistableModel<MigrateMySqlAzureDBForMySqlOfflineTaskOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateMySqlAzureDBForMySqlOfflineTaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateMySqlAzureDBForMySqlOfflineTaskOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateMySqlAzureDBForMySqlOfflineTaskOutput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateMySqlAzureDBForMySqlOfflineTaskOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
