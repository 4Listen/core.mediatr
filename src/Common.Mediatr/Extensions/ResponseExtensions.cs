using Common.Mediatr.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Mediatr.Extensions
{
	public static class ResponseExtensions
	{
		public static Response<T> ErrorNotFound<T, TEnum>(this Response<T> response, TEnum msgEnum, params object[] additionalInfo) where TEnum : Enum
		{
			response.NotFound(msgEnum, additionalInfo);
			return response;
		}

		public static Response<T> ErrorAddValidation<T, TEnum>(this Response<T> response, TEnum msgEnum, params object[] additionalInfo)
			where TEnum : Enum
		{
			response.AddValidation(msgEnum, additionalInfo);
			return response;
		}

		public static Response<T> ErrorAddError<T, TEnum>(this Response<T> response, TEnum msgEnum, params object[] additionalInfo)
			where TEnum : Enum
		{
			response.AddError(msgEnum, additionalInfo);
			return response;
		}

		public static Response<T> ErrorNotAuthorized<T, TEnum>(this Response<T> response, TEnum msgEnum, params object[] additionalInfo)
			where TEnum : Enum
		{
			response.NotAuthorized(msgEnum, additionalInfo);
			return response;
		}
	}
}
