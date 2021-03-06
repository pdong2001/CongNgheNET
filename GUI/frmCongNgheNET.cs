using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class frmCongNgheNET : Form
    {
        public frmCongNgheNET()
        {
            InitializeComponent();
        }
        DataTable data = new DataTable();

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void frmCongNgheNET_Load(object sender, EventArgs e)
        {
            data = SanPhamBUS.Instance.GetTable();
            dgSanPham.DataSource = data;
            dgSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgSanPham.AutoResizeColumn(0, DataGridViewAutoSizeColumnMode.AllCells);
            dgSanPham.AutoResizeColumn(2, DataGridViewAutoSizeColumnMode.AllCells);
            dgSanPham.AutoResizeColumn(3, DataGridViewAutoSizeColumnMode.AllCells);
            dgSanPham.AutoResizeColumn(4, DataGridViewAutoSizeColumnMode.AllCells);
        }

        private void dgSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgSanPham.SelectedCells.Count > 0)
            {
                DataGridViewRow data = dgSanPham.Rows[dgSanPham.SelectedCells[0].RowIndex];
                if (data.Cells[0].Value == null)
                {
                    return;
                }
                txtMaSP.Text = data.Cells[0].Value.ToString();
                txtTenSP.Text = data.Cells[1].Value.ToString();
                txtSL.Text = data.Cells[2].Value.ToString();
                txtGiaBan.Text = data.Cells[3].Value.ToString();
                txtXuatSu.Text = data.Cells[4].Value.ToString();
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in pnlInput.Controls)
            {
                if (ctrl.GetType().Name == "TextBox")
                {
                    ctrl.Text = "";
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataTable data = (DataTable)dgSanPham.DataSource;
            DataRow Row = data.NewRow();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i][0].ToString().Trim() == txtMaSP.Text.Trim())
                {
                    MessageBox.Show("Mã sản phẩm đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            Row[0] = txtMaSP.Text;
            Row[1] = txtTenSP.Text;
            Row[2] = int.Parse(txtSL.Text);
            Row[3] = int.Parse(txtGiaBan.Text);
            Row[4] = txtXuatSu.Text;
            data.Rows.Add(Row);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i][0].ToString().Trim() == dgSanPham.Rows[dgSanPham.SelectedCells[0].RowIndex].Cells[0].Value.ToString().Trim())
                {
                    data.Rows[i][0] = txtMaSP.Text;
                    data.Rows[i][1] = txtTenSP.Text;
                    data.Rows[i][2] = txtSL.Text;
                    data.Rows[i][3] = int.Parse(txtGiaBan.Text);
                    data.Rows[i][4] = int.Parse(txtXuatSu.Text);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i][0].ToString().Trim() == txtMaSP.Text.Trim())
                {
                    data.Rows.RemoveAt(i);
                }
            }
        }

        private void txtGiaBan_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            if (ctrl.Text.Length == 0)
            {
                ctrl.Text = "0";
            }
        }
    }
}
