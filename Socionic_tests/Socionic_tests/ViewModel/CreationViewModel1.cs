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
    public class CreationViewModel1 : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the CreationViewModel1 class.
        /// </summary>
        private ViewModelLocator _lockator;
        public CreationViewModel1()
        {
            _lockator = new ViewModelLocator();
            ToTheMiddleCreationPage = new RelayCommand(MoveToTheMiddle);
        }

        private void MoveToTheMiddle()
        {
            _lockator.NavigationService.NavigateTo("creationWin_3");
        }
        public RelayCommand ToTheMiddleCreationPage { get; set; }
    }
}