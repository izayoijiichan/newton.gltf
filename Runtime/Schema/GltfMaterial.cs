// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GltfMaterial
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using System.ComponentModel;
    using VgoGltf;

    /// <summary>
    /// The material appearance of a primitive.
    /// </summary>
    [Serializable]
    [JsonObject("material")]
    public class GltfMaterial : GltfChildOfRootProperty
    {
        /// <summary>A set of parameter values that are used to define the metallic-roughness material model from Physically-Based Rendering (PBR) methodology.</summary>
        [JsonProperty("pbrMetallicRoughness")]
        public GltfMaterialPbrMetallicRoughness pbrMetallicRoughness = null;

        /// <summary>The normal map texture.</summary>
        /// <remarks>
        /// A tangent space normal map.
        /// The texture contains RGB components in linear space.
        /// Each texel represents the XYZ components of a normal vector in tangent space.
        /// Red [0 to 255] maps to X [-1 to 1].
        /// Green [0 to 255] maps to Y [-1 to 1].
        /// Blue [128 to 255] maps to Z [1/255 to 1].
        /// The normal vectors use OpenGL conventions where +X is right and +Y is up.
        /// +Z points toward the viewer.
        /// In GLSL, this vector would be unpacked like so: `float3 normalVector = tex2D(<sampled normal map texture value>, texCoord) * 2 - 1`.
        /// Client implementations should normalize the normal vectors before using them in lighting equations.
        /// </remarks>
        [JsonProperty("normalTexture")]
        public GltfNormalTextureInfo normalTexture = null;

        /// <summary>The occlusion map texture.</summary>
        /// <remarks>
        /// The occlusion map texture.
        /// The occlusion values are sampled from the R channel.
        /// Higher values indicate areas that should receive full indirect lighting and lower values indicate no indirect lighting.
        /// These values are linear.
        /// If other channels are present (GBA), they are ignored for occlusion calculations.
        /// </remarks>
        [JsonProperty("occlusionTexture")]
        public GltfOcclusionTextureInfo occlusionTexture = null;

        /// <summary>The emissive map texture.</summary>
        /// <remarks>
        /// The emissive map controls the color and intensity of the light being emitted by the material.
        /// This texture contains RGB components encoded with the sRGB transfer function.
        /// If a fourth component (A) is present, it is ignored.
        /// </remarks>
        [JsonProperty("emissiveTexture")]
        public GltfTextureInfo emissiveTexture = null;

        /// <summary>The emissive color of the material.</summary>
        /// <remarks>
        /// The RGB components of the emissive color of the material.
        /// These values are linear.
        /// If an emissiveTexture is specified, this value is multiplied with the texel values.
        /// </remarks>
        [JsonProperty("emissiveFactor")]
        public Color3? emissiveFactor = null;

        /// <summary>The alpha rendering mode of the material.</summary>
        /// <remarks>The material's alpha rendering mode enumeration specifying the interpretation of the alpha value of the main factor and texture.</remarks>
        [JsonProperty("alphaMode", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(GltfAlphaMode.OPAQUE)]
        public GltfAlphaMode alphaMode;

        /// <summary>The alpha cutoff value of the material.</summary>
        /// <remarks>
        /// Specifies the cutoff threshold when in `MASK` mode.
        /// If the alpha value is greater than or equal to this value then it is rendered as fully opaque, otherwise, it is rendered as fully transparent.
        /// A value greater than 1.0 will render the entire material as fully transparent.
        /// This value is ignored for other modes.
        /// </remarks>
        [JsonProperty("alphaCutoff", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(-1.0f)]
        //[Range(0.0f, 1.0f)]
        public float alphaCutoff = -1.0f;

        /// <summary>Specifies whether the material is double sided.</summary>
        /// <remarks>
        /// Specifies whether the material is double sided.
        /// When this value is false, back-face culling is enabled.
        /// When this value is true, back-face culling is disabled and double sided lighting is enabled.
        /// The back-face must have its normals reversed before the lighting equation is evaluated.
        /// </remarks>
        [JsonProperty("doubleSided", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(false)]
        public bool doubleSided = false;
    }
}
