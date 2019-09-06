using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace JsonValidate.JSInterop
{
    public class Clipboard
    {
        public static ValueTask<string> WriteTextAsync(IJSRuntime jsRuntime, string text)
        {
            // Implemented in cliboard.js
            return jsRuntime.InvokeAsync<string>(
                "clipboard.copy",
                text);
        }        
    }
}
