using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Grocery_Inventory_Manager.ViewModels
{
    internal class AboutPageViewModel : BindableObject
    {
        public AboutPageViewModel()
        {
            getPrivacy = new Command(getPrivacyPolicy);
        }


        public ICommand getPrivacy { get; }

        async void getPrivacyPolicy(object obj)
        {
            String page = obj.ToString();

            try { await Browser.Default.OpenAsync(page); } catch (Exception) { }
        }
    }
}
