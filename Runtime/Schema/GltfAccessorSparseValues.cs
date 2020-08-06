// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GltfAccessorSparseValues
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using System.ComponentModel;

    /// <summary>
    /// Accessor Sparse Values
    /// </summary>
    /// <remarks>Array of size `accessor.sparse.count` times number of components storing the displaced accessor attributes pointed by `accessor.sparse.indices`.</remarks>
    [Serializable]
    [JsonObject("accessor.sparse.values")]
    public class GltfAccessorSparseValues : GlTFProperty
    {
        /// <summary>The index of the bufferView with sparse values.</summary>
        /// <remarks>Referenced bufferView can't have ARRAY_BUFFER or ELEMENT_ARRAY_BUFFER target.</remarks>
        [JsonProperty("bufferView", Required = Required.Always)]
        public int bufferView = -1;

        /// <summary>The offset relative to the start of the bufferView in bytes.</summary>
        /// <remarks>Must be aligned.</remarks>
        [JsonProperty("byteOffset", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(0)]
        public int byteOffset;
    }
}
