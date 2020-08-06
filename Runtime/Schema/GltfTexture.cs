// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GltfTexture
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using System.ComponentModel;

    /// <summary>
    /// A texture and its sampler.
    /// </summary>
    [Serializable]
    [JsonObject("texture")]
    public class GltfTexture : GltfChildOfRootProperty
    {
        /// <summary>The index of the sampler used by this texture.</summary>
        /// <remarks>When undefined, a sampler with repeat wrapping and auto filtering should be used.</remarks>
        [JsonProperty("sampler", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(-1)]
        public int sampler = -1;

        /// <summary>The index of the image used by this texture.</summary>
        /// <remarks>When undefined, it is expected that an extension or other mechanism will supply an alternate texture source, otherwise behavior is undefined.</remarks>
        [JsonProperty("source", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(-1)]
        public int source = -1;
    }
}
