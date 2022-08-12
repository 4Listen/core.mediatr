namespace Common.Mediatr.Helpers.Base
{
	/// <summary>
	/// Default object to search
	/// </summary>
	public class SearchBaseGeneric<T, TFiltro> : Request<T>
	{
		/// <summary>
		/// Filter to search
		/// </summary>
		public TFiltro Filter { get; set; }
	}
}
