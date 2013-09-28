using System;
using System.ComponentModel;
using MonoTouch.Foundation;

namespace SeguesAndViewModels
{
	[Preserve]
	public class TitleEditorViewModel : INotifyPropertyChanged, IFollow<InitialViewModel>
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
			Title = rnd.NextDouble().ToString();
		}
	}
}
