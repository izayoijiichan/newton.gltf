// ----------------------------------------------------------------------
// @Namespace : NewtonGltf.Serialization
// @Class     : GltfJsonSerializerSettings
// ----------------------------------------------------------------------
namespace NewtonGltf.Serialization
{
    using Newtonsoft.Json;
    using NewtonGltf.Serialization.JsonConverters;

    /// <summary>
    /// glTF JSON Serializer Settings
    /// </summary>
    public class GltfJsonSerializerSettings : JsonSerializerSettings
    {
        #region Constructors

        /// <summary>
        /// Create a new instance of GltfJsonSerializerSettings.
        /// </summary>
        public GltfJsonSerializerSettings() : base()
        {
            ContractResolver = new GltfContractResolver();

            //Converters = new List<JsonConverter>();

            Converters.Add(new Color3JsonConverter());
            Converters.Add(new Color4JsonConverter());
            Converters.Add(new Matrix4x4JsonConverter());
            Converters.Add(new QuaternionJsonConverter());
            Converters.Add(new Vector2JsonConverter());
            Converters.Add(new Vector3JsonConverter());
            Converters.Add(new Vector4JsonConverter());

            Converters.Add(new NullableColor3JsonConverter());
            Converters.Add(new NullableColor4JsonConverter());
            Converters.Add(new NullableMatrix4x4JsonConverter());
            Converters.Add(new NullableQuaternionJsonConverter());
            Converters.Add(new NullableVector2JsonConverter());
            Converters.Add(new NullableVector3JsonConverter());
            Converters.Add(new NullableVector4JsonConverter());

            NullValueHandling = NullValueHandling.Ignore;
        }

        #endregion
    }
}
