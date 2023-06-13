using BMI.MAUI.MVVM.Views;

namespace BMI.MAUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new BMIView();
	}
}
