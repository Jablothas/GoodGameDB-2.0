namespace GoodGameDB
{
    partial class Database
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Database));
            this.Pnl_SubMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_ReloadData = new System.Windows.Forms.PictureBox();
            this.Note = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Pnl_Data_Splitter = new System.Windows.Forms.Panel();
            this.Pnl_Data = new System.Windows.Forms.Panel();
            this.Pnl_Info = new System.Windows.Forms.Panel();
            this.Pnl_ConfirmDelete = new System.Windows.Forms.Panel();
            this.Btn_AbortDelete = new System.Windows.Forms.Button();
            this.Btn_ConfirmDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Pnl_InfoData = new System.Windows.Forms.Panel();
            this.Pnl_SideMenu_Title = new System.Windows.Forms.Panel();
            this.Lbl_Title = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_Note = new System.Windows.Forms.Label();
            this.Pnl_InfoOptions = new System.Windows.Forms.Panel();
            this.Btn_Delete = new System.Windows.Forms.PictureBox();
            this.Btn_Edit = new System.Windows.Forms.PictureBox();
            this.Btn_Hide = new System.Windows.Forms.PictureBox();
            this.Lbl_PtCnt = new System.Windows.Forms.Label();
            this.Lbl_PtLocation = new System.Windows.Forms.Label();
            this.Lbl_PtDate = new System.Windows.Forms.Label();
            this.Pnl_InfoSplitter = new System.Windows.Forms.Panel();
            this.Pnl_SubMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_ReloadData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).BeginInit();
            this.Pnl_Info.SuspendLayout();
            this.Pnl_ConfirmDelete.SuspendLayout();
            this.Pnl_SideMenu_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Pnl_InfoOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Hide)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_SubMenu
            // 
            this.Pnl_SubMenu.BackColor = System.Drawing.Color.White;
            this.Pnl_SubMenu.Controls.Add(this.panel1);
            this.Pnl_SubMenu.Controls.Add(this.Note);
            this.Pnl_SubMenu.Controls.Add(this.Search);
            this.Pnl_SubMenu.Controls.Add(this.txtSearch);
            this.Pnl_SubMenu.Controls.Add(this.label4);
            this.Pnl_SubMenu.Controls.Add(this.label3);
            this.Pnl_SubMenu.Controls.Add(this.label2);
            this.Pnl_SubMenu.Controls.Add(this.label1);
            this.Pnl_SubMenu.Controls.Add(this.Pnl_Data_Splitter);
            this.Pnl_SubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_SubMenu.Location = new System.Drawing.Point(425, 0);
            this.Pnl_SubMenu.Name = "Pnl_SubMenu";
            this.Pnl_SubMenu.Size = new System.Drawing.Size(1100, 67);
            this.Pnl_SubMenu.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_ReloadData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1046, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(54, 64);
            this.panel1.TabIndex = 15;
            // 
            // Btn_ReloadData
            // 
            this.Btn_ReloadData.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ReloadData.Image")));
            this.Btn_ReloadData.Location = new System.Drawing.Point(16, 14);
            this.Btn_ReloadData.Name = "Btn_ReloadData";
            this.Btn_ReloadData.Size = new System.Drawing.Size(22, 22);
            this.Btn_ReloadData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_ReloadData.TabIndex = 14;
            this.Btn_ReloadData.TabStop = false;
            this.Btn_ReloadData.Click += new System.EventHandler(this.Btn_ReloadData_Click);
            // 
            // Note
            // 
            this.Note.AutoSize = true;
            this.Note.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Note.ForeColor = System.Drawing.Color.Black;
            this.Note.Location = new System.Drawing.Point(857, 43);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(44, 18);
            this.Note.TabIndex = 6;
            this.Note.Text = "Note";
            // 
            // Search
            // 
            this.Search.Image = global::GoodGameDB.Properties.Resources.search2;
            this.Search.Location = new System.Drawing.Point(488, 11);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(22, 22);
            this.Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Search.TabIndex = 0;
            this.Search.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(14, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(467, 22);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(750, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(550, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(150, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Game";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score";
            // 
            // Pnl_Data_Splitter
            // 
            this.Pnl_Data_Splitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Pnl_Data_Splitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_Data_Splitter.Location = new System.Drawing.Point(0, 64);
            this.Pnl_Data_Splitter.Name = "Pnl_Data_Splitter";
            this.Pnl_Data_Splitter.Size = new System.Drawing.Size(1100, 3);
            this.Pnl_Data_Splitter.TabIndex = 0;
            // 
            // Pnl_Data
            // 
            this.Pnl_Data.AutoScroll = true;
            this.Pnl_Data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Data.Location = new System.Drawing.Point(425, 67);
            this.Pnl_Data.Name = "Pnl_Data";
            this.Pnl_Data.Size = new System.Drawing.Size(1100, 808);
            this.Pnl_Data.TabIndex = 4;
            // 
            // Pnl_Info
            // 
            this.Pnl_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Pnl_Info.Controls.Add(this.Pnl_ConfirmDelete);
            this.Pnl_Info.Controls.Add(this.label8);
            this.Pnl_Info.Controls.Add(this.Pnl_InfoData);
            this.Pnl_Info.Controls.Add(this.Pnl_SideMenu_Title);
            this.Pnl_Info.Controls.Add(this.pictureBox2);
            this.Pnl_Info.Controls.Add(this.pictureBox1);
            this.Pnl_Info.Controls.Add(this.Lbl_Note);
            this.Pnl_Info.Controls.Add(this.Pnl_InfoOptions);
            this.Pnl_Info.Controls.Add(this.Lbl_PtCnt);
            this.Pnl_Info.Controls.Add(this.Lbl_PtLocation);
            this.Pnl_Info.Controls.Add(this.Lbl_PtDate);
            this.Pnl_Info.Controls.Add(this.Pnl_InfoSplitter);
            this.Pnl_Info.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl_Info.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Info.Name = "Pnl_Info";
            this.Pnl_Info.Size = new System.Drawing.Size(425, 875);
            this.Pnl_Info.TabIndex = 5;
            // 
            // Pnl_ConfirmDelete
            // 
            this.Pnl_ConfirmDelete.Controls.Add(this.Btn_AbortDelete);
            this.Pnl_ConfirmDelete.Controls.Add(this.Btn_ConfirmDelete);
            this.Pnl_ConfirmDelete.Controls.Add(this.label5);
            this.Pnl_ConfirmDelete.Location = new System.Drawing.Point(3, 805);
            this.Pnl_ConfirmDelete.Name = "Pnl_ConfirmDelete";
            this.Pnl_ConfirmDelete.Size = new System.Drawing.Size(403, 67);
            this.Pnl_ConfirmDelete.TabIndex = 0;
            this.Pnl_ConfirmDelete.Visible = false;
            // 
            // Btn_AbortDelete
            // 
            this.Btn_AbortDelete.Location = new System.Drawing.Point(96, 32);
            this.Btn_AbortDelete.Name = "Btn_AbortDelete";
            this.Btn_AbortDelete.Size = new System.Drawing.Size(75, 23);
            this.Btn_AbortDelete.TabIndex = 2;
            this.Btn_AbortDelete.Text = "No";
            this.Btn_AbortDelete.UseVisualStyleBackColor = true;
            this.Btn_AbortDelete.Click += new System.EventHandler(this.Btn_AbortDelete_Click);
            // 
            // Btn_ConfirmDelete
            // 
            this.Btn_ConfirmDelete.Location = new System.Drawing.Point(15, 32);
            this.Btn_ConfirmDelete.Name = "Btn_ConfirmDelete";
            this.Btn_ConfirmDelete.Size = new System.Drawing.Size(75, 23);
            this.Btn_ConfirmDelete.TabIndex = 1;
            this.Btn_ConfirmDelete.Text = "Yes";
            this.Btn_ConfirmDelete.UseVisualStyleBackColor = true;
            this.Btn_ConfirmDelete.Click += new System.EventHandler(this.Btn_ConfirmDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 14);
            this.label5.TabIndex = 0;
            this.label5.Text = "Do you really want delete this entry?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(20, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 14);
            this.label8.TabIndex = 14;
            this.label8.Text = "Playthrough Record";
            // 
            // Pnl_InfoData
            // 
            this.Pnl_InfoData.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_InfoData.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_InfoData.Location = new System.Drawing.Point(0, 33);
            this.Pnl_InfoData.Name = "Pnl_InfoData";
            this.Pnl_InfoData.Size = new System.Drawing.Size(420, 238);
            this.Pnl_InfoData.TabIndex = 1;
            // 
            // Pnl_SideMenu_Title
            // 
            this.Pnl_SideMenu_Title.Controls.Add(this.Lbl_Title);
            this.Pnl_SideMenu_Title.Controls.Add(this.label7);
            this.Pnl_SideMenu_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_SideMenu_Title.Location = new System.Drawing.Point(0, 0);
            this.Pnl_SideMenu_Title.Name = "Pnl_SideMenu_Title";
            this.Pnl_SideMenu_Title.Size = new System.Drawing.Size(420, 33);
            this.Pnl_SideMenu_Title.TabIndex = 13;
            // 
            // Lbl_Title
            // 
            this.Lbl_Title.AutoSize = true;
            this.Lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Title.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.Lbl_Title.Location = new System.Drawing.Point(82, 13);
            this.Lbl_Title.Name = "Lbl_Title";
            this.Lbl_Title.Size = new System.Drawing.Size(51, 16);
            this.Lbl_Title.TabIndex = 10;
            this.Lbl_Title.Text = "Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(20, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Stats of";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GoodGameDB.Properties.Resources.record_white;
            this.pictureBox2.Location = new System.Drawing.Point(320, 490);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GoodGameDB.Properties.Resources.note_white;
            this.pictureBox1.Location = new System.Drawing.Point(20, 278);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Lbl_Note
            // 
            this.Lbl_Note.AutoSize = true;
            this.Lbl_Note.ForeColor = System.Drawing.Color.White;
            this.Lbl_Note.Location = new System.Drawing.Point(56, 285);
            this.Lbl_Note.Name = "Lbl_Note";
            this.Lbl_Note.Size = new System.Drawing.Size(33, 14);
            this.Lbl_Note.TabIndex = 8;
            this.Lbl_Note.Text = "Test";
            // 
            // Pnl_InfoOptions
            // 
            this.Pnl_InfoOptions.Controls.Add(this.Btn_Delete);
            this.Pnl_InfoOptions.Controls.Add(this.Btn_Edit);
            this.Pnl_InfoOptions.Controls.Add(this.Btn_Hide);
            this.Pnl_InfoOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_InfoOptions.Location = new System.Drawing.Point(0, 811);
            this.Pnl_InfoOptions.Name = "Pnl_InfoOptions";
            this.Pnl_InfoOptions.Size = new System.Drawing.Size(420, 64);
            this.Pnl_InfoOptions.TabIndex = 6;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Delete.Image")));
            this.Btn_Delete.Location = new System.Drawing.Point(62, 22);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(30, 30);
            this.Btn_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_Delete.TabIndex = 2;
            this.Btn_Delete.TabStop = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.Image = global::GoodGameDB.Properties.Resources.edit_white;
            this.Btn_Edit.Location = new System.Drawing.Point(98, 22);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(30, 30);
            this.Btn_Edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_Edit.TabIndex = 1;
            this.Btn_Edit.TabStop = false;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Hide
            // 
            this.Btn_Hide.Image = global::GoodGameDB.Properties.Resources.hide_popup;
            this.Btn_Hide.Location = new System.Drawing.Point(12, 22);
            this.Btn_Hide.Name = "Btn_Hide";
            this.Btn_Hide.Size = new System.Drawing.Size(30, 30);
            this.Btn_Hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Btn_Hide.TabIndex = 0;
            this.Btn_Hide.TabStop = false;
            this.Btn_Hide.Click += new System.EventHandler(this.Btn_Hide_Click);
            // 
            // Lbl_PtCnt
            // 
            this.Lbl_PtCnt.AutoSize = true;
            this.Lbl_PtCnt.ForeColor = System.Drawing.Color.White;
            this.Lbl_PtCnt.Location = new System.Drawing.Point(20, 341);
            this.Lbl_PtCnt.Name = "Lbl_PtCnt";
            this.Lbl_PtCnt.Size = new System.Drawing.Size(19, 14);
            this.Lbl_PtCnt.TabIndex = 5;
            this.Lbl_PtCnt.Text = "1.";
            this.Lbl_PtCnt.Click += new System.EventHandler(this.Lbl_PtCnt_Click);
            // 
            // Lbl_PtLocation
            // 
            this.Lbl_PtLocation.AutoSize = true;
            this.Lbl_PtLocation.ForeColor = System.Drawing.Color.DarkGray;
            this.Lbl_PtLocation.Location = new System.Drawing.Point(130, 341);
            this.Lbl_PtLocation.Name = "Lbl_PtLocation";
            this.Lbl_PtLocation.Size = new System.Drawing.Size(47, 14);
            this.Lbl_PtLocation.TabIndex = 4;
            this.Lbl_PtLocation.Text = "Steam";
            this.Lbl_PtLocation.Click += new System.EventHandler(this.Lbl_PtLocation_Click);
            // 
            // Lbl_PtDate
            // 
            this.Lbl_PtDate.AutoSize = true;
            this.Lbl_PtDate.ForeColor = System.Drawing.Color.White;
            this.Lbl_PtDate.Location = new System.Drawing.Point(45, 341);
            this.Lbl_PtDate.Name = "Lbl_PtDate";
            this.Lbl_PtDate.Size = new System.Drawing.Size(79, 14);
            this.Lbl_PtDate.TabIndex = 3;
            this.Lbl_PtDate.Text = "19.01.1800";
            this.Lbl_PtDate.Click += new System.EventHandler(this.Lbl_PtDate_Click);
            // 
            // Pnl_InfoSplitter
            // 
            this.Pnl_InfoSplitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(255)))));
            this.Pnl_InfoSplitter.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnl_InfoSplitter.Location = new System.Drawing.Point(420, 0);
            this.Pnl_InfoSplitter.Name = "Pnl_InfoSplitter";
            this.Pnl_InfoSplitter.Size = new System.Drawing.Size(5, 875);
            this.Pnl_InfoSplitter.TabIndex = 0;
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1525, 875);
            this.Controls.Add(this.Pnl_Data);
            this.Controls.Add(this.Pnl_SubMenu);
            this.Controls.Add(this.Pnl_Info);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Database";
            this.Text = "Database";
            this.Pnl_SubMenu.ResumeLayout(false);
            this.Pnl_SubMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_ReloadData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Search)).EndInit();
            this.Pnl_Info.ResumeLayout(false);
            this.Pnl_Info.PerformLayout();
            this.Pnl_ConfirmDelete.ResumeLayout(false);
            this.Pnl_ConfirmDelete.PerformLayout();
            this.Pnl_SideMenu_Title.ResumeLayout(false);
            this.Pnl_SideMenu_Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Pnl_InfoOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Hide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel Pnl_SubMenu;
        private Panel Pnl_Data_Splitter;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Panel Pnl_Data;
        private PictureBox Search;
        private TextBox txtSearch;
        private Panel Pnl_Info;
        private Panel Pnl_InfoSplitter;
        private Panel Pnl_InfoData;
        private Label Lbl_PtLocation;
        private Label Lbl_PtDate;
        private Label Lbl_PtCnt;
        private Label label6;
        private Panel Pnl_InfoOptions;
        private PictureBox Btn_Hide;
        private Label Lbl_Note;
        private Label Lbl_Title;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label Note;
        private Panel Pnl_SideMenu_Title;
        private PictureBox Btn_Edit;
        private PictureBox Btn_Delete;
        private PictureBox Btn_ReloadData;
        private Panel panel1;
        private Panel Pnl_ConfirmDelete;
        private Button Btn_AbortDelete;
        private Button Btn_ConfirmDelete;
        private Label label5;
        private Label label7;
        private Label label8;
    }
}