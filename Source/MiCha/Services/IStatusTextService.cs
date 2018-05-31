using Reactive.Bindings;

namespace MiCha.Services
{
    public interface IStatusTextService
    {
        ReactiveProperty<string> Text { get; }

        void UpdateStatusText(object obj);
    }
}