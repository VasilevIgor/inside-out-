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
    public class TestingViewModel1 : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the TestingViewModel1 class.
        /// </summary>
        private ViewModelLocator _lockator;
        public TestingViewModel1()
        {
            _lockator = new ViewModelLocator();
            GoToReccomendation = new RelayCommand(OpenReccomendationPage);
        }

        private void OpenReccomendationPage()
        {
            _lockator.NavigationService.NavigateTo("reccomendation");
        }
        public RelayCommand GoToReccomendation { get; set; }
    }
}