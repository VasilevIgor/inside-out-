/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocatorTemplate xmlns:vm="clr-namespace:Socionic_tests.ViewModel"
                                   x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using Socionic_tests.Model;

namespace Socionic_tests.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class ViewModelLocator
    {
       
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);


            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<CreationVievModel_2>();
             SimpleIoc.Default.Register<CreationViewModel1>();
             SimpleIoc.Default.Register<ProfileViewModel1>();
             SimpleIoc.Default.Register<RegistrationViewModel1>();
             SimpleIoc.Default.Register<TestingViewModel1>();
             SimpleIoc.Default.Register<TestSelectionViewModel1>();
        }

        /// <summary>
        /// Gets the Main property.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
      //  ServiceLocator.Current.GetInstance<MainViewModel>();
        public INavigationService NavigationService 
        {
            get
            {
                return new NavigationService();
            }
            
        }
        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }
        public CreationViewModel1 TestCreationPartOne
        {
            get
            {
                return ServiceLocator.Current.GetInstance<CreationViewModel1>();
            }
        }
        public CreationVievModel_2 TestCreationPartTwo
        {
            get
            {
                return ServiceLocator.Current.GetInstance<CreationVievModel_2>();
            }
        }
        public TestSelectionViewModel1 SelectTest
        {
            get
            {
                return ServiceLocator.Current.GetInstance<TestSelectionViewModel1>();
            }
        }
        public ProfileViewModel1 ChangeProfile
        {
            get
            {
                return ServiceLocator.Current.GetInstance<ProfileViewModel1>();
            }
        }
        public RegistrationViewModel1 RegisterProfile
        {
            get
            {
                return ServiceLocator.Current.GetInstance<RegistrationViewModel1>();
            }
        }
        public TestingViewModel1 Testing
        {
             get
            {
                return ServiceLocator.Current.GetInstance<TestingViewModel1>();
            }
        }

        /// <summary>
        /// Cleans up all the resources.
        /// </summary>
        public static void Cleanup()
        {
        }
    }
}