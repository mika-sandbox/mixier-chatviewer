using Reactive.Bindings;

namespace MiCha.Services
{
    internal class StatusTextService : IStatusTextService
    {
        public StatusTextService()
        {
            Text = new ReactiveProperty<string>("Ready");
        }

        public ReactiveProperty<string> Text { get; }

        public void UpdateStatusText(object obj)
        {
            if (obj is string str)
                Text.Value = str;
            else
                Text.Value = obj?.ToString() ?? "(null)";
        }
    }
}