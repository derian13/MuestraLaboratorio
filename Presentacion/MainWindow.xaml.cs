using BusinessLogicApi.DTO;
using Presentation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Presentation
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MantenimientoMuestraVM vm;

        public MainWindow()
        {
            InitializeComponent();
            vm = new MantenimientoMuestraVM();
            vm.LoadMuestras();
            this.DataContext = vm;
        }

        private void btnGrabar_Click(object sender, RoutedEventArgs e)
        {
            vm.CreateMuestra();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            vm.DeleteMuestra();
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            vm.Edit();
        }

        private void dtgMuestras_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            vm.Edit();
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            vm.Clear();
        }
    }
}
