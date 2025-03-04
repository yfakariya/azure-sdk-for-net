// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.StreamAnalytics;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The request object for query testing. </summary>
    public partial class StreamAnalyticsTestQuery
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsTestQuery"/>. </summary>
        /// <param name="streamingJob"> Stream analytics job object which defines the input, output, and transformation for the query testing. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="streamingJob"/> is null. </exception>
        public StreamAnalyticsTestQuery(StreamingJobData streamingJob)
        {
            Argument.AssertNotNull(streamingJob, nameof(streamingJob));

            StreamingJob = streamingJob;
        }

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsTestQuery"/>. </summary>
        /// <param name="streamingJob"> Stream analytics job object which defines the input, output, and transformation for the query testing. </param>
        /// <param name="writeUri"> The SAS URI to the container or directory. </param>
        /// <param name="path"> The path to the subdirectory. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamAnalyticsTestQuery(StreamingJobData streamingJob, Uri writeUri, string path, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StreamingJob = streamingJob;
            WriteUri = writeUri;
            Path = path;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StreamAnalyticsTestQuery"/> for deserialization. </summary>
        internal StreamAnalyticsTestQuery()
        {
        }

        /// <summary> Stream analytics job object which defines the input, output, and transformation for the query testing. </summary>
        public StreamingJobData StreamingJob { get; }
        /// <summary> The SAS URI to the container or directory. </summary>
        public Uri WriteUri { get; set; }
        /// <summary> The path to the subdirectory. </summary>
        public string Path { get; set; }
    }
}
