using Common.Mediatr.Model;
using System.Collections.ObjectModel;

namespace Common.Mediatr.Helpers
{
	public class Response<T>
	{
		private readonly List<Notification> _notifications;

		public static Response<T> CreateSuccess(T output)
		{
			return new Response<T>() { Output = output };

		}

		public Response()
		{
			_notifications = new List<Notification>();
		}

		public T Output { get; set; }

		public ReadOnlyCollection<Notification> Notifications => _notifications.AsReadOnly();

		private bool IsSuccessful() => Output != null && (Notifications == null || Notifications.Count == 0);
		public void NotFound<TEnum>(TEnum msgEnum, params object[] additionalInfo)
			where TEnum : Enum
		{
			Add(Effect.NotFound, msgEnum, additionalInfo);
		}

		public void AddValidation<TEnum>(TEnum msgEnum, params object[] additionalInfo)
			where TEnum : Enum
		{
			Add(Effect.Validation, msgEnum, additionalInfo);
		}

		public void AddError<TEnum>(TEnum msgEnum, params object[] additionalInfo)
			where TEnum : Enum
		{
			Add(Effect.Error, msgEnum, additionalInfo);
		}

		public void NotAuthorized<TEnum>(TEnum msgEnum, params object[] additionalInfo)
			where TEnum : Enum
		{
			Add(Effect.NotAuthorized, msgEnum, additionalInfo);
		}

		public void Add<TEnum>(Effect effect, TEnum msgEnum, params object[] additionalInfo)
			where TEnum : Enum
		{
			_notifications.Add(new Notification<TEnum>(msgEnum, effect, additionalInfo));
		}

		public void Add(Effect effect, string msgEnum, params object[] additionalInfo)
		{
			_notifications.Add(new BasicNotification(msgEnum, effect, additionalInfo));
		}

		public void AddRange(IEnumerable<Notification> collection)
		{
			_notifications.AddRange(collection);
		}

		public void Deconstruct(out bool success, out T result, out ReadOnlyCollection<Notification> notifications)
		{
			(success, result, notifications) = (IsSuccessful(), Output, Notifications);
		}
	}
}
