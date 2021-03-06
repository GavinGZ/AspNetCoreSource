// <auto-generated>
using System.Reflection;


namespace Microsoft.Extensions.Configuration
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

        /// <summary>A configuration source is not registered. Please register one before setting a value.</summary>
        internal static string Error_NoSources => GetResourceString("Error_NoSources");

    }
}
