// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : Gltf
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The root object for a glTF asset.
    /// </summary>
    [Serializable]
    [JsonObject("glTF")]
    public class Gltf : GlTFProperty
    {
        /// <summary>Names of glTF extensions used somewhere in this asset.</summary>
        [JsonProperty("extensionsUsed")]
        public List<string> extensionsUsed = new List<string>();

        /// <summary>Names of glTF extensions required to properly load this asset.</summary>
        [JsonProperty("extensionsRequired")]
        public List<string> extensionsRequired = new List<string>();

        /// <summary>List of accessors.</summary>
        [JsonProperty("accessors")]
        public List<GltfAccessor> accessors = new List<GltfAccessor>();

        /// <summary>Metadata about the glTF asset.</summary>
        [JsonProperty("asset", Required = Required.Always)]
        public GltfAsset asset = new GltfAsset();

        /// <summary>List of keyframe animations</summary>
        [JsonProperty("animations")]
        public List<GltfAnimation> animations = new List<GltfAnimation>();

        /// <summary>List of buffers.</summary>
        [JsonProperty("buffers")]
        public List<GltfBuffer> buffers = new List<GltfBuffer>();

        /// <summary>List of bufferViews.</summary>
        [JsonProperty("bufferViews")]
        public List<GltfBufferView> bufferViews = new List<GltfBufferView>();

        /// <summary>List of cameras.</summary>
        [JsonProperty("cameras")]
        public List<GltfCamera> cameras = new List<GltfCamera>();

        /// <summary>List of images.</summary>
        [JsonProperty("images")]
        public List<GltfImage> images = new List<GltfImage>();

        /// <summary>List of materials.</summary>
        [JsonProperty("materials")]
        public List<GltfMaterial> materials = new List<GltfMaterial>();

        /// <summary>List of meshes.</summary>
        [JsonProperty("meshes")]
        public List<GltfMesh> meshes = new List<GltfMesh>();

        /// <summary>List of nodes.</summary>
        [JsonProperty("nodes")]
        public List<GltfNode> nodes = new List<GltfNode>();

        /// <summary>List of samplers.</summary>
        [JsonProperty("samplers")]
        public List<GltfTextureSampler> samplers = new List<GltfTextureSampler>();

        /// <summary>List of accessors.</summary>
        [JsonProperty("scene")]
        public int scene;

        /// <summary>List of scenes.</summary>
        [JsonProperty("scenes")]
        public List<GltfScene> scenes = new List<GltfScene>();

        /// <summary>List of skins.</summary>
        [JsonProperty("skins")]
        public List<GltfSkin> skins = new List<GltfSkin>();

        /// <summary>List of textures.</summary>
        [JsonProperty("textures")]
        public List<GltfTexture> textures = new List<GltfTexture>();

        /// <summary></summary>
        [JsonIgnore]
        public int[] rootnodes => (scenes.Count > 0) ? scenes[scene].nodes : null;
    }
}
