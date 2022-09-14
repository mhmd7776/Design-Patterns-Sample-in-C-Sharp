using Memento.Models;

var editor = new Editor();
var history = new EditorContentHistory();

editor.CurrentTitle = "ASP.NET Core";
editor.CurrentText = "ASP.NET Core is a free and open-source web framework developed by Microsoft."; 
history.Push(editor.CreateEditorContent());

editor.CurrentTitle = "PHP";
editor.CurrentText = "PHP is a general-purpose scripting language geared toward web development.";
history.Push(editor.CreateEditorContent());

editor.CurrentTitle = "Django";
editor.CurrentText = "Django is a free and open-source web framework that follows the MVT architectural pattern.";

editor.UndoContent(history.Pop());
editor.UndoContent(history.Pop());

Console.WriteLine($"Title : {editor.CurrentTitle}\nText : {editor.CurrentText}");
