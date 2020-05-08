using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace JsonValidate.JSInterop
{
    public class CodeMirror
    {
        public static ValueTask CreateAsync(IJSRuntime jsRuntime, object textArea) =>
            jsRuntime.InvokeVoidAsync(
                "codemirror.create",
                textArea);

        public static ValueTask ClearAsync(IJSRuntime jsRuntime) =>
            jsRuntime.InvokeVoidAsync(
                "codemirror.clear");

        public static ValueTask<string> GetValueAsync(IJSRuntime jsRuntime) =>
            jsRuntime.InvokeAsync<string>(
                "codemirror.getValue");

        public static ValueTask SetValueAsync(IJSRuntime jsRuntime, string value) =>
            jsRuntime.InvokeVoidAsync(
                "codemirror.setValue",
                value);

        public static ValueTask SetOptionAsync(IJSRuntime jsRuntime, string key, string value) =>
            jsRuntime.InvokeVoidAsync(
                "codemirror.setOption",
                key,
                value);

        public static ValueTask HighlightAsync(
            IJSRuntime jsRuntime, int fromLine, int fromChar, 
            int toLine, int toChar, bool isLightTheme) =>
            jsRuntime.InvokeVoidAsync(
                "codemirror.highlight",
                fromLine,
                fromChar,
                toLine,
                toChar,
                isLightTheme);
    }
}
