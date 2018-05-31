using MiCha.Extensions;
using MiCha.Models;
using MiCha.Services;

using Reactive.Bindings;

namespace MiCha.ViewModels
{
    public class ShellViewModel : ViewModel
    {
        public ReactiveProperty<string> Title { get; }
        public ReadOnlyReactiveProperty<string> Status { get; }

        public ShellViewModel(IStatusTextService statusTextService)
        {
            Title = new ReactiveProperty<string>("MiCha");
            Status = statusTextService.Text.ToReadOnlyReactiveProperty().AddTo(this);
        }
    }
}