// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Communication.Models
{
    public partial class DomainPropertiesVerificationRecords : IUtf8JsonSerializable, IJsonModel<DomainPropertiesVerificationRecords>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DomainPropertiesVerificationRecords>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DomainPropertiesVerificationRecords>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DomainPropertiesVerificationRecords>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DomainPropertiesVerificationRecords)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Domain))
            {
                writer.WritePropertyName("Domain"u8);
                writer.WriteObjectValue(Domain);
            }
            if (Optional.IsDefined(Spf))
            {
                writer.WritePropertyName("SPF"u8);
                writer.WriteObjectValue(Spf);
            }
            if (Optional.IsDefined(Dkim))
            {
                writer.WritePropertyName("DKIM"u8);
                writer.WriteObjectValue(Dkim);
            }
            if (Optional.IsDefined(Dkim2))
            {
                writer.WritePropertyName("DKIM2"u8);
                writer.WriteObjectValue(Dkim2);
            }
            if (Optional.IsDefined(Dmarc))
            {
                writer.WritePropertyName("DMARC"u8);
                writer.WriteObjectValue(Dmarc);
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

        DomainPropertiesVerificationRecords IJsonModel<DomainPropertiesVerificationRecords>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DomainPropertiesVerificationRecords>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DomainPropertiesVerificationRecords)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDomainPropertiesVerificationRecords(document.RootElement, options);
        }

        internal static DomainPropertiesVerificationRecords DeserializeDomainPropertiesVerificationRecords(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<VerificationDnsRecord> domain = default;
            Optional<VerificationDnsRecord> spf = default;
            Optional<VerificationDnsRecord> dkim = default;
            Optional<VerificationDnsRecord> dkiM2 = default;
            Optional<VerificationDnsRecord> dmarc = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Domain"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    domain = VerificationDnsRecord.DeserializeVerificationDnsRecord(property.Value);
                    continue;
                }
                if (property.NameEquals("SPF"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    spf = VerificationDnsRecord.DeserializeVerificationDnsRecord(property.Value);
                    continue;
                }
                if (property.NameEquals("DKIM"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dkim = VerificationDnsRecord.DeserializeVerificationDnsRecord(property.Value);
                    continue;
                }
                if (property.NameEquals("DKIM2"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dkiM2 = VerificationDnsRecord.DeserializeVerificationDnsRecord(property.Value);
                    continue;
                }
                if (property.NameEquals("DMARC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dmarc = VerificationDnsRecord.DeserializeVerificationDnsRecord(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DomainPropertiesVerificationRecords(domain.Value, spf.Value, dkim.Value, dkiM2.Value, dmarc.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DomainPropertiesVerificationRecords>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DomainPropertiesVerificationRecords>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DomainPropertiesVerificationRecords)} does not support '{options.Format}' format.");
            }
        }

        DomainPropertiesVerificationRecords IPersistableModel<DomainPropertiesVerificationRecords>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DomainPropertiesVerificationRecords>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDomainPropertiesVerificationRecords(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DomainPropertiesVerificationRecords)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DomainPropertiesVerificationRecords>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
