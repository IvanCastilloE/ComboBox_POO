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

namespace Listas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Persona> listaPersonas = new List<Persona>(); //Sirve para crear una lista
            listaPersonas.Add(new Persona("Jotaro", "Kujo"));
            listaPersonas.Add(new Persona("Memazo", "Peludo"));

            foreach(Persona persona in listaPersonas)
            {
                ComboBoxItem cbi = new ComboBoxItem();
                cbi.Content = persona;
                cbBox.Items.Add(cbi);
            }
        }

        private void cbBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)cbBox.SelectedItem;//Tener acceso alItem seleccionado
            Persona persona = (Persona)cbi.Content;//tomo los datos de lo que seleccione
            lblNombre.Content = persona.Nombre;//Asigno el contenido de persona al atributo Content de mi label
            lblApellido.Content = persona.Apellido;
        }
    }
}
