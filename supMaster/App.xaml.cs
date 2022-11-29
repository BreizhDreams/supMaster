using supMaster.View;

namespace supMaster;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new CalculPrixVue();
	}
}
