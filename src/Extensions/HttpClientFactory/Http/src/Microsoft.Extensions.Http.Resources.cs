// <auto-generated>
using System.Reflection;


namespace Microsoft.Extensions.Http
{
    internal static partial class Resources
    {
        private static global::System.Resources.ResourceManager s_resourceManager;
        internal static global::System.Resources.ResourceManager ResourceManager => s_resourceManager ?? (s_resourceManager = new global::System.Resources.ResourceManager(typeof(Resources)));
        internal static global::System.Globalization.CultureInfo Culture { get; set; }

        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        internal static string GetResourceString(string resourceKey, string defaultValue = null) =>  ResourceManager.GetString(resourceKey, Culture);

        private static string GetResourceString(string resourceKey, string[] formatterNames)
        {
           var value = GetResourceString(resourceKey);
           if (formatterNames != null)
           {
               for (var i = 0; i < formatterNames.Length; i++)
               {
                   value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
               }
           }
           return value;
        }

        /// <summary>The '{0}' must not contain a null entry.</summary>
        internal static string HttpMessageHandlerBuilder_AdditionalHandlerIsNull => GetResourceString("HttpMessageHandlerBuilder_AdditionalHandlerIsNull");
        /// <summary>The '{0}' must not contain a null entry.</summary>
        internal static string FormatHttpMessageHandlerBuilder_AdditionalHandlerIsNull(object p0)
           => string.Format(Culture, GetResourceString("HttpMessageHandlerBuilder_AdditionalHandlerIsNull"), p0);

        /// <summary>The '{0}' property must be null. '{1}' instances provided to '{2}' must not be reused or cached.{3}Handler: '{4}'</summary>
        internal static string HttpMessageHandlerBuilder_AdditionHandlerIsInvalid => GetResourceString("HttpMessageHandlerBuilder_AdditionHandlerIsInvalid");
        /// <summary>The '{0}' property must be null. '{1}' instances provided to '{2}' must not be reused or cached.{3}Handler: '{4}'</summary>
        internal static string FormatHttpMessageHandlerBuilder_AdditionHandlerIsInvalid(object p0, object p1, object p2, object p3, object p4)
           => string.Format(Culture, GetResourceString("HttpMessageHandlerBuilder_AdditionHandlerIsInvalid"), p0, p1, p2, p3, p4);

        /// <summary>The '{0}' must not be null.</summary>
        internal static string HttpMessageHandlerBuilder_PrimaryHandlerIsNull => GetResourceString("HttpMessageHandlerBuilder_PrimaryHandlerIsNull");
        /// <summary>The '{0}' must not be null.</summary>
        internal static string FormatHttpMessageHandlerBuilder_PrimaryHandlerIsNull(object p0)
           => string.Format(Culture, GetResourceString("HttpMessageHandlerBuilder_PrimaryHandlerIsNull"), p0);

        /// <summary>The handler lifetime must be at least 1 second.</summary>
        internal static string HandlerLifetime_InvalidValue => GetResourceString("HandlerLifetime_InvalidValue");

    }
}
