using Aplicatvo_teste.Models;

namespace Aplicatvo_teste.View;

public partial class AcomodacoesPage : ContentPage
{
    List<Quarto> quartos = new();

    public AcomodacoesPage()
    {
        InitializeComponent();  

        quartos.Add(new Quarto
        {
            Nome = "Loft Standard",
            Descricao = "Aconchegante loft com varanda e vista para o jardim. Lareira, TV e Wi-Fi.",
            Preco = 939,
            Icone = "🌿"
        });

        quartos.Add(new Quarto
        {
            Nome = "Suíte Vista Cachoeira",
            Descricao = "Suíte ampla com vista privilegiada para a Cachoeira Cassorova. Ofurô externo.",
            Preco = 1200,
            Icone = "💧"
        });

        quartos.Add(new Quarto
        {
            Nome = "Chalé Premium",
            Descricao = "Chalé independente com piscina privativa aquecida e deck exclusivo.",
            Preco = 1580,
            Icone = "🏡"
        });

        quartos.Add(new Quarto
        {
            Nome = "Suíte Master Luxo",
            Descricao = "Nossa acomodação mais exclusiva. Piscina infinita privativa com vista para as cachoeiras.",
            Preco = 2100,
            Icone = "✨"
        });

        ListaQuartos.ItemsSource = quartos;
    }
}