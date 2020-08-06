// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GltfExtras
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// Application-specific data.
    /// </summary>
    [Serializable]
    [JsonObject("extras")]
    //[JsonConverter(typeof(GltfExtrasJsonConverter))]
    public class GltfExtras : GltfExBase
    {
        /// <summary>
        /// Create a new instance of GltfExtras with jsonSerializerSettings.
        /// </summary>
        /// <param name="jsonSerializerSettings"></param>
        public GltfExtras(JsonSerializerSettings jsonSerializerSettings = null) : base(jsonSerializerSettings) { }
    }
}
