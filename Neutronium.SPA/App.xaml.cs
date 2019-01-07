using System.Diagnostics;
using System.Windows;
using Chromium;
using Neutronium.BuildingBlocks.SetUp;
using Neutronium.BuildingBlocks.SetUp.NpmHelper;
using Neutronium.Core.JavascriptFramework;
using Neutronium.JavascriptFramework.Vue;
using Neutronium.WebBrowserEngine.ChromiumFx;
using Neutronium.WPF;

namespace Neutronium.SPA
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : ChromiumFxWebBrowserApp
    {
        public static SetUpViewModel SetUp => (Current as App)?.SetUpViewModel;

        private SetUpViewModel SetUpViewModel { get; }
        private readonly ApplicationSetUpBuilder _ApplicationSetUpBuilder;

        public App()
        {
            _ApplicationSetUpBuilder = new ApplicationSetUpBuilder("View");
            SetUpViewModel = new SetUpViewModel(_ApplicationSetUpBuilder);
        }

        protected override IJavascriptFrameworkManager GetJavascriptUIFrameworkManager()
        {
            return new VueSessionInjector();
        }

        protected override void UpdateChromiumBrowserSettings(CfxBrowserSettings browserSettings)
        {
            var black = new CfxColor(255, 0, 0, 0);
            browserSettings.BackgroundColor = black;
        }

        protected override void OnStartUp(IHTMLEngineFactory factory)
        {
#if DEBUG
            _ApplicationSetUpBuilder.OnRunnerMessageReceived += OnRunnerMessageReceived;
            SetUpViewModel.InitFromArgs(Args).Wait();
            Trace.WriteLine($"Starting with set-up: {SetUpViewModel}");
#else
            SetUpViewModel.InitForProduction();
#endif
            factory.RegisterJavaScriptFrameworkAsDefault(new VueSessionInjectorV2 { RunTimeOnly = true });
            base.OnStartUp(factory);
        }

        private void OnRunnerMessageReceived(object sender, RunnerMessageEventArgs e)
        {
            Trace.WriteLine($"Npm runner log: {e.Message}");
        }

        protected override void OnExit(ExitEventArgs e)
        {
            _ApplicationSetUpBuilder.Dispose();
            base.OnExit(e);
        }
    }
}
