using System;
using MonoTouch.UIKit;
using System.ComponentModel;

namespace SeguesAndViewModels
{
	public partial class InitialController : UIViewController
	{
		InitialViewModel _vm = new InitialViewModel();

		public override void ViewDidLoad()
		{
			_vm.PropertyChanged += HandlePropertyChanged;
			TitleLabel.Text = _vm.Title;
		}

		void HandlePropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			TitleLabel.Text = _vm.Title;	// VM => V
		}

		public override void PrepareForSegue(UIStoryboardSegue segue, MonoTouch.Foundation.NSObject sender)
		{
			base.PrepareForSegue(segue, sender);
			var nextController = segue.DestinationViewController as TitleEditorController;
			nextController.VM = new TitleEditorViewModel { Predecessor = _vm };
		}

		public InitialController(IntPtr handle) : base(handle) { }
	}
}
