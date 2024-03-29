using CommunityToolkit.Mvvm.ComponentModel;
using ReactiveUI;

namespace SimpleMarkdownEditor.ViewModels;

public class MarkdownEditorViewModel: ViewModelBase
{
       // I'm using MainWindowViewModel as an example
       private ObservableObject _mdParsing;
       
       private MarkdownParsingViewModel ParsingViewModel { get; }

       public MarkdownEditorViewModel()
       {
              ParsingViewModel = new MarkdownParsingViewModel();
              _mdParsing = ParsingViewModel;
       }
       
       // Makes the mdParsing available in my view :D
       public MarkdownParsingViewModel MdParsing
       {
              get => (MarkdownParsingViewModel)_mdParsing;
              private set => this.RaiseAndSetIfChanged(ref _mdParsing, value);
       }
}
