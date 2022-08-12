using MediatR;

namespace Common.Mediatr.Helpers
{
	public class Request<T> : IRequest<Response<T>>, INotification
	{
	}
}
