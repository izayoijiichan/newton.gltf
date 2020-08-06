// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GltfAsset
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// Metadata about the glTF asset.
    /// </summary>
    [Serializable]
    [JsonObject("asset")]
    public class GltfAsset : GlTFProperty
    {
        /// <summary>A copyright message suitable for display to credit the content creator.</summary>
        [JsonProperty("copyright")]
        public string copyright;

        /// <summary>Tool that generated this glTF model.</summary>
        /// <remarks>Useful for debugging.</remarks>
        [JsonProperty("generator")]
        public string generator;

        /// <summary>The glTF version that this asset targets.</summary>
        [JsonProperty("version", Required = Required.Always)]
        //[RegularExpression("^[0-9]+\\.[0-9]+$")]
        public string version;

        /// <summary>The minimum glTF version that this asset targets.</summary>
        [JsonProperty("minVersion")]
        //[RegularExpression("^[0-9]+\\.[0-9]+$")]
        public string minVersion;
    }
}
