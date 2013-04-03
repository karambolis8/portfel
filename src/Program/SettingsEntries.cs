
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using ErrorsReporting;
using Microsoft.Win32;


namespace portfel
{
    class SettingsEntries
    {
        private const string PORTFEL_PATH = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\portfel.exe";
        private const string USER_FOLDER = "user";
        private const string FILE_EXT = ".ini";

        private string setuppath;


        private string UserSettingsFolder
        {
            get
            {
                return Path.Combine(this.setuppath, USER_FOLDER);
            }
        }

        public SettingsEntries()
        {
            try
            {
                string path = (string)Registry.GetValue(PORTFEL_PATH, "", null);
                this.setuppath = path.Substring(0, path.LastIndexOf('\\'));
            }
            catch
            {
                this.setuppath = null;
                string text = "Aplikacja jest niepoprawnie zainstalowana i część funkcjonalności może być niedostępna.\n";
                text += "Ponowne zainstalowanie programu rozwiąże problem.";
                MainForm.MessageBoxWrapper(text + this.setuppath, MessageType.WOK);
            }
        }


        /// <summary>Wczytuje ustawienia okna aplikacji.</summary>
        /// <remarks>Próbuje wczytać z pliku konfiguracyjnego rozmiar, pozycję i stan okna.
        /// W przypadku niepowodzenia wprowadza domyślne ustawienia.</remarks>
        public void ReadSettings(MainForm form)
        {
            string file = this.FileName(form.portfel.profile);
            XmlTextReader reader = null;

            try
            {
                if(File.Exists(file))
                {
                    reader = new XmlTextReader(file);

                    XmlSerializer serializer = new XmlSerializer(typeof(ApplicationSettings));
                    ApplicationSettings settings = (ApplicationSettings)serializer.Deserialize(reader);

                    form.dateColumnHeader.Width = settings.DateColumn;
                    form.valueColumnHeader.Width = settings.ValueColumn;
                    form.categoryColumnHeader.Width = settings.CategoryColumn;
                    form.descriptionColumnHeader.Width = settings.DescriptionColumn;

                    form.StartPosition = FormStartPosition.Manual;

                    if(settings.WindowState == FormWindowState.Maximized)
                        form.WindowState = FormWindowState.Maximized;
                    else
                        form.WindowState = FormWindowState.Normal;

                    form.Size = new Size(settings.Width, settings.Height);
                    form.Location = new Point(settings.X, settings.Y);
                    reader.Close();
                }
                else
                {
#if DEBUG
                    MessageBox.Show("brak pliku ustawien okna");
#endif
                    form.StartPosition = FormStartPosition.CenterScreen;
                    form.dateColumnHeader.Width = 65;
                    form.valueColumnHeader.Width = 60;
                    form.categoryColumnHeader.Width = 67;
                    form.descriptionColumnHeader.Width = 69;
                }
            }
            catch(Exception ex)
            {
                string text = "Plik ustawień okna aplikacji wygląda na uszkodzony.\n";
                text += "Program portfel może spróbować rozwiązać problem.\n";
                text += "Jeśli jednak błąd mimo wszystko powtarza się, możesz wysłać do autora raport o błędzie.\n";
                text += "Czy spróbować naprawić problem?";
#if DEBUG
                text += "\n\n" + ex.ToString();
#endif

                if(MainForm.MessageBoxWrapper(text, MessageType.EYesNo) == DialogResult.Yes)
                {
                    reader.Close();
                    File.Delete(file);
                }
                else
                {
                    text = "Czy chcesz wysłac do autora raport o błędzie?";
                    if(MainForm.MessageBoxWrapper(text, MessageType.EYesNo) == DialogResult.Yes)
                        try
                        {
                            ErrorReporter.Send("Portfel v" + PortfelAboutBox.AssemblyVersion, ex.ToString(), null);
                        }
                        catch
                        {
                        }
                }
            }
        }

        /// <summary>Zapisuje ustawienia okna aplikacji.</summary>
        /// <remarks>Zapisuje pozycję rozmiar i stan okna w czasie zamykania programu.</remarks>
        public void SaveSettings(MainForm form)
        {
            string file = this.FileName(form.portfel.profile);
            XmlTextWriter writer = null;

            try
            {
                if(!Directory.Exists(this.UserSettingsFolder))
                    Directory.CreateDirectory(this.UserSettingsFolder);

                writer = new XmlTextWriter(file, Encoding.UTF8);
                writer.Formatting = Formatting.Indented;

                ApplicationSettings settings = new ApplicationSettings();

                if(form.WindowState == FormWindowState.Maximized)
                    settings.WindowState = form.WindowState;
                else
                    settings.WindowState = FormWindowState.Normal;

                form.WindowState = FormWindowState.Normal;
                settings.Width = form.Size.Width;
                settings.Height = form.Size.Height;
                settings.X = form.Location.X;
                settings.Y = form.Location.Y;

                settings.DateColumn = form.dateColumnHeader.Width;
                settings.ValueColumn = form.valueColumnHeader.Width;
                settings.CategoryColumn = form.categoryColumnHeader.Width;
                settings.DescriptionColumn = form.descriptionColumnHeader.Width;

                XmlSerializer serializer = new XmlSerializer(typeof(ApplicationSettings));
                serializer.Serialize(writer, settings);
                writer.Close();
            }
            catch(Exception ex)
            {
                string text = "Wystąpił nieznany problem z plikiem ustawień okna aplikacji.\n";
                text += "Możesz teraz wysłać do autora raport o błędzie.";
#if DEBUG
                text += "\n\n" + ex.ToString();
#endif

                if(MainForm.MessageBoxWrapper(text, MessageType.EYesNo) == DialogResult.Yes)
                {
                    try
                    {
                        ErrorReporter.Send("Portfel v" + PortfelAboutBox.AssemblyVersion, ex.ToString(), null);
                    }
                    catch
                    {
                    }
                }
            }
        }

        private string FileName(string profile)
        {
            if(this.setuppath == null)
                return null;

            return Path.Combine(this.UserSettingsFolder, profile + FILE_EXT);
        }
    }
}
