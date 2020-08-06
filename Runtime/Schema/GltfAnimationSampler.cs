// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GltfAnimationSampler
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using System.ComponentModel;
    using VgoGltf;

    /// <summary>
    /// Combines input and output accessors with an interpolation algorithm to define a keyframe graph (but not its target).
    /// </summary>
    [Serializable]
    [JsonObject("animation.sampler")]
    public class GltfAnimationSampler : GlTFProperty
    {
        /// <summary>The index of an accessor containing keyframe input values, e.g., time.</summary>
        /// <remarks>
        /// That accessor must have componentType `FLOAT`.
        /// The values represent time in seconds with `time[0] >= 0.0`, and strictly increasing values, i.e., `time[n + 1] > time[n]`.
        /// </remarks>
        [JsonProperty("input", Required = Required.Always)]
        public int input = -1;

        /// <summary>Interpolation algorithm.</summary>
        [JsonProperty("interpolation", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(GltfAnimationInterpolationType.LINEAR)]
        public GltfAnimationInterpolationType interpolation;

        /// <summary>The index of an accessor, containing keyframe output values.</summary>
        [JsonProperty("output", Required = Required.Always)]
        public int output = -1;
    }
}
