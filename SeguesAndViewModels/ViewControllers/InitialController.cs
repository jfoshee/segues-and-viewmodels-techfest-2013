using System;
using System.ComponentModel;
using MonoTouch.CoreGraphics;
using MonoTouch.UIKit;

namespace SeguesAndViewModels
{
    public partial class InitialController : UIViewControllerWithViewModel
	{
        public InitialViewModel InitialViewModel { get { return (InitialViewModel)VM; } }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            VM = new InitialViewModel();
        }

        public override void ViewModelChanged()
        {
            if (InitialViewModel != null)
            {
                TitleLabel.Text = InitialViewModel.Title;
                Value1Slider.Value = InitialViewModel.Value1;
                Value1Slider.ValueChanged += (sender, e) => InitialViewModel.Value1 = Value1Slider.Value;
                Value2Slider.Value = InitialViewModel.Value2;
                Value2Slider.ValueChanged += (sender, e) => InitialViewModel.Value2 = Value2Slider.Value;
            }
        }

        public override void HandlePropertyChanged(string propertyName)
        {
            switch(propertyName)
            {
            case "Title":
                TitleLabel.Text = InitialViewModel.Title;
                break;
            case "Value1":
                TitleLabel.Font = UIFont.SystemFontOfSize(8 + InitialViewModel.Value1 * 10);
                break;
            case "Value2":
                TitleLabel.Transform = CGAffineTransform.MakeRotation(
                    InitialViewModel.Value2 * 2 * (float)Math.PI);
                break;
            }
        }

		public InitialController(IntPtr handle) : base(handle) { }
	}
}
