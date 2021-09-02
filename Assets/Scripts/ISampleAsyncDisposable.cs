using System.Threading.Tasks;

namespace AwaitUsing
{
    public interface ISampleAsyncDisposable
    {
        Task DisposeAsync();
    }

}