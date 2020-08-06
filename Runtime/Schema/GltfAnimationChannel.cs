// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GltfAnimationChannel
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// Targets an animation's sampler at a node's property.
    /// </summary>
    [Serializable]
    [JsonObject("animation.channel")]
    public class GltfAnimationChannel : GlTFProperty
    {
        /// <summary>The index of a sampler in this animation used to compute the value for the target.</summary>
        /// <remarks>e.g., a node's translation, rotation, or scale (TRS).</remarks>
        [JsonProperty("sampler", Required = Required.Always)]
        public int sampler = -1;

        /// <summary>The index of the node and TRS property to target.</summary>
        [JsonProperty("target", Required = Required.Always)]
        public GltfAnimationChannelTarget target;
    }
}
