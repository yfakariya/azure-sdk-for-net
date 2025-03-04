// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningComputeInstanceSshSettings : IUtf8JsonSerializable, IJsonModel<MachineLearningComputeInstanceSshSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningComputeInstanceSshSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningComputeInstanceSshSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningComputeInstanceSshSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningComputeInstanceSshSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SshPublicAccess))
            {
                writer.WritePropertyName("sshPublicAccess"u8);
                writer.WriteStringValue(SshPublicAccess.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(AdminUserName))
            {
                writer.WritePropertyName("adminUserName"u8);
                writer.WriteStringValue(AdminUserName);
            }
            if (options.Format != "W" && Optional.IsDefined(SshPort))
            {
                writer.WritePropertyName("sshPort"u8);
                writer.WriteNumberValue(SshPort.Value);
            }
            if (Optional.IsDefined(AdminPublicKey))
            {
                writer.WritePropertyName("adminPublicKey"u8);
                writer.WriteStringValue(AdminPublicKey);
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

        MachineLearningComputeInstanceSshSettings IJsonModel<MachineLearningComputeInstanceSshSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningComputeInstanceSshSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningComputeInstanceSshSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningComputeInstanceSshSettings(document.RootElement, options);
        }

        internal static MachineLearningComputeInstanceSshSettings DeserializeMachineLearningComputeInstanceSshSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MachineLearningSshPublicAccess> sshPublicAccess = default;
            Optional<string> adminUserName = default;
            Optional<int> sshPort = default;
            Optional<string> adminPublicKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sshPublicAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sshPublicAccess = new MachineLearningSshPublicAccess(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("adminUserName"u8))
                {
                    adminUserName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sshPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sshPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("adminPublicKey"u8))
                {
                    adminPublicKey = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MachineLearningComputeInstanceSshSettings(Optional.ToNullable(sshPublicAccess), adminUserName.Value, Optional.ToNullable(sshPort), adminPublicKey.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningComputeInstanceSshSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningComputeInstanceSshSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningComputeInstanceSshSettings)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningComputeInstanceSshSettings IPersistableModel<MachineLearningComputeInstanceSshSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningComputeInstanceSshSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningComputeInstanceSshSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningComputeInstanceSshSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningComputeInstanceSshSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
