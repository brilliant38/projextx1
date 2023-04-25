using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace FirstApp
{
    /// <summary>
    /// ch12.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ch12 : Window
    {
        private ObservableCollection<Person> list;
        public ch12()
        {
            InitializeComponent();
            list = new ObservableCollection<Person>
            {
                new Person{isChecked = true ,Name="홍길동", Age = 100},
                new Person{isChecked = false ,Name="임꺽정", Age = 90},
                new Person{isChecked = false ,Name="타요", Age = 5},
                new Person{isChecked = true ,Name="뽀로로", Age = 7},
            };
            lst.ItemsSource = list;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            list.Add(new Person { isChecked = true, Name = "뽀로로2", Age = 3 });
        }
    }

    public class Person
    {
        public bool isChecked { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
