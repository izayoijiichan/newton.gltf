// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GltfMeshPrimitive
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using VgoGltf;

    /// <summary>
    /// Geometry to be rendered with the given material.
    /// </summary>
    [Serializable]
    [JsonObject("mesh.primitive")]
    public class GltfMeshPrimitive : GlTFProperty
    {
        /// <summary>A dictionary object, where each key corresponds to mesh attribute semantic and each value is the index of the accessor containing attribute's data.</summary>
        [JsonProperty("attributes", Required = Required.Always)]
        public GltfMeshPrimitiveAttributes attributes = null;

        /// <summary>The index of the accessor that contains the indices.</summary>
        /// <remarks>
        /// The index of the accessor that contains mesh indices.
        /// When this is not defined, the primitives should be rendered without indices using `drawArrays()`.
        /// When defined, the accessor must contain indices:
        /// the `bufferView` referenced by the accessor should have a `target` equal to 34963 (ELEMENT_ARRAY_BUFFER);
        /// `componentType` must be 5121 (UNSIGNED_BYTE), 5123 (UNSIGNED_SHORT) or 5125 (UNSIGNED_INT), the latter may require enabling additional hardware support;
        /// `type` must be `\"SCALAR\"`.
        /// For triangle primitives, the front face has a counter-clockwise (CCW) winding order.
        /// Values of the index accessor must not include the maximum value for the given component type,
        /// which triggers primitive restart in several graphics APIs and would require client implementations to rebuild the index buffer.
        /// Primitive restart values are disallowed and all index values must refer to actual vertices.
        /// As a result, the index accessor's values must not exceed the following maxima: BYTE `< 255`, UNSIGNED_SHORT `< 65535`, UNSIGNED_INT `< 4294967295`.
        /// </remarks>
        [JsonProperty("indices", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(-1)]
        public int indices = -1;

        /// <summary>The index of the material to apply to this primitive when rendering.</summary>
        [JsonProperty("material", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(-1)]
        public int material = -1;

        /// <summary>The type of primitives to render.</summary>
        [JsonProperty("mode", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(GltfMeshPrimitiveMode.TRIANGLES)]
        public GltfMeshPrimitiveMode mode = GltfMeshPrimitiveMode.TRIANGLES;

        /// <summary>An array of Morph Targets.</summary>
        /// <remarks>An array of Morph Targets, each Morph Target is a dictionary mapping attributes (only `POSITION`, `NORMAL`, and `TANGENT` supported) to their deviations in the Morph Target.</remarks>
        [JsonProperty("targets")]
        public List<GltfMeshPrimitiveAttributes> targets = null;

        /// <summary>List of target name.</summary>
        [JsonIgnore]
        public List<string> targetNames = new List<string>();

        /// <summary>Whether this primitive has a vertex color.</summary>
        [JsonIgnore]
        public bool HasVertexColor => (attributes != null) && (attributes.COLOR_0 != -1);
    }
}
