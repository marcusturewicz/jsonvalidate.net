using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace JsonValidate.JSInterop
{
    public class Clipboard
    {
        public static ValueTask WriteTextAsync(IJSRuntime jsRuntime, string text) =>
            jsRuntime.InvokeVoidAsync(
                "clipboard.copy",
                text);
    }
}
