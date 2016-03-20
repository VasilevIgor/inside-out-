using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Socionic_tests.Skins;

namespace Socionic_tests.Model
{
  public  class NavigationService: INavigationService
    {
        Dictionary<string, Window> _windows = new Dictionary<string, Window>();
        public void NavigateTo(string window)
        {
            Window winObj;
            if(_windows.TryGetValue(window, out winObj))
            {
                winObj.ShowDialog();
            }
        }
        public NavigationService()
        {
            _windows["main"] = new MainWindow();
            _windows["profile"] = new ProfileWindow();
            _windows["registration"] = new RegistrationWindow();
            _windows["testing"] = new Testing_Window1();
            _windows["TestSelection"] = new TestSelectionWindow();
            _windows["reccomendation"] = new RecommendationWindow();
            _windows["creationWin_1"] = new Creation_Window1();
            _windows["creationWin_2"] = new Creation_Window2();
        }
    }
}
