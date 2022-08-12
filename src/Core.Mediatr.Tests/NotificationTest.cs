using Common.Mediatr.Helpers;
using Common.Mediatr.Model;
using Xunit;

namespace Core.Mediatr.Tests
{
    public class NotificationTest
    {
		[Fact(DisplayName = "When adding a validation you must add it as enum")]
		public void WhenAddingAValidationYouMustAddItAsEnum()
		{
			var result = new Response<string>();

			result.AddValidation(Message.Test, "string", "value");

			Assert.Single(result.Notifications);
			var baseNotification = result.Notifications.First();
			Assert.NotNull(baseNotification);
			Assert.True(baseNotification is Notification<Message>);
			Assert.Equal(Effect.Validation, baseNotification.Effect);
			Assert.Equal(2, baseNotification.AdditionalInfo.Length);
			Assert.Equal("string", baseNotification.AdditionalInfo[0]);
			Assert.Equal("value", baseNotification.AdditionalInfo[1]);
			Assert.Equal(Message.Test, baseNotification.Identifier);
			var notification = (Notification<Message>)baseNotification;
			Assert.Equal(Message.Test, notification.Code);
		}

		[Fact(DisplayName = "When adding an error must add as enum")]
		public void WhenAddingAnErrorMustAddAsEnum()
		{
			var result = new Response<string>();

			result.AddError(Message.Test, "string", "value");

			Assert.Single(result.Notifications);
			var baseNotification = result.Notifications.First();
			Assert.NotNull(baseNotification);
			Assert.True(baseNotification is Notification<Message>);
			Assert.Equal(Effect.Error, baseNotification.Effect);
			Assert.Equal(2, baseNotification.AdditionalInfo.Length);
			Assert.Equal("string", baseNotification.AdditionalInfo[0]);
			Assert.Equal("value", baseNotification.AdditionalInfo[1]);
			Assert.Equal(Message.Test, baseNotification.Identifier);
			var notification = (Notification<Message>)baseNotification;
			Assert.Equal(Message.Test, notification.Code);
		}

		[Fact(DisplayName = "When Adding a Not Found you must add as enum")]
		public void WhenAddingANotFoundYouMustAddAsEnum()
		{
			var result = new Response<string>();

			result.NotFound(Message.Test, "string", "value");

			Assert.Single(result.Notifications);
			var baseNotification = result.Notifications.First();
			Assert.NotNull(baseNotification);
			Assert.True(baseNotification is Notification<Message>);
			Assert.Equal(Effect.NotFound, baseNotification.Effect);
			Assert.Equal(2, baseNotification.AdditionalInfo.Length);
			Assert.Equal("string", baseNotification.AdditionalInfo[0]);
			Assert.Equal("value", baseNotification.AdditionalInfo[1]);
			Assert.Equal(Message.Test, baseNotification.Identifier);
			var notification = (Notification<Message>)baseNotification;
			Assert.Equal(Message.Test, notification.Code);
		}

		[Fact(DisplayName = "When adding a Not Authorized you must add as enum")]
		public void WhenAddingANotAuthorizedYouMustAddAsEnum()
		{
			var result = new Response<string>();

			result.NotAuthorized(Message.Test, "string", "value");

			Assert.Single(result.Notifications);
			var baseNotification = result.Notifications.First();
			Assert.NotNull(baseNotification);
			Assert.True(baseNotification is Notification<Message>);
			Assert.Equal(Effect.NotAuthorized, baseNotification.Effect);
			Assert.Equal(2, baseNotification.AdditionalInfo.Length);
			Assert.Equal("string", baseNotification.AdditionalInfo[0]);
			Assert.Equal("value", baseNotification.AdditionalInfo[1]);
			Assert.Equal(Message.Test, baseNotification.Identifier);
			var notification = (Notification<Message>)baseNotification;
			Assert.Equal(Message.Test, notification.Code);
		}

		[Fact(DisplayName = "When adding another one must add as string")]
		public void WhenAddingAnotherOneMustAddAsString ()
		{
			var result = new Response<string>();

			result.Add(Effect.Conflicted, "message/test", "string", "value");

			Assert.Single(result.Notifications);
			var baseNotification = result.Notifications.First();
			Assert.NotNull(baseNotification);
			Assert.True(baseNotification is BasicNotification);
			Assert.Equal(Effect.Conflicted, baseNotification.Effect);
			Assert.Equal(2, baseNotification.AdditionalInfo.Length);
			Assert.Equal("string", baseNotification.AdditionalInfo[0]);
			Assert.Equal("value", baseNotification.AdditionalInfo[1]);
			Assert.Equal("message/test", baseNotification.Identifier);
			var notification = (BasicNotification)baseNotification;
			Assert.Equal("message/test", notification.Code);
		}



		[Fact(DisplayName = "When adding multiples it should copy correctly")]
		public void WhenAddingMultiplesItShouldCopyCorrectly()
		{
			var result = new Response<string>();

			result.Add(Effect.Conflicted, "message/test", "string", "valor");
			result.Add(Effect.InvalidStatus, "message/test2", "string", "valor");

			var result2 = new Response<int>();

			result2.AddRange(result.Notifications);

			Assert.Equal(2, result2.Notifications.Count);
			Assert.Equal(result2.Notifications, result2.Notifications);
		}
	}

	public enum Message
	{
		Test
	}
}
