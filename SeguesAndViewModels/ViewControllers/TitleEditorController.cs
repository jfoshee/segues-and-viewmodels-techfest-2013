using System;
using MonoTouch.UIKit;
using System.ComponentModel;

namespace SeguesAndViewModels
{
	public partial class TitleEditorController : UIViewController, IHasViewModel
	{
		public TitleEditorViewModel VM { get; set; }
		INotifyPropertyChanged IHasViewModel.VM {
			get { return VM; }
			set { VM = (TitleEditorViewModel)value; }
		}

		public override void ViewDidLoad()
		{
			VM.PropertyChanged += HandlePropertyChanged;
			UpdateButton.TouchUpInside += HandleTouchUpInside;
			RandomButton.TouchUpInside += (s,e) => VM.Randomize();
		}

		void HandlePropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			TitleField.Text = VM.Title;	// VM => V
		}

		void HandleTouchUpInside(object sender, EventArgs e)
		{
			VM.Title = TitleField.Text;	// V => VM
		}

		public TitleEditorController(IntPtr handle) : base (handle) { }
	}
}
