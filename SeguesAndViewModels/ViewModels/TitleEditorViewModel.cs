using System;
using System.ComponentModel;

namespace SeguesAndViewModels
{
	public class TitleEditorViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public InitialViewModel Predecessor { get; set; }

		public string Title {
			get { return Predecessor.Title; }
			set { Predecessor.Title = value; PropertyChanged(this, new PropertyChangedEventArgs("Title")); }
		}

		public void Randomize()
		{
			var rnd = new Random();
			var buffer = new byte[20];
			rnd.NextBytes(buffer);
			Title = System.Text.Encoding.UTF8.GetString(buffer);
		}
	}
}
