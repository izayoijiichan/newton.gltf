// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GltfAnimation
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// A keyframe animation.
    /// </summary>
    [Serializable]
    [JsonObject("animation")]
    public partial class GltfAnimation : GltfChildOfRootProperty
    {
        /// <summary>An array of channels, each of which targets an animation's sampler at a node's property.</summary>
        [JsonProperty("channels", Required = Required.Always)]
        public List<GltfAnimationChannel> channels = new List<GltfAnimationChannel>();

        /// <summary>An array of samplers that combines input and output accessors with an interpolation algorithm to define a keyframe graph (but not its target).</summary>
        [JsonProperty("samplers", Required = Required.Always)]
        public List<GltfAnimationSampler> samplers = new List<GltfAnimationSampler>();
    }
}
