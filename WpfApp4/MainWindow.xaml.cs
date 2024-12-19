using System.Collections.ObjectModel;
using System.Windows;

namespace WpfAppLists
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> Products { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            // Создаем коллекцию товаров
            Products = new ObservableCollection<Product>
            {
                new Product
                {
                    Name = "Ноутбук",
                    Description = "Мощный ноутбук для работы и игр",
                    Manufacturer = "Dell",
                    Price = 75000,
                    Stock = 10,
                    ImagePath = "Images/laptop.jpg"
                },
                new Product
                {
                    Name = "Смартфон",
                    Description = "Современный смартфон с отличной камерой",
                    Manufacturer = "Samsung",
                    Price = 50000,
                    Stock = 15,
                    ImagePath = "Images/smartphone.jpg"
                },
                new Product
                {
                    Name = "Наушники",
                    Description = "Беспроводные наушники с шумоподавлением",
                    Manufacturer = "Sony",
                    Price = 15000,
                    Stock = 20,
                    ImagePath = "Images/headphones.jpg"
                }
            };

            // Устанавливаем DataContext для привязки данных
            DataContext = this;
        }
    }
}
