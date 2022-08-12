namespace Common.Mediatr.Helpers.Base
{
	/// <summary>
	/// Default object to Delete
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class DeleteBase<T> : Request<T>
	{
		/// <summary>
		/// Identifier
		/// </summary>
		public string Id { get; set; }
	}
}
