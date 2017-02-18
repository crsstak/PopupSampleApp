using Prism.Unity;
using PopupSampleApp.Views;

namespace PopupSampleApp
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer = null) : base(initializer) { }

		protected override void OnInitialized()
		{
			InitializeComponent();

			NavigationService.NavigateAsync("PopupSamplePage?title=Hello%20from%20Xamarin.Forms");
		}

		protected override void RegisterTypes()
		{
			Container.RegisterTypeForNavigation<PopupSamplePage>();
		}
	}
}
