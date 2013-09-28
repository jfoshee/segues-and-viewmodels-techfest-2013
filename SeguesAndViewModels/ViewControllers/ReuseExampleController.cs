using System;

namespace SeguesAndViewModels
{
	public partial class ReuseExampleController : UIViewControllerWithViewModel
	{
		public override void ViewModelChanged()
		{
			HandlePropertyChanged("");
		}

		public override void HandlePropertyChanged(string propertyName)
		{
			var vm = VM as ReuseExampleViewModel;
			ValueLabel.Text = vm.ValueText;
		}

		public ReuseExampleController (IntPtr handle) : base (handle) { }
	}
}
