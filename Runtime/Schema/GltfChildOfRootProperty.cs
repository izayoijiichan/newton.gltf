// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : GltfChildOfRootProperty
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// glTF Child of Root Property
    /// </summary>
    [Serializable]
    [JsonObject("glTF")]
    public class GltfChildOfRootProperty : GlTFProperty
    {
        /// <summary>The user-defined name of this object.</summary>
        /// <remarks>This is not necessarily unique, e.g., an accessor and a buffer could have the same name, or two accessors could even have the same name.</remarks>
        [JsonProperty("name")]
        public string name;

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return name ?? "{no name}";
        }
    }
}
