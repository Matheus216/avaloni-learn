using Avalonia.Interactivity;
using System.Diagnostics;
using Avalonia.Controls;
using HomeBroker.ViewModels.Graph;

namespace HomeBroker.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new GraphViewModel();
    }

    // private void ButtonBase_OnClick(object? sender, RoutedEventArgs e)
    // {
    //     Debug.WriteLine($"Value of Celsius: {Celsius.Text} Fahreinght: {Fah.Text}");
    //     if (string.IsNullOrEmpty(Celsius.Text) && string.IsNullOrEmpty(Fah.Text))
    //         return;
    //     
    //     if (!string.IsNullOrEmpty(Celsius.Text))
    //     {
    //         Fah.Text = (double.Parse(Celsius.Text) * (9d/5d) + 32).ToString("0.0"); 
    //     }
    //     else 
    //     {
    //         Celsius.Text = (((double.Parse(Fah.Text) - 32) / 1.8).ToString("0.0"));
    //     }
    // }
    //
    // private void OnCelsiusToFahreingth(object sender, TextChangedEventArgs e)
    // {
    //     if (string.IsNullOrEmpty(Celsius.Text))
    //         return;
    //     
    //     Fah.Text = (double.Parse(Celsius.Text) * (9d/5d) + 32).ToString("0.0");
    // }
    //
    // private void OnFahreingToCelsius(object sender, TextChangedEventArgs e)
    // {
    //     if (string.IsNullOrEmpty(Fah.Text))
    //         return;
    //     
    //     Celsius.Text = (((double.Parse(Fah.Text) - 32) / 1.8).ToString("0.0"));
    // }
}