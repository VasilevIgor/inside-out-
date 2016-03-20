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
    public class CreationTest_3_ViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the CreationTest_3_ViewModel class.
        /// </summary>
        private ViewModelLocator _lockator;
        public CreationTest_3_ViewModel()
        {
            _lockator = new ViewModelLocator();
            ToLastCreationPage = new RelayCommand(ToTheLastPage);
        }

        private void ToTheLastPage()
        {
            _lockator.NavigationService.NavigateTo("creationWin_2");
        }
        public RelayCommand ToLastCreationPage { get; set; }
    }
}