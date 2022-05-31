using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using System.Windows.Input;
using System.Globalization;
using JrBase.ViewModels.Base;
using JrBase.Languages;

namespace JrBase.ViewModels.MainUI
{
    public class viewMainModel : ViewModelBase
    {
        public ICommand ButtonCommand { get; set; }

        public viewMainModel()
        {
            Init();
        }

        private void Init()
        {
            // Button Command
            ButtonCommand = new RelayCommand<string>(OnButtonCommand);
        }

        private void OnButtonCommand(string btnCmd)
        {            
            System.Windows.MessageBox.Show(btnCmd);
            
            NavigationMessage msg = new("Message Send");
            WeakReferenceMessenger.Default.Send<NavigationMessage>(msg);
        }

        public override void OnNavigated(object sender, object navigatedEventArgs)
        {
            System.Windows.MessageBox.Show("Main Navigated");
        }
    }
}
