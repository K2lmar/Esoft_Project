using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_Project
{
    public partial class FormRealtor : Form
    {
        public FormRealtor()
        {
            InitializeComponent();
            ShowRealtor();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            RealtorsSet realtorSet = new RealtorsSet();
            realtorSet.FirstName = textBoxFirstName.Text;
            realtorSet.MiddleName = textBoxMiddleName.Text;
            realtorSet.LastName = textBoxLastName.Text;
            realtorSet.DealShare = Convert.ToInt32(textBoxDealShare.Text);
            Program.wftDb.RealtorsSet.Add(realtorSet);
            Program.wftDb.SaveChanges();
            ShowRealtor();
        }
        void ShowRealtor()
        {
            listViewRealtor.Items.Clear();
            foreach (RealtorsSet realtorSet in Program.wftDb.RealtorsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                  realtorSet.Id.ToString(), realtorSet.FirstName, realtorSet.MiddleName,
                  realtorSet.LastName, realtorSet.DealShare.ToString()
                });
                item.Tag = realtorSet;
                listViewRealtor.Items.Add(item);
            }
            listViewRealtor.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewRealtor.SelectedItems.Count == 1)
            {
                RealtorsSet realtorSet = listViewRealtor.SelectedItems[0].Tag as RealtorsSet;
                realtorSet.FirstName = textBoxFirstName.Text;
                realtorSet.MiddleName = textBoxMiddleName.Text;
                realtorSet.LastName = textBoxLastName.Text;
                realtorSet.DealShare = Convert.ToInt32(textBoxDealShare.Text);
                Program.wftDb.SaveChanges();
                ShowRealtor();
            }
        }

        private void listViewRealtor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewRealtor.SelectedItems.Count == 1)
            {
                RealtorsSet realtorSet = listViewRealtor.SelectedItems[0].Tag as RealtorsSet;
                textBoxFirstName.Text = realtorSet.FirstName;
                textBoxMiddleName.Text = realtorSet.MiddleName;
                textBoxLastName.Text = realtorSet.LastName;
                textBoxDealShare.Text = Convert.ToString(realtorSet.DealShare);
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxDealShare.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewRealtor.SelectedItems.Count == 1)
                {
                    RealtorsSet realtorSet = listViewRealtor.SelectedItems[0].Tag as RealtorsSet;
                    Program.wftDb.RealtorsSet.Remove(realtorSet);
                    Program.wftDb.SaveChanges();
                    ShowRealtor();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxDealShare.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
