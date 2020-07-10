using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace FirstApplication.IslevselNugetPackages.SettingPlugins
{
	public static class Settings
	{
		private static ISettings AppSettings => CrossSettings.Current;

		//Kullanıcı adını hafıza da tutmak için kullanıcam
		public static string GeneralSettings
		{
			get => AppSettings.GetValueOrDefault(nameof(GeneralSettings), string.Empty);

			set => AppSettings.AddOrUpdateValue(nameof(GeneralSettings), value);
		}

		//Şifreyi hafızada tutmak için kullanıcam
		public static string GeneralSettingsPass
		{
			get => AppSettings.GetValueOrDefault(nameof(GeneralSettingsPass), string.Empty);

			set => AppSettings.AddOrUpdateValue(nameof(GeneralSettingsPass), value);
		}

		//Beni hatırla olayını tutmak için kullanıcam
		public static string GeneralSettingsRemember
		{
			get => AppSettings.GetValueOrDefault(nameof(GeneralSettingsRemember), string.Empty);

			set => AppSettings.AddOrUpdateValue(nameof(GeneralSettingsRemember), value);
		}
	}
}
