using System;
using MonoTouch.Foundation;

namespace SeguesAndViewModels
{
	[Preserve(AllMembers = true)]
	public class ReuseExampleViewModel : ViewModelBase<PageTwoViewModel>, IReusable
	{
		public string Identifier { get; set; }

		public string ValueText { 
			get { 
				return (Identifier == "1") ?
					Predecessor.Predecessor.Value1.ToString() :
					Predecessor.Predecessor.Value2.ToString();
			}
		}
	}
}
