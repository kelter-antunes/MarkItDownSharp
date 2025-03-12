﻿// Models/DocumentConverterResult.cs
namespace MarkItDownSharp.Models
{
    public class DocumentConverterResult
    {
        public DocumentConverterResult(string title = null, string textContent = "")
        {
            Title = title;
            TextContent = textContent;
        }

        public string Title { get; set; }
        public string TextContent { get; set; }
        public System.Collections.Generic.Dictionary<string, object> MetaData { get; set; }
    }
}
