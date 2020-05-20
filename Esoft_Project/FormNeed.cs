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
    public partial class FormNeed : Form
    {
        public FormNeed()
        {
            InitializeComponent();
            comboBoxTypes.SelectedIndex = 0;
            ShowRealtors();
            ShowClients();
            ShowDemandSet();
        }
        void ShowRealtors()
        {
            comboBoxRealtors.Items.Clear();
            foreach (RealtorsSet realtorSet in Program.wftDb.RealtorsSet)
            {
                string[] item = { realtorSet.Id.ToString() + ".", realtorSet.FirstName, realtorSet.MiddleName, realtorSet.LastName };
                comboBoxRealtors.Items.Add(string.Join("", item));
            }
        }
        void ShowClients()
        {
            comboBoxClients.Items.Clear();
            foreach (ClientsSet clientsSet in Program.wftDb.ClientsSet)
            {
                string[] item = { clientsSet.Id.ToString() + ".", clientsSet.FirstName, clientsSet.MiddleName, clientsSet.LastName };
                comboBoxClients.Items.Add(string.Join("", item));
            }
        }
        void ShowDemandSet()
        {
            listViewDemandSet_Apartment.Items.Clear();
            listViewDemandSet_House.Items.Clear();
            listViewDemandSet_Land.Items.Clear();
            foreach (DemandSet need in Program.wftDb.DemandSet)
            {
                if (need.Type == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                    need.IdRealtor.ToString(),
                    need.RealtorsSet.FirstName+" "+need.RealtorsSet.MiddleName+" "+need.RealtorsSet.LastName,
                    need.IdClient.ToString(),
                    need.ClientsSet.FirstName+" "+need.ClientsSet.MiddleName+" "+need.ClientsSet.LastName,
                    need.Type.ToString(),
                    need.MinPrice.ToString(),
                    need.MaxPrice.ToString(),
                    need.MinArea.ToString(),
                    need.MaxArea.ToString(),
                    need.MinRooms.ToString(),
                    need.MaxRooms.ToString(),
                    need.MinFloor.ToString(),
                    need.MaxFloor.ToString(),
                    need.MinFloors.ToString(),
                    need.MaxFloors.ToString()
                    });
                    item.Tag = need;
                    listViewDemandSet_Apartment.Items.Add(item);
                }
                else if (need.Type == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                    need.IdRealtor.ToString(),
                    need.RealtorsSet.FirstName+" "+need.RealtorsSet.MiddleName+" "+need.RealtorsSet.LastName,
                    need.IdClient.ToString(),
                    need.ClientsSet.FirstName+" "+need.ClientsSet.MiddleName+" "+need.ClientsSet.LastName,
                    need.Type.ToString(),
                    need.MinPrice.ToString(),
                    need.MaxPrice.ToString(),
                    need.MinArea.ToString(),
                    need.MaxArea.ToString(),
                    need.MinRooms.ToString(),
                    need.MaxRooms.ToString(),
                    need.MinFloors.ToString(),
                    need.MaxFloors.ToString()
                    });
                    item.Tag = need;
                    listViewDemandSet_Apartment.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                    need.IdRealtor.ToString(),
                    need.RealtorsSet.FirstName+" "+need.RealtorsSet.MiddleName+" "+need.RealtorsSet.LastName,
                    need.IdClient.ToString(),
                    need.ClientsSet.FirstName+" "+need.ClientsSet.MiddleName+" "+need.ClientsSet.LastName,
                    need.Type.ToString(),
                    need.MinPrice.ToString(),
                    need.MaxPrice.ToString(),
                    need.MinArea.ToString(),
                    need.MaxArea.ToString()
                    });
                    item.Tag = need;
                    listViewDemandSet_Apartment.Items.Add(item);
                }
            }
            listViewDemandSet_Apartment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewDemandSet_House.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewDemandSet_Land.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxRealtors.SelectedItem != null && comboBoxClients.SelectedItem != null && comboBoxTypes != null 
                && textBoxMinPrice.Text != null && textBoxMaxPrice.Text != null && textBoxMinArea.Text != null && textBoxMaxArea.Text != null 
                && textBoxMinRooms.Text != null && textBoxMaxRooms.Text != null && textBoxMinFloor.Text != null && textBoxMaxFloor.Text != null
                && textBoxMinFloors.Text != null && textBoxMaxFloors.Text != "")
            {
                DemandSet need = new DemandSet();
                need.IdRealtor = Convert.ToInt32(comboBoxRealtors.SelectedItem.ToString().Split('.')[0]);
                need.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                need.Type = Convert.ToInt32(comboBoxTypes.SelectedItem.ToString().Split('.')[0]);
                need.MinPrice = Convert.ToInt32(textBoxMinPrice.Text);
                need.MaxPrice = Convert.ToInt32(textBoxMaxPrice.Text);
                need.MinArea = Convert.ToInt32(textBoxMinArea.Text);
                need.MaxArea = Convert.ToInt32(textBoxMaxArea.Text);
                need.MinRooms = Convert.ToInt32(textBoxMinRooms.Text);
                need.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text);
                need.MinFloor = Convert.ToInt32(textBoxMinFloor.Text);
                need.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text);
                need.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
                need.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text);
                if (comboBoxTypes.SelectedIndex == 0)
                {
                    need.Type = 0;
                }
                else if (comboBoxTypes.SelectedIndex == 1)
                {
                    need.Type = 1;
                }
                else 
                {
                    need.Type = 2;
                }
                Program.wftDb.DemandSet.Add(need);
                Program.wftDb.SaveChanges();
                ShowDemandSet();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxTypes.SelectedIndex == 0)
            {
                if (listViewDemandSet_Apartment.SelectedItems.Count == 1)
                {
                    DemandSet need = listViewDemandSet_Apartment.SelectedItems[0].Tag as DemandSet;
                    need.IdRealtor = Convert.ToInt32(comboBoxRealtors.SelectedItem.ToString().Split('.')[0]);
                    need.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                    need.Type = Convert.ToInt32(comboBoxTypes.SelectedItem.ToString().Split('.')[0]);
                    need.MinPrice = Convert.ToInt32(textBoxMinPrice.Text);
                    need.MaxPrice = Convert.ToInt32(textBoxMaxPrice.Text);
                    need.MinArea = Convert.ToInt32(textBoxMinArea.Text);
                    need.MaxArea = Convert.ToInt32(textBoxMaxArea.Text);
                    need.MinRooms = Convert.ToInt32(textBoxMinRooms.Text);
                    need.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text);
                    need.MinFloor = Convert.ToInt32(textBoxMinFloor.Text);
                    need.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text);
                    need.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
                    need.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text);
                    Program.wftDb.SaveChanges();
                    ShowDemandSet();
                }
            }
            else if (comboBoxTypes.SelectedIndex == 1)
            {
                if (listViewDemandSet_Apartment.SelectedItems.Count == 1)
                {
                    DemandSet need = listViewDemandSet_Apartment.SelectedItems[0].Tag as DemandSet;
                    need.IdRealtor = Convert.ToInt32(comboBoxRealtors.SelectedItem.ToString().Split('.')[0]);
                    need.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                    need.Type = Convert.ToInt32(comboBoxTypes.SelectedItem.ToString().Split('.')[0]);
                    need.MinPrice = Convert.ToInt32(textBoxMinPrice.Text);
                    need.MaxPrice = Convert.ToInt32(textBoxMaxPrice.Text);
                    need.MinArea = Convert.ToInt32(textBoxMinArea.Text);
                    need.MaxArea = Convert.ToInt32(textBoxMaxArea.Text);
                    need.MinRooms = Convert.ToInt32(textBoxMinRooms.Text);
                    need.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text);
                    need.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
                    need.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text);
                    Program.wftDb.SaveChanges();
                    ShowDemandSet();
                }
            }
            else
            {
                if (listViewDemandSet_Apartment.SelectedItems.Count == 1)
                {
                    DemandSet need = listViewDemandSet_Apartment.SelectedItems[0].Tag as DemandSet;
                    need.IdRealtor = Convert.ToInt32(comboBoxRealtors.SelectedItem.ToString().Split('.')[0]);
                    need.IdClient = Convert.ToInt32(comboBoxClients.SelectedItem.ToString().Split('.')[0]);
                    need.Type = Convert.ToInt32(comboBoxTypes.SelectedItem.ToString().Split('.')[0]);
                    need.MinPrice = Convert.ToInt32(textBoxMinPrice.Text);
                    need.MaxPrice = Convert.ToInt32(textBoxMaxPrice.Text);
                    need.MinArea = Convert.ToInt32(textBoxMinArea.Text);
                    need.MaxArea = Convert.ToInt32(textBoxMaxArea.Text);
                    Program.wftDb.SaveChanges();
                    ShowDemandSet();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxTypes.SelectedIndex == 0)
                {
                    if (listViewDemandSet_Apartment.SelectedItems.Count == 1)
                    {
                        DemandSet need = listViewDemandSet_Apartment.SelectedItems[0].Tag as DemandSet;
                        Program.wftDb.DemandSet.Remove(need);
                        Program.wftDb.SaveChanges();
                        ShowDemandSet();
                    }
                    comboBoxRealtors.SelectedItem = null;
                    comboBoxClients.SelectedItem = null;
                    comboBoxTypes.SelectedItem = null;
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                    textBoxMinRooms.Text = "";
                    textBoxMaxRooms.Text = "";
                    textBoxMinFloor.Text = "";
                    textBoxMaxFloor.Text = "";
                    textBoxMinFloors.Text = "";
                    textBoxMaxFloors.Text = "";
                }
                else if (comboBoxTypes.SelectedIndex == 1)
                {
                    if (listViewDemandSet_House.SelectedItems.Count == 1)
                    {
                        DemandSet need = listViewDemandSet_House.SelectedItems[0].Tag as DemandSet;
                        Program.wftDb.DemandSet.Remove(need);
                        Program.wftDb.SaveChanges();
                        ShowDemandSet();
                    }
                    comboBoxRealtors.SelectedItem = null;
                    comboBoxClients.SelectedItem = null;
                    comboBoxTypes.SelectedItem = null;
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                    textBoxMinRooms.Text = "";
                    textBoxMaxRooms.Text = "";
                    textBoxMinFloors.Text = "";
                    textBoxMaxFloors.Text = "";
                }
                else
                {
                    if (listViewDemandSet_Land.SelectedItems.Count == 1)
                    {
                        DemandSet need = listViewDemandSet_Land.SelectedItems[0].Tag as DemandSet;
                        Program.wftDb.DemandSet.Remove(need);
                        Program.wftDb.SaveChanges();
                        ShowDemandSet();
                    }
                    comboBoxRealtors.SelectedItem = null;
                    comboBoxClients.SelectedItem = null;
                    comboBoxTypes.SelectedItem = null;
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTypes.SelectedIndex == 0)
            {
                listViewDemandSet_Apartment.Visible = true;


                listViewDemandSet_House.Visible = false;
                listViewDemandSet_Land.Visible = false;

                comboBoxRealtors.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxTypes.SelectedItem = null;
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";
            }
            else if (comboBoxTypes.SelectedIndex == 1)
            {
                listViewDemandSet_House.Visible = true;

                listViewDemandSet_Apartment.Visible = false;
                listViewDemandSet_Land.Visible = false;
                labelMinFloor.Visible = false;
                textBoxMinFloor.Visible = false;
                labelMaxFloor.Visible = false;
                textBoxMaxFloor.Visible = false;

                comboBoxRealtors.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxTypes.SelectedItem = null;
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";
            }
            else if (comboBoxTypes.SelectedIndex == 2)
            {
                listViewDemandSet_Land.Visible = true;

                listViewDemandSet_Apartment.Visible = false;
                listViewDemandSet_House.Visible = false;
                labelMinRooms.Visible = false;
                textBoxMinRooms.Visible = false;
                labelMaxRooms.Visible = false;
                textBoxMaxRooms.Visible = false;
                labelMinFloor.Visible = false;
                textBoxMinFloor.Visible = false;
                labelMaxFloor.Visible = false;
                textBoxMaxFloor.Visible = false;
                labelMinFloors.Visible = false;
                textBoxMinFloors.Visible = false;
                labelMaxFloors.Visible = false;
                textBoxMaxFloors.Visible = false;

                comboBoxRealtors.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxTypes.SelectedItem = null;
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
            }
        }

        private void listViewDemandSet_Apartment_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listViewDemandSet_Apartment.SelectedItems.Count == 1)
            {
                DemandSet need = listViewDemandSet_Apartment.SelectedItems[0].Tag as DemandSet;
                comboBoxRealtors.SelectedItem = comboBoxRealtors.FindString(need.IdRealtor.ToString());
                comboBoxClients.SelectedItem = comboBoxClients.FindString(need.IdClient.ToString());
                comboBoxTypes.SelectedItem = comboBoxTypes.FindString(need.Type.ToString());
                textBoxMinPrice.Text = need.MinPrice.ToString();
                textBoxMaxPrice.Text = need.MaxPrice.ToString();
                textBoxMinArea.Text = need.MinArea.ToString();
                textBoxMaxArea.Text = need.MaxArea.ToString();
                textBoxMinRooms.Text = need.MinRooms.ToString();
                textBoxMaxRooms.Text = need.MaxRooms.ToString();
                textBoxMinFloor.Text = need.MinFloor.ToString();
                textBoxMaxFloor.Text = need.MaxFloor.ToString();
                textBoxMinFloors.Text = need.MinFloors.ToString();
                textBoxMaxFloors.Text = need.MaxFloors.ToString();
            }
            else
            {
                comboBoxRealtors.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxTypes.SelectedItem = null;
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";
            }
        }

        private void listViewDemandSet_House_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDemandSet_Apartment.SelectedItems.Count == 1)
            {
                DemandSet need = listViewDemandSet_Apartment.SelectedItems[0].Tag as DemandSet;
                comboBoxRealtors.SelectedItem = comboBoxRealtors.FindString(need.IdRealtor.ToString());
                comboBoxClients.SelectedItem = comboBoxClients.FindString(need.IdClient.ToString());
                comboBoxTypes.SelectedItem = comboBoxTypes.FindString(need.Type.ToString());
                textBoxMinPrice.Text = need.MinPrice.ToString();
                textBoxMaxPrice.Text = need.MaxPrice.ToString();
                textBoxMinArea.Text = need.MinArea.ToString();
                textBoxMaxArea.Text = need.MaxArea.ToString();
                textBoxMinRooms.Text = need.MinRooms.ToString();
                textBoxMaxRooms.Text = need.MaxRooms.ToString();
                textBoxMinFloors.Text = need.MinFloors.ToString();
                textBoxMaxFloors.Text = need.MaxFloors.ToString();
            }
            else
            {
                comboBoxRealtors.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxTypes.SelectedItem = null;
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";
            }
        }

        private void listViewDemandSet_Land_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDemandSet_Apartment.SelectedItems.Count == 1)
            {
                DemandSet need = listViewDemandSet_Apartment.SelectedItems[0].Tag as DemandSet;
                comboBoxRealtors.SelectedItem = comboBoxRealtors.FindString(need.IdRealtor.ToString());
                comboBoxClients.SelectedItem = comboBoxClients.FindString(need.IdClient.ToString());
                comboBoxTypes.SelectedItem = comboBoxTypes.FindString(need.Type.ToString());
                textBoxMinPrice.Text = need.MinPrice.ToString();
                textBoxMaxPrice.Text = need.MaxPrice.ToString();
                textBoxMinArea.Text = need.MinArea.ToString();
                textBoxMaxArea.Text = need.MaxArea.ToString();
            }
            else
            {
                comboBoxRealtors.SelectedItem = null;
                comboBoxClients.SelectedItem = null;
                comboBoxTypes.SelectedItem = null;
                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
            }
        }
    }
}
