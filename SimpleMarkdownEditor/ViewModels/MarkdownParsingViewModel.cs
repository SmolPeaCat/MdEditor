using CommunityToolkit.Mvvm.ComponentModel;

namespace SimpleMarkdownEditor.ViewModels;

public partial class MarkdownParsingViewModel : ObservableObject
{
    [ObservableProperty]
    private string? _text;
}