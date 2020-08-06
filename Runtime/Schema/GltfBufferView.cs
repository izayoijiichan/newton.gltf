// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GltfBufferView
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using System.ComponentModel;
    using VgoGltf;

    /// <summary>
    /// A view into a buffer generally representing a subset of the buffer.
    /// </summary>
    [Serializable]
    [JsonObject("bufferView")]
    public class GltfBufferView : GltfChildOfRootProperty
    {
        /// <summary>The index of the buffer.</summary>
        [JsonProperty("buffer", Required = Required.Always)]
        public int buffer = -1;

        /// <summary>The offset into the buffer in bytes.</summary>
        [JsonProperty("byteOffset", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(0)]
        public int byteOffset;

        /// <summary>The total byte length of the buffer view.</summary>
        [JsonProperty("byteLength", Required = Required.Always)]
        public int byteLength;

        /// <summary>The stride, in bytes.</summary>
        /// <remarks>
        /// The stride, in bytes, between vertex attributes.
        /// When this is not defined, data is tightly packed.
        /// When two or more accessors use the same bufferView, this field must be defined.
        /// </remarks>
        [JsonProperty("byteStride", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(4)]
        //[Range(4, 252)]
        public int byteStride = 4;

        /// <summary>The target that the GPU buffer should be bound to.</summary>
        [JsonProperty("target", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(GltfBufferViewTarget.NONE)]
        public GltfBufferViewTarget target;
    }
}
