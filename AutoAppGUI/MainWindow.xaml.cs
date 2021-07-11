using System.Windows;
using System.Windows.Forms;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Config.Net;
using AutoApp;

namespace AutoAppGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Application1.Items.Clear();
            List<SettingsModel> items = new();
            items.Add(new SettingsModel() { AppName = "Diff Tool", Directory = @"\\regression\data\tools\Diff Tool\fury", LocalVersion = "1.4.0.12046", LatestVersion = "1.4.0.25026" });
            items.Add(new SettingsModel() { AppName = "Blob Extractor Tool", Directory = @"\\regression\data\tools\Magnet.BlobExtractor\fury", LocalVersion = "1.4.0.11234", LatestVersion = "1.4.0.25028", IsSelected = true });
            items.Add(new SettingsModel() { AppName = "Axiom Prod", Directory = @"\\regression\build_data\production\axiom\fury", LocalVersion = "4.11.0.12455", LatestVersion = "5.0.0.24639" });
            items.Add(new SettingsModel() { AppName = "iOS Backup Viewer", Directory = @"\\regression\data\tools\Magnet.IosBackupViewer\fury", LocalVersion = "1.4.0.11234", IsSelected = true });
            items.Add(new SettingsModel() { AppName = "Android Data Extractor", Directory = @"\\regression\data\tools\Magnet.AndroidDataExtractor\fury", LocalVersion = "1.4.0.11234", LatestVersion = "1.4.0.25029" });
            items.Add(new SettingsModel() { AppName = "Schema Diff Tool", Directory = @"\\regression\data\tools\Magnet.Schema.Diff\fury", LocalVersion = "1.4.0.11234", LatestVersion = "1.4.0.25029" });
            Application1.ItemsSource = SettingsSqliteHandler.ConnectionSettingsList;
        }

        private void SelectAppDirectory_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog openFolderDialog = new FolderBrowserDialog();

            DialogResult result = openFolderDialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(openFolderDialog.SelectedPath))
            {
                DirectoryValue.Text = openFolderDialog.SelectedPath;
            }
        }

        private void AddApplication_Click(object sender, RoutedEventArgs e)
        {
            AddApplicationWindow addApp = new AddApplicationWindow();

            addApp.ShowDialog();
        }

        private void RemoveApplication_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
