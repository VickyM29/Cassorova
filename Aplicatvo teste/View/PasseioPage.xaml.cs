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
            Nome = "Trilha Cachoeira Cassorova",
            Descricao = "Caminhada guiada até a cachoeira dupla mais famosa da região. Vista incrível!",
            Horario = "08:00 e 14:00",
            Preco = 80,
            Icone = "🥾"
        });

        passeios.Add(new Passeio
        {
            Nome = "Tirolesa",
            Descricao = "Voo de tirolesa sobre o vale com vista para as cachoeiras. Experiência única!",
            Horario = "09:00 às 17:00",
            Preco = 150,
            Icone = "🪂"
        });

        passeios.Add(new Passeio
        {
            Nome = "Caiaque",
            Descricao = "Passeio de caiaque pelo rio com percurso guiado. Equipamentos inclusos.",
            Horario = "08:30 e 14:30",
            Preco = 120,
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