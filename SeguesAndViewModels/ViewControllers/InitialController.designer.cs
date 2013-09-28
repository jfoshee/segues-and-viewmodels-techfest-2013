// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace SeguesAndViewModels
{
	[Register ("InitialController")]
	partial class InitialController
	{
		[Outlet]
		MonoTouch.UIKit.UILabel TitleLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UISlider Value1Slider { get; set; }

		[Outlet]
		MonoTouch.UIKit.UISlider Value2Slider { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (TitleLabel != null) {
				TitleLabel.Dispose ();
				TitleLabel = null;
			}

			if (Value1Slider != null) {
				Value1Slider.Dispose ();
				Value1Slider = null;
			}

			if (Value2Slider != null) {
				Value2Slider.Dispose ();
				Value2Slider = null;
			}
		}
	}
}
