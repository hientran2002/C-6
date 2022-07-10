using Microsoft.AspNetCore.Components;

namespace BlazorApp5.Pages
{
    public class CounterBase: ComponentBase
    {
        protected int currentCount = 0;

        protected void IncrementCount()
        {
            currentCount++;
        }
    }
}
