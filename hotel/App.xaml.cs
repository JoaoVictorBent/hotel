namespace hotel
{
    public partial class App : Application
    {
        public App()
        {
            
            InitializeComponent();

            MainPage = new NavigationPage(new interface_grafica.contratacaoHospedagem());

        } 

        protected override Window CreateWindow(IActivationState activationState)
        {

            var window = base.CreateWindow(activationState);

            window.Height = 600;
            window.Width = 400;    

            return window;

        }

    }
}