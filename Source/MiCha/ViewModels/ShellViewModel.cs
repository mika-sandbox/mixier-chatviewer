using Reactive.Bindings;

namespace MiCha.ViewModels
{
    public class ShellViewModel
    {
        public ReactiveProperty<string> Title { get; set; }

        public ShellViewModel()
        {
            Title = new ReactiveProperty<string>("MiCha");
        }
    }
}