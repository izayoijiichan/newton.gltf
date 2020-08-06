// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GltfFImage
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;
    using System.ComponentModel;
    using System.IO;

    /// <summary>Image data used to create a texture.</summary>
    /// <remarks>Image can be referenced by URI or `bufferView` index. `mimeType` is required in the latter case.</remarks>
    [Serializable]
    [JsonObject("image")]
    public class GltfImage : GltfChildOfRootProperty
    {
        /// <summary>The uri of the image.</summary>
        /// <remarks>
        /// Relative paths are relative to the .gltf file.
        /// Instead of referencing an external file, the uri can also be a data-uri.
        /// The image format must be jpg or png.
        /// </remarks>
        [JsonProperty("uri")]
        public string uri = null;

        /// <summary>The image's MIME type.</summary>
        /// <remarks>Required if `bufferView` is defined.</remarks>
        [JsonProperty("mimeType")]
        public string mimeType = null;

        /// <summary>The index of the bufferView that contains the image.</summary>
        [JsonProperty("bufferView", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(-1)]
        public int bufferView = -1;

        /// <summary>
        /// Returns the extension (including the period ".") of the specified path string.
        /// </summary>
        /// <returns>The extension of the specified path (including the period "."), or null, or Empty.</returns>
        public string GetExtension()
        {
            if (string.IsNullOrEmpty(mimeType) == false)
            {
                if (mimeType == "image/jpeg")
                {
                    return ".jpg";
                }
                else if (mimeType == "image/png")
                {
                    return ".png";
                }
            }

            if (string.IsNullOrEmpty(uri))
            {
                return string.Empty;
            }

            if (uri.StartsWith("data:image/jpeg;"))
            {
                return ".jpg";
            }
            else if (uri.StartsWith("data:image/png;"))
            {
                return ".png";
            }

            return Path.GetExtension(uri).ToLower();
        }
    }
}
