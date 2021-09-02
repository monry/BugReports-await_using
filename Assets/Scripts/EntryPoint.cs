using UnityEngine;

namespace AwaitUsing
{
    public class EntryPoint : MonoBehaviour
    {
        private async void Start()
        {
            Debug.Log("Before await using");
            {
                await using var sample = new Sample();
            }
            Debug.Log("After await using");
        }
    }
}