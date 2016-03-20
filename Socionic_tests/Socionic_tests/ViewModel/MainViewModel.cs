using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Socionic_tests.Model;
using System.Windows.Input;

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
        public UserDataItem User { get; set; }
        public RelayCommand LogInCommand { get; private set; }
        private ViewModelLocator _lockator;
        public MainViewModel()
        {
            _lockator = new ViewModelLocator();
            SignUp = new RelayCommand(Sign_Up);
            LogVK = new RelayCommand(Log_VK);
          LogInCommand = new RelayCommand(OnLogInCommand);
        }


        private void Log_VK()
        {
           
        }

        private void Sign_Up()
        {
            _lockator.NavigationService.NavigateTo("reg");
         
            App.Current.MainWindow.Close();
        }
        public RelayCommand SignUp { get; set; }
        public RelayCommand LogVK { get; set; }

        private void OnLogInCommand()
        {
           //   string testUsername = Username;
            //  string testPassword = Password;
            _lockator.NavigationService.NavigateTo("profile");
            App.Current.MainWindow.Close();
        }

    #region Properties
    public string Username
    {
        get { return User.Login; }
        set { User.Login = value; }
    }
    public string Password
    {
        get { return User.Password; }
        set { User.Password = value; }
    }
    #endregion
        
    }
}