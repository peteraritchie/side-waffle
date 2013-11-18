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

namespace $safeprojectname$.UI {
    /// <summary>
    /// Interaction logic for InputForm.xaml
    /// </summary>
    public partial class InputForm : Window {
        public InputForm() {
            InitializeComponent();
        }

        public string GetTextValue() {
            return this.TextFieldValue != null ? this.TextFieldValue.Text : null;
        }

        private void OkClicked(object sender, RoutedEventArgs e) {
            this.DialogResult = true;
        }

        private void CancelClicked(object sender, RoutedEventArgs e) {
            this.DialogResult = false;
        }
    }
}
