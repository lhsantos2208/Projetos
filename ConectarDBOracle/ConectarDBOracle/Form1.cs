using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace ConectarDBOracle
{
    public partial class frmDbOracle : Form
    {
        protected OleDbConnection Con;    //conexão com o banco de dados
        protected OleDbCommand Cmd;       //executar comandos SQL
        protected OleDbDataReader Dr;     //Ler dados de consultas 
        protected OleDbTransaction Tr;    //Transações em banco de dados (commit/rollback)

        public frmDbOracle()
        {
            InitializeComponent();
        }
        private void frmDbOracle_Load(object sender, EventArgs e)
        {
            Con = new OleDbConnection("Provider=OraOLEDB.Oracle;Data Source=ODA_TESTE;USer ID=co_tortuga;Password=coteste*9)");
            Con.Open();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                Inserir(int.Parse(txtCodigo.Text), txtDescricao.Text);
                txtCodigo.Clear();
                txtDescricao.Clear();
                ConsultaGeral();
            }
            else
            {
                MessageBox.Show("O campo código precisa ser preenchido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                Excluir(int.Parse(txtCodigo.Text));
                txtCodigo.Clear();
                txtDescricao.Clear();
                ConsultaGeral();
            }
            else
            {
                MessageBox.Show("Preencha o campo código para fazer a exclusão!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                Consultar(int.Parse(txtCodigo.Text));
            }
            else
            {
                MessageBox.Show("Preencha o campo código para fazer a consulta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnConsultaGeral_Click(object sender, EventArgs e)
        {
            ConsultaGeral();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string vacodTst = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            txtCodigo.Text = vacodTst;
            string vadesTst = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            txtDescricao.Text = vadesTst;
        }

        private void Inserir(int vncodTst, string vadesTst)
        {
            Cmd = new OleDbCommand("SELECT USU_CODTST AS CODIGO, USU_DESTST AS DESCRICAO FROM USU_TTESTE WHERE USU_CODTST = " + txtCodigo.Text, Con);
            Dr = Cmd.ExecuteReader();
            if (Dr.Read())
            {
                DialogResult res = MessageBox.Show("O registro já exite na base, deseja alterar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    Alterar(int.Parse(txtCodigo.Text), txtDescricao.Text);
                }
            }
            else
            {
                string vaSql = "INSERT INTO USU_TTESTE(USU_CODTST, " +
                           "                       USU_DESTST) " +
                           "VALUES(" + vncodTst + ", " +
                           "       '" + vadesTst + "')";
                Cmd = new OleDbCommand(vaSql, Con);
                Cmd.ExecuteNonQuery();
            }
        }

        private void Alterar(int vncodTst, string vadesTst)
        {
            string vaSql = "UPDATE USU_TTESTE " +
                           "   SET USU_DESTST = '" + vadesTst + "' " +
                           " WHERE USU_CODTST = " + vncodTst;
            Cmd = new OleDbCommand(vaSql, Con);
            Cmd.ExecuteNonQuery();
        }

        private void Excluir(int vncodTst)
        {
            Cmd = new OleDbCommand("SELECT USU_CODTST AS CODIGO, USU_DESTST AS DESCRICAO FROM USU_TTESTE WHERE USU_CODTST = " + txtCodigo.Text, Con);
            Dr = Cmd.ExecuteReader();
            if (Dr.Read())
            {
                string vaSql = "DELETE USU_TTESTE " +
                           " WHERE USU_CODTST = " + vncodTst;
                Cmd = new OleDbCommand(vaSql, Con);
                Cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Registro não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Consultar(int vncodTst)
        {
            Cmd = new OleDbCommand("SELECT USU_CODTST AS CODIGO, USU_DESTST AS DESCRICAO FROM USU_TTESTE WHERE USU_CODTST = " + txtCodigo.Text, Con);
            Dr = Cmd.ExecuteReader();
            if (Dr.Read())
            {
                txtCodigo.Text = Convert.ToString(Dr["CODIGO"]);
                txtDescricao.Text = Convert.ToString(Dr["DESCRICAO"]);
            }
            else
            {
                MessageBox.Show("Registro não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ConsultaGeral()
        {
            OleDbDataAdapter cmd = new OleDbDataAdapter("SELECT USU_CODTST AS CODIGO, USU_DESTST AS DESCRICAO FROM USU_TTESTE ORDER BY USU_CODTST", Con);
            DataTable dt = new DataTable();
            cmd.Fill(dt);            
            dataGridView1.DataSource = dt;
        }

        private void frmDbOracle_FormClosed(object sender, FormClosedEventArgs e)
        {
            Con.Close();
        }       
    }
}
