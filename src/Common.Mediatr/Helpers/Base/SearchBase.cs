namespace Common.Mediatr.Helpers.Base
{
    /// <summary>
    /// Default object to search
    /// </summary>
    public class SearchBase<T> : Request<T>
    {
        /// <summary>
        /// Filter to search
        /// </summary>
        public string Filter { get; set; }

    }
}
