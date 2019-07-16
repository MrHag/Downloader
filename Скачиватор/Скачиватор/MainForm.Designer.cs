namespace Скачиватор
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Bodymenu = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.URL_design_link = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.result_url = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.subdomen_text = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.port_number = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.toogleServer_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.connection_tunnelserver_status = new System.Windows.Forms.Label();
            this.connection_tunnelserver_text = new System.Windows.Forms.Label();
            this.connection_server_status = new System.Windows.Forms.Label();
            this.connection_server_text = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.start_tunnelserver_status = new System.Windows.Forms.Label();
            this.start_tunnelserver_text = new System.Windows.Forms.Label();
            this.start_server_status = new System.Windows.Forms.Label();
            this.start_server_text = new System.Windows.Forms.Label();
            this.refresh_button = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.defaultFolder_check = new System.Windows.Forms.CheckBox();
            this.Directory_text = new System.Windows.Forms.TextBox();
            this.OpenFolder_button = new System.Windows.Forms.Button();
            this.refresh_files = new System.Windows.Forms.Button();
            this.FilesList = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.GlobalProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.GlobalStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.FilesList_contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Bodymenu.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.port_number)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.FilesList_contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(608, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Bodymenu
            // 
            this.Bodymenu.Controls.Add(this.tabPage2);
            this.Bodymenu.Controls.Add(this.tabPage3);
            this.Bodymenu.Location = new System.Drawing.Point(0, 28);
            this.Bodymenu.Name = "Bodymenu";
            this.Bodymenu.SelectedIndex = 0;
            this.Bodymenu.Size = new System.Drawing.Size(608, 368);
            this.Bodymenu.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(600, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Сервер";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox3.Controls.Add(this.URL_design_link);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.result_url);
            this.groupBox3.Location = new System.Drawing.Point(6, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(588, 136);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Результат";
            // 
            // URL_design_link
            // 
            this.URL_design_link.AutoSize = true;
            this.URL_design_link.Location = new System.Drawing.Point(71, 71);
            this.URL_design_link.Name = "URL_design_link";
            this.URL_design_link.Size = new System.Drawing.Size(51, 13);
            this.URL_design_link.TabIndex = 7;
            this.URL_design_link.TabStop = true;
            this.URL_design_link.Text = "Открыть";
            this.URL_design_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.URL_design_link_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ссылка: ";
            // 
            // result_url
            // 
            this.result_url.Location = new System.Drawing.Point(72, 38);
            this.result_url.Name = "result_url";
            this.result_url.ReadOnly = true;
            this.result_url.Size = new System.Drawing.Size(239, 20);
            this.result_url.TabIndex = 0;
            this.result_url.Text = "URL";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.subdomen_text);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.port_number);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.toogleServer_button);
            this.groupBox2.Location = new System.Drawing.Point(319, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 188);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сервер";
            // 
            // subdomen_text
            // 
            this.subdomen_text.Location = new System.Drawing.Point(82, 25);
            this.subdomen_text.Name = "subdomen_text";
            this.subdomen_text.Size = new System.Drawing.Size(186, 20);
            this.subdomen_text.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Субдомен: ";
            // 
            // port_number
            // 
            this.port_number.Location = new System.Drawing.Point(83, 57);
            this.port_number.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.port_number.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.port_number.Name = "port_number";
            this.port_number.Size = new System.Drawing.Size(69, 20);
            this.port_number.TabIndex = 3;
            this.port_number.ThousandsSeparator = true;
            this.port_number.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Порт:";
            // 
            // toogleServer_button
            // 
            this.toogleServer_button.Location = new System.Drawing.Point(102, 103);
            this.toogleServer_button.Name = "toogleServer_button";
            this.toogleServer_button.Size = new System.Drawing.Size(75, 23);
            this.toogleServer_button.TabIndex = 0;
            this.toogleServer_button.Text = "Запустить";
            this.toogleServer_button.UseVisualStyleBackColor = true;
            this.toogleServer_button.Click += new System.EventHandler(this.toogleServer_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.refresh_button);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 188);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox5.Controls.Add(this.connection_tunnelserver_status);
            this.groupBox5.Controls.Add(this.connection_tunnelserver_text);
            this.groupBox5.Controls.Add(this.connection_server_status);
            this.groupBox5.Controls.Add(this.connection_server_text);
            this.groupBox5.Location = new System.Drawing.Point(97, 103);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(204, 79);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Статус соединения";
            // 
            // connection_tunnelserver_status
            // 
            this.connection_tunnelserver_status.AutoSize = true;
            this.connection_tunnelserver_status.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connection_tunnelserver_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.connection_tunnelserver_status.Location = new System.Drawing.Point(131, 45);
            this.connection_tunnelserver_status.Name = "connection_tunnelserver_status";
            this.connection_tunnelserver_status.Size = new System.Drawing.Size(50, 18);
            this.connection_tunnelserver_status.TabIndex = 4;
            this.connection_tunnelserver_status.Text = "STATUS";
            // 
            // connection_tunnelserver_text
            // 
            this.connection_tunnelserver_text.AutoSize = true;
            this.connection_tunnelserver_text.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connection_tunnelserver_text.Location = new System.Drawing.Point(8, 44);
            this.connection_tunnelserver_text.Name = "connection_tunnelserver_text";
            this.connection_tunnelserver_text.Size = new System.Drawing.Size(129, 18);
            this.connection_tunnelserver_text.TabIndex = 3;
            this.connection_tunnelserver_text.Text = "Тунельный сервер: ";
            // 
            // connection_server_status
            // 
            this.connection_server_status.AutoSize = true;
            this.connection_server_status.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connection_server_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.connection_server_status.Location = new System.Drawing.Point(61, 20);
            this.connection_server_status.Name = "connection_server_status";
            this.connection_server_status.Size = new System.Drawing.Size(50, 18);
            this.connection_server_status.TabIndex = 2;
            this.connection_server_status.Text = "STATUS";
            // 
            // connection_server_text
            // 
            this.connection_server_text.AutoSize = true;
            this.connection_server_text.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connection_server_text.Location = new System.Drawing.Point(7, 19);
            this.connection_server_text.Name = "connection_server_text";
            this.connection_server_text.Size = new System.Drawing.Size(60, 18);
            this.connection_server_text.TabIndex = 1;
            this.connection_server_text.Text = "Сервер: ";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox4.Controls.Add(this.start_tunnelserver_status);
            this.groupBox4.Controls.Add(this.start_tunnelserver_text);
            this.groupBox4.Controls.Add(this.start_server_status);
            this.groupBox4.Controls.Add(this.start_server_text);
            this.groupBox4.Location = new System.Drawing.Point(97, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(204, 79);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Статус запуска";
            // 
            // start_tunnelserver_status
            // 
            this.start_tunnelserver_status.AutoSize = true;
            this.start_tunnelserver_status.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_tunnelserver_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.start_tunnelserver_status.Location = new System.Drawing.Point(131, 45);
            this.start_tunnelserver_status.Name = "start_tunnelserver_status";
            this.start_tunnelserver_status.Size = new System.Drawing.Size(50, 18);
            this.start_tunnelserver_status.TabIndex = 4;
            this.start_tunnelserver_status.Text = "STATUS";
            // 
            // start_tunnelserver_text
            // 
            this.start_tunnelserver_text.AutoSize = true;
            this.start_tunnelserver_text.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_tunnelserver_text.Location = new System.Drawing.Point(8, 44);
            this.start_tunnelserver_text.Name = "start_tunnelserver_text";
            this.start_tunnelserver_text.Size = new System.Drawing.Size(129, 18);
            this.start_tunnelserver_text.TabIndex = 3;
            this.start_tunnelserver_text.Text = "Тунельный сервер: ";
            // 
            // start_server_status
            // 
            this.start_server_status.AutoSize = true;
            this.start_server_status.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_server_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.start_server_status.Location = new System.Drawing.Point(61, 20);
            this.start_server_status.Name = "start_server_status";
            this.start_server_status.Size = new System.Drawing.Size(50, 18);
            this.start_server_status.TabIndex = 2;
            this.start_server_status.Text = "STATUS";
            // 
            // start_server_text
            // 
            this.start_server_text.AutoSize = true;
            this.start_server_text.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_server_text.Location = new System.Drawing.Point(7, 19);
            this.start_server_text.Name = "start_server_text";
            this.start_server_text.Size = new System.Drawing.Size(60, 18);
            this.start_server_text.TabIndex = 1;
            this.start_server_text.Text = "Сервер: ";
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(16, 28);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(75, 23);
            this.refresh_button.TabIndex = 0;
            this.refresh_button.Text = "Обновить";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.defaultFolder_check);
            this.tabPage3.Controls.Add(this.Directory_text);
            this.tabPage3.Controls.Add(this.OpenFolder_button);
            this.tabPage3.Controls.Add(this.refresh_files);
            this.tabPage3.Controls.Add(this.FilesList);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(600, 342);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Файлы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // defaultFolder_check
            // 
            this.defaultFolder_check.AutoSize = true;
            this.defaultFolder_check.Location = new System.Drawing.Point(329, 36);
            this.defaultFolder_check.Name = "defaultFolder_check";
            this.defaultFolder_check.Size = new System.Drawing.Size(205, 17);
            this.defaultFolder_check.TabIndex = 4;
            this.defaultFolder_check.Text = "Использовать папку по умолчанию";
            this.defaultFolder_check.UseVisualStyleBackColor = true;
            this.defaultFolder_check.CheckedChanged += new System.EventHandler(this.defaultFolder_check_CheckedChanged);
            // 
            // Directory_text
            // 
            this.Directory_text.AccessibleDescription = "";
            this.Directory_text.AccessibleName = "";
            this.Directory_text.Location = new System.Drawing.Point(7, 5);
            this.Directory_text.Name = "Directory_text";
            this.Directory_text.ReadOnly = true;
            this.Directory_text.Size = new System.Drawing.Size(294, 20);
            this.Directory_text.TabIndex = 3;
            // 
            // OpenFolder_button
            // 
            this.OpenFolder_button.Location = new System.Drawing.Point(327, 3);
            this.OpenFolder_button.Name = "OpenFolder_button";
            this.OpenFolder_button.Size = new System.Drawing.Size(94, 23);
            this.OpenFolder_button.TabIndex = 2;
            this.OpenFolder_button.Text = "Выбрать папку";
            this.OpenFolder_button.UseVisualStyleBackColor = true;
            this.OpenFolder_button.Click += new System.EventHandler(this.OpenFolder_button_Click);
            // 
            // refresh_files
            // 
            this.refresh_files.Location = new System.Drawing.Point(307, 141);
            this.refresh_files.Name = "refresh_files";
            this.refresh_files.Size = new System.Drawing.Size(75, 23);
            this.refresh_files.TabIndex = 1;
            this.refresh_files.Text = "Обновить";
            this.refresh_files.UseVisualStyleBackColor = true;
            this.refresh_files.Click += new System.EventHandler(this.refresh_files_Click);
            // 
            // FilesList
            // 
            this.FilesList.FormattingEnabled = true;
            this.FilesList.Location = new System.Drawing.Point(7, 31);
            this.FilesList.Name = "FilesList";
            this.FilesList.Size = new System.Drawing.Size(294, 303);
            this.FilesList.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GlobalProgressBar,
            this.GlobalStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(608, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // GlobalProgressBar
            // 
            this.GlobalProgressBar.Name = "GlobalProgressBar";
            this.GlobalProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // GlobalStatus
            // 
            this.GlobalStatus.Name = "GlobalStatus";
            this.GlobalStatus.Size = new System.Drawing.Size(43, 17);
            this.GlobalStatus.Text = "Статус";
            this.GlobalStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FilesList_contextMenu
            // 
            this.FilesList_contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem});
            this.FilesList_contextMenu.Name = "FilesList_contextMenu";
            this.FilesList_contextMenu.Size = new System.Drawing.Size(183, 48);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать ссылку";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 421);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Bodymenu);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Скачиватор";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Bodymenu.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.port_number)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.FilesList_contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabControl Bodymenu;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel GlobalStatus;
        private System.Windows.Forms.ToolStripProgressBar GlobalProgressBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown port_number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button toogleServer_button;
        private System.Windows.Forms.TextBox subdomen_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel URL_design_link;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox result_url;
        private System.Windows.Forms.ListBox FilesList;
        private System.Windows.Forms.Button refresh_files;
        private System.Windows.Forms.Button OpenFolder_button;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label connection_tunnelserver_status;
        private System.Windows.Forms.Label connection_tunnelserver_text;
        private System.Windows.Forms.Label connection_server_status;
        private System.Windows.Forms.Label connection_server_text;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label start_tunnelserver_status;
        private System.Windows.Forms.Label start_tunnelserver_text;
        private System.Windows.Forms.Label start_server_status;
        private System.Windows.Forms.Label start_server_text;
        private System.Windows.Forms.TextBox Directory_text;
        private System.Windows.Forms.CheckBox defaultFolder_check;
        private System.Windows.Forms.ContextMenuStrip FilesList_contextMenu;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
    }
}

