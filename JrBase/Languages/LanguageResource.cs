using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Markup;

namespace JrBase.Languages
{
    public class LanguageResource : DynamicObject, IDynamicResource
    {
        /// <summary>
        /// 언어 변경 이벤트 
        /// </summary>
        public event EventHandler<string> LanguageChanged;

        /// <summary>
        /// 공용 리소스 메니저
        /// </summary>
        private readonly ResourceManager _resourceManager;
        private CultureInfo CulInfo = new CultureInfo("ko-KR");        

        public LanguageResource()
        {           
            _resourceManager = new ResourceManager(typeof(AppLanguage));
        }

        /// <summary>
        /// 프로퍼티로 호출
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string this[string id]
        {
            get
            {
                if (string.IsNullOrEmpty(id))
                {
                    return null;
                }
                string value = _resourceManager.GetString(id, CulInfo);
                if (string.IsNullOrEmpty(value))
                {
                    value = id;
                }
                return value;
            }
        }

        /// <summary>
        /// 이름으로 호출
        /// </summary>
        /// <param name="binder"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            string id = binder.Name;
            string value = _resourceManager.GetString(id, CulInfo);
            if (string.IsNullOrEmpty(value))
            {
                value = id;
            }
            result = value;
            return true;
        }

        /// <summary>
        /// 런타임 언어 변경
        /// </summary>
        /// <param name="languageCode"></param>
        public void ChangeLanguage(string langCode)
        {
            CulInfo = new CultureInfo(langCode);
            Thread.CurrentThread.CurrentCulture = CulInfo;
            Thread.CurrentThread.CurrentUICulture = CulInfo;

            foreach (Window window in Application.Current.Windows.Cast<Window>())
            {
                if (!window.AllowsTransparency)
                {
                    window.Language = XmlLanguage.GetLanguage(CulInfo.Name);
                }
                if (LanguageChanged != null)
                {
                    LanguageChanged.Invoke(this, CulInfo.Name);
                }
            }
        }
    }
}
