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
using System.Windows.Shapes;

namespace StudyHelper
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private int count = 0;

        public List<String> objList =  new List<String>();

        public Window2()
        {
            InitializeComponent();

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            objList.Add(addTextBox.Text);

            objectivesPanel.Children.Add(new TextBlock
            {
                Text = $"{count} - {this.addTextBox.Text}",
                FontSize=15,
                HorizontalAlignment = HorizontalAlignment.Center
            });
            count++;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            objectivesPanel.Children.Clear();

            objList.RemoveAt(int.Parse(deleteText.Text));

            for (int i= 0; i < objList.Count; i++)
            {
                objectivesPanel.Children.Add(new TextBlock
                {
                    Text = $"{i} - {objList[i]}",
                    FontSize = 15,
                    HorizontalAlignment = HorizontalAlignment.Center
                });

            }
        }
    }
}
