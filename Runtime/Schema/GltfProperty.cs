// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GlTFProperty
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// glTF Property
    /// </summary>
    [Serializable]
    public class GlTFProperty
    {
        /// <summary>Dictionary object with extension-specific objects.</summary>
        [JsonProperty("extensions")]
        public GltfExtensions extensions = null;

        /// <summary>Application-specific data.</summary>
        [JsonProperty("extras")]
        public GltfExtras extras = null;
    }
}
