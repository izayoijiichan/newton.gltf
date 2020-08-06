// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GltfCameraOrthographic
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// An orthographic camera containing properties to create an orthographic projection matrix.
    /// </summary>
    [Serializable]
    [JsonObject("camera.orthographic")]
    public class GltfCameraOrthographic : GlTFProperty
    {
        /// <summary>The floating-point horizontal magnification of the view.</summary>
        [JsonProperty("xmag", Required = Required.Always)]
        public float xmag;

        /// <summary>The floating-point vertical magnification of the view.</summary>
        [JsonProperty("ymag", Required = Required.Always)]
        public float ymag;

        /// <summary>The floating-point distance to the far clipping plane.</summary>
        [JsonProperty("zfar", Required = Required.Always)]
        public float zfar = 0.0f;

        /// <summary>The floating-point distance to the near clipping plane.</summary>
        [JsonProperty("znear", Required = Required.Always)]
        public float znear = 0.0f;
    }
}
