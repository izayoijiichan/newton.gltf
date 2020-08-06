// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GltfCamera
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using VgoGltf;

    /// <summary>A camera's projection.</summary>
    /// <remarks>A node can reference a camera to apply a transform to place the camera in the scene.</remarks>
    [Serializable]
    [JsonObject("camera")]
    public class GltfCamera : GltfChildOfRootProperty
    {
        /// <summary></summary>
        [JsonProperty("orthographic")]
        public GltfCameraOrthographic orthographic;

        /// <summary></summary>
        [JsonProperty("perspective")]
        public GltfCameraPerspective perspective;

        /// <summary>Specifies if the camera uses a perspective or orthographic projection.</summary>
        /// <remarks>Based on this, either the camera's `perspective` or `orthographic` property will be defined.</remarks>
        [JsonProperty("type", Required = Required.Always)]
        public GltfCameraProjectionType type;
    }
}
