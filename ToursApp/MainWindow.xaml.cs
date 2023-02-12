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
using System.IO;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToursApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new ToursPage());
            Manager.MainFrame = MainFrame;
            ImportTours();
        }
        private void ImportTours()
        {
            
            var fileData = File.ReadAllLines(@"C:\Users\kvm04\OneDrive\Рабочий стол\Новая папка\Туры.txt");
            var Images = Directory.GetFiles(@"C:\Users\kvm04\OneDrive\Рабочий стол\Новая папка\Фотографии Туров");

            foreach ( var line in fileData ) 
            {
                var data = line.Split('\t');

                var tempTour = new Tour
                {
                    Name = data[0].Replace("\"", ""),
                    TicketCount = int.Parse(data[2]),
                    Price = decimal.Parse(data[3]),
                    IsActual = (data[4] == "0") ? false : true
                };

                foreach (var tourType in data[5].Replace("\"","").Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries))
                {
                    var currenType = ToursBaseEntities.GetContext().Types.ToList().FirstOrDefault(p => p.Name == tourType);
                    if (currenType != null)
                        tempTour.Types.Add(currenType);

                }

                try
                {
                    tempTour.ImagePreview=File.ReadAllBytes(Images.FirstOrDefault(p=>p.Contains(tempTour.Name)));
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                ToursBaseEntities.GetContext().Tours.Add(tempTour);
                ToursBaseEntities.GetContext().SaveChanges();
            }
        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }
            private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                BtnBack.Visibility = Visibility.Visible;
            }
            else
            {
                BtnBack.Visibility = Visibility.Hidden;
            }
        }
    }   
}
