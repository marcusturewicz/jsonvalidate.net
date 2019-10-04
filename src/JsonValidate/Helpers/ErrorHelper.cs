namespace JsonValidate.Helpers
{
    public class ErrorHelper
    {
        public static (int Line, int Pos) ParseError(string message)
        {
            var lineDelimiter = "LineNumber:";
            var charDelimiter = "BytePositionInLine:";
            var gap = 3;
            var end = 1;
            var lineErrorStart = message.IndexOf(lineDelimiter);
            var posErrorStart = message.IndexOf(charDelimiter);
            var line = int.Parse(message.Substring(lineErrorStart + lineDelimiter.Length, 
                (posErrorStart - gap - lineErrorStart - lineDelimiter.Length)));
            var pos = int.Parse(message.Substring(posErrorStart + charDelimiter.Length, 
                (message.Length - end - posErrorStart - charDelimiter.Length)));
            return (line, pos);
        }
    }
}
