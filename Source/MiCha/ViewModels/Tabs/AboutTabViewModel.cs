using System;
using System.Collections.ObjectModel;
using System.Linq;

using MiCha.Extensions;
using MiCha.Models;

namespace MiCha.ViewModels.Tabs
{
    internal class AboutTabViewModel : ViewModel
    {
        public ReadOnlyCollection<LicenseViewModel> Libraries => ProductInfo.LicenseNotices.Select(w => new LicenseViewModel(w)).ToList().AsReadOnly();

        public string Name => ProductInfo.Name.Value;

        public string Version => $"Version {ProductInfo.Version.Value} {ProductInfo.ReleaseType.Value.ToVersionString()}".Trim();

        public string Copyright => ProductInfo.Copyright.Value;

        public string OsVersion => $"OsVersion = {Environment.OSVersion}";
    }
}