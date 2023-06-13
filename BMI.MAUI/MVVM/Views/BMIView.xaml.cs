using BMI.MAUI.MVVM.ViewModels;

namespace BMI.MAUI.MVVM.Views;

public partial class BMIView : ContentPage
{
	public BMIView()
	{
		InitializeComponent();
		BindingContext = new BMIViewModel();
	}
}