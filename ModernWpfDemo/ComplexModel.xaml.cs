using EngineComponent;
using Microsoft.Toolkit.Wpf.UI.XamlHost;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ModernWpfDemo
{
    /// <summary>
    /// Interaction logic for ComplexModel.xaml
    /// </summary>
    public partial class ComplexModel : Window
    {
        public ComplexModel()
        {
            InitializeComponent();
        }

        private void WindowsXamlHost_ChildChanged(object sender, EventArgs e)
        {
            if (sender is WindowsXamlHost windowsXamlHost && windowsXamlHost.Child is EngineModel engineModel)
            {
                engineModel.ModelUrl = new Uri("ms-appx:///Model/Telescope.gltf");
            }
        }
    }
}
