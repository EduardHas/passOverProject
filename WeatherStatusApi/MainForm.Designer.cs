namespace WeatherStatusApi
{
    partial class MainForm
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
            this.Start_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.getTempFromFile_btn = new System.Windows.Forms.Button();
            this.City_textBox = new System.Windows.Forms.TextBox();
            this.RefRet_textBox = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.AddTolList_btn = new System.Windows.Forms.Button();
            this.Listed_City_textBox = new System.Windows.Forms.TextBox();
            this.DictionaryTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.TempOutput_Tb = new System.Windows.Forms.TextBox();
            this.CityInput_Tb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Start_btn
            // 
            this.Start_btn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Start_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Start_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start_btn.Font = new System.Drawing.Font("Narkisim", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Start_btn.Location = new System.Drawing.Point(34, 49);
            this.Start_btn.Name = "Start_btn";
            this.Start_btn.Size = new System.Drawing.Size(263, 155);
            this.Start_btn.TabIndex = 0;
            this.Start_btn.Text = "Start Atuo Request";
            this.Start_btn.UseVisualStyleBackColor = false;
            this.Start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.stop_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stop_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stop_btn.Font = new System.Drawing.Font("Narkisim", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.stop_btn.Location = new System.Drawing.Point(34, 240);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(263, 155);
            this.stop_btn.TabIndex = 1;
            this.stop_btn.Text = "Stop Atuo Request";
            this.stop_btn.UseVisualStyleBackColor = false;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // getTempFromFile_btn
            // 
            this.getTempFromFile_btn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.getTempFromFile_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.getTempFromFile_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getTempFromFile_btn.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.getTempFromFile_btn.Location = new System.Drawing.Point(34, 441);
            this.getTempFromFile_btn.Name = "getTempFromFile_btn";
            this.getTempFromFile_btn.Size = new System.Drawing.Size(263, 140);
            this.getTempFromFile_btn.TabIndex = 2;
            this.getTempFromFile_btn.Text = "Get Current Temperature From File";
            this.getTempFromFile_btn.UseVisualStyleBackColor = false;
            this.getTempFromFile_btn.Click += new System.EventHandler(this.getTempFromFile_btn_Click);
            // 
            // City_textBox
            // 
            this.City_textBox.AllowDrop = true;
            this.City_textBox.BackColor = System.Drawing.SystemColors.Menu;
            this.City_textBox.Font = new System.Drawing.Font("Narkisim", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.City_textBox.Location = new System.Drawing.Point(359, 67);
            this.City_textBox.Name = "City_textBox";
            this.City_textBox.ShortcutsEnabled = false;
            this.City_textBox.Size = new System.Drawing.Size(446, 31);
            this.City_textBox.TabIndex = 3;
            this.City_textBox.Tag = "";
            this.City_textBox.Text = "Wirte  City You look for *Here*";
            this.City_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.City_textBox.TextChanged += new System.EventHandler(this.City_textBox_TextChanged);
            // 
            // RefRet_textBox
            // 
            this.RefRet_textBox.BackColor = System.Drawing.SystemColors.Menu;
            this.RefRet_textBox.Font = new System.Drawing.Font("Narkisim", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RefRet_textBox.Location = new System.Drawing.Point(879, 63);
            this.RefRet_textBox.Name = "RefRet_textBox";
            this.RefRet_textBox.Size = new System.Drawing.Size(622, 35);
            this.RefRet_textBox.TabIndex = 4;
            this.RefRet_textBox.Text = "Wirte Refresh rate for Weather information";
            this.RefRet_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.numericUpDown1.Location = new System.Drawing.Point(1129, 112);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 35);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Tag = "sec";
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(54, 613);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1432, 32);
            this.progressBar1.TabIndex = 7;
            this.progressBar1.Visible = false;
            // 
            // AddTolList_btn
            // 
            this.AddTolList_btn.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.AddTolList_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddTolList_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTolList_btn.Font = new System.Drawing.Font("Narkisim", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AddTolList_btn.Location = new System.Drawing.Point(34, 676);
            this.AddTolList_btn.Name = "AddTolList_btn";
            this.AddTolList_btn.Size = new System.Drawing.Size(263, 111);
            this.AddTolList_btn.TabIndex = 8;
            this.AddTolList_btn.Text = "Add Into the List";
            this.AddTolList_btn.UseVisualStyleBackColor = false;
            this.AddTolList_btn.Click += new System.EventHandler(this.AddTolList_btn_Click);
            // 
            // Listed_City_textBox
            // 
            this.Listed_City_textBox.BackColor = System.Drawing.SystemColors.Menu;
            this.Listed_City_textBox.Font = new System.Drawing.Font("Narkisim", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Listed_City_textBox.Location = new System.Drawing.Point(402, 717);
            this.Listed_City_textBox.Name = "Listed_City_textBox";
            this.Listed_City_textBox.Size = new System.Drawing.Size(446, 31);
            this.Listed_City_textBox.TabIndex = 9;
            this.Listed_City_textBox.Text = "Wirte  City You look for *Here*";
            this.Listed_City_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DictionaryTableLayoutPanel
            // 
            this.DictionaryTableLayoutPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.DictionaryTableLayoutPanel.ColumnCount = 2;
            this.DictionaryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DictionaryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DictionaryTableLayoutPanel.Location = new System.Drawing.Point(330, 838);
            this.DictionaryTableLayoutPanel.Name = "DictionaryTableLayoutPanel";
            this.DictionaryTableLayoutPanel.RowCount = 2;
            this.DictionaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DictionaryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DictionaryTableLayoutPanel.Size = new System.Drawing.Size(697, 126);
            this.DictionaryTableLayoutPanel.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Narkisim", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(1223, 894);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 111);
            this.button2.TabIndex = 11;
            this.button2.Text = "Refersh List";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // TempOutput_Tb
            // 
            this.TempOutput_Tb.AccessibleName = "";
            this.TempOutput_Tb.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.TempOutput_Tb.Location = new System.Drawing.Point(547, 513);
            this.TempOutput_Tb.Name = "TempOutput_Tb";
            this.TempOutput_Tb.ReadOnly = true;
            this.TempOutput_Tb.Size = new System.Drawing.Size(321, 26);
            this.TempOutput_Tb.TabIndex = 12;
            this.TempOutput_Tb.TextChanged += new System.EventHandler(this.TempOutput_Tb_TextChanged);
            // 
            // CityInput_Tb
            // 
            this.CityInput_Tb.AllowDrop = true;
            this.CityInput_Tb.BackColor = System.Drawing.SystemColors.Menu;
            this.CityInput_Tb.Font = new System.Drawing.Font("Narkisim", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CityInput_Tb.Location = new System.Drawing.Point(359, 112);
            this.CityInput_Tb.Name = "CityInput_Tb";
            this.CityInput_Tb.ShortcutsEnabled = false;
            this.CityInput_Tb.Size = new System.Drawing.Size(446, 31);
            this.CityInput_Tb.TabIndex = 13;
            this.CityInput_Tb.Tag = "";
            this.CityInput_Tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CityInput_Tb.TextChanged += new System.EventHandler(this.CityInput_Tb_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1711, 1017);
            this.Controls.Add(this.CityInput_Tb);
            this.Controls.Add(this.TempOutput_Tb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DictionaryTableLayoutPanel);
            this.Controls.Add(this.Listed_City_textBox);
            this.Controls.Add(this.AddTolList_btn);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.RefRet_textBox);
            this.Controls.Add(this.City_textBox);
            this.Controls.Add(this.getTempFromFile_btn);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.Start_btn);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Button getTempFromFile_btn;
        private System.Windows.Forms.TextBox RefRet_textBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button AddTolList_btn;
        private System.Windows.Forms.TextBox Listed_City_textBox;
        private System.Windows.Forms.TableLayoutPanel DictionaryTableLayoutPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TempOutput_Tb;
        private System.Windows.Forms.TextBox City_textBox;
        private System.Windows.Forms.TextBox CityInput_Tb;
    }
}

