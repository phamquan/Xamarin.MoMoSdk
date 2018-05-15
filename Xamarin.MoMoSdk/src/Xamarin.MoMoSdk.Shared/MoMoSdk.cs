using System;
using Xamarin.MoMoSdk.Abstractions;

namespace Xamarin.MoMoSdk
{
    public class MoMoSdk
    {
        static Lazy<IMoMoSdk> implementation = new Lazy<IMoMoSdk>(() => Create(), System.Threading.LazyThreadSafetyMode.PublicationOnly);

        /// <summary>
        /// Gets if the plugin is supported on the current platform.
        /// </summary>
        public static bool IsSupported => implementation.Value == null ? false : true;

        /// <summary>
        /// Current plugin implementation to use
        /// </summary>
        public static IMoMoSdk Current
        {
            get
            {
                var ret = implementation.Value;
                if (ret == null)
                {
                    throw NotImplementedInReferenceAssembly();
                }
                return ret;
            }
        }

        static IMoMoSdk Create()
        {
#if NETSTANDARD1_0 || NETSTANDARD2_0 || PCL
            return null;
#else
            return new MoMoSdkImplementation();
#endif

        }

        internal static Exception NotImplementedInReferenceAssembly() =>
            new NotImplementedException("This functionality is not implemented in the portable version of this assembly.  You should reference the NuGet package from your main application project in order to reference the platform-specific implementation.");

    }
}
