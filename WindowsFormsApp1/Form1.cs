using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data; 

namespace WindowsFormsApp1

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            this.Text = "Máy tính của: Nguyễn Văn Phong";
        }

        
        private void btnNhap_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtBieuThuc.Text += btn.Text;
        }

        
        private void btnBang_Click(object sender, EventArgs e)
        {
            try
            {
               
                var result = new DataTable().Compute(txtBieuThuc.Text, null);
                txtKetQua.Text = result.ToString();
            }
            catch
            {
                txtKetQua.Text = "Lỗi biểu thức";
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtBieuThuc.Text = "";
            txtKetQua.Text = "";
        }

   
        private void thayĐổiMàuSắcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

           
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
               
                foreach (Control control in tableLayoutPanel1.Controls)
                {
                    if (control is Button)
                    {
                        control.BackColor = colorDialog.Color;
                    }
                }
            }
        }

        private void thayĐổiFontChữToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                
                this.Font = fontDialog.Font;


                txtBieuThuc.Font = fontDialog.Font;
                txtKetQua.Font = fontDialog.Font;

                foreach (Control control in tableLayoutPanel1.Controls)
                {
                    if (control is Button)
                    {
                        control.Font = fontDialog.Font;
                    }
                }
            }
        }
    }
}