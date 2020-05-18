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
    public partial class FormSupply : Form
    {
        public FormSupply()
        {
            InitializeComponent();
            ShowRealtors();
            ShowClients();
            ShowRealEstate();
            ShowSupplySet();
        }

        void ShowRealtors()
        {
            comboBoxRealtors.Items.Clear();
            foreach (RealtorsSet realtorSet in Program.wftDb.RealtorsSet)
            {
                string[] item = { realtorSet.Id.ToString() + ".", realtorSet.FirstName, realtorSet.MiddleName, realtorSet.LastName};
                comboBoxRealtors.Items.Add(string.Join("", item));
            }
        }
        void ShowClients()
        {
            comboBoxClients.Items.Clear();
            foreach (ClientsSet clientsSet in Program.wftDb.ClientsSet)
            {
                string[] item = { clientsSet.Id.ToString() + ".", clientsSet.FirstName, clientsSet.MiddleName, clientsSet.LastName};
                comboBoxClients.Items.Add(string.Join("", item));
            }
        }
        void ShowRealEstate()
        {
            comboBoxRealEstate.Items.Clear();
            foreach (RealEstateSet realEstateSet in Program.wftDb.RealEstateSet)
            {
                string[] item = { realEstateSet.Id.ToString() + ".", realEstateSet.Address_City + ",", realEstateSet.Address_Street + ",",
                                  "д. " + realEstateSet.Address_House + ",", "кв. " + realEstateSet.Address_Number };
                comboBoxRealEstate.Items.Add(string.Join("", item));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxRealtors.SelectedItem != null && comboBoxClients.SelectedItem != null && comboBoxRealEstate != null && textBoxPrice.Text != "")
            {
                SupplySet supply = new SupplySet();
                supply.IdRealtor = Convert.ToInt32(comboBoxRealtors.SelectedItem.ToString().Split('.')[0]);
                supply.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                supply.IdRealEstate = Convert.ToInt32(comboBoxRealEstate.SelectedItem.ToString().Split('.')[0]);
                supply.Price = Convert.ToInt64(textBoxPrice.Text);
                Program.wftDb.SupplySet.Add(supply);
                Program.wftDb.SaveChanges();
                ShowSupplySet();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void ShowSupplySet()
        {
            listViewSupplySet.Items.Clear();
            foreach (SupplySet supply in Program.wftDb.SupplySet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    supply.IdRealtor.ToString(),
                    supply.RealtorsSet.FirstName+" "+supply.RealtorsSet.MiddleName+" "+supply.RealtorsSet.LastName,
                    supply.IdClient.ToString(),
                    supply.ClientsSet.FirstName+" "+supply.ClientsSet.MiddleName+" "+supply.ClientsSet.LastName,
                    supply.IdRealEstate.ToString(),
                    "г. " + supply.RealEstateSet.Address_City + ", ул. " + supply.RealEstateSet.Address_Street + ", д. " +
                    supply.RealEstateSet.Address_House + ", кв. " + supply.RealEstateSet.Address_Number,
                    supply.Price.ToString()
                });
                item.Tag = supply;
                listViewSupplySet.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewSupplySet.SelectedItems.Count == 1)
            {
                SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                supply.IdRealtor = Convert.ToInt32(comboBoxRealtors.SelectedItem.ToString().Split('.')[0]);
                supply.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                supply.IdRealEstate = Convert.ToInt32(comboBoxRealEstate.SelectedItem.ToString().Split('.')[0]); 
                supply.Price = Convert.ToInt64(textBoxPrice.Text);
                Program.wftDb.SaveChanges();
                ShowSupplySet();
            }
        }

        private void listViewSupplySet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSupplySet.SelectedItems.Count == 1)
            {
                SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                comboBoxRealtors.SelectedIndex = comboBoxRealtors.FindString(supply.IdRealtor.ToString());
                comboBoxClients.SelectedIndex = comboBoxClients.FindString(supply.IdClient.ToString());
                comboBoxRealEstate.SelectedIndex = comboBoxRealEstate.FindString(supply.IdRealEstate.ToString());
                textBoxPrice.Text = supply.Price.ToString();
            }
            else
            {
                comboBoxRealtors.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxRealEstate.SelectedItem = null;
                textBoxPrice.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSupplySet.SelectedItems.Count == 1)
                {
                    SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                    Program.wftDb.SupplySet.Remove(supply);
                    Program.wftDb.SaveChanges();
                    ShowSupplySet();
                }
                comboBoxRealtors.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxRealEstate.SelectedItem = null;
                textBoxPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
