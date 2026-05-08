using Aplicatvo_teste.View;

namespace Aplicatvo_teste
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(AcomodacoesPage), typeof(AcomodacoesPage));
            Routing.RegisterRoute(nameof(PasseioPage), typeof(PasseioPage));
            Routing.RegisterRoute(nameof(PagamentoPage), typeof(PagamentoPage));
            Routing.RegisterRoute(nameof(ReservaPage), typeof(ReservaPage));
            Routing.RegisterRoute(nameof(AvaliacoesPage), typeof(AvaliacoesPage));
        }
    }
}
