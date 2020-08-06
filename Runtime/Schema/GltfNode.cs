// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GltfNode
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using System.ComponentModel;
    using System.Numerics;

    /// <summary>
    /// A node in the node hierarchy.
    /// </summary>
    /// <remarks>
    /// When the node contains `skin`, all `mesh.primitives` must contain `JOINTS_0` and `WEIGHTS_0` attributes.
    /// A node can have either a `matrix` or any combination of `translation`/`rotation`/`scale` (TRS) properties.
    /// TRS properties are converted to matrices and postmultiplied in the `T * R * S` order to compose the transformation matrix;
    /// first the scale is applied to the vertices, then the rotation, and then the translation. If none are provided, the transform is the identity.
    /// When a node is targeted for animation (referenced by an animation.channel.target), only TRS properties may be present; `matrix` will not be present.
    /// </remarks>
    [Serializable]
    [JsonObject("node")]
    public class GltfNode : GltfChildOfRootProperty
    {
        /// <summary>The index of the camera referenced by this node.</summary>
        [JsonProperty("camera", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [DefaultValue(-1)]
        public int camera = -1;

        /// <summary>The indices of this node's children.</summary>
        [JsonProperty("children")]
        public int[] children = null;

        /// <summary>The index of the skin referenced by this node.</summary>
        [JsonProperty("skin", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(-1)]
        public int skin = -1;

        /// <summary>A floating-point 4x4 transformation matrix stored in column-major order.</summary>
        [JsonProperty("matrix")]
        public Matrix4x4? matrix = null;

        /// <summary>The index of the mesh in this node.</summary>
        [JsonProperty("mesh", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(-1)]
        public int mesh = -1;

        /// <summary>The node's unit quaternion rotation in the order (x, y, z, w), where w is the scalar.</summary>
        [JsonProperty("rotation")]
        //[Range(-1.0f, 1.0f)]
        public Quaternion? rotation = null;

        /// <summary>The node's non-uniform scale, given as the scaling factors along the x, y, and z axes.</summary>
        [JsonProperty("scale")]
        public Vector3? scale = null;

        /// <summary>The node's translation along the x, y, and z axes.</summary>
        [JsonProperty("translation")]
        public Vector3? translation = null;

        /// <summary>The weights of the instantiated Morph Target. Number of elements must match number of Morph Targets of used mesh.</summary>
        [JsonProperty("weights")]
        public float[] weights = null;
    }
}
