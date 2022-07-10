using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace BlazorWebAssemblyApp.Pages
{
    public partial class CallJavaScriptlnDoNet
    {
        [Inject]
        public IJSRuntime JSRuntime { get; set; }       
        private IJSObjectReference _jsModule;
       
        protected override async Task OnInitializedAsync()
        {
            _jsModule = await JSRuntime.InvokeAsync<IJSObjectReference>("import", "./script/jsExamples.js");

        }
        private async Task ShowAlertWindow() => 
            await _jsModule.InvokeVoidAsync("showAlert", new { Name = "Hien", Age = 20 });
    }
}
