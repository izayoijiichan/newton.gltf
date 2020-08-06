// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GltfAnimationChannelTarget
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using VgoGltf;

    /// <summary>
    /// The index of the node and TRS property that an animation channel targets.
    /// </summary>
    [Serializable]
    [JsonObject("animation.channel.target")]
    public class GltfAnimationChannelTarget : GlTFProperty
    {
        /// <summary>The index of the node to target.</summary>
        [JsonProperty("node")]
        public int node = -1;

        /// <summary>The name of the node's TRS property to modify, or the \"weights\" of the Morph Targets it instantiates.</summary>
        [JsonProperty("path", Required = Required.Always)]
        public GltfAnimationChannelPath path;
    }
}
