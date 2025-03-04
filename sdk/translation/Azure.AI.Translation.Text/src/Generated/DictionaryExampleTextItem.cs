// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Translation.Text
{
    /// <summary> Element containing the text with translation. </summary>
    public partial class DictionaryExampleTextItem : InputTextItem
    {
        /// <summary> Initializes a new instance of <see cref="DictionaryExampleTextItem"/>. </summary>
        /// <param name="text"> Text to translate. </param>
        /// <param name="translation">
        /// A string specifying the translated text previously returned by the Dictionary lookup operation.
        /// This should be the value from the normalizedTarget field in the translations list of the Dictionary
        /// lookup response. The service will return examples for the specific source-target word-pair.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> or <paramref name="translation"/> is null. </exception>
        public DictionaryExampleTextItem(string text, string translation) : base(text)
        {
            Argument.AssertNotNull(text, nameof(text));
            Argument.AssertNotNull(translation, nameof(translation));

            Translation = translation;
        }

        /// <summary> Initializes a new instance of <see cref="DictionaryExampleTextItem"/>. </summary>
        /// <param name="text"> Text to translate. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="translation">
        /// A string specifying the translated text previously returned by the Dictionary lookup operation.
        /// This should be the value from the normalizedTarget field in the translations list of the Dictionary
        /// lookup response. The service will return examples for the specific source-target word-pair.
        /// </param>
        internal DictionaryExampleTextItem(string text, IDictionary<string, BinaryData> serializedAdditionalRawData, string translation) : base(text, serializedAdditionalRawData)
        {
            Translation = translation;
        }

        /// <summary> Initializes a new instance of <see cref="DictionaryExampleTextItem"/> for deserialization. </summary>
        internal DictionaryExampleTextItem()
        {
        }

        /// <summary>
        /// A string specifying the translated text previously returned by the Dictionary lookup operation.
        /// This should be the value from the normalizedTarget field in the translations list of the Dictionary
        /// lookup response. The service will return examples for the specific source-target word-pair.
        /// </summary>
        public string Translation { get; }
    }
}
