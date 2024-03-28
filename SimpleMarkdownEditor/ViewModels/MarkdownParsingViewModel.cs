using CommunityToolkit.Mvvm.ComponentModel;

namespace SimpleMarkdownEditor.ViewModels;

public partial class MarkdownParsingViewModel : ObservableObject
{
    // Enables any element binded to Text to change automatically 
    [ObservableProperty]
    private string? _text;
}