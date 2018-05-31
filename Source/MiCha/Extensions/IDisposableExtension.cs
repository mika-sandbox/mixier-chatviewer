using System;

using MiCha.Models;

namespace MiCha.Extensions
{
    // ReSharper disable once InconsistentNaming
    public static class IDisposableExtension
    {
        public static T AddTo<T>(this T disposable, ViewModel viewModel) where T : IDisposable
        {
            viewModel.CompositeDisposable.Add(disposable);
            return disposable;
        }
    }
}