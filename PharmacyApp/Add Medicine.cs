using PharmacyApp.Helper;
using PharmacyApp.modell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyApp
{
    public partial class Add_Medicine : Form
    {
        PharrmacyDbEntities _context = new PharrmacyDbEntities();
        public Add_Medicine()
        {
            InitializeComponent();
        }
        private void FillTagsComboBox()
        {
            cmbTags.Items.AddRange(_context.Tags.Select(x => x.Tag_Name).ToArray());
        }
        private void FillFirmsComboBox()
        {
            cmbFirms.Items.AddRange(_context.Firms.Select(x => x.Firm_Name).ToArray());
        }
        private int FindFirm(string firmName)
        {
            Firm selectedFirm = _context.Firms.FirstOrDefault(x => x.Firm_Name == firmName);
            if (selectedFirm == null)
            {
                Firm firm = _context.Firms.Add(new Firm() 
                {
                Firm_Name = firmName
            });
                _context.SaveChanges();
                return firm.Id;
            }
            else
            {
                return selectedFirm.Id;
            }
        }
        private void ClearAllField()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox || item is ComboBox || item is RichTextBox)
                {
                    item.Text = string.Empty;
                }
                else if(item is NumericUpDown)
                {
                    NumericUpDown numericUpDown = (NumericUpDown)item;
                    numericUpDown.Value = 1;
                }
                else if(item is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)item;
                    dateTimePicker.Value = DateTime.Now;
                }
                else if(item is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)item;
                    checkBox.Checked = false;
                }
                else if(item is CheckedListBox)
                {
                    CheckedListBox checkedListBox = (CheckedListBox)item;
                    checkedListBox.Items.Clear();
                }
            }
        }
        private void FillMedicineDataGridView()
        {
            dtgMedicine.DataSource = _context.Medicines.Select(x => new 
            {
            x.Id,
            x.Medicine_Name,
            x.Price,
            x.Quantity,
            x.Firm.Firm_Name,
            Receipt = x.IsReceipt ? "Reseptli" : "Reseptsiz",
            x.Production_Date,
            x.Experience_Date
            }).ToList();
            dtgMedicine.Columns[0].Visible = false;
            for (int i = 0; i < dtgMedicine.Rows.Count; i++)
            {
                if (dtgMedicine.Rows[i].Index % 2 ==0)
                {
                    dtgMedicine.Rows[i].DefaultCellStyle.BackColor = Color.Indigo;
                    dtgMedicine.Rows[i].DefaultCellStyle.ForeColor = Color.White;

                }
            }
        }
        private void Add_Medicine_Load(object sender, EventArgs e)
        {
            FillFirmsComboBox();
            FillTagsComboBox();
            FillMedicineDataGridView();
        }
        private void CheckAndAddTags(string tagName)
        {
            if (tagName.Trim().Length !=0)
            {
                if (!ckTagsList.Items.Contains(tagName))
                {
                    ckTagsList.Items.Add(tagName, true);
                }
            }
            
        }
        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 47 || e.KeyChar > 58) && e.KeyChar != 8 && e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }
        private bool CheckTag(string tagName)
        {
            Tag selectedTag = _context.Tags.FirstOrDefault(x => x.Tag_Name == tagName);
            if (selectedTag == null)
            {
                return false;
            }
            return true;
        }
        private void MedecineAddTag(int medicineId)
        {
            for (int i = 0; i < ckTagsList.Items.Count; i++)
            {
               string tagName = ckTagsList.Items[i].ToString();
                int tagId;
                if (CheckTag(tagName))
                {
                     tagId = _context.Tags.First(x => x.Tag_Name == tagName).Id;
                }
                else
                {
                    Tag tag = new Tag();
                    tag.Tag_Name = tagName;
                    _context.Tags.Add(tag);
                    _context.SaveChanges();
                    tagId = tag.Id;
                }
                 _context.Medicine_To_Tag.Add(new Medicine_To_Tag() 
                {
                MedicineId = medicineId,
                TagId = tagId
            });
                _context.SaveChanges();
                

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string medicineName = txtName.Text;
            decimal Price = nmPrice.Value;
            int Quantity = (int)nmQuantity.Value;
            string barcode = txtBarcode.Text;
            string description = rtbDescription.Text;
            DateTime productionDate = dtProductionDate.Value;
            DateTime experienceDate = dtExperienceDate.Value;
            string firms = cmbFirms.Text;
            string tags = cmbTags.Text;          
            if (Utilities.IsEmpty(medicineName,barcode,firms))
            {
                lblError.Visible = false;
                int firmId = FindFirm(firms);
                Medicine medicine = _context.Medicines.Add(new Medicine()
                {

                    Medicine_Name = medicineName,
                    Barcode = barcode,
                    Price = Price,
                    Quantity = Quantity,
                    Production_Date = productionDate,
                    Experience_Date = experienceDate,
                    IsReceipt = ckReceipt.Checked ? true : false,
                    Description = description,
                    FirmId = firmId
                });
                
                _context.SaveChanges();
                MedecineAddTag(medicine.Id);
                ClearAllField();
                FillMedicineDataGridView();

            }
            else
            {
                lblError.Text = "Please, fill all field!";
                lblError.Visible = true;
            }
        }
        private void cmbTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tagName = cmbTags.Text;
            CheckAndAddTags(tagName);
            
        }
        private void cmbTags_KeyUp(object sender, KeyEventArgs e)
        {
            string tagName = cmbTags.Text;
            if (e.KeyCode == Keys.Enter)
            {
                CheckAndAddTags(tagName);
            }

        }

        private void ckTagsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selected = ckTagsList.SelectedIndex;
            if (selected != -1)
            {
                ckTagsList.Items.RemoveAt(selected);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
