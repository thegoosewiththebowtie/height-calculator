using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using height_calculator;
using static System.Windows.Forms.DataFormats;

namespace height_calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public bool CB { get; set; }
        public bool NE { get; set; } = false;
        public int h {  get; set; }
        public MainWindow()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            InitializeComponent();
        }
        private void tb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !int.TryParse(e.Text, out int result);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string lh = tb.Text;
            if (lh != string.Empty)
            {
                h = Convert.ToInt32(lh);
                NE = true;
            }
            else NE = false;
        }
        private void check(object sender, RoutedEventArgs e)
        {
            CB = Convert.ToBoolean(cb.IsChecked);
        }
        private void start_Click(object sender, RoutedEventArgs e)
        {
            if (CB && NE == true)
            {
                
                f1 F2 = new f1(h);
                F2.ShowDialog();
                
            }
            else if (CB == false && NE == true)
            {
                System.Windows.Forms.MessageBox.Show("you have to accept our Terms and Conditions", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                System.Windows.Forms.MessageBox.Show("you have to input your height", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        
    }
}