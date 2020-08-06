// ----------------------------------------------------------------------
// @Namespace : NewtonGltf
// @Class     : KHR_materials_unlit
// ----------------------------------------------------------------------
namespace NewtonGltf
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// KHR materials unlit
    /// </summary>
    [Serializable]
    [JsonObject("material.extensions.KHR_materials_unlit")]
    public class KHR_materials_unlit
    {
        /// <summary></summary>
        [JsonIgnore]
        public static string ExtensionName => "KHR_materials_unlit";
    }
}
