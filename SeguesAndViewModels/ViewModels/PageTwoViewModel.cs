
namespace SeguesAndViewModels
{
	public class PageTwoViewModel : ViewModelBase<InitialViewModel>
	{
		public string Title {
			get { return Predecessor.Title; }
		}
	}
}
