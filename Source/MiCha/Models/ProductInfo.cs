using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;

namespace MiCha.Models
{
    public static class ProductInfo
    {
        public static readonly ReadOnlyCollection<License> LicenseNotices = new List<License>
        {
            new License
            {
                Name = "CommonServiceLocator",
                Url = "https://github.com/unitycontainer/commonservicelocator"
            },
            new License
            {
                Name = "FontAwesome",
                Url = "https://github.com/FortAwesome/Font-Awesome",
                Authors = new[] {"Fort Awesome"}
            },
            new License
            {
                Name = "FontAwesome.Sharp",
                Url = "https://github.com/awesome-inc/FontAwesome.Sharp",
                Authors = new[] {"Awesome Incremented"}
            },
            new License
            {
                Name = "MetroRadiance",
                Url = "https://github.com/Grabacr07/MetroRadiance",
                Authors = new[] {"Manato KAMEYA"}
            },
            new License
            {
                Name = "MetroRadiance.Chrome",
                Url = "https://github.com/Grabacr07/MetroRadiance",
                Authors = new[] {"Manato KAMEYA"}
            },
            new License
            {
                Name = "MetroRadiance.Core",
                Url = "https://github.com/Grabacr07/MetroRadiance",
                Authors = new[] {"Manato KAMEYA"}
            },
            new License
            {
                Name = "Microsoft.Practices.Unity",
                Url = "https://github.com/unitycontainer/unity"
            },
            new License
            {
                Name = "Microsoft.Practices.Unity.Configuration",
                Url = "https://github.com/unitycontainer/unity"
            },
            new License
            {
                Name = "Microsoft.Practices.Unity.RegistrationByConvetion",
                Url = "https://github.com/unitycontainer/unity"
            },
            new License
            {
                Name = "Newtonsoft.Json",
                Url = "https://github.com/JamesNK/Newtonsoft.Json",
                Authors = new[] {"James Newton-King"}
            },
            new License
            {
                Name = "Prism",
                Url = "https://github.com/PrismLibrary/Prism",
                Authors = new[] {".NET Foundation"}
            },
            new License
            {
                Name = "Prism.Unity.Wpf",
                Url = "https://github.com/PrismLibrary/Prism",
                Authors = new[] {".NET Foundation"}
            },
            new License
            {
                Name = "Prism.Wpf",
                Url = "https://github.com/PrismLibrary/Prism",
                Authors = new[] {".NET Foundation"}
            },
            new License
            {
                Name = "ReactiveProperty (Modified for System.Reactive 4)",
                Url = "https://github.com/runceel/ReactiveProperty",
                Authors = new[] {"neuecc", "xin9le", "okazuki"}
            },
            new License
            {
                Name = "System.Reactive",
                Url = "https://github.com/dotnet/reactive",
                Authors = new[] {".NET Foundation and Contributors"}
            }
        }.OrderBy(w => w.Name).ToList().AsReadOnly();

        public static Lazy<string> Name => new Lazy<string>(() => GetAssemblyInfo<AssemblyTitleAttribute>().Title);

        public static Lazy<string> Description => new Lazy<string>(() => GetAssemblyInfo<AssemblyDescriptionAttribute>().Description);

        public static Lazy<string> Copyright => new Lazy<string>(() => GetAssemblyInfo<AssemblyCopyrightAttribute>().Copyright);

        public static Lazy<string> Version => new Lazy<string>(() => Assembly.GetExecutingAssembly().GetName().Version.ToString());

        public static Lazy<Release> ReleaseType => new Lazy<Release>(() => Release.NightlyBuild);

        private static T GetAssemblyInfo<T>() where T : Attribute
        {
            return (T) Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(T));
        }
    }
}