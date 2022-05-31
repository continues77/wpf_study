using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using JrBase.ViewModels;
using JrBase.ViewModels.MainUI;
using JrBase.Languages;

namespace JrBase
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Services = ConfigureServices();
            this.InitializeComponent();
        }

        public new static App Current => (App)Application.Current;

        public IServiceProvider Services { get; }

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddTransient(typeof(MainWindowModel));
            services.AddTransient(typeof(viewMainModel));
            services.AddTransient(typeof(viewRecipeModel));

            var dr = new LanguageResource();           
            Current.Resources.Add("DR", dr);
            services.AddSingleton<IDynamicResource>(dr);

            return services.BuildServiceProvider();
        }       
    }
}
