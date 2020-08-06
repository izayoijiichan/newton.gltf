// ----------------------------------------------------------------------
// @Namespace : NewtonGltf.Serialization
// @Class     : GltfContractResolver
// ----------------------------------------------------------------------
namespace NewtonGltf.Serialization
{
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Serialization;
    using System;
    using NewtonGltf.Serialization.JsonConverters;
    using VgoGltf;

    /// <summary>
    /// glTF Contract Resolver
    /// </summary>
    public class GltfContractResolver : DefaultContractResolver
    {
        /// <summary>
        /// Determines which contract type is created for the given type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns>A Newtonsoft.Json.Serialization.JsonContract for the given type.</returns>
        protected override JsonContract CreateContract(Type objectType)
        {
            JsonContract contract = base.CreateContract(objectType);

            if (objectType == typeof(GltfMeshPrimitiveAttributes))
            {
                contract.Converter = new GltfMeshPrimitiveAttributesJsonConverter();
            }

            if (objectType == typeof(GltfExtensions))
            {
                contract.Converter = new GltfExtensionsJsonConverter();
            }

            if (objectType == typeof(GltfExtras))
            {
                contract.Converter = new GltfExtrasJsonConverter();
            }

            if ((objectType == typeof(GltfAccessorType)) ||
                (objectType == typeof(GltfAnimationChannelPath)) ||
                (objectType == typeof(GltfAnimationInterpolationType)) ||
                (objectType == typeof(GltfCameraProjectionType)) ||
                (objectType == typeof(GltfAlphaMode))
            )
            {
                contract.Converter = new StringEnumConverter(new DefaultNamingStrategy(), allowIntegerValues: false);
            }

            return contract;
        }
    }
}