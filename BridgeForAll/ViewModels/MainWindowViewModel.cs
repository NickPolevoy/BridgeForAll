using Prism.Mvvm;

namespace BridgeForAll.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string title = "Бридж для всех";
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
