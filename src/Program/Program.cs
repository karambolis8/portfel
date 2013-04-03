
using System;
using System.Threading;
using System.Windows.Forms;
using ErrorsReporting;
using System.Diagnostics;


namespace portfel
{
    /// <summary>Klasa reprezentujaca program.</summary>
    /// <remarks>Odpowiada jedynie za stworzenie i wywolanie instancji MainForm.</remarks>
    class Program
    {
        /// <summary>Metoda uruchamjajaca program.</summary>
        /// <remarks>W zależnosci od parametrów programu, wywołuje instancję MainForm z odpowiednim konstruktorem.
        /// Przechwytuje nieobsłużone błędy i wysyła raport o wyjątkach do autora.</remarks>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                MainForm form;
                if(args.Length > 0)
                    form = new MainForm(args[0]);
                else
                    form = new MainForm();

                Application.ThreadException += Program.HandleUnhandled;
                Application.Run(form);
            }
            catch(Exception e)
            {
                HandleUnhandled(null, new ThreadExceptionEventArgs(e));
            }
        }

        private static void HandleUnhandled(object sender, ThreadExceptionEventArgs e)
        {
            string text = "Uuups! Coś się nie udało ;)\n";
            text += "Aplikacja zostanie zamknięta.\n";
            text += "Możesz wysłać do autora raport o błędzie wybierając 'Tak'.";
#if DEBUG
            text += "\n\n" + e.Exception.ToString();
#endif

            DialogResult result = MainForm.MessageBoxWrapper(text, MessageType.EYesNo);

            if(result == DialogResult.Yes)
            {
                try
                {
                    new Thread(() => ErrorReporter.Send("Portfel v" + PortfelAboutBox.AssemblyVersion, e.Exception.ToString(), null)).Start();
                }
                catch(Exception ex)
                {
#if DEBUG
                    MainForm.MessageBoxWrapper(ex.ToString(), MessageType.WOK);
#endif
                }
            }

            Application.Exit();
        }
    }
}
