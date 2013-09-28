using System;
using MonoTouch.UIKit;
using System.ComponentModel;

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

	public partial class PageTwoController : UIViewControllerWithViewModel
	{
		public PageTwoViewModel ViewModel {
			get { return base.VM as PageTwoViewModel; }
		}

		public override void ViewModelChanged()
		{
			HandlePropertyChanged("");
		}

		public override void HandlePropertyChanged(string propertyName)
		{
			NavigationItem.Title = ViewModel.Title;
		}

		public PageTwoController (IntPtr handle) : base(handle) { }
	}
}
