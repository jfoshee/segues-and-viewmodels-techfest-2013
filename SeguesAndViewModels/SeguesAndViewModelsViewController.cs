using System;
using MonoTouch.UIKit;
using System.ComponentModel;

namespace SeguesAndViewModels
{
	public partial class SeguesAndViewModelsViewController : UIViewController
	{
		InitialViewModel _vm = new InitialViewModel();

		public override void ViewDidLoad()
		{
			_vm.PropertyChanged += HandlePropertyChanged;
			TitleLabel.Text = _vm.Title;
			UpdateButton.TouchUpInside += HandleTouchUpInside;
		}

		void HandlePropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			TitleLabel.Text = _vm.Title;
		}

		void HandleTouchUpInside(object sender, EventArgs e)
		{
			_vm.Title = TitleField.Text;
		}

		public SeguesAndViewModelsViewController(IntPtr handle) : base(handle) { }
	}
}
