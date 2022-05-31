using Microsoft.Toolkit.Mvvm.Messaging.Messages;

namespace JrBase.ViewModels.Base
{
    public class NavigationMessage : ValueChangedMessage<string>
    {
        public NavigationMessage(string value) : base(value)
        {
        }
    }
}
