// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : KHR_texture_transform
// @See       : https://github.com/KhronosGroup/glTF/blob/master/extensions/2.0/Khronos/KHR_texture_transform/schema/KHR_texture_transform.textureInfo.schema.json
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using System.ComponentModel;
    using System.Numerics;

    [Serializable]
    public class KHR_texture_transform
    {
        /// <summary></summary>
        [JsonIgnore]
        public static string ExtensionName => "KHR_texture_transform";

        /// <summary>The offset of the UV coordinate origin as a factor of the texture dimensions.</summary>
        [JsonProperty("offset")]
        // [Default([0.0f, 0.0f])]
        public Vector2? offset;

        /// <summary>Rotate the UVs by this many radians counter-clockwise around the origin.</summary>
        /// <remarks>This is equivalent to a similar rotation of the image clockwise.</remarks>
        [JsonProperty("rotation", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(0.0f)]
        public float rotation;

        /// <summary>The scale factor applied to the components of the UV coordinates.</summary>
        [JsonProperty("scale")]
        // [Default([1.0f, 1.0f])]
        public Vector2? scale;

        /// <summary>Overrides the textureInfo texCoord value if supplied, and if this extension is supported.</summary>
        [JsonProperty("texCoord", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(-1)]
        public int texCoord = -1;
    }
}
