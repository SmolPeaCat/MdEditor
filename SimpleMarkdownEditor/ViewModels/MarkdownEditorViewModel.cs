using System;
using System.ComponentModel;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using CommunityToolkit.Mvvm.ComponentModel;
using ReactiveUI;
using SimpleMarkdownEditor.Views;

namespace SimpleMarkdownEditor.ViewModels;

public class MarkdownEditorViewModel: ViewModelBase
{
       private ObservableObject _mdParsing;
       
       private MarkdownParsingViewModel ParsingViewModel { get; set; }

       public MarkdownEditorViewModel()
       {
              ParsingViewModel = new MarkdownParsingViewModel();
              _mdParsing = ParsingViewModel;
       }

       public MarkdownParsingViewModel MdParsing
       {
              get => (MarkdownParsingViewModel)_mdParsing;
              private set => this.RaiseAndSetIfChanged(ref _mdParsing, value);
       }
}
