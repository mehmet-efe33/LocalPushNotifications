using Plugin.LocalNotification;

namespace LocalPushNotification;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		var request = new NotificationRequest
		{
			NotificationId = 1337,
			Title = "Hello everyone",
			Subtitle = "Warning",
			Description = "It's me",
			BadgeNumber = 42,
			Schedule = new NotificationRequestSchedule
			{
				NotifyTime = DateTime.Now.AddSeconds(5),
				NotifyRepeatInterval = TimeSpan.FromDays(1),
			}
		};

		LocalNotificationCenter.Current.Show(request);
	}
}

