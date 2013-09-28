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
	[Register ("ReuseExampleController")]
	partial class ReuseExampleController
	{
		[Outlet]
		MonoTouch.UIKit.UILabel ValueLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ValueLabel != null) {
				ValueLabel.Dispose ();
				ValueLabel = null;
			}
		}
	}
}
