using Aplicatvo_teste.View;

namespace Aplicatvo_teste
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
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
