using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Net.Http;
using Newtonsoft.Json;

namespace DiscordTool
{
    public partial class Window : Form
    {
        protected static string token;
        public Window()
        {
            InitializeComponent();
            LoadVariables();
        }

        private void Window_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notify.Visible = true;
            }
        }

        private void notify_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notify.Visible = false;
        }

        private void tokenBtn_Click(object sender, EventArgs e)
        {
            string txt = tokenTxt.Text;
            if (!SetToken(txt)) return;
            
            MessageBox.Show(token.ToString());
        }

        private void tokenTxt_Validating(object sender, CancelEventArgs e)
        {
            string txt = tokenTxt.Text;
            if (txt != "" && !SetToken(txt))
            {
                e.Cancel = true;
                MessageBox.Show("Please enter a valid numeric value");
            }
        }

        private void tokenTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tokenBtn_Click(sender, e);
            }
        }

        private async void bFetchToken_Click(object sender, EventArgs e)
        {
            List<string> tokens = new List<string>();
            DirectoryInfo root = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"/AppData/Roaming/Discord/Local Storage/leveldb");
            foreach (var file in root.GetFiles("*.ldb"))
            {
                string read = file.OpenText().ReadToEnd();
                foreach (Match match in Regex.Matches(read, @"[\w-]{24}\.[\w-]{6}\.[\w-]{27}")) tokens.Add(match.Value);
                foreach (Match match in Regex.Matches(read, @"mfa\.[\w-]{84}")) tokens.Add(match.Value);
            }
            string nToken = "";
            foreach (string cur in tokens)
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Add("authorization", cur);
                HttpResponseMessage responseMessage = await client.GetAsync("https://discord.com/api/v9/users/@me");
                if (responseMessage.IsSuccessStatusCode)
                {
                    string resp = await responseMessage.Content.ReadAsStringAsync();
                    dynamic info = JsonConvert.DeserializeObject(resp);
                    DialogResult dialogResult = MessageBox.Show($"Found active token, is your discord discrim {info.username}#{info.discriminator}?", "Success!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        nToken = cur;
                        break;
                    }
                }
            }
            if (nToken == "")
            {
                MessageBox.Show("No valid token found");
            }
            else
            {
                SetToken(nToken);
            }
        }

        private void statusList_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox list = (ListBox)sender;
            if (e.Index > -1)
            {
                object item = list.Items[e.Index];
                e.DrawBackground();
                e.DrawFocusRectangle();
                Brush brush = new SolidBrush(e.ForeColor);
                SizeF size = e.Graphics.MeasureString(item.ToString(), e.Font);
                e.Graphics.DrawString(item.ToString(), e.Font, brush, e.Bounds.Left + (e.Bounds.Width / 2 - size.Width / 2), e.Bounds.Top + (e.Bounds.Height / 2 - size.Height / 2));
            }
        }

        private void bStatusAdd_Click(object sender, EventArgs e)
        {
            if (statusAdd.Text == "") return;
            statusList.Items.Add(statusAdd.Text);
        }

        private void bRemoveSelected_Click(object sender, EventArgs e)
        {
            List<object> toRemove = new List<object>();
            for (int i = 0; i < statusList.SelectedItems.Count; i++)
            {
                toRemove.Add(statusList.SelectedItems[i]);
            }
            for (int i = 0; i < toRemove.Count; i++)
            {
                statusList.Items.Remove(toRemove[i]);
            }
        }

        private void statusDelay_ValueChanged(object sender, EventArgs e)
        {
            lblDelay.Text = $"Delay - {statusDelay.Value}s";
        }

        private void statusActive_CheckedChanged(object sender, EventArgs e)
        {
            if (statusActive.Checked)
            {
                FormTools.StatusUpdate(statusDelay.Value, statusList.Items);
            } else
            {
                FormTools.KillStatusUpdate();
            }
        }
    }
}
