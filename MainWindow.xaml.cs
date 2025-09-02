using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;

namespace DllCopierWpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CopyDlls_Click(object sender, RoutedEventArgs e)
        {
            var pathMap = new[]
            {
                new
                {
                    Source = @"C:\Users\DAmiri\source\repos\dll\PrimeTester\bin\Debug\",
                    Targets = new[]
                    {
                        @"C:\Users\DAmiri\source\repos\dll\projectCalcul\bin\Debug\",
                        //@"C:\Users\DAmiri\DllCopierProject\core-server\build\Core\bin\x64\Debug\bin"
                    }
                }

                //add other source-Target entry
                //new
                //{
                //    Source = @"C:\Users\DAmiri\source\repos\dll\PrimeTester\bin\Debug\",
                //    Targets = new[]
                //    {
                //        @"C:\Users\DAmiri\source\repos\dll\projectCalcul\bin\Debug\",
                //        @"C:\Users\DAmiri\DllCopierProject\core-server\build\Core\bin\x64\Debug\bin"
                //    }
                //}
            };

            foreach (var entry in pathMap)
            {
                string[] files;
                try
                {
                    files = Directory.GetFiles(entry.Source, "*.dll", SearchOption.AllDirectories);
                }
                catch (Exception ex)
                {
                    Log($"Failed to access source path '{entry.Source}': {ex.Message}");
                    continue;
                }

                foreach (var target in entry.Targets)
                {
                    try
                    {
                        if (!Directory.Exists(target))
                        {
                            Directory.CreateDirectory(target);
                            Log($"Created directory: {target}");
                        }

                        foreach (var file in files)
                        {
                            string destinationFile = Path.Combine(target, Path.GetFileName(file));
                            // make sure that the source-target is correct
                            Log($"Preparing to copy:\n  From: {file}\n  To:   {destinationFile}");

                            if (!File.Exists(destinationFile) || File.GetLastWriteTime(file) > File.GetLastWriteTime(destinationFile))
                            {
                                File.Copy(file, destinationFile, true);
                                Log($"Copied {Path.GetFileName(file)} to {target}");
                            }
                            else
                            {
                                Log($"Skipped {Path.GetFileName(file)} (up-to-date)");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Log($"Error copying to '{target}': {ex.Message}");
                    }
                }
            }

            Log("DLL copying completed.");
        }

        private void Log(string message)
        {
            LogTextBox.AppendText($"[{DateTime.Now}] {message}{Environment.NewLine}");
            LogTextBox.ScrollToEnd();
        }
    }
}
