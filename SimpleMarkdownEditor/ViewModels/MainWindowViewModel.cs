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
        EditorView = new MarkdownEditorViewModel();
        _contentViewModel = EditorView;
    }

    public ViewModelBase ContentViewModel
    {
        get => _contentViewModel;
        private set => this.RaiseAndSetIfChanged(ref _contentViewModel, value);
    }
}