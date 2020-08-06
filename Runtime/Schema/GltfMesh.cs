// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GltfMesh
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A set of primitives to be rendered.
    /// </summary>
    /// <remarks>
    /// A node can contain one mesh.
    /// A node's transform places the mesh in the scene.
    /// </remarks>
    [Serializable]
    [JsonObject("mesh")]
    public class GltfMesh : GltfChildOfRootProperty
    {
        /// <summary>An array of primitives, each defining geometry to be rendered with a material.</summary>
        [JsonProperty("primitives", Required = Required.Always)]
        public List<GltfMeshPrimitive> primitives = new List<GltfMeshPrimitive>();

        /// <summary>Array of weights to be applied to the Morph Targets.</summary>
        [JsonProperty("weights")]
        public float[] weights = null;

        /// <summary>
        /// Create a new instance of GltfMesh.
        /// </summary>
        public GltfMesh()
        {
        }

        /// <summary>
        /// Create a new instance of GltfMesh with name.
        /// </summary>
        /// <param name="name"></param>
        public GltfMesh(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Whether all primitives have the same attributes.
        /// </summary>
        /// <returns>Returns true if all primitives have the same attributes, false otherwise.</returns>
        public bool AllPrimitivesHasSameAttributes()
        {
            if (primitives.Count <= 1)
            {
                return true;
            }

            GltfMeshPrimitive firstPrimitive = primitives.First();

            if (primitives.Any(p => p.attributes.Equals(firstPrimitive.attributes) == false))
            {
                return false;
            }

            return true;
        }
    }
}
