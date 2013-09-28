using System;

namespace SeguesAndViewModels
{
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
