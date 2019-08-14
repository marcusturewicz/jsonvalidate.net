using Microsoft.JSInterop;

namespace JsonValidate.JSInterop
{
    public class CodeMirror
    {
        public static object Create(IJSRuntime jsRuntime, object textArea)
        {
            return ((IJSInProcessRuntime)jsRuntime).Invoke<object>(
                "codemirror.create",
                textArea);
        } 

        public static object Clear(IJSRuntime jsRuntime)
        {
            return ((IJSInProcessRuntime)jsRuntime).Invoke<object>(
                "codemirror.clear");
        }   

        public static string GetValue(IJSRuntime jsRuntime)
        {
            return ((IJSInProcessRuntime)jsRuntime).Invoke<string>(
                "codemirror.getValue");
        }  

        public static string SetValue(IJSRuntime jsRuntime, string value)
        {
            return ((IJSInProcessRuntime)jsRuntime).Invoke<string>(
                "codemirror.setValue",
                value);
        }

        public static object Highlight(IJSRuntime jsRuntime, int fromLine, int fromChar, int toLine, int toChar)
        {
            return ((IJSInProcessRuntime)jsRuntime).Invoke<object>(
                "codemirror.highlight",
                fromLine,
                fromChar,
                toLine,
                toChar);
        }                                  
    }
}
