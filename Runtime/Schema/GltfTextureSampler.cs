// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GltfTextureSampler
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using System.ComponentModel;
    using VgoGltf;

    /// <summary>
    /// Texture sampler properties for filtering and wrapping modes.
    /// </summary>
    [Serializable]
    [JsonObject("sampler")]
    public class GltfTextureSampler : GltfChildOfRootProperty
    {
        /// <summary>Magnification filter.</summary>
        /// <remarks>Valid values correspond to WebGL enums: `9728` (NEAREST) and `9729` (LINEAR).</remarks>
        [JsonProperty("magFilter", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(GltfTextureMagFilterMode.NONE)]
        public GltfTextureMagFilterMode magFilter = GltfTextureMagFilterMode.NONE;

        /// <summary>Minification filter.</summary>
        /// <remarks>All valid values correspond to WebGL enums.</remarks>
        [JsonProperty("minFilter", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(GltfTextureMinFilterMode.NONE)]
        public GltfTextureMinFilterMode minFilter = GltfTextureMinFilterMode.NONE;

        /// <summary>s wrapping mode.</summary>
        [JsonProperty("wrapS", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(GltfTextureWrapMode.REPEAT)]
        public GltfTextureWrapMode wrapS = GltfTextureWrapMode.NONE;

        /// <summary>t wrapping mode.</summary>
        [JsonProperty("wrapT", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(GltfTextureWrapMode.REPEAT)]
        public GltfTextureWrapMode wrapT = GltfTextureWrapMode.NONE;
    }
}
