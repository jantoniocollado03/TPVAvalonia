using Avalonia.Controls;
using Avalonia.Interactivity;

namespace TPV.UI;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent(); // Esto dibuja tu XAML en la pantalla
            
        // AQUÍ CONECTAMOS EL BOTÓN CON LA ACCIÓN
        // El operador += significa "suscríbete a este evento"
        btnCobrar.Click += BtnCobrar_Click;
    }
    
    private void BtnCobrar_Click(object? sender, RoutedEventArgs e)
    {
        // Aquí dentro irá la lógica de calcular el total y generar el ticket
    }
}