using System;
using System.Dynamic;

namespace JrBase.Languages
{
    public interface IDynamicResource
    {
        string this[string id] { get; }

        /// <summary>
        /// 언어 변경 이벤트
        /// </summary>
        event EventHandler<string> LanguageChanged;

        /// <summary>
        /// 언어변경
        /// </summary>
        /// <param name="languageCode"></param>
        void ChangeLanguage(string languageCode);

        /// <summary>
        /// 코드에서 사용하도록
        /// </summary>
        /// <param name="binder"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        bool TryGetMember(GetMemberBinder binder, out object result);
    }
}
