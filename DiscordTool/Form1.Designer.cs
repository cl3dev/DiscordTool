
namespace DiscordTool
{
    partial class Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bRemoveSelected = new System.Windows.Forms.Button();
            this.bStatusAdd = new System.Windows.Forms.Button();
            this.statusAdd = new System.Windows.Forms.TextBox();
            this.statusList = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bFetchToken = new System.Windows.Forms.Button();
            this.tokenBtn = new System.Windows.Forms.Button();
            this.tokenTxt = new System.Windows.Forms.TextBox();
            this.statusActive = new System.Windows.Forms.CheckBox();
            this.statusDelay = new System.Windows.Forms.TrackBar();
            this.lblDelay = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // notify
            // 
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "DiscordTool";
            this.notify.Click += new System.EventHandler(this.notify_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(803, 449);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDelay);
            this.groupBox2.Controls.Add(this.statusDelay);
            this.groupBox2.Controls.Add(this.statusActive);
            this.groupBox2.Controls.Add(this.bRemoveSelected);
            this.groupBox2.Controls.Add(this.bStatusAdd);
            this.groupBox2.Controls.Add(this.statusAdd);
            this.groupBox2.Controls.Add(this.statusList);
            this.groupBox2.Location = new System.Drawing.Point(19, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 194);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status Ticker";
            // 
            // bRemoveSelected
            // 
            this.bRemoveSelected.Location = new System.Drawing.Point(6, 120);
            this.bRemoveSelected.Name = "bRemoveSelected";
            this.bRemoveSelected.Size = new System.Drawing.Size(317, 23);
            this.bRemoveSelected.TabIndex = 3;
            this.bRemoveSelected.Text = "Remove Selected";
            this.bRemoveSelected.UseVisualStyleBackColor = true;
            this.bRemoveSelected.Click += new System.EventHandler(this.bRemoveSelected_Click);
            // 
            // bStatusAdd
            // 
            this.bStatusAdd.Location = new System.Drawing.Point(240, 94);
            this.bStatusAdd.Name = "bStatusAdd";
            this.bStatusAdd.Size = new System.Drawing.Size(82, 20);
            this.bStatusAdd.TabIndex = 2;
            this.bStatusAdd.Text = "Add";
            this.bStatusAdd.UseVisualStyleBackColor = true;
            this.bStatusAdd.Click += new System.EventHandler(this.bStatusAdd_Click);
            // 
            // statusAdd
            // 
            this.statusAdd.Location = new System.Drawing.Point(6, 94);
            this.statusAdd.Name = "statusAdd";
            this.statusAdd.Size = new System.Drawing.Size(235, 20);
            this.statusAdd.TabIndex = 1;
            // 
            // statusList
            // 
            this.statusList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.statusList.FormattingEnabled = true;
            this.statusList.Location = new System.Drawing.Point(6, 19);
            this.statusList.Name = "statusList";
            this.statusList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.statusList.Size = new System.Drawing.Size(317, 69);
            this.statusList.TabIndex = 0;
            this.statusList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.statusList_DrawItem);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DM\'s";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DimGray;
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(795, 423);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bFetchToken);
            this.groupBox1.Controls.Add(this.tokenBtn);
            this.groupBox1.Controls.Add(this.tokenTxt);
            this.groupBox1.Location = new System.Drawing.Point(18, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Token";
            // 
            // bFetchToken
            // 
            this.bFetchToken.Location = new System.Drawing.Point(6, 88);
            this.bFetchToken.Name = "bFetchToken";
            this.bFetchToken.Size = new System.Drawing.Size(204, 23);
            this.bFetchToken.TabIndex = 1;
            this.bFetchToken.Text = "Fetch automatically";
            this.bFetchToken.UseVisualStyleBackColor = true;
            this.bFetchToken.Click += new System.EventHandler(this.bFetchToken_Click);
            // 
            // tokenBtn
            // 
            this.tokenBtn.Location = new System.Drawing.Point(6, 59);
            this.tokenBtn.Name = "tokenBtn";
            this.tokenBtn.Size = new System.Drawing.Size(204, 23);
            this.tokenBtn.TabIndex = 1;
            this.tokenBtn.Text = "Submit";
            this.tokenBtn.UseVisualStyleBackColor = true;
            this.tokenBtn.Click += new System.EventHandler(this.tokenBtn_Click);
            // 
            // tokenTxt
            // 
            this.tokenTxt.Location = new System.Drawing.Point(6, 33);
            this.tokenTxt.Name = "tokenTxt";
            this.tokenTxt.Size = new System.Drawing.Size(204, 20);
            this.tokenTxt.TabIndex = 0;
            this.tokenTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tokenTxt_KeyDown);
            this.tokenTxt.Validating += new System.ComponentModel.CancelEventHandler(this.tokenTxt_Validating);
            // 
            // statusActive
            // 
            this.statusActive.AutoSize = true;
            this.statusActive.Location = new System.Drawing.Point(6, 144);
            this.statusActive.Name = "statusActive";
            this.statusActive.Size = new System.Drawing.Size(65, 17);
            this.statusActive.TabIndex = 1;
            this.statusActive.Text = "Enabled";
            this.statusActive.UseVisualStyleBackColor = true;
            this.statusActive.CheckedChanged += new System.EventHandler(this.statusActive_CheckedChanged);
            // 
            // statusDelay
            // 
            this.statusDelay.BackColor = System.Drawing.Color.DimGray;
            this.statusDelay.Location = new System.Drawing.Point(77, 142);
            this.statusDelay.Maximum = 20;
            this.statusDelay.Minimum = 5;
            this.statusDelay.Name = "statusDelay";
            this.statusDelay.Size = new System.Drawing.Size(246, 45);
            this.statusDelay.TabIndex = 4;
            this.statusDelay.Value = 5;
            this.statusDelay.ValueChanged += new System.EventHandler(this.statusDelay_ValueChanged);
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(173, 174);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(54, 13);
            this.lblDelay.TabIndex = 2;
            this.lblDelay.Text = "Delay - 5s";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiscordTool";
            this.Resize += new System.EventHandler(this.Window_Resize);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusDelay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button tokenBtn;
        private System.Windows.Forms.TextBox tokenTxt;
        private System.Windows.Forms.Button bFetchToken;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bRemoveSelected;
        private System.Windows.Forms.Button bStatusAdd;
        private System.Windows.Forms.TextBox statusAdd;
        private System.Windows.Forms.ListBox statusList;
        private System.Windows.Forms.TrackBar statusDelay;
        private System.Windows.Forms.CheckBox statusActive;
        private System.Windows.Forms.Label lblDelay;
    }
}

