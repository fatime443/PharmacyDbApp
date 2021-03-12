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
    public partial class WorkerDashboard : Form
    {
        PharrmacyDbEntities _context = new PharrmacyDbEntities();

        public WorkerDashboard()
        {
            InitializeComponent();
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
                if (dtgMedicine.Rows[i].Index % 2 == 0)
                {
                    dtgMedicine.Rows[i].DefaultCellStyle.BackColor = Color.Indigo;
                    dtgMedicine.Rows[i].DefaultCellStyle.ForeColor = Color.White;

                }
            }
        }

        private void WorkerDashboard_Load(object sender, EventArgs e)
        {
            FillMedicineDataGridView();
        }
    }
}
