using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace DiscordTool
{
    class FormTools : Window
    {
        static Timer timer;
        public static void SaveToken()
        {
            StreamWriter streamWriter = new StreamWriter("./data/token.txt");
            streamWriter.WriteLine(token);
            streamWriter.Close();
        }

        public static void StatusUpdate(int delay, ListBox.ObjectCollection objectCollection)
        {
            AutoResetEvent autoEvent = new AutoResetEvent(false);
            timer = new Timer(UpdateStatus, autoEvent, 0, delay * 1000);
        }
        public static void KillStatusUpdate()
        {
            timer.Dispose();
        }

        static void UpdateStatus(object state)
        {
            // do update
            Console.WriteLine("running");
        }
    }

    partial class Window
    {
        bool SetToken(string nToken)
        {
            token = nToken;
            FormTools.SaveToken();
            if (tokenTxt.Text != nToken)
            {
                tokenTxt.Text = nToken;
            }
            return true;
        }

        void LoadVariables()
        {
            Directory.CreateDirectory("./data");
            if (File.Exists("./data/token.txt"))
            {
                StreamReader streamReader = new StreamReader("./data/token.txt");
                string newToken = streamReader.ReadLine();
                streamReader.Close();
                SetToken(newToken);
                tokenTxt.Text = token.ToString();
            }
        }
    }
}