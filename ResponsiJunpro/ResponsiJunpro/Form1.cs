using Npgsql;
using System.Data;
using System.Runtime.CompilerServices;

namespace ResponsiJunpro
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection conn = new NpgsqlConnection(ConnectionString.conString);
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        private DataGridViewRow r;
        List<string> depList = new List<string>();
        public Form1()
        {
            InitializeComponent();
            depList = Departemen.GetDepartemenList();
            foreach (string dep in depList)
            {
                comboBox1.AutoCompleteCustomSource.Add(dep);
                comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
                comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            string nama = textBox1.Text;
            string dep_id = Departemen.GetDepartemenId(comboBox1.Text);
            try
            {
                conn.Open();
                sql = "INSERT INTO karyawan(nama, id_dep, id_karyawan) VALUES (_nama, _id_dep, nextval('kar_id'))";
                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("_nama", nama);
                cmd.Parameters.AddWithValue("_id_dep", dep_id);
                object result = cmd.ExecuteScalar();
                if(result != null)
                {
                    MessageBox.Show("Insert Sukses");
                    textBox1.Text = comboBox1.Text = null;
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}