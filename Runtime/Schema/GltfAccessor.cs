// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GltfAccessor
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using System.ComponentModel;
    using VgoGltf;

    /// <summary>
    /// A typed view into a bufferView.
    /// </summary>
    /// <remarks>
    /// A bufferView contains raw binary data.
    /// An accessor provides a typed view into a bufferView or a subset of a bufferView similar to how WebGL's `vertexAttribPointer()` defines an attribute in a buffer.
    /// </remarks>
    [Serializable]
    [JsonObject("accessor")]
    public class GltfAccessor : GltfChildOfRootProperty
    {
        /// <summary>The index of the bufferView.</summary>
        /// <remarks>
        /// When not defined, accessor must be initialized with zeros; `sparse` property or extensions could override zeros with actual values.
        /// </remarks>
        [JsonProperty("bufferView", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(-1)]
        public int bufferView = -1;

        /// <summary>The offset relative to the start of the bufferView in bytes.</summary>
        /// <remarks>
        /// This must be a multiple of the size of the component datatype.
        /// </remarks>
        [JsonProperty("byteOffset", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(0)]
        public int byteOffset;

        /// <summary>The datatype of components in the attribute.</summary>
        /// <remarks>
        /// All valid values correspond to WebGL enums.
        /// The corresponding typed arrays are `Int8Array`, `Uint8Array`, `Int16Array`, `Uint16Array`, `Uint32Array`, and `Float32Array`, respectively.
        /// 5125 (UNSIGNED_INT) is only allowed when the accessor contains indices, i.e., the accessor is only referenced by `primitive.indices`.
        /// </remarks>
        [JsonProperty("componentType", Required = Required.Always)]
        public GltfComponentType componentType;

        /// <summary>Specifies whether integer data values should be normalized.</summary>
        /// <remarks>
        /// Specifies whether integer data values should be normalized (`true`) to [0, 1] (for unsigned types) or [-1, 1] (for signed types),
        /// or converted directly (`false`) when they are accessed.
        /// This property is defined only for accessors that contain vertex attributes or animation output data.
        /// </remarks>
        [JsonProperty("normalized", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(false)]
        public bool normalized;

        /// <summary>The number of attributes referenced by this accessor.</summary>
        /// <remarks>The number of attributes referenced by this accessor, not to be confused with the number of bytes or number of components.</remarks>
        [JsonProperty("count", Required = Required.Always)]
        public int count;

        /// <summary>Specifies if the attribute is a scalar, vector, or matrix.</summary>
        /// <remarks>
        /// </remarks>
        [JsonProperty("type", Required = Required.Always)]
        public GltfAccessorType type;

        /// <summary>Maximum value of each component in this attribute.</summary>
        /// <remarks>
        /// Array elements must be treated as having the same data type as accessor's `componentType`.
        /// Both min and max arrays have the same length.
        /// The length is determined by the value of the type property;
        /// it can be 1, 2, 3, 4, 9, or 16.\n\n`normalized` property has no effect on array values:
        /// they always correspond to the actual values stored in the buffer.
        /// When accessor is sparse, this property must contain max values of accessor data with sparse substitution applied.
        /// </remarks>
        [JsonProperty("max")]
        public float[] max;

        /// <summary>Minimum value of each component in this attribute.</summary>
        /// <remarks>
        /// Array elements must be treated as having the same data type as accessor's `componentType`.
        /// Both min and max arrays have the same length.
        /// The length is determined by the value of the type property;
        /// it can be 1, 2, 3, 4, 9, or 16.\n\n`normalized` property has no effect on array values:
        /// they always correspond to the actual values stored in the buffer.
        /// When accessor is sparse, this property must contain min values of accessor data with sparse substitution applied.
        /// </remarks>
        [JsonProperty("min")]
        public float[] min;

        /// <summary>Sparse storage of attributes that deviate from their initialization value.</summary>
        [JsonProperty("sparse")]
        public GltfAccessorSparse sparse;

        /// <summary>The size of the data stride for this attribute.</summary>
        [JsonIgnore]
        public int Stride => componentType.ByteSize() * type.TypeCount();

        /// <summary>The byte length of this attribute.</summary>
        [JsonIgnore]
        public int ByteLength => Stride * count;

        /// <summary>Whether sparse is defined for this accessor.</summary>
        [JsonIgnore]
        public bool HasSparse => sparse != null;
    }
}
