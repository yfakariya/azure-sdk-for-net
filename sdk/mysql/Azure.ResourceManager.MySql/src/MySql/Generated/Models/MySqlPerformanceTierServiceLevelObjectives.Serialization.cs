// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.Models
{
    public partial class MySqlPerformanceTierServiceLevelObjectives : IUtf8JsonSerializable, IJsonModel<MySqlPerformanceTierServiceLevelObjectives>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MySqlPerformanceTierServiceLevelObjectives>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MySqlPerformanceTierServiceLevelObjectives>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlPerformanceTierServiceLevelObjectives>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlPerformanceTierServiceLevelObjectives)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Edition))
            {
                writer.WritePropertyName("edition"u8);
                writer.WriteStringValue(Edition);
            }
            if (Optional.IsDefined(VCores))
            {
                writer.WritePropertyName("vCore"u8);
                writer.WriteNumberValue(VCores.Value);
            }
            if (Optional.IsDefined(HardwareGeneration))
            {
                writer.WritePropertyName("hardwareGeneration"u8);
                writer.WriteStringValue(HardwareGeneration);
            }
            if (Optional.IsDefined(MaxBackupRetentionDays))
            {
                writer.WritePropertyName("maxBackupRetentionDays"u8);
                writer.WriteNumberValue(MaxBackupRetentionDays.Value);
            }
            if (Optional.IsDefined(MinBackupRetentionDays))
            {
                writer.WritePropertyName("minBackupRetentionDays"u8);
                writer.WriteNumberValue(MinBackupRetentionDays.Value);
            }
            if (Optional.IsDefined(MaxStorageInMB))
            {
                writer.WritePropertyName("maxStorageMB"u8);
                writer.WriteNumberValue(MaxStorageInMB.Value);
            }
            if (Optional.IsDefined(MinStorageInMB))
            {
                writer.WritePropertyName("minStorageMB"u8);
                writer.WriteNumberValue(MinStorageInMB.Value);
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

        MySqlPerformanceTierServiceLevelObjectives IJsonModel<MySqlPerformanceTierServiceLevelObjectives>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlPerformanceTierServiceLevelObjectives>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MySqlPerformanceTierServiceLevelObjectives)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlPerformanceTierServiceLevelObjectives(document.RootElement, options);
        }

        internal static MySqlPerformanceTierServiceLevelObjectives DeserializeMySqlPerformanceTierServiceLevelObjectives(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> edition = default;
            Optional<int> vCore = default;
            Optional<string> hardwareGeneration = default;
            Optional<int> maxBackupRetentionDays = default;
            Optional<int> minBackupRetentionDays = default;
            Optional<int> maxStorageMB = default;
            Optional<int> minStorageMB = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("edition"u8))
                {
                    edition = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vCore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vCore = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("hardwareGeneration"u8))
                {
                    hardwareGeneration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxBackupRetentionDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxBackupRetentionDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minBackupRetentionDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minBackupRetentionDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxStorageMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxStorageMB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minStorageMB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minStorageMB = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MySqlPerformanceTierServiceLevelObjectives(id.Value, edition.Value, Optional.ToNullable(vCore), hardwareGeneration.Value, Optional.ToNullable(maxBackupRetentionDays), Optional.ToNullable(minBackupRetentionDays), Optional.ToNullable(maxStorageMB), Optional.ToNullable(minStorageMB), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MySqlPerformanceTierServiceLevelObjectives>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlPerformanceTierServiceLevelObjectives>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MySqlPerformanceTierServiceLevelObjectives)} does not support '{options.Format}' format.");
            }
        }

        MySqlPerformanceTierServiceLevelObjectives IPersistableModel<MySqlPerformanceTierServiceLevelObjectives>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlPerformanceTierServiceLevelObjectives>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMySqlPerformanceTierServiceLevelObjectives(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MySqlPerformanceTierServiceLevelObjectives)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MySqlPerformanceTierServiceLevelObjectives>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
