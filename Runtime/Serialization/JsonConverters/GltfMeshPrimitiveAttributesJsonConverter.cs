// ----------------------------------------------------------------------
// @Namespace : NewtonGltf.Serialization.JsonConverters
// @Class     : GltfMeshPrimitiveAttributesJsonConverter
// ----------------------------------------------------------------------
namespace NewtonGltf.Serialization.JsonConverters
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// glTF GltfMeshPrimitiveAttributes Json Converter
    /// </summary>
    public class GltfMeshPrimitiveAttributesJsonConverter : JsonConverter
    {
        /// <summary>
        /// Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns></returns>
        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(GltfMeshPrimitiveAttributes);
        }

        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The Newtonsoft.Json.JsonReader to read from.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <returns>The object value.</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            Dictionary<string, int> dictionary;

            if (reader.TokenType == JsonToken.StartArray)
            {
                dictionary = serializer
                    .Deserialize<KeyValuePair<string, int>[]>(reader)
                    .ToDictionary(x => x.Key, x => x.Value);
            }
            else
            {
                dictionary = serializer.Deserialize<Dictionary<string, int>>(reader);
            }

            if (dictionary == null)
            {
                return null;
            }

            return new GltfMeshPrimitiveAttributes(dictionary);
        }

        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The Newtonsoft.Json.JsonWriter to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                return;
            }

            GltfMeshPrimitiveAttributes attributes = value as GltfMeshPrimitiveAttributes;

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (KeyValuePair<string, int> attribute in attributes)
            {
                dictionary.Add(attribute.Key, attribute.Value);
            }

            serializer.Serialize(writer, dictionary);
        }
    }
}