using System;
using ReactiveUI;
using SimpleMarkdownEditor.Views;

namespace SimpleMarkdownEditor.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    
    private ViewModelBase _contentViewModel;
    
    private MarkdownEditorViewModel EditorView { get; set; }
    public MainWindowViewModel()
    {
        // Create a new instance of the Markdown VM so that when loaded
        // Then main window's mv is changed to the right one
        EditorView = new MarkdownEditorViewModel();
        _contentViewModel = EditorView;
    }

    public ViewModelBase ContentViewModel
    {
        get => _contentViewModel;
        private set => this.RaiseAndSetIfChanged(ref _contentViewModel, value);
    }
}