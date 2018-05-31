using Reactive.Bindings;

namespace MiCha.ViewModels
{
    public class ShellViewModel
    {
        public ReactiveProperty<string> Title { get; }
        public ReactiveProperty<string> Status { get; }

        public ShellViewModel()
        {
            Title = new ReactiveProperty<string>("MiCha");
            Status = new ReactiveProperty<string>("Ready");
        }
    }
}