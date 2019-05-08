using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bukmacher
{
    public partial class BukmacherMainMenu : Form
    {
        private LinqToSql_DB_BukmacherDataContext dataBase;

        public BukmacherMainMenu()
        {
            dataBase = new LinqToSql_DB_BukmacherDataContext();
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.matchesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_BukmacherDataSet1);

        }

        private void BukmacherMainMenu_Load(object sender, EventArgs e)
        {
            this.matchesTableAdapter.FillByDate(dB_BukmacherDataSet1.Matches, DateTime.Today.ToString());
        }

        private void matchesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.matchesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_BukmacherDataSet1);

        }
        double kurs = 1;
        public int EnvironmentVariableTargetx { get; private set; }

        private void SaveBetButton_Click(object sender, EventArgs e)
        {
            Dane_Error.Text = "";
            if (IdTextBox.Text.Length > 0 && !Regex.IsMatch(IdTextBox.Text, @"^\d+$"))
            {

            }
            var result = from p in dataBase.Matches
                         where p.ID.ToString() == IdTextBox.Text
                         select p;

            if (result.Any())
            {
                if ((EnvironmentVariableTargetx = KuponListBox.FindString(IdTextBox.Text)) == -1)
                    if (TeamTextBox.Text == "1")
                    {
                        KuponListBox.Items.Add(result.First().ID.ToString() + "  " + result.First().Team1 + "  " + result.First()._1);
                        kurs = kurs * result.First()._1;
                        Kurs_wypis.Text = kurs.ToString();
                        IdTextBox.Text = "";
                        TeamTextBox.Text = "";
                    }
                    else if (TeamTextBox.Text == "2")
                    {
                        KuponListBox.Items.Add(result.First().ID.ToString() + "  " + result.First().Team2 + "  " + result.First()._2);
                        kurs = kurs * result.First()._2;
                        Kurs_wypis.Text = kurs.ToString();
                        IdTextBox.Text = "";
                        TeamTextBox.Text = "";
                    }
                    else if (TeamTextBox.Text == "X" || TeamTextBox.Text == "x")
                    {
                        KuponListBox.Items.Add(result.First().ID.ToString() + "  Remis  " + result.First().X);
                        kurs = kurs * result.First().X;
                        Kurs_wypis.Text = kurs.ToString();
                    }
                    else Dane_Error.Text = "Nieprawidłowa drużyna, wpisz 1, X lub 2.";
            }
            else Dane_Error.Text = "Nieprawidłowe ID";
            if (BetValueLabel.Text.Length > 0)
            {
                if (double.Parse(BetValueLabel.Text) >= 2)
                {
                    Kwota_wypis.Text = (double.Parse(BetValueLabel.Text) * kurs).ToString();
                    kwota_error.Text = "";
                }
                else
                    kwota_error.Text = "Minimalna kwota zakładu to 2 zł.";
            }
            else
                kwota_error.Text = "Podaj kwotę by zobaczyć przewidywaną wygraną i naciśnij ponownie 'Dodaj'!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(IdTextBox.Text.Length > 0 || !Regex.IsMatch(IdTextBox.Text, @"^\d+$"))
            {
                int index = KuponListBox.FindString(IdTextBox.Text);
                if (index != -1)
                {
                    KuponListBox.SetSelected(index, true);
                    string[] separators = { "  " };
                    string[] words = KuponListBox.SelectedItem.ToString().Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    kurs = kurs / double.Parse(words[2]);
                    Kurs_wypis.Text = kurs.ToString();
                    if (BetValueLabel.Text.Length>0)
                    Kwota_wypis.Text = (double.Parse(BetValueLabel.Text) * kurs).ToString();
                    KuponListBox.Items.Remove(KuponListBox.SelectedItem);
                    KuponListBox.Refresh();
                }
                
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files(*.txt) | *.txt | All Files(*.*) | *.*";
            saveFileDialog1.Title = "Save to a text file.";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog1.OpenFile());

                for (int i = 0; i < KuponListBox.Items.Count; i++)

                {

                    writer.WriteLine(KuponListBox.Items[i].ToString());

                }
                writer.WriteLine();
                writer.Write(label3.Text.ToString());
                writer.WriteLine(BetValueLabel.Text.ToString());
                writer.Write(KursLabel.Text.ToString());
                writer.WriteLine(Kurs_wypis.Text.ToString());
                writer.Write(TextKwota.Text.ToString());
                writer.Write(Kwota_wypis.Text.ToString());
                writer.Dispose();
                writer.Close();
                KuponListBox.Items.Clear();
                Kurs_wypis.Text = "0";
                kurs = 1;
                Kwota_wypis.Text = "0";
                
            }
        }
    }
}
