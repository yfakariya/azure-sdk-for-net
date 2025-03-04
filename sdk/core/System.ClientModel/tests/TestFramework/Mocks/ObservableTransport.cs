﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ClientModel.Tests.Mocks;

public class ObservableTransport : PipelineTransport
{
    public string Id { get; }

    public ObservableTransport(string id)
    {
        Id = id;
    }

    protected override PipelineMessage CreateMessageCore()
    {
        return new TransportMessage();
    }

    protected override void ProcessCore(PipelineMessage message)
    {
        Stamp(message, "Transport");

        if (message is TransportMessage transportMessage)
        {
            transportMessage.SetResponse();
        }
    }

    protected override ValueTask ProcessCoreAsync(PipelineMessage message)
    {
        Stamp(message, "Transport");

        if (message is TransportMessage transportMessage)
        {
            transportMessage.SetResponse();
        }

        return new ValueTask();
    }

    private void Stamp(PipelineMessage message, string prefix)
    {
        List<string> values;

        if (message.TryGetProperty(typeof(ObservablePolicy), out object? prop) &&
            prop is List<string> list)
        {
            values = list;
        }
        else
        {
            values = new List<string>();
            message.SetProperty(typeof(ObservablePolicy), values);
        }

        values.Add($"{prefix}:{Id}");
    }

    private class TransportMessage : PipelineMessage
    {
        public TransportMessage() : this(new TransportRequest())
        {
        }

        protected internal TransportMessage(PipelineRequest request) : base(request)
        {
        }

        public void SetResponse()
        {
            Response = new TransportResponse();
        }
    }

    private class TransportRequest : PipelineRequest
    {
        public TransportRequest() { }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }

        protected override BinaryContent? GetContentCore()
        {
            throw new NotImplementedException();
        }

        protected override PipelineRequestHeaders GetHeadersCore()
        {
            throw new NotImplementedException();
        }

        protected override string GetMethodCore()
        {
            throw new NotImplementedException();
        }

        protected override Uri GetUriCore()
        {
            throw new NotImplementedException();
        }

        protected override void SetContentCore(BinaryContent? content)
        {
            throw new NotImplementedException();
        }

        protected override void SetMethodCore(string method)
        {
            throw new NotImplementedException();
        }

        protected override void SetUriCore(Uri uri)
        {
            throw new NotImplementedException();
        }
    }

    private class TransportResponse : PipelineResponse
    {
        public override int Status => 0;

        public override string ReasonPhrase => throw new NotImplementedException();

        public override Stream? ContentStream
        {
            get => null;
            set => throw new NotImplementedException();
        }

        protected override PipelineResponseHeaders GetHeadersCore()
        {
            throw new NotImplementedException();
        }

        public override void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
