
namespace Memento.Models
{
    public class Editor
    {
        public string? CurrentTitle { get; set; }

        public string? CurrentText { get; set; }

        public EditorContent CreateEditorContent()
        {
            var editorContent = new EditorContent
            {
                Text = CurrentText,
                Title = CurrentTitle
            };

            return editorContent;
        }

        public void UndoContent(EditorContent content)
        {
            CurrentTitle = content.Title;
            CurrentText = content.Text;
        }
    }
}
