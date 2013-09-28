using System;
using System.ComponentModel;
using System.Reflection;
using MonoTouch.UIKit;

namespace SeguesAndViewModels
{
	public class ViewModelFactory
	{
        public static ViewModelFactory Instance = new ViewModelFactory();
        
        public void InitializeNextViewModel(UIStoryboardSegue segue)
        {
            UIViewController destination = segue.DestinationViewController;
            if (destination is UINavigationController)
            {
                // HACK: skip to root view controller of a NavigationController
                destination = ((UINavigationController)destination).ViewControllers[0];
            }
            InitializeNextViewModel(segue.SourceViewController as IHasViewModel,
                                    destination                as IHasViewModel);
        }

        public void InitializeNextViewModel(IHasViewModel current, IHasViewModel next)
        {
			var nextVmTypeName = next.GetType().FullName.Replace("Controller", "ViewModel");
			var nextVm = Construct(nextVmTypeName);
			next.VM = (INotifyPropertyChanged)nextVm;
			SetPredecessor(current, next);
        }

		static void SetPredecessor(IHasViewModel current, IHasViewModel next)
		{
			var predecessorProperty = next.VM.GetType().GetProperty("Predecessor");
			predecessorProperty.SetValue(next.VM, current.VM);
		}

		static object Construct(string typeName)
		{
			var assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
			return Activator.CreateInstance(assemblyName, typeName).Unwrap();
		}
	}
}

