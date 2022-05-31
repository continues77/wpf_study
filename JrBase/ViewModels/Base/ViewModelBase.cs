using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace JrBase.ViewModels.Base
{
    public class ViewModelBase : ObservableObject, INavigationAware
    {
        /// <summary>
        ///  네이게이션 완료 시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="navigatedEventArgs"></param>
        public virtual void OnNavigated(object sender, object navigatedEventArgs)
        {
        }

        /// <summary>
        /// 네비게이션 시작 시
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="navigationEventArgs"></param>
        public virtual void OnNavigating(object sender, object navigationEventArgs)
        {
        }
    }
}
