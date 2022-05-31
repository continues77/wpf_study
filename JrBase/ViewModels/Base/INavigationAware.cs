using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JrBase.ViewModels.Base
{
    public interface INavigationAware
    {
        /// <summary>
        /// 화면 전환 중 Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="navigationEventArgs"></param>
        void OnNavigating(object sender, object navigationEventArgs);

        /// <summary>
        /// 화면 전환 완료 후 Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="navigatedEventArgs"></param>
        void OnNavigated(object sender, object navigatedEventArgs);
    }
}
