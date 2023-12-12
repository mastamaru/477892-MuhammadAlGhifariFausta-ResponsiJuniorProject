using Npgsql;
using System.Collections.Generic;
using System.Data;

namespace Responsi2Junpro
{
    public partial class Form1 : Form
    {
        private string connstring = "Server=localhost; Port=5432; User Id=postgres; Password=informatika; Database=ResponsiJunpro";
        private NpgsqlConnection conn;
        private DataGridViewRow row;

        public List<string> departemen = new List<string>
        {

                "Human Resources", "Engineer", "Developer", "Project Manager", "Finance"

         };


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            LoadData();
            LoadCBData();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM st_select()", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgKaryawan.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void LoadCBData()
        {
            cbDept.DataSource = departemen;
            cbDept.SelectedIndex = -1;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT st_insert(:nama, :id_dep)", conn);
                if(tbNama.Text == "")

                {
                    MessageBox.Show("Nama Karyawan Tidak Boleh Kosong!");
                    return;
                }
                cmd.Parameters.AddWithValue("nama", tbNama.Text);
                var departemenID = new Dictionary<string, string>
                {
                    {"Human Resources", "HR"},
                    {"Engineer", "ENG"},
                    {"Developer", "DEV"},
                    {"Project Manager", "PM"},
                    {"Finance", "FIN" }
                };

                if (cbDept.SelectedIndex == -1)
                {
                    MessageBox.Show("Departemen harus dipilih!");
                    return;
                }
                cmd.Parameters.AddWithValue("id_dep", departemenID[cbDept.SelectedItem.ToString()]);


                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data Karyawan Berhasil Ditambahkan");
                    tbNama.Text = null;
                    cbDept.SelectedIndex = -1;
                    conn.Close();
                    LoadData();
                }
           
                else
                {
                    MessageBox.Show("Data Karyawan Gagal Ditambahkan, Cek Lagi Input Anda!");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgKaryawan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                row = dgKaryawan.Rows[e.RowIndex];
                tbNama.Text = row.Cells[1].Value.ToString();
                cbDept.SelectedItem = row.Cells[2].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (row == null)
            {
                MessageBox.Show("Pilih baris data yang akan diupdate");
                return;
            }

            try
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("SELECT st_update(@_nama, @_id_dep, @_id_karyawan)", conn);
                cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                var departemenMapping = new Dictionary<string, string>
                {
                    {"Human Resources", "HR"},
                    {"Engineer", "ENG"},
                    {"Developer", "DEV"},
                    {"Project Manager", "PM"},
                    {"Finance", "FIN" }
                };
                cmd.Parameters.AddWithValue("_id_dep", departemenMapping[cbDept.SelectedItem.ToString()]);
                cmd.Parameters.AddWithValue("_id_karyawan", row.Cells[0].Value.ToString());
                int result = (int)cmd.ExecuteScalar();

                if (result == 1)
                {
                    MessageBox.Show("Data Karyawan Berhasil Diupdate");
                    tbNama.Text = null;
                    cbDept.SelectedIndex = -1;
                    conn.Close();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Data Karyawan Gagal Diupdate, Cek Lagi Input Anda!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (row == null)
            {
                MessageBox.Show("Pilih baris data yang akan dihapus");
                return;
            }

            try
            {
                conn.Open();
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Data Karyawan Ini?", "Konfirmasi", buttons);

                if (result == DialogResult.Yes)
                {
                       NpgsqlCommand cmd = new NpgsqlCommand("SELECT st_delete(@_id_karyawan)", conn);
                    cmd.Parameters.AddWithValue("_id_karyawan", row.Cells[0].Value.ToString());
                    int res = (int)cmd.ExecuteScalar();

                    if (res == 1)
                    {
                        MessageBox.Show("Data Karyawan Berhasil Dihapus");
                        tbNama.Text = null;
                        cbDept.SelectedIndex = -1;
                        conn.Close();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Data Karyawan Gagal Dihapus");
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
