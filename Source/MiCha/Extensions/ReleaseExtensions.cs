using System;

using MiCha.Models;

namespace MiCha.Extensions
{
    public static class ReleaseExtensions
    {
        public static string ToVersionString(this Release obj)
        {
            switch (obj)
            {
                case Release.Master:
                    return "";

                case Release.NightlyBuild:
                    return "(Nightly Build)";

                default:
                    throw new ArgumentOutOfRangeException(nameof(obj), obj, null);
            }
        }
    }
}