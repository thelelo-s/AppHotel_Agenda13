using AppHotel_Agenda13.Models;

namespace AppHotel_Agenda13.Pages;

public partial class HomePage : ContentPage
{
    private readonly ReservaViewModel _viewModel = new();

    public HomePage()
    {
        InitializeComponent();
        BindingContext = _viewModel;
    }

    private async void OnConsultarClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Resumo da consulta",
            $"Entrada: {_viewModel.DataEntrada:dd/MM/yyyy}\n" +
            $"Acomodação: {_viewModel.TipoQuarto}\n" +
            $"Hóspedes: {_viewModel.QuantidadeHospedes}",
            "OK");
    }
}
