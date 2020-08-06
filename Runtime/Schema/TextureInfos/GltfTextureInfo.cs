// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GltfTextureInfo
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using System.ComponentModel;

    /// <summary>
    /// Reference to a texture.
    /// </summary>
    [Serializable]
    [JsonObject("textureInfo")]
    public class GltfTextureInfo : GlTFProperty, IGltfTextureinfo
    {
        /// <summary>The index of the texture.</summary>
        [JsonProperty("index", Required = Required.Always)]
        public int index = -1;

        /// <summary>The set index of texture's TEXCOORD attribute used for texture coordinate mapping.</summary>
        /// <remarks>
        /// This integer value is used to construct a string in the format `TEXCOORD_<set index>`
        /// which is a reference to a key in mesh.primitives.attributes (e.g. A value of `0` corresponds to `TEXCOORD_0`).
        /// Mesh must have corresponding texture coordinate attributes for the material to be applicable to it.
        /// </remarks>
        [JsonProperty("texCoord", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(0)]
        public int texCoord;
    }
}
