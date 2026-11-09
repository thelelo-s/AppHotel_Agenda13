using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AppHotel_Agenda13.Models;

public class ReservaViewModel : INotifyPropertyChanged
{
    private int _quantidadeHospedes = 2;
    private DateTime _dataEntrada = DateTime.Today.AddDays(1);
    private string _tipoQuarto = "Standard";

    public ObservableCollection<string> TiposQuarto { get; } =
        new() { "Standard", "Luxo", "Suíte" };

    public int QuantidadeHospedes
    {
        get => _quantidadeHospedes;
        set { if (_quantidadeHospedes != value) { _quantidadeHospedes = value; OnPropertyChanged(); } }
    }

    public DateTime DataEntrada
    {
        get => _dataEntrada;
        set { if (_dataEntrada != value) { _dataEntrada = value; OnPropertyChanged(); } }
    }

    public string TipoQuarto
    {
        get => _tipoQuarto;
        set { if (_tipoQuarto != value) { _tipoQuarto = value; OnPropertyChanged(); } }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    private void OnPropertyChanged([CallerMemberName] string? name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
