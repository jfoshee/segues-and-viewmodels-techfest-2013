using System;
using MonoTouch.UIKit;
using System.ComponentModel;

namespace SeguesAndViewModels
{
	public partial class InitialController : UIViewController, IHasViewModel
	{
		InitialViewModel _vm = new InitialViewModel();
		INotifyPropertyChanged IHasViewModel.VM {
			get { return _vm; }
			set { _vm = (InitialViewModel)value; }
		}

		public override void ViewDidLoad()
		{
			_vm.PropertyChanged += HandlePropertyChanged;
			TitleLabel.Text = _vm.Title;
			Value1Slider.ValueChanged += (sender, e) => _vm.Value1 = Value1Slider.Value;
			Value2Slider.ValueChanged += (sender, e) => _vm.Value2 = Value2Slider.Value;
		}

		void HandlePropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			TitleLabel.Text = _vm.Title;	// VM => V
		}

		public override void PrepareForSegue(UIStoryboardSegue segue, MonoTouch.Foundation.NSObject sender)
		{
			base.PrepareForSegue(segue, sender);
			ViewModelFactory.Instance.InitializeNextViewModel(segue);
		}

		public InitialController(IntPtr handle) : base(handle) { }
	}
}
