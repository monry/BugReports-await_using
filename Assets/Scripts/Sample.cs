using System;
using System.Threading.Tasks;
using UnityEngine;

namespace AwaitUsing
{
    public class Sample : ISampleAsyncDisposable
    {
        public async Task DisposeAsync()
        {
            Debug.Log("Before awaiting");
            await Task.Delay(TimeSpan.FromSeconds(3.0));
            Debug.Log("After awaiting");
        }
    }
}