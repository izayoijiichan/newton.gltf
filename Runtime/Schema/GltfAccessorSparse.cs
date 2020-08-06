// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GltfAccessorSparse
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// Sparse storage of attributes that deviate from their initialization value.
    /// </summary>
    [Serializable]
    [JsonObject("accessor.sparse")]
    public class GltfAccessorSparse : GlTFProperty
    {
        /// <summary>Number of entries stored in the sparse array.</summary>
        /// <remarks>The number of attributes encoded in this sparse accessor.</remarks>
        [JsonProperty("count", Required = Required.Always)]
        public int count;

        /// <summary>Index array of size `count` that points to those accessor attributes that deviate from their initialization value.</summary>
        /// <remarks>Indices must strictly increase.</remarks>
        [JsonProperty("indices", Required = Required.Always)]
        public GltfAccessorSparseIndices indices;

        /// <summary>Array of size `count` times number of components, storing the displaced accessor attributes pointed by `indices`.</summary>
        /// <remarks>Substituted values must have the same `componentType` and number of components as the base accessor.</remarks>
        [JsonProperty("values", Required = Required.Always)]
        public GltfAccessorSparseValues values;
    }
}
