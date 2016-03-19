using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Socionic_tests.Model;

namespace Socionic_tests.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            SignIn = new RelayCommand(Sign_In);
            SignUp = new RelayCommand(Sign_Up);
            LogVK = new RelayCommand(Log_VK);
        }

        private void Log_VK()
        {
           
        }

        private void Sign_Up()
        {
            
        }

        private void Sign_In()
        {
            
        }

        public RelayCommand SignIn { get; set; }
        public RelayCommand SignUp { get; set; }
        public RelayCommand LogVK { get; set; }
    }
}