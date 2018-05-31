﻿using System;
using System.Reactive.Disposables;

using Prism.Mvvm;

namespace MiCha.Models
{
    public class ViewModel : BindableBase, IDisposable
    {
        public CompositeDisposable CompositeDisposable { get; }

        protected ViewModel()
        {
            CompositeDisposable = new CompositeDisposable();
        }

        public void Dispose()
        {
            CompositeDisposable?.Dispose();
        }
    }
}