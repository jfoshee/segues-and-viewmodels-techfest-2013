using System.ComponentModel;

namespace SeguesAndViewModels
{
	public interface IHasViewModel
	{
		INotifyPropertyChanged VM { get; set; }
	}
}
