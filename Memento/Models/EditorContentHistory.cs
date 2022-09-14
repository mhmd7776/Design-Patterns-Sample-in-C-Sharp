using System;
using System.Collections.Generic;
using System.Linq;

namespace Memento.Models
{
    public class EditorContentHistory
    {
        public List<EditorContent> EditorContents = new();

        public void Push(EditorContent content)
        {
            EditorContents.Add(content);
        }

        public EditorContent Pop()
        {
            var lastItem = EditorContents.Last();

            EditorContents.Remove(lastItem);

            return lastItem;
        }
    }
}
