// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GltfExtensions
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// Dictionary object with extension-specific objects.
    /// </summary>
    [Serializable]
    [JsonObject("extensions")]
    //[JsonConverter(typeof(GltfExtensionsJsonConverter))]
    public class GltfExtensions : GltfExBase
    {
        /// <summary>
        /// Create a new instance of GltfExtras with jsonSerializerSettings.
        /// </summary>
        /// <param name="jsonSerializerSettings"></param>
        public GltfExtensions(JsonSerializerSettings jsonSerializerSettings = null) : base(jsonSerializerSettings) { }
    }
}
