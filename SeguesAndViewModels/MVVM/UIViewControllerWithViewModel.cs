using System;
using System.ComponentModel;
using MonoTouch.UIKit;

namespace SeguesAndViewModels
{
	public abstract class UIViewControllerWithViewModel : UIViewController, IHasViewModel
	{
		INotifyPropertyChanged _vm;
		public INotifyPropertyChanged VM {
			get { return _vm; }
			set { _vm = value; 
				_vm.PropertyChanged += (sender, e) => HandlePropertyChanged(e.PropertyName);
				if (IsViewLoaded)
					ViewModelChanged();
			}
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			ViewModelChanged();
		}

		public override void PrepareForSegue(UIStoryboardSegue segue, MonoTouch.Foundation.NSObject sender)
		{
			base.PrepareForSegue(segue, sender);
			ViewModelFactory.Instance.InitializeNextViewModel(segue);
		}

		public abstract void ViewModelChanged();
		public abstract void HandlePropertyChanged(string propertyName);

		public UIViewControllerWithViewModel(IntPtr handle) : base (handle) { }
	}
}
