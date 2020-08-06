// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GltfOcclusionTextureInfo
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using System.ComponentModel;

    /// <summary>
    /// Occlusion Texture Info
    /// </summary>
    [Serializable]
    [JsonObject("occlusionTextureInfo")]
    public class GltfOcclusionTextureInfo : GltfTextureInfo
    {
        /// <summary>A scalar multiplier controlling the amount of occlusion applied.</summary>
        /// <remarks>
        /// A value of 0.0 means no occlusion.
        /// A value of 1.0 means full occlusion.
        /// This value affects the resulting color using the formula: `occludedColor = lerp(color, color * <sampled occlusion texture value>, <occlusion strength>)`.
        /// This value is ignored if the corresponding texture is not specified.
        /// This value is linear.
        /// </remarks>
        [JsonProperty("strength", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(1.0f)]
        //[JsonSchema(Minimum = 0.0, Maximum = 1.0)]
        public float strength = 1.0f;
    }
}
