using Aplicatvo_teste.Models;

namespace Aplicatvo_teste.View;

public partial class PasseioPage : ContentPage
{
    List<Passeio> passeios = new();

    public PasseioPage()
    {
        InitializeComponent();

        passeios.Add(new Passeio
        {
            Nome = "Picnic na Natureza",
            Descricao = "Escolha seu espaço na natureza e montamos seu picnic, com cesta de petiscos e vinho.",
            Horario = "Reserve na recepção",
            Preco = 525,
            Icone = "🥾"
        });

        passeios.Add(new Passeio
        {
            Nome = "Picnic na Varanda",
            Descricao = "Um picnic na varanda de seu bangalô, ao lado de seu ofurô, com vista do horizonte.",
            Horario = "Reserve na recepção",
            Preco = 525,
            Icone = "🪂"
        });

        passeios.Add(new Passeio
        {
            Nome = "Day Use",
            Descricao = "Nosso day use entrega mais valor e satisfação por cada real pago.",
            Horario = "Reserve agora",
            Preco = 200,
            Icone = "🛶"
        });

        passeios.Add(new Passeio
        {
            Nome = "Rapel na Cachoeira",
            Descricao = "Descida de rapel na cachoeira com instrutores certificados. Adrenalina pura!",
            Horario = "09:30 e 15:00",
            Preco = 200,
            Icone = "⛰️"
        });

        passeios.Add(new Passeio
        {
            Nome = "Fogueira & Estrelas",
            Descricao = "Noite especial ao redor da fogueira com contação de histórias e observação do céu.",
            Horario = "20:00",
            Preco = 60,
            Icone = "🔥"
        });

        ListaPasseio.ItemsSource = passeios;
    }
}