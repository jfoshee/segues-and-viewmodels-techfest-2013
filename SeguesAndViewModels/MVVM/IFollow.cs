
namespace SeguesAndViewModels
{
	// This means I am the ViewModel that can come after the given predecessor
	public interface IFollow<T>
	{
		T Predecessor { get; set; }
	}
}
