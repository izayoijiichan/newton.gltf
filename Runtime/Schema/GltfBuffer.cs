// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GltfBuffer
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// A buffer points to binary geometry, animation, or skins.
    /// </summary>
    [Serializable]
    [JsonObject("buffer")]
    public class GltfBuffer : GltfChildOfRootProperty
    {
        /// <summary>The uri of the buffer.</summary>
        /// <remarks>
        /// Relative paths are relative to the .gltf file.
        /// Instead of referencing an external file, the uri can also be a data-uri.
        /// </remarks>
        [JsonProperty("uri")]
        public string uri;

        /// <summary>The length of the buffer in bytes.</summary>
        [JsonProperty("byteLength", Required = Required.Always)]
        public int byteLength;
    }
}
