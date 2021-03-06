﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Socionic_tests.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class TestSelectionViewModel1 : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the TestSelectionViewModel1 class.
        /// </summary>
        private ViewModelLocator _lockator;
        public TestSelectionViewModel1()
        {
            _lockator = new ViewModelLocator();
            BeginCommand = new RelayCommand(BeginPressed);
        }

        private void BeginPressed()
        {
            _lockator.NavigationService.NavigateTo("testing");
        }
        public RelayCommand BeginCommand { get; set; }
    }
}