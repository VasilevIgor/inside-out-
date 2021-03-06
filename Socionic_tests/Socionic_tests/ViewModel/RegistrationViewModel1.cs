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
    public class RegistrationViewModel1 : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the RegistrationViewModel1 class.
        /// </summary>
        private ViewModelLocator _lockator;
        public RegistrationViewModel1()
        {
            _lockator = new ViewModelLocator();
            
        }

   
    }
}