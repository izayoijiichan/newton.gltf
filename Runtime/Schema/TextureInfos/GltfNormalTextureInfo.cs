// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GltfNormalTextureInfo
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using System.ComponentModel;

    /// <summary>
    /// Normal Texture Info
    /// </summary>
    [Serializable]
    [JsonObject("normalTextureInfo")]
    public class GltfNormalTextureInfo : GltfTextureInfo
    {
        /// <summary>The scalar multiplier applied to each normal vector of the normal texture.</summary>
        /// <remarks>
        /// The scalar multiplier applied to each normal vector of the texture.
        /// This value scales the normal vector using the formula:
        /// `scaledNormal =  normalize((<sampled normal texture value> * 2.0 - 1.0) * vec3(<normal scale>, <normal scale>, 1.0))`.
        /// This value is ignored if normalTexture is not specified.
        /// This value is linear.
        /// </remarks>
        [JsonProperty("scale", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(1.0f)]
        public float scale = 1.0f;
    }
}
