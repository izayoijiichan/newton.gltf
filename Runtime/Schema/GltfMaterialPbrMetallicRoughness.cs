// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GltfMaterialPbrMetallicRoughness
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using System.ComponentModel;
    using VgoGltf;

    /// <summary>
    /// Material PBR Metallic Roughness
    /// </summary>
    /// <remarks>
    /// A set of parameter values that are used to define the metallic-roughness material model from Physically-Based Rendering (PBR) methodology.
    /// </remarks>
    [Serializable]
    [JsonObject("material.pbrMetallicRoughness")]
    public class GltfMaterialPbrMetallicRoughness : GlTFProperty
    {
        /// <summary>The material's base color factor.</summary>
        /// <remarks>
        /// The RGBA components of the base color of the material. The fourth component (A) is the alpha coverage of the material.
        /// The `alphaMode` property specifies how alpha is interpreted.
        /// These values are linear.
        /// If a baseColorTexture is specified, this value is multiplied with the texel values.
        /// </remarks>
        [JsonProperty("baseColorFactor")]
        public Color4? baseColorFactor = null;

        /// <summary>The base color texture.</summary>
        /// <remarks>
        /// The base color texture.
        /// The first three components (RGB) are encoded with the sRGB transfer function.
        /// They specify the base color of the material.
        /// If the fourth component (A) is present, it represents the linear alpha coverage of the material.
        /// Otherwise, an alpha of 1.0 is assumed.
        /// The `alphaMode` property specifies how alpha is interpreted.
        /// The stored texels must not be premultiplied.
        /// </remarks>
        [JsonProperty("baseColorTexture")]
        public GltfTextureInfo baseColorTexture = null;

        /// <summary>The metalness of the material.</summary>
        /// <remarks>
        /// The metalness of the material.
        /// A value of 1.0 means the material is a metal.
        /// A value of 0.0 means the material is a dielectric.
        /// Values in between are for blending between metals and dielectrics such as dirty metallic surfaces.
        /// This value is linear.
        /// If a metallicRoughnessTexture is specified, this value is multiplied with the metallic texel values.
        /// </remarks>
        [JsonProperty("metallicFactor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-1.0f)]
        //[Range(0.0f , 1.0f)]
        public float metallicFactor = -1.0f;

        /// <summary>The roughness of the material.</summary>
        /// <remarks>
        /// The roughness of the material.
        /// A value of 1.0 means the material is completely rough.
        /// A value of 0.0 means the material is completely smooth.
        /// This value is linear.
        /// If a metallicRoughnessTexture is specified, this value is multiplied with the roughness texel values.
        /// </remarks>
        [JsonProperty("roughnessFactor", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-1.0f)]
        //[Range(0.0f, 1.0f)]
        public float roughnessFactor = -1.0f;

        /// <summary>The metallic-roughness texture.</summary>
        /// <remarks>
        /// The metallic-roughness texture.
        /// The metalness values are sampled from the B channel.
        /// The roughness values are sampled from the G channel.
        /// These values are linear.
        /// If other channels are present (R or A), they are ignored for metallic-roughness calculations.
        /// </remarks>
        [JsonProperty("metallicRoughnessTexture")]
        public GltfTextureInfo metallicRoughnessTexture = null;
    }
}
