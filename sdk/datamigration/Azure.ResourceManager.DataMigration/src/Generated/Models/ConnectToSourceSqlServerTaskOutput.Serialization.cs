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
    [PersistableModelProxy(typeof(UnknownConnectToSourceSqlServerTaskOutput))]
    public partial class ConnectToSourceSqlServerTaskOutput : IUtf8JsonSerializable, IJsonModel<ConnectToSourceSqlServerTaskOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectToSourceSqlServerTaskOutput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConnectToSourceSqlServerTaskOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToSourceSqlServerTaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectToSourceSqlServerTaskOutput)} does not support '{format}' format.");
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

        ConnectToSourceSqlServerTaskOutput IJsonModel<ConnectToSourceSqlServerTaskOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToSourceSqlServerTaskOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectToSourceSqlServerTaskOutput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectToSourceSqlServerTaskOutput(document.RootElement, options);
        }

        internal static ConnectToSourceSqlServerTaskOutput DeserializeConnectToSourceSqlServerTaskOutput(JsonElement element, ModelReaderWriterOptions options = null)
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
                    case "AgentJobLevelOutput": return ConnectToSourceSqlServerTaskOutputAgentJobLevel.DeserializeConnectToSourceSqlServerTaskOutputAgentJobLevel(element);
                    case "DatabaseLevelOutput": return ConnectToSourceSqlServerTaskOutputDatabaseLevel.DeserializeConnectToSourceSqlServerTaskOutputDatabaseLevel(element);
                    case "LoginLevelOutput": return ConnectToSourceSqlServerTaskOutputLoginLevel.DeserializeConnectToSourceSqlServerTaskOutputLoginLevel(element);
                    case "TaskLevelOutput": return ConnectToSourceSqlServerTaskOutputTaskLevel.DeserializeConnectToSourceSqlServerTaskOutputTaskLevel(element);
                }
            }
            return UnknownConnectToSourceSqlServerTaskOutput.DeserializeUnknownConnectToSourceSqlServerTaskOutput(element);
        }

        BinaryData IPersistableModel<ConnectToSourceSqlServerTaskOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToSourceSqlServerTaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConnectToSourceSqlServerTaskOutput)} does not support '{options.Format}' format.");
            }
        }

        ConnectToSourceSqlServerTaskOutput IPersistableModel<ConnectToSourceSqlServerTaskOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectToSourceSqlServerTaskOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConnectToSourceSqlServerTaskOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectToSourceSqlServerTaskOutput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectToSourceSqlServerTaskOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
