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
	[Register ("TitleEditorController")]
	partial class TitleEditorController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton RandomButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField TitleField { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton UpdateButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (RandomButton != null) {
				RandomButton.Dispose ();
				RandomButton = null;
			}

			if (TitleField != null) {
				TitleField.Dispose ();
				TitleField = null;
			}

			if (UpdateButton != null) {
				UpdateButton.Dispose ();
				UpdateButton = null;
			}
		}
	}
}
