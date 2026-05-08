namespace Aplicatvo_teste.View;

public partial class ReservaPage : ContentPage
{
    public ReservaPage()
    {
        InitializeComponent();
    }

    private async void VerificarDisponibilidade(object sender, EventArgs e)
    {
        // Validação simples
        if (string.IsNullOrWhiteSpace(txt_nome.Text))
        {
            await DisplayAlertAsync("Atenção", "Por favor, preencha seu nome.", "OK");
            return;
        }

        if (string.IsNullOrWhiteSpace(txt_hospedes.Text))
        {
            await DisplayAlertAsync("Atenção", "Informe a quantidade de hóspedes.", "OK");
            return;
        }

        // Garantir valores não nulos para as datas
        DateTime checkin = dtp_checkin.Date ?? DateTime.Today;
        DateTime checkout = dtp_checkout.Date ?? DateTime.Today;

        if (checkout <= checkin)
        {
            await DisplayAlertAsync("Atenção", "A data de check-out deve ser posterior ao check-in.", "OK");
            return;
        }

        // Calcular número de diárias
        int diarias = (checkout - checkin).Days;

        string mensagem = $"Olá, {txt_nome.Text}!\n\n" +
                          $"✅ Verificamos disponibilidade para:\n" +
                          $"📅 Check-in: {checkin:dd/MM/yyyy}\n" +
                          $"📅 Check-out: {checkout:dd/MM/yyyy}\n" +
                          $"🌙 {diarias} diária(s)\n" +
                          $"👥 {txt_hospedes.Text} hóspede(s)\n\n" +
                          $"Nossa equipe entrará em contato para confirmar sua reserva. Obrigado!";

        await DisplayAlertAsync("Solicitação Enviada!", mensagem, "Perfeito!");
    }
    private async void IrMainPage(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopToRootAsync();
    }
}