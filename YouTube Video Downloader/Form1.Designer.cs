
namespace YouTube_Video_Downloader
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bgWorkerGetVideo = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Txt_url = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_start = new Guna.UI2.WinForms.Guna2Button();
            this.GrbVideoDetails = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Title = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbQuality = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Save_Path = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnBrowse = new Guna.UI2.WinForms.Guna2Button();
            this.AudioOnly_Checkbx = new System.Windows.Forms.CheckBox();
            this.btnDownload = new Guna.UI2.WinForms.Guna2Button();
            this.cmbAudioQuality = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.miniToolStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.DataProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabPage1.SuspendLayout();
            this.GrbVideoDetails.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgWorkerGetVideo
            // 
            this.bgWorkerGetVideo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerGetVideo_DoWork);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.progressBar1);
            this.tabPage1.Controls.Add(this.GrbVideoDetails);
            this.tabPage1.Controls.Add(this.btn_start);
            this.tabPage1.Controls.Add(this.Txt_url);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Download";
            // 
            // Txt_url
            // 
            this.Txt_url.BorderColor = System.Drawing.Color.White;
            this.Txt_url.BorderRadius = 10;
            this.Txt_url.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_url.DefaultText = "";
            this.Txt_url.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_url.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_url.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_url.DisabledState.Parent = this.Txt_url;
            this.Txt_url.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_url.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_url.FocusedState.Parent = this.Txt_url;
            this.Txt_url.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txt_url.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_url.HoverState.Parent = this.Txt_url;
            this.Txt_url.Location = new System.Drawing.Point(8, 6);
            this.Txt_url.Name = "Txt_url";
            this.Txt_url.PasswordChar = '\0';
            this.Txt_url.PlaceholderText = "";
            this.Txt_url.SelectedText = "";
            this.Txt_url.ShadowDecoration.Parent = this.Txt_url;
            this.Txt_url.Size = new System.Drawing.Size(755, 36);
            this.Txt_url.TabIndex = 0;
            this.Txt_url.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            this.Txt_url.Enter += new System.EventHandler(this.txtUrl_Enter);
            this.Txt_url.Leave += new System.EventHandler(this.Txt_url_Leave);
            // 
            // btn_start
            // 
            this.btn_start.BorderRadius = 20;
            this.btn_start.CheckedState.Parent = this.btn_start;
            this.btn_start.CustomImages.Parent = this.btn_start;
            this.btn_start.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_start.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_start.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_start.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_start.DisabledState.Parent = this.btn_start;
            this.btn_start.FillColor = System.Drawing.Color.SpringGreen;
            this.btn_start.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_start.ForeColor = System.Drawing.Color.White;
            this.btn_start.HoverState.Parent = this.btn_start;
            this.btn_start.Location = new System.Drawing.Point(643, 48);
            this.btn_start.Name = "btn_start";
            this.btn_start.PressedColor = System.Drawing.Color.IndianRed;
            this.btn_start.ShadowDecoration.Parent = this.btn_start;
            this.btn_start.Size = new System.Drawing.Size(120, 45);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // GrbVideoDetails
            // 
            this.GrbVideoDetails.BorderColor = System.Drawing.Color.Black;
            this.GrbVideoDetails.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.GrbVideoDetails.BorderThickness = 0;
            this.GrbVideoDetails.Controls.Add(this.label4);
            this.GrbVideoDetails.Controls.Add(this.cmbAudioQuality);
            this.GrbVideoDetails.Controls.Add(this.btnDownload);
            this.GrbVideoDetails.Controls.Add(this.AudioOnly_Checkbx);
            this.GrbVideoDetails.Controls.Add(this.btnBrowse);
            this.GrbVideoDetails.Controls.Add(this.Save_Path);
            this.GrbVideoDetails.Controls.Add(this.label3);
            this.GrbVideoDetails.Controls.Add(this.label2);
            this.GrbVideoDetails.Controls.Add(this.cmbQuality);
            this.GrbVideoDetails.Controls.Add(this.Txt_Title);
            this.GrbVideoDetails.Controls.Add(this.label1);
            this.GrbVideoDetails.CustomBorderColor = System.Drawing.Color.WhiteSmoke;
            this.GrbVideoDetails.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.GrbVideoDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.GrbVideoDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbVideoDetails.ForeColor = System.Drawing.Color.DodgerBlue;
            this.GrbVideoDetails.Location = new System.Drawing.Point(6, 99);
            this.GrbVideoDetails.Name = "GrbVideoDetails";
            this.GrbVideoDetails.ShadowDecoration.Parent = this.GrbVideoDetails;
            this.GrbVideoDetails.Size = new System.Drawing.Size(784, 273);
            this.GrbVideoDetails.TabIndex = 2;
            this.GrbVideoDetails.Text = "Download Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // Txt_Title
            // 
            this.Txt_Title.BorderRadius = 15;
            this.Txt_Title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Title.DefaultText = "";
            this.Txt_Title.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Txt_Title.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Txt_Title.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Title.DisabledState.Parent = this.Txt_Title;
            this.Txt_Title.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Txt_Title.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Title.FocusedState.Parent = this.Txt_Title;
            this.Txt_Title.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Txt_Title.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Txt_Title.HoverState.Parent = this.Txt_Title;
            this.Txt_Title.Location = new System.Drawing.Point(120, 47);
            this.Txt_Title.Name = "Txt_Title";
            this.Txt_Title.PasswordChar = '\0';
            this.Txt_Title.PlaceholderText = "";
            this.Txt_Title.SelectedText = "";
            this.Txt_Title.ShadowDecoration.Parent = this.Txt_Title;
            this.Txt_Title.Size = new System.Drawing.Size(540, 36);
            this.Txt_Title.TabIndex = 1;
            this.Txt_Title.TextChanged += new System.EventHandler(this.Txt_Title_TextChanged);
            // 
            // cmbQuality
            // 
            this.cmbQuality.BackColor = System.Drawing.Color.Transparent;
            this.cmbQuality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuality.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbQuality.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbQuality.FocusedState.Parent = this.cmbQuality;
            this.cmbQuality.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbQuality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbQuality.HoverState.Parent = this.cmbQuality;
            this.cmbQuality.ItemHeight = 30;
            this.cmbQuality.ItemsAppearance.Parent = this.cmbQuality;
            this.cmbQuality.Location = new System.Drawing.Point(120, 118);
            this.cmbQuality.Name = "cmbQuality";
            this.cmbQuality.ShadowDecoration.Parent = this.cmbQuality;
            this.cmbQuality.Size = new System.Drawing.Size(140, 36);
            this.cmbQuality.TabIndex = 2;
            this.cmbQuality.SelectedIndexChanged += new System.EventHandler(this.cmbQuality_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Video Quality";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Save To";
            // 
            // Save_Path
            // 
            this.Save_Path.BorderRadius = 15;
            this.Save_Path.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Save_Path.DefaultText = "";
            this.Save_Path.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Save_Path.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Save_Path.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Save_Path.DisabledState.Parent = this.Save_Path;
            this.Save_Path.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Save_Path.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Save_Path.FocusedState.Parent = this.Save_Path;
            this.Save_Path.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Save_Path.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Save_Path.HoverState.Parent = this.Save_Path;
            this.Save_Path.Location = new System.Drawing.Point(120, 211);
            this.Save_Path.Name = "Save_Path";
            this.Save_Path.PasswordChar = '\0';
            this.Save_Path.PlaceholderText = "";
            this.Save_Path.SelectedText = "";
            this.Save_Path.ShadowDecoration.Parent = this.Save_Path;
            this.Save_Path.Size = new System.Drawing.Size(540, 36);
            this.Save_Path.TabIndex = 5;
            this.Save_Path.TextChanged += new System.EventHandler(this.Save_Path_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnBrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowse.BackgroundImage")));
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBrowse.CheckedState.Parent = this.btnBrowse;
            this.btnBrowse.CustomImages.Parent = this.btnBrowse;
            this.btnBrowse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBrowse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBrowse.DisabledState.Parent = this.btnBrowse;
            this.btnBrowse.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.HoverState.Parent = this.btnBrowse;
            this.btnBrowse.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowse.Image")));
            this.btnBrowse.Location = new System.Drawing.Point(695, 211);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.ShadowDecoration.Parent = this.btnBrowse;
            this.btnBrowse.Size = new System.Drawing.Size(62, 36);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // AudioOnly_Checkbx
            // 
            this.AudioOnly_Checkbx.AutoSize = true;
            this.AudioOnly_Checkbx.Location = new System.Drawing.Point(534, 169);
            this.AudioOnly_Checkbx.Name = "AudioOnly_Checkbx";
            this.AudioOnly_Checkbx.Size = new System.Drawing.Size(97, 21);
            this.AudioOnly_Checkbx.TabIndex = 7;
            this.AudioOnly_Checkbx.Text = "Audio Only";
            this.AudioOnly_Checkbx.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            this.btnDownload.BorderRadius = 20;
            this.btnDownload.CheckedState.Parent = this.btnDownload;
            this.btnDownload.CustomImages.Parent = this.btnDownload;
            this.btnDownload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDownload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDownload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDownload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDownload.DisabledState.Parent = this.btnDownload;
            this.btnDownload.FillColor = System.Drawing.Color.SpringGreen;
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.HoverState.Parent = this.btnDownload;
            this.btnDownload.Location = new System.Drawing.Point(637, 160);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.PressedColor = System.Drawing.Color.IndianRed;
            this.btnDownload.ShadowDecoration.Parent = this.btnDownload;
            this.btnDownload.Size = new System.Drawing.Size(120, 45);
            this.btnDownload.TabIndex = 3;
            this.btnDownload.Text = "Download";
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // cmbAudioQuality
            // 
            this.cmbAudioQuality.BackColor = System.Drawing.Color.Transparent;
            this.cmbAudioQuality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAudioQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAudioQuality.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAudioQuality.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbAudioQuality.FocusedState.Parent = this.cmbAudioQuality;
            this.cmbAudioQuality.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbAudioQuality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbAudioQuality.HoverState.Parent = this.cmbAudioQuality;
            this.cmbAudioQuality.ItemHeight = 30;
            this.cmbAudioQuality.ItemsAppearance.Parent = this.cmbAudioQuality;
            this.cmbAudioQuality.Location = new System.Drawing.Point(520, 118);
            this.cmbAudioQuality.Name = "cmbAudioQuality";
            this.cmbAudioQuality.ShadowDecoration.Parent = this.cmbAudioQuality;
            this.cmbAudioQuality.Size = new System.Drawing.Size(140, 36);
            this.cmbAudioQuality.TabIndex = 8;
            this.cmbAudioQuality.SelectedIndexChanged += new System.EventHandler(this.cmbAudioQuality_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Audio Quality";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 378);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(787, 30);
            this.progressBar1.TabIndex = 3;
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AccessibleName = "New item selection";
            this.miniToolStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.Location = new System.Drawing.Point(1, 1);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(787, 22);
            this.miniToolStrip.TabIndex = 4;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Status
            // 
            this.Status.BackColor = System.Drawing.Color.White;
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 17);
            // 
            // DataProgress
            // 
            this.DataProgress.ActiveLinkColor = System.Drawing.Color.Red;
            this.DataProgress.BackColor = System.Drawing.Color.White;
            this.DataProgress.Name = "DataProgress";
            this.DataProgress.Size = new System.Drawing.Size(0, 17);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 478);
            this.tabControl1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Status,
            this.DataProgress});
            this.statusStrip1.Location = new System.Drawing.Point(3, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(787, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Youtube Video Downloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.GrbVideoDetails.ResumeLayout(false);
            this.GrbVideoDetails.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker bgWorkerGetVideo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Status;
        private System.Windows.Forms.ToolStripStatusLabel DataProgress;
        private System.Windows.Forms.ProgressBar progressBar1;
        private Guna.UI2.WinForms.Guna2GroupBox GrbVideoDetails;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cmbAudioQuality;
        private Guna.UI2.WinForms.Guna2Button btnDownload;
        private System.Windows.Forms.CheckBox AudioOnly_Checkbx;
        private Guna.UI2.WinForms.Guna2Button btnBrowse;
        private Guna.UI2.WinForms.Guna2TextBox Save_Path;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbQuality;
        private Guna.UI2.WinForms.Guna2TextBox Txt_Title;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_start;
        private Guna.UI2.WinForms.Guna2TextBox Txt_url;
        private System.Windows.Forms.StatusStrip miniToolStrip;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

