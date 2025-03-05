namespace MiniCRM.UIApplication
{
    public partial class App : Application
    {
        public App()  // Inject AppShell using DI
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}