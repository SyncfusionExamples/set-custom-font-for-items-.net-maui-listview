using Syncfusion.Maui.ListView.Hosting;

namespace ListViewMaui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Lobster-Regular.ttf", "LobsterRegular");
				fonts.AddFont("Satisfy-Regular.ttf", "SatisfyRegular");
			});

		builder.ConfigureSyncfusionListView();
		return builder.Build();
	}
}
