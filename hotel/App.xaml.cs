using hotel.Models;

namespace hotel
{
    public partial class App : Application
    {

        public List<Quarto> lista_quartos = new List<Quarto>
        {

            new Quarto()
            {

                Descricao = "Suite super luxo",
                ValordadiariaAdulto = 110.00,
                ValordadiariaCrianca = 55.00

            },

            new Quarto()
            {

                Descricao = "Suite luxo",
                ValordadiariaAdulto = 80.00,
                ValordadiariaCrianca = 40.00

            },

            new Quarto()
            {

                Descricao = "Suite single",
                ValordadiariaAdulto = 50.00,
                ValordadiariaCrianca = 25.00

            },

            new Quarto()
            {

                Descricao = "Suite Crise",
                ValordadiariaAdulto = 25.00,
                ValordadiariaCrianca = 12.50

            }

        };

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