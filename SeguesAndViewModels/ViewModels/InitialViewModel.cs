using System;
using System.ComponentModel;

namespace SeguesAndViewModels
{
	public class InitialViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		string _title;
		public string Title {
			get { return _title; }
			set { _title = value; PropertyChanged(this, new PropertyChangedEventArgs("Title")); }
		}

		public float Value1 { get; set; }
		public float Value2 { get; set; }

		public InitialViewModel()
		{
			_title = "Hello, World!";
		}
	}
}
