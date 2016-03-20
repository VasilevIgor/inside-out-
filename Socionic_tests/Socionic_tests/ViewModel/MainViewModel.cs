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
        public ICommand LogInCommand { get; private set; }
       // private INavigationService _navigationService = new NavigationService();
        public MainViewModel()
        {
            SignUp = new RelayCommand(Sign_Up);
            LogVK = new RelayCommand(Log_VK);
          LogInCommand = new RelayCommand(this.OnLogInCommand);
        }


        private void Log_VK()
        {
           
        }

        private void Sign_Up()
        {
    //        _navigationService.NavigateTo("registration");
        }
        public RelayCommand SignUp { get; set; }
        public RelayCommand LogVK { get; set; }

        private void OnLogInCommand()
        {
              string testUsername = Username;
              string testPassword = Password;
      // _navigationService.NavigateTo("registration");
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