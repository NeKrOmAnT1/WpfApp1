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
using Crypto.AES;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_shifr_Click(object sender, RoutedEventArgs e)
        {
            using (AES aes = new AES(tb_key.Text))
            {
                string toBeEncrypted = aes.Encrypt(tb_shifr.Text);
                string encrypted = aes.Encrypt(toBeEncrypted);
                tb_shifr.Text = encrypted;  
                
            }

        }

        private void button_deshifr_Click(object sender, RoutedEventArgs e)
        {
            using (AES aes = new AES(tb_key.Text))
            {
                string toBeDecrypted = aes.Decrypt(tb_shifr.Text);
                string decrypted = aes.Decrypt(toBeDecrypted);
                tb_deshifr.Text = decrypted;
            }
        }
    }
}
