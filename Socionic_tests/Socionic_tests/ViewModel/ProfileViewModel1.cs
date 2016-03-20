using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Socionic_tests.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class ProfileViewModel1 : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the ProfileViewModel1 class.
        /// </summary>
         private ViewModelLocator _lockator;
        public ProfileViewModel1()
        {
            _lockator = new ViewModelLocator();
            TakeNewTest = new RelayCommand(TakeTest);
            CreateTest = new RelayCommand(CreateNewTest);
        }
        public RelayCommand CreateTest { get; set; }
        private void CreateNewTest()
        {
            _lockator.NavigationService.NavigateTo("creationWin_1");
        }
        public RelayCommand TakeNewTest { get; set; }
        
        private void TakeTest()
        {
            _lockator.NavigationService.NavigateTo("TestSelection");
        }
    }
}