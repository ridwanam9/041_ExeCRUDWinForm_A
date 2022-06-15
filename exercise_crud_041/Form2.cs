using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace exercise_crud_041
{
    public partial class Form2 : Form
    {
        DataTable dt;
        DataRow dr;
        string code;

        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'exercise_pabdDataSet.Pegawai' table. You can move, or remove it, as needed.
            this.pegawaiTableAdapter.Fill(this.exercise_pabdDataSet.Pegawai);

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Simpan.Enabled = true;
            textInduk.Enabled = true;
            textNama.Enabled = true;
            textTitle.Enabled = true;
            textIdMa.Enabled = true;
            textIdSt.Enabled = true;
            

            textNama.Text = "";
            textInduk.Text = "";
            textTitle.Text = "";
            textIdMa.Text = "";
            textIdSt.Text = "";
            int ctr, len;
            string codeval;
            dt = exercise_pabdDataSet.Tables["Pegawai"];
            len = dt.Rows.Count - 1;
            dr = dt.Rows[len];
            code = dr["nomor_induk"].ToString();
            codeval = code.Substring(1, 3);
            ctr = Convert.ToInt32(codeval);
            if ((ctr >= 1) && (ctr < 9))
            {
                ctr = ctr + 1;
                textInduk.Text = "000" + ctr;
            }
            else if ((ctr >= 9) && (ctr < 99))
            {
                ctr = ctr + 1;
                textInduk.Text = "00" + ctr;
            }
            else if (ctr >= 99)
            {
                ctr = ctr + 1;
                textInduk.Text = "0" + ctr;
            }
            Simpan.Enabled = false;
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            dt = exercise_pabdDataSet.Tables["empdetails"];
            dr = dt.NewRow();
            dr[0] = textInduk.Text;
            dr[1] = textNama.Text;
            dr[2] = textTitle.Text;
            dr[3] = textIdMa.Text;
            dr[4] = textIdSt.Text;
            
            dt.Rows.Add(dr);

            pegawaiTableAdapter.Update(exercise_pabdDataSet);
            textInduk.Text = System.Convert.ToString(dr[0]);
            textNama.Enabled = false;
            textTitle.Enabled = false;
            textIdMa.Enabled = false;
            textIdSt.Enabled = false;
            this.pegawaiTableAdapter.Fill(this.exercise_pabdDataSet.Pegawai);
            Tambah.Enabled = true;
            Simpan.Enabled = false;
        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            string code;
            code = textInduk.Text;
            dr = exercise_pabdDataSet.Tables["Pegawai"].Rows.Find(code);
            dr.Delete();
            pegawaiTableAdapter.Update(exercise_pabdDataSet);
        }
    }
}
