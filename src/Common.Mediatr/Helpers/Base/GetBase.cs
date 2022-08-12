namespace Common.Mediatr.Helpers.Base
{
	/// <summary>
	/// Default object for GetById
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class GetBase<T> : Request<T>
	{
		/// <summary>
		/// Identifier
		/// </summary>
		public string Id { get; set; }
	}
}
