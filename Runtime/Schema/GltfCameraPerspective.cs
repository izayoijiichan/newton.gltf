// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GltfCameraPerspective
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// A perspective camera containing properties to create a perspective projection matrix.
    /// </summary>
    [Serializable]
    [JsonObject("camera.perspective")]
    public class GltfCameraPerspective : GlTFProperty
    {
        /// <summary>The floating-point aspect ratio of the field of view.</summary>
        [JsonProperty("aspectRatio")]
        public float aspectRatio = 0.0f;

        /// <summary>The floating-point vertical field of view in radians.</summary>
        [JsonProperty("yfov", Required = Required.Always)]
        public float yfov = 0.0f;

        /// <summary>The floating-point distance to the far clipping plane.</summary>
        [JsonProperty("zfar")]
        public float zfar = 0.0f;

        /// <summary>The floating-point distance to the near clipping plane.</summary>
        [JsonProperty("znear", Required = Required.Always)]
        public float znear = 0.0f;
    }
}
