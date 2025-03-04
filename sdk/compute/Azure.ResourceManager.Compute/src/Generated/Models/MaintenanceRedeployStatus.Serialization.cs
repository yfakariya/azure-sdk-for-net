// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class MaintenanceRedeployStatus : IUtf8JsonSerializable, IJsonModel<MaintenanceRedeployStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MaintenanceRedeployStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MaintenanceRedeployStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaintenanceRedeployStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MaintenanceRedeployStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsCustomerInitiatedMaintenanceAllowed))
            {
                writer.WritePropertyName("isCustomerInitiatedMaintenanceAllowed"u8);
                writer.WriteBooleanValue(IsCustomerInitiatedMaintenanceAllowed.Value);
            }
            if (Optional.IsDefined(PreMaintenanceWindowStartOn))
            {
                writer.WritePropertyName("preMaintenanceWindowStartTime"u8);
                writer.WriteStringValue(PreMaintenanceWindowStartOn.Value, "O");
            }
            if (Optional.IsDefined(PreMaintenanceWindowEndOn))
            {
                writer.WritePropertyName("preMaintenanceWindowEndTime"u8);
                writer.WriteStringValue(PreMaintenanceWindowEndOn.Value, "O");
            }
            if (Optional.IsDefined(MaintenanceWindowStartOn))
            {
                writer.WritePropertyName("maintenanceWindowStartTime"u8);
                writer.WriteStringValue(MaintenanceWindowStartOn.Value, "O");
            }
            if (Optional.IsDefined(MaintenanceWindowEndOn))
            {
                writer.WritePropertyName("maintenanceWindowEndTime"u8);
                writer.WriteStringValue(MaintenanceWindowEndOn.Value, "O");
            }
            if (Optional.IsDefined(LastOperationResultCode))
            {
                writer.WritePropertyName("lastOperationResultCode"u8);
                writer.WriteStringValue(LastOperationResultCode.Value.ToSerialString());
            }
            if (Optional.IsDefined(LastOperationMessage))
            {
                writer.WritePropertyName("lastOperationMessage"u8);
                writer.WriteStringValue(LastOperationMessage);
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

        MaintenanceRedeployStatus IJsonModel<MaintenanceRedeployStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaintenanceRedeployStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MaintenanceRedeployStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMaintenanceRedeployStatus(document.RootElement, options);
        }

        internal static MaintenanceRedeployStatus DeserializeMaintenanceRedeployStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> isCustomerInitiatedMaintenanceAllowed = default;
            Optional<DateTimeOffset> preMaintenanceWindowStartTime = default;
            Optional<DateTimeOffset> preMaintenanceWindowEndTime = default;
            Optional<DateTimeOffset> maintenanceWindowStartTime = default;
            Optional<DateTimeOffset> maintenanceWindowEndTime = default;
            Optional<MaintenanceOperationResultCodeType> lastOperationResultCode = default;
            Optional<string> lastOperationMessage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isCustomerInitiatedMaintenanceAllowed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isCustomerInitiatedMaintenanceAllowed = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("preMaintenanceWindowStartTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preMaintenanceWindowStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("preMaintenanceWindowEndTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preMaintenanceWindowEndTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("maintenanceWindowStartTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maintenanceWindowStartTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("maintenanceWindowEndTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maintenanceWindowEndTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastOperationResultCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastOperationResultCode = property.Value.GetString().ToMaintenanceOperationResultCodeType();
                    continue;
                }
                if (property.NameEquals("lastOperationMessage"u8))
                {
                    lastOperationMessage = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MaintenanceRedeployStatus(Optional.ToNullable(isCustomerInitiatedMaintenanceAllowed), Optional.ToNullable(preMaintenanceWindowStartTime), Optional.ToNullable(preMaintenanceWindowEndTime), Optional.ToNullable(maintenanceWindowStartTime), Optional.ToNullable(maintenanceWindowEndTime), Optional.ToNullable(lastOperationResultCode), lastOperationMessage.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MaintenanceRedeployStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaintenanceRedeployStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MaintenanceRedeployStatus)} does not support '{options.Format}' format.");
            }
        }

        MaintenanceRedeployStatus IPersistableModel<MaintenanceRedeployStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MaintenanceRedeployStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMaintenanceRedeployStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MaintenanceRedeployStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MaintenanceRedeployStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
