using System;
using System.ComponentModel;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using SimpleMarkdownEditor.Views;

namespace SimpleMarkdownEditor.ViewModels;

public class MarkdownEditorViewModel: ViewModelBase
{
    public string? Text { get; set; }
}