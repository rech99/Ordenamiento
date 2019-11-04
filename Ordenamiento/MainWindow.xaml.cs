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
using System.Collections.ObjectModel;

namespace Ordenamiento
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<int> miLista = new ObservableCollection<int>();
        ObservableCollection<Alumno> alumnos = new ObservableCollection<Alumno>();
        public MainWindow()
        {
            InitializeComponent();
            miLista.Add(58);
            miLista.Add(34);
            miLista.Add(54);
            miLista.Add(87);
            miLista.Add(98);
            miLista.Add(12);
            miLista.Add(32);
            miLista.Add(97);

            alumnos.Add(new Alumno("Maria", 9.1f, 2));
            alumnos.Add(new Alumno("Tnia", 9.8f, 0));
            alumnos.Add(new Alumno("Alberto", 6.4f, 14));
            alumnos.Add(new Alumno("Eliozabet", 6.4f, 4));
            alumnos.Add(new Alumno("Analucia", 8.5f, 1));

            lstNumeros.ItemsSource = alumnos;

            //lstNumeros.ItemsSource = miLista;
        }

        private void BtnOrdenar_Click(object sender, RoutedEventArgs e)
        {
            //para cambiar actuqalizar en ell data
            /*var temp = miLista[0];
            miLista[0] = miLista[3];
            miLista[3] = temp;*/

            /*int gap, temp, i, j;
             * para numeros
             * ---------------------------------------------------------

            gap = alumnos.Count / 2;

            while (gap > 0)
            {
                for (i = 0; i < alumnos.Count; i++)
                {
                    if (gap + i < alumnos.Count && alumnos[i].Promedio > alumnos[gap + Promedio])
                    {
                        temp = miLista[i];
                        miLista[i] = miLista[gap + i];
                        miLista[gap + i] = temp;
                    }



                }

                gap--;
            }
        }*/
        //----------------------------------------------------------------

        //cambiar para alumno/donde dice miLista
        int gap, i;

            gap = alumnos.Count / 2;

            while (gap > 0)
            {
                for (i = 0; i < alumnos.Count; i++)
                {
                    if (gap + i <alumnos.Count && alumnos[i].Promedio > alumnos[gap + i].Promedio)
                    {
                        var temp = alumnos[i];
                        alumnos[i] = alumnos[gap + i];
                        alumnos[gap + i] = temp;
                    }


               
                }

                gap--;
            }
        }

        private void BtnOrdenarbbl_Click(object sender, RoutedEventArgs e)
        {
            bool intercambio = false;
            do
            {
                intercambio = false;
                for(int i=0; i<alumnos.Count -1; i++ )
                {
                    if(alumnos[i].Promedio>alumnos[i+1].Promedio)
                    {
                        var temp = alumnos[i];
                        alumnos[i] = alumnos[i + 1];
                        alumnos[i + 1] = temp;
                        intercambio = true;
                    }
                }
            } 
               while (intercambio);
        }

        private void BtnOrdenar1(object sender, RoutedEventArgs e)
        {
            int gap, i;

            gap = alumnos.Count / 2;

            while (gap > 0)
            {
                for (i = 0; i < alumnos.Count; i++)
                {
                    if (gap + i < alumnos.Count && alumnos[i].Faltas > alumnos[gap + i].Faltas)
                    {
                        var temp = alumnos[i];
                        alumnos[i] = alumnos[gap + i];
                        alumnos[gap + i] = temp;
                    }



                }

                gap--;
            }

        }

        private void BtnOrdenarbbl2(object sender, RoutedEventArgs e)
        {
            bool intercambio = false;
            do
            {
                intercambio = false;
                for (int i = 0; i < alumnos.Count - 1; i++)
                {
                    if (alumnos[i].Faltas > alumnos[i + 1].Faltas)
                    {
                        var temp = alumnos[i];
                        alumnos[i] = alumnos[i + 1];
                        alumnos[i + 1] = temp;
                        intercambio = true;
                    }
                }
            }
            while (intercambio);
        }
    }

}
