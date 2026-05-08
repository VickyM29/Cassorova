using Aplicatvo_teste.View;

namespace Aplicatvo_teste
{
    public partial class MainPage : ContentPage
    {
        private bool _autoPlay;

        public List<string> Imagens { get; }

        public MainPage()
        {
            InitializeComponent();

            Imagens = new List<string>
        {
            "carosselp.jpg",
            "carosselt.jpg"
        };

            BindingContext = this;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _autoPlay = true;

            Dispatcher.StartTimer(TimeSpan.FromSeconds(3), () =>
            {
                if (!_autoPlay) return false;

                var items = MeuCarrossel.ItemsSource?.Cast<object>().ToList();
                if (items == null || items.Count == 0) return true;

                var nextIndex = (MeuCarrossel.Position + 1) % items.Count;
                var nextItem = items[nextIndex];

                // Atualiza o item atual de forma segura na UI
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    MeuCarrossel.CurrentItem = nextItem;
                });

                return true;
            });
        }

        protected override void OnDisappearing()
        {
            _autoPlay = false;
            base.OnDisappearing();
        }

        private async void IrAcomodacoes(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(AcomodacoesPage));
        }

        private async void IrPasseios(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(PasseioPage));
        }

        private async void IrPagamentos(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(PagamentoPage));
        }

        private async void IrReservas(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(ReservaPage));
        }

        private async void IrAvaliacoes(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(AvaliacoesPage));
        }
    }

}
