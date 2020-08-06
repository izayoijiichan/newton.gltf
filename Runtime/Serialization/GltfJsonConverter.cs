// ----------------------------------------------------------------------
// @Namespace : NewtonGltf.Serialization
// @Class     : GltfJsonConverter
// ----------------------------------------------------------------------
namespace NewtonGltf.Serialization
{
    using Newtonsoft.Json;
    using System;

    /// <summary>
    /// glTF JSON Converter
    /// </summary>
    public class GltfJsonConverter
    {
        #region Public Methods

        /// <summary>
        /// Converts Gltf to JSON.
        /// </summary>
        /// <param name="jsonString">The JSON string.</param>
        /// <returns>The Gltf object.</returns>
        public Gltf ConvertJsonToGltf(string jsonString)
        {
            try
            {
                var settings = new GltfJsonSerializerSettings();

                Gltf gltf = JsonConvert.DeserializeObject<Gltf>(jsonString, settings);

                return gltf;
            }
            catch (JsonSerializationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Converts JSON to Gltf.
        /// </summary>
        /// <param name="gltf">The Gltf object.</param>
        /// <returns>The JSON string.</returns>
        public string ConvertGltfToJsonString(Gltf gltf)
        {
            try
            {
                var settings = new GltfJsonSerializerSettings();

                string jsonString = JsonConvert.SerializeObject(gltf, settings);

                return jsonString;
            }
            catch (JsonSerializationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
