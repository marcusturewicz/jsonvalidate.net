using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace JsonValidate.JSInterop
{
    public class CodeMirror
    {
        public static ValueTask<object> Create(IJSRuntime jsRuntime, object textArea)
        {
            return jsRuntime.InvokeAsync<object>(
                "codemirror.create",
                textArea);
        } 

        public static ValueTask<object> Clear(IJSRuntime jsRuntime)
        {
            return jsRuntime.InvokeAsync<object>(
                "codemirror.clear");
        }   

        public static ValueTask<string> GetValue(IJSRuntime jsRuntime)
        {
            return jsRuntime.InvokeAsync<string>(
                "codemirror.getValue");
        }  

        public static ValueTask<string> SetValue(IJSRuntime jsRuntime, string value)
        {
            return jsRuntime.InvokeAsync<string>(
                "codemirror.setValue",
                value);
        }

        public static ValueTask<object> Highlight(IJSRuntime jsRuntime, int fromLine, int fromChar, int toLine, int toChar)
        {
            return jsRuntime.InvokeAsync<object>(
                "codemirror.highlight",
                fromLine,
                fromChar,
                toLine,
                toChar);
        }                                  
    }
}
