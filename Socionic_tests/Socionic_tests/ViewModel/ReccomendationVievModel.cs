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
    public class ReccomendationVievModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the ReccomendationVievModel class.
        /// </summary>
        private ViewModelLocator _lockator;
        public ReccomendationVievModel()
        {
            _lockator = new ViewModelLocator();
            GoTestAgain = new RelayCommand(TestingAgain);
        }
        private void TestingAgain()
        {
            _lockator.NavigationService.NavigateTo("profile");
        }
        public RelayCommand GoTestAgain { get; set; }
    }
}