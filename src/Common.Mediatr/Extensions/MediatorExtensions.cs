using Common.Mediatr.Helpers;
using Common.Mediatr.Helpers.Base;
using MediatR;

namespace Common.Mediatr.Extensions
{
	public static class MediatorExtensions
	{
		public static async Task<Response<T>> SendGet<T>(this IMediator mediator, string id)
		{
			var obterBase = new GetBase<T>() { Id = id };
			return await mediator.Send(obterBase);
		}

		public static async Task<Response<T>> SendPesquisa<T>(this IMediator mediator, string filter)
		{
			var obterBase = new SearchBase<T>() { Filter = filter };
			return await mediator.Send(obterBase);
		}

		public static async Task<Response<T>> SendDelete<T>(this IMediator mediator, string id)
		{
			var obterBase = new DeleteBase<T>() { Id = id };
			return await mediator.Send(obterBase);
		}
	}
}
