// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GltfAccessorSparseIndices
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using System.ComponentModel;
    using VgoGltf;

    /// <summary>
    /// Accessor Sparse Indices
    /// </summary>
    /// <remarks>Indices of those attributes that deviate from their initialization value.</remarks>
    [Serializable]
    [JsonObject("accessor.sparse.indices")]
    public class GltfAccessorSparseIndices : GlTFProperty
    {
        /// <summary>The index of the bufferView with sparse indices.</summary>
        /// <remarks>Referenced bufferView can't have ARRAY_BUFFER or ELEMENT_ARRAY_BUFFER target.</remarks>
        [JsonProperty("bufferView", Required = Required.Always)]
        public int bufferView = -1;

        /// <summary>The offset relative to the start of the bufferView in bytes.</summary>
        /// <remarks>Must be aligned.</remarks>
        [JsonProperty("byteOffset", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(0)]
        public int byteOffset;

        /// <summary>The indices data type.</summary>
        /// <remarks>Valid values correspond to WebGL enums: `5121` (UNSIGNED_BYTE), `5123` (UNSIGNED_SHORT), `5125` (UNSIGNED_INT).</remarks>
        [JsonProperty("componentType", Required = Required.Always)]
        public GltfComponentType componentType;
    }
}
