// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GltfScene
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// The root nodes of a scene.
    /// </summary>
    [Serializable]
    [JsonObject("scene")]
    public class GltfScene : GltfChildOfRootProperty
    {
        /// <summary>The indices of each root node.</summary>
        [JsonProperty("nodes")]
        public int[] nodes;
    }
}
