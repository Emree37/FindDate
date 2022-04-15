using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindDate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDayWeek.Items.Add("Günlük");
            cmbDayWeek.Items.Add("Haftalık");

        }

        private void cmbDayWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDayWeek.SelectedItem.ToString() == "Günlük")
            {
                cmbDayWeekCount.Items.Clear();
                for (int i = 1; i <= 31; i++)
                {
                    ComboboxItem comboboxItem = new ComboboxItem();
                    comboboxItem.Text = i + " Günlük";
                    comboboxItem.Value = i;
                    cmbDayWeekCount.Items.Add(comboboxItem);
                }
                ButtonDisable();
            }
            if (cmbDayWeek.SelectedItem.ToString() == "Haftalık")
            {
                cmbDayWeekCount.Items.Clear();
                for (int i = 1; i <= 8; i++)
                {
                    ComboboxItem comboboxItem = new ComboboxItem();
                    comboboxItem.Text = i + " Haftalık";
                    comboboxItem.Value = i;
                    cmbDayWeekCount.Items.Add(comboboxItem);
                }
                ButtonEnable();
            }
        }

        private void cmbDayWeekCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            FindDate();
        }

        private void FindDate()
        {
            List<string> selectedDays = new List<string>();
            selectedDays = SelectedDays();

            lstDays.Items.Clear();
            DateTime startDate = mcStartDate.SelectionRange.Start;
            DateTime endDate = mcEndDate.SelectionRange.Start;

            int x = (cmbDayWeekCount.SelectedItem as ComboboxItem).Value;



            if (cmbDayWeek.SelectedItem.ToString() == "Günlük")
            {
                for (DateTime dt = startDate; dt <= endDate; dt = dt.AddDays(x))
                {
                    lstDays.Items.Add(dt);
                }

            }

            if (cmbDayWeek.SelectedItem.ToString() == "Haftalık")
            {
                x = x * 7;
                DateTime firstDay = new DateTime();
                for (DateTime dt = startDate; dt <= startDate.AddDays(7); dt = dt.AddDays(1))
                {
                    foreach (var item in selectedDays)
                    {
                        if (dt.DayOfWeek.ToString() == item)
                        {
                            lstDays.Items.Add(dt);
                            firstDay = dt.AddDays(x);
                            while (firstDay <= endDate)
                            {
                                lstDays.Items.Add(firstDay);
                                firstDay = firstDay.AddDays(x);
                            }
                        }
                    }
                }

            }
        }

        private void ButtonColorCheck(object sender)
        {
            Button btn = sender as Button;
            if (btn.BackColor == SystemColors.Control)
            {
                btn.BackColor = Color.Red;
            }
            else
            {
                btn.BackColor = SystemColors.Control;
            }
        }

        private void ButtonDisable()
        {
            foreach (Button item in flpDays.Controls)
            {
                item.Enabled = false;    
            }
        }
        private void ButtonEnable()
        {
            foreach (Button item in flpDays.Controls)
            {
                item.Enabled = true;
            }
        }
        private List<string> SelectedDays()
        {
            List<string> selectedDays = new List<string>();
            foreach (Button item in flpDays.Controls)
            {
                if (item.BackColor == Color.Red)
                {
                    selectedDays.Add(item.Name);
                }
            }
            return selectedDays;
        }

        private void Monday_Click(object sender, EventArgs e)
        {
            if(cmbDayWeekCount.SelectedItem != null)
            {
                ButtonColorCheck(sender);
                FindDate();
            }
            else
            {
                MessageBox.Show("Hafta Aralığını Seçiniz");
            }
            
        }

        private void Tuesday_Click(object sender, EventArgs e)
        {
            if (cmbDayWeekCount.SelectedItem != null)
            {
                ButtonColorCheck(sender);
                FindDate();
            }
            else
            {
                MessageBox.Show("Hafta Aralığını Seçiniz");
            }
        }

        private void Wednesday_Click(object sender, EventArgs e)
        {
            if (cmbDayWeekCount.SelectedItem != null)
            {
                ButtonColorCheck(sender);
                FindDate();
            }
            else
            {
                MessageBox.Show("Hafta Aralığını Seçiniz");
            }
        }

        private void Thursday_Click(object sender, EventArgs e)
        {
            if (cmbDayWeekCount.SelectedItem != null)
            {
                ButtonColorCheck(sender);
                FindDate();
            }
            else
            {
                MessageBox.Show("Hafta Aralığını Seçiniz");
            }
        }

        private void Friday_Click(object sender, EventArgs e)
        {
            if (cmbDayWeekCount.SelectedItem != null)
            {
                ButtonColorCheck(sender);
                FindDate();
            }
            else
            {
                MessageBox.Show("Hafta Aralığını Seçiniz");
            }
        }

        private void Saturday_Click(object sender, EventArgs e)
        {
            if (cmbDayWeekCount.SelectedItem != null)
            {
                ButtonColorCheck(sender);
                FindDate();
            }
            else
            {
                MessageBox.Show("Hafta Aralığını Seçiniz");
            }
        }

        private void Sunday_Click(object sender, EventArgs e)
        {
            if (cmbDayWeekCount.SelectedItem != null)
            {
                ButtonColorCheck(sender);
                FindDate();
            }
            else
            {
                MessageBox.Show("Hafta Aralığını Seçiniz");
            }
        }
    }
}
