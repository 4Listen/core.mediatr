namespace Common.Mediatr.Model
{
	public abstract class Notification
	{
		public Effect Effect { get; protected set; }

		public object[] AdditionalInfo { get; protected set; }

		public abstract object Identifier
		{
			get;
		}
	}

	public class Notification<T> : Notification
		where T : Enum
	{
		internal Notification(T code, Effect effect, params object[] addInfo)
		{
			Code = code;
			Effect = effect;
			AdditionalInfo = addInfo;
		}

		public T Code { get; protected set; }

		public override object Identifier => Code;
	}

	public class BasicNotification : Notification
	{
		internal BasicNotification(string code, Effect effect, params object[] addInfo)
		{
			Code = code;
			Effect = effect;
			AdditionalInfo = addInfo;
		}

		public string Code { get; protected set; }

		public override object Identifier => Code;
	}
}
