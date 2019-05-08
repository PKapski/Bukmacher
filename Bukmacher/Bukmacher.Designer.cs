using System;

namespace Bukmacher
{
    partial class BukmacherMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BukmacherMainMenu));
            this.BetValueLabel = new System.Windows.Forms.TextBox();
            this.TextKwota = new System.Windows.Forms.Label();
            this.Prize = new System.Windows.Forms.Label();
            this.matchesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_BukmacherDataSet1 = new Bukmacher.DB_BukmacherDataSet1();
            this.SaveBetButton = new System.Windows.Forms.Button();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.TeamTextBox = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.TeamLabel = new System.Windows.Forms.Label();
            this.KuponListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.KursLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Kurs_wypis = new System.Windows.Forms.Label();
            this.Kwota_wypis = new System.Windows.Forms.Label();
            this.kwota_error = new System.Windows.Forms.Label();
            this.RemoveBetButton = new System.Windows.Forms.Button();
            this.Dane_Error = new System.Windows.Forms.Label();
            this.KuponLabel = new System.Windows.Forms.Label();
            this.BukmacherLabel = new System.Windows.Forms.Label();
            this.matchesTableAdapter = new Bukmacher.DB_BukmacherDataSet1TableAdapters.MatchesTableAdapter();
            this.tableAdapterManager = new Bukmacher.DB_BukmacherDataSet1TableAdapters.TableAdapterManager();
            this.Savebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matchesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_BukmacherDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // BetValueLabel
            // 
            this.BetValueLabel.Location = new System.Drawing.Point(393, 475);
            this.BetValueLabel.Name = "BetValueLabel";
            this.BetValueLabel.Size = new System.Drawing.Size(179, 20);
            this.BetValueLabel.TabIndex = 0;
            // 
            // TextKwota
            // 
            this.TextKwota.AutoSize = true;
            this.TextKwota.BackColor = System.Drawing.Color.Transparent;
            this.TextKwota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextKwota.Location = new System.Drawing.Point(803, 473);
            this.TextKwota.Name = "TextKwota";
            this.TextKwota.Size = new System.Drawing.Size(163, 20);
            this.TextKwota.TabIndex = 1;
            this.TextKwota.Text = "Kwota do wygrania:";
            this.TextKwota.Click += new System.EventHandler(this.TextKwota_Click);
            // 
            // Prize
            // 
            this.Prize.AutoSize = true;
            this.Prize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Prize.Location = new System.Drawing.Point(760, 480);
            this.Prize.Name = "Prize";
            this.Prize.Size = new System.Drawing.Size(0, 20);
            this.Prize.TabIndex = 2;
            // 
            // matchesDataGridView
            // 
            this.matchesDataGridView.AutoGenerateColumns = false;
            this.matchesDataGridView.BackgroundColor = System.Drawing.Color.Wheat;
            this.matchesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matchesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.matchesDataGridView.DataSource = this.matchesBindingSource;
            this.matchesDataGridView.Location = new System.Drawing.Point(8, 39);
            this.matchesDataGridView.Name = "matchesDataGridView";
            this.matchesDataGridView.Size = new System.Drawing.Size(564, 414);
            this.matchesDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Sport";
            this.dataGridViewTextBoxColumn2.HeaderText = "Sport";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Team1";
            this.dataGridViewTextBoxColumn3.HeaderText = "Team1";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Team2";
            this.dataGridViewTextBoxColumn4.HeaderText = "Team2";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "1";
            this.dataGridViewTextBoxColumn5.HeaderText = "1";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 30;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "X";
            this.dataGridViewTextBoxColumn6.HeaderText = "X";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 30;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "2";
            this.dataGridViewTextBoxColumn7.HeaderText = "2";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 30;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Data spotkania";
            this.dataGridViewTextBoxColumn8.HeaderText = "Data spotkania";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // matchesBindingSource
            // 
            this.matchesBindingSource.DataMember = "Matches";
            this.matchesBindingSource.DataSource = this.dB_BukmacherDataSet1;
            // 
            // dB_BukmacherDataSet1
            // 
            this.dB_BukmacherDataSet1.DataSetName = "DB_BukmacherDataSet1";
            this.dB_BukmacherDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SaveBetButton
            // 
            this.SaveBetButton.BackColor = System.Drawing.Color.Tan;
            this.SaveBetButton.Location = new System.Drawing.Point(662, 265);
            this.SaveBetButton.Name = "SaveBetButton";
            this.SaveBetButton.Size = new System.Drawing.Size(129, 37);
            this.SaveBetButton.TabIndex = 5;
            this.SaveBetButton.Text = "Dodaj\r\n";
            this.SaveBetButton.UseVisualStyleBackColor = false;
            this.SaveBetButton.Click += new System.EventHandler(this.SaveBetButton_Click);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(607, 223);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(96, 20);
            this.IdTextBox.TabIndex = 6;
            // 
            // TeamTextBox
            // 
            this.TeamTextBox.Location = new System.Drawing.Point(737, 223);
            this.TeamTextBox.Name = "TeamTextBox";
            this.TeamTextBox.Size = new System.Drawing.Size(96, 20);
            this.TeamTextBox.TabIndex = 7;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IDLabel.Location = new System.Drawing.Point(640, 204);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(24, 18);
            this.IDLabel.TabIndex = 8;
            this.IDLabel.Text = "ID";
            // 
            // TeamLabel
            // 
            this.TeamLabel.AutoSize = true;
            this.TeamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TeamLabel.Location = new System.Drawing.Point(748, 203);
            this.TeamLabel.Name = "TeamLabel";
            this.TeamLabel.Size = new System.Drawing.Size(75, 20);
            this.TeamLabel.TabIndex = 9;
            this.TeamLabel.Text = "Drużyna";
            // 
            // KuponListBox
            // 
            this.KuponListBox.BackColor = System.Drawing.Color.BurlyWood;
            this.KuponListBox.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KuponListBox.FormattingEnabled = true;
            this.KuponListBox.ItemHeight = 18;
            this.KuponListBox.Location = new System.Drawing.Point(869, 53);
            this.KuponListBox.Name = "KuponListBox";
            this.KuponListBox.Size = new System.Drawing.Size(221, 364);
            this.KuponListBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(229, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Postawiona kwota:";
            // 
            // KursLabel
            // 
            this.KursLabel.AutoSize = true;
            this.KursLabel.BackColor = System.Drawing.Color.Transparent;
            this.KursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KursLabel.Location = new System.Drawing.Point(597, 473);
            this.KursLabel.Name = "KursLabel";
            this.KursLabel.Size = new System.Drawing.Size(129, 20);
            this.KursLabel.TabIndex = 13;
            this.KursLabel.Text = "Całkowity kurs:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(962, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 14;
            // 
            // Kurs_wypis
            // 
            this.Kurs_wypis.AutoSize = true;
            this.Kurs_wypis.BackColor = System.Drawing.Color.Transparent;
            this.Kurs_wypis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kurs_wypis.Location = new System.Drawing.Point(723, 473);
            this.Kurs_wypis.Name = "Kurs_wypis";
            this.Kurs_wypis.Size = new System.Drawing.Size(19, 20);
            this.Kurs_wypis.TabIndex = 15;
            this.Kurs_wypis.Text = "1";
            // 
            // Kwota_wypis
            // 
            this.Kwota_wypis.AutoSize = true;
            this.Kwota_wypis.BackColor = System.Drawing.Color.Transparent;
            this.Kwota_wypis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kwota_wypis.Location = new System.Drawing.Point(962, 473);
            this.Kwota_wypis.Name = "Kwota_wypis";
            this.Kwota_wypis.Size = new System.Drawing.Size(19, 20);
            this.Kwota_wypis.TabIndex = 16;
            this.Kwota_wypis.Text = "0";
            // 
            // kwota_error
            // 
            this.kwota_error.AutoSize = true;
            this.kwota_error.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kwota_error.ForeColor = System.Drawing.Color.Red;
            this.kwota_error.Location = new System.Drawing.Point(160, 504);
            this.kwota_error.Name = "kwota_error";
            this.kwota_error.Size = new System.Drawing.Size(0, 19);
            this.kwota_error.TabIndex = 17;
            // 
            // RemoveBetButton
            // 
            this.RemoveBetButton.BackColor = System.Drawing.Color.Tan;
            this.RemoveBetButton.Location = new System.Drawing.Point(662, 323);
            this.RemoveBetButton.Name = "RemoveBetButton";
            this.RemoveBetButton.Size = new System.Drawing.Size(129, 60);
            this.RemoveBetButton.TabIndex = 18;
            this.RemoveBetButton.Text = "Usuń z kuponu mecz o podanym ID";
            this.RemoveBetButton.UseVisualStyleBackColor = false;
            this.RemoveBetButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dane_Error
            // 
            this.Dane_Error.AutoSize = true;
            this.Dane_Error.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dane_Error.ForeColor = System.Drawing.Color.Red;
            this.Dane_Error.Location = new System.Drawing.Point(578, 247);
            this.Dane_Error.Name = "Dane_Error";
            this.Dane_Error.Size = new System.Drawing.Size(0, 15);
            this.Dane_Error.TabIndex = 19;
            // 
            // KuponLabel
            // 
            this.KuponLabel.AutoSize = true;
            this.KuponLabel.BackColor = System.Drawing.Color.Transparent;
            this.KuponLabel.Font = new System.Drawing.Font("Tele-Marines", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KuponLabel.Location = new System.Drawing.Point(908, 25);
            this.KuponLabel.Name = "KuponLabel";
            this.KuponLabel.Size = new System.Drawing.Size(152, 25);
            this.KuponLabel.TabIndex = 20;
            this.KuponLabel.Text = "KUPON";
            // 
            // BukmacherLabel
            // 
            this.BukmacherLabel.AutoSize = true;
            this.BukmacherLabel.BackColor = System.Drawing.Color.Transparent;
            this.BukmacherLabel.Font = new System.Drawing.Font("Modern No. 20", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BukmacherLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.BukmacherLabel.Location = new System.Drawing.Point(592, 71);
            this.BukmacherLabel.Name = "BukmacherLabel";
            this.BukmacherLabel.Size = new System.Drawing.Size(257, 50);
            this.BukmacherLabel.TabIndex = 21;
            this.BukmacherLabel.Text = "Bukmacher";
            // 
            // matchesTableAdapter
            // 
            this.matchesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Bukmacher.DB_BukmacherDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Savebutton
            // 
            this.Savebutton.BackColor = System.Drawing.Color.Tan;
            this.Savebutton.Location = new System.Drawing.Point(662, 393);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(129, 60);
            this.Savebutton.TabIndex = 22;
            this.Savebutton.Text = "Zapisz kupon do pliku";
            this.Savebutton.UseVisualStyleBackColor = false;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(975, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "By Piotr Kapski";
            // 
            // BukmacherMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(1116, 533);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.BukmacherLabel);
            this.Controls.Add(this.KuponLabel);
            this.Controls.Add(this.Dane_Error);
            this.Controls.Add(this.RemoveBetButton);
            this.Controls.Add(this.kwota_error);
            this.Controls.Add(this.Kwota_wypis);
            this.Controls.Add(this.Kurs_wypis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KursLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.KuponListBox);
            this.Controls.Add(this.TeamLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.TeamTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.SaveBetButton);
            this.Controls.Add(this.matchesDataGridView);
            this.Controls.Add(this.Prize);
            this.Controls.Add(this.TextKwota);
            this.Controls.Add(this.BetValueLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BukmacherMainMenu";
            this.Text = "Bukmacher";
            this.Load += new System.EventHandler(this.BukmacherMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matchesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_BukmacherDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TextKwota_Click(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.TextBox BetValueLabel;
        private System.Windows.Forms.Label TextKwota;
        private System.Windows.Forms.Label Prize;
        private DB_BukmacherDataSet1 dB_BukmacherDataSet1;
        private System.Windows.Forms.BindingSource matchesBindingSource;
        private DB_BukmacherDataSet1TableAdapters.MatchesTableAdapter matchesTableAdapter;
        private DB_BukmacherDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView matchesDataGridView;
        private System.Windows.Forms.Button SaveBetButton;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox TeamTextBox;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label TeamLabel;
        private System.Windows.Forms.ListBox KuponListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label KursLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Kurs_wypis;
        private System.Windows.Forms.Label Kwota_wypis;
        private System.Windows.Forms.Label kwota_error;
        private System.Windows.Forms.Button RemoveBetButton;
        private System.Windows.Forms.Label Dane_Error;
        private System.Windows.Forms.Label KuponLabel;
        private System.Windows.Forms.Label BukmacherLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Label label1;
    }
}

