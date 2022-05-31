using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using System.Windows.Input;
using System.Globalization;
using JrBase.ViewModels.Base;
using JrBase.Languages;

namespace JrBase.ViewModels
{
    public class MainWindowModel : ViewModelBase, INavigationAware
    {
        private string _navigationSource;
        public string NavigationSource
        {
            get { return _navigationSource; }
            set { SetProperty(ref _navigationSource, value); }
        }

        private readonly IDynamicResource _dr;
                    
        public IRelayCommand NavigateCommand { get; set; }
        public IRelayCommand ButtonCommand { get; set; }
        public IRelayCommand LanguageChangeCommand { get; set; }

        public IRelayCommand LeftSideBar { get; set; }
     
        /// <summary>
        /// App.ConfigureServices()에서 Singleton으로 등록 함.
        /// </summary>
        /// <param name="dynamicResource"></param>
        public MainWindowModel(IDynamicResource dynamicResource)
        {
            _dr = dynamicResource;
            Init();
        }

        private void Init()
        {
            //NavigationSource = "Views/MainUI/viewMain.xaml";
            NavigateCommand = new RelayCommand<string>(OnNavigate);

            WeakReferenceMessenger.Default.Register<NavigationMessage>(this, OnNavigationMessage);

            // Lang change command
            LanguageChangeCommand = new RelayCommand<string>(OnLanguageChangeCommand);

            // Button Command
            ButtonCommand = new RelayCommand<string>(OnButtonCommand);

            // Left
            LeftSideBar = new RelayCommand<string>(OnLeftSideBar);
        }

        private void OnLeftSideBar(string action)
        {

        }

        private void OnNavigationMessage(object recipient, NavigationMessage message)
        {
            System.Windows.MessageBox.Show(message.Value);
        }

        private void OnNavigate(string pageUri)
        {
            NavigationSource = pageUri;
        }

        private void OnLanguageChangeCommand(string langCode)
        {
            switch (langCode)
            {
                case "english":
                    _dr.ChangeLanguage("en-US");
                    break;

                case "korean":
                    _dr.ChangeLanguage("ko-KR");
                    break;
            }
        }

        private void OnButtonCommand(string btnCommand)
        {
            switch(btnCommand)
            {              
                case "START":
                    System.Windows.MessageBox.Show(btnCommand);                    
                    break;                
            }
        }
    }
}
