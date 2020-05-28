using System;
using System.Windows.Forms;
using Interfile.FDI.PainelSLA.Business;
using Interfile.FDI.PainelSLA.Data;
using Interfile.FDI.PainelSLA.Businnes;
using Interfile.FDI.PainelSLA.Models;
using System.Data;

namespace Interfile.FDI.PainelSLA
{
    public partial class Form1 : Form
    {
        FilaData filaData = new FilaData();
        PriorizacaoBusiness prio = new PriorizacaoBusiness();
        PriorizacaoModel model = new PriorizacaoModel();
        public Form1()
        {
            InitializeComponent();
            timer3.Start();
            timer2.Start();
            CarregarGrid();
            GetCountFilaAtual();
            using (ControlePausaBusiness pauseApllication = new ControlePausaBusiness())
            {
                lblOnline.Text = pauseApllication.GetOnline();
                lblPausa.Text = pauseApllication.GetPausa();
                pauseApllication.Dispose();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ContadoresEtapas();
        }

        private void ContadoresEtapas()
        {
            model = prio.GetContadoresFila();
            lblClassificacao.Text = model.Classificacao;
            lblPreValidacao.Text = model.PreValidacao;
            lblFormalizacao.Text = model.Forma;
            lblValidacao.Text = model.Validacao;
            prio.Dispose();
            model.Dispose();
        }

        public void CarregarGrid()
        {
            GetFilaAtual();
        }

        public void AtualizarGrid()
        {
            GetFilaAtual();
        }
        public void AtualizaDados()
        {
            GetFilaAtual();
            GetCountFilaAtual();

            using (ControlePausaBusiness pauseApllication = new ControlePausaBusiness())
            {
                lblOnline.Text = pauseApllication.GetOnline();
                lblPausa.Text = pauseApllication.GetPausa();
            }
            double contdgv = this.dgvFilaAtual.RowCount - 1;
            this.dgvFilaAtual.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilaAtual.MultiSelect = true;
            for (int i = 0; i < contdgv; i++)
            {
                var dataHora = Convert.ToDateTime(this.dgvFilaAtual.Rows[this.dgvFilaAtual.Rows[i].Index].Cells["Data Entrada - FDI"].Value.ToString());
                var slaMin = Convert.ToInt32(this.dgvFilaAtual.Rows[this.dgvFilaAtual.Rows[i].Index].Cells["SLA - min"].Value.ToString());
                string colaborador = this.dgvFilaAtual.Rows[this.dgvFilaAtual.Rows[i].Index].Cells["Colaborador"].Value.ToString();
                var sla = DateTime.Now - dataHora;
                string proposta = this.dgvFilaAtual.Rows[this.dgvFilaAtual.Rows[i].Index].Cells["Proposta"].Value.ToString();
                string etapa = this.dgvFilaAtual.Rows[this.dgvFilaAtual.Rows[i].Index].Cells["Atividade"].Value.ToString();
                if (this.dgvFilaAtual.Rows[this.dgvFilaAtual.Rows[i].Index].Cells["Atividade"].Value.ToString() != "CONTINGÊNCIA")
                {
                    if (this.dgvFilaAtual.Rows[this.dgvFilaAtual.Rows[i].Index].Cells["Atividade"].Value.ToString() != "AGUARDAR FINALIZAÇÃO FDI")
                    {
                        if (slaMin >= 25 && slaMin < 30 && string.IsNullOrEmpty(colaborador))
                        {
                            this.dgvFilaAtual.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Orange;
                            AutoClosingMessageBox.Show($"A proposta {proposta} na Etapa de {etapa} tem apenas {30 - slaMin} minuto(s) para estourar o SLA.", "ATENÇÃO!", 2000);
                        }
                        else if (slaMin > 28 && slaMin < 30 && !string.IsNullOrEmpty(colaborador))
                        {
                            this.dgvFilaAtual.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Orange;
                            AutoClosingMessageBox.Show($"A proposta {proposta} na Etapa de {etapa} tem apenas {30 - slaMin} minuto(s) para estourar o SLA.", "ATENÇÃO!", 2000);
                        }

                        else if (slaMin >= 30)
                        {
                            this.dgvFilaAtual.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Orange;
                            AutoClosingMessageBox.Show($"A proposta {proposta} na Etapa de {etapa} está com {slaMin} minuto(s) de SLA.", "ATENÇÃO!", 2000); 
                            
                        }
                        colaborador = null;
                        proposta = null;
                        etapa = null;
                    }
                }
            }
        }

        public void GetCountFilaAtual()
        {
            label9.Text = string.Empty;
            label9.Text = $"Fila Atual({dgvFilaAtual.RowCount.ToString()})";
        }

        public void GetFilaAtual()
        {
            var dataSourceAnterior = dgvFilaAtual.DataSource as IDisposable;
            var dataTableAnterior = dgvFilaAtual.DataSource as DataTable;

            dgvFilaAtual.DataSource = null;

            if (dataSourceAnterior != null) dataSourceAnterior.Dispose();
            if (dataTableAnterior != null) dataTableAnterior.Clear();

            dgvFilaAtual.DataSource = filaData.GetFilaAtual();
            dgvFilaAtual.Columns["ORDEM"].Visible = false;
            dgvFilaAtual.Columns["Idpropostadistribuidor"].Visible = false;
            dgvFilaAtual.Columns["CPF"].Visible = false;
            dgvFilaAtual.Columns["CNPJ"].Visible = false;
            dgvFilaAtual.Columns["Cadastro Positivo?"].Visible = false;           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AtualizaDados();
            dgvFilaAtual.Update();
            dgvFilaAtual.Refresh();
            ContadoresEtapas();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // MetroMessageBox.Show(this, "EXISTEM PROPOSTAS COM SLA PROXIMO AO FIM FAVOR VERIFICAR.", "ATENÇÃO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void htmlToolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

        }

        private void fDIAUTOMACAODataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void tClassificacao_Click(object sender, EventArgs e)
        {

        }

        private void tBoleto_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizaDados();
            model = prio.GetContadoresFila();
            lblClassificacao.Text = model.Classificacao;
            lblPreValidacao.Text = model.PreValidacao;
            lblFormalizacao.Text = model.Forma;
            lblValidacao.Text = model.Validacao;
            prio.Dispose();
            model.Dispose();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            this.label2.Text = DateTime.Now.ToString();
        }

        public class AutoClosingMessageBox
        {
            System.Threading.Timer _timeoutTimer;
            string _caption;
            AutoClosingMessageBox(string text, string caption, int timeout)
            {
                _caption = caption;
                _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                    null, timeout, System.Threading.Timeout.Infinite);
                using (_timeoutTimer)
                    MessageBox.Show(text, caption);
            }
            public static void Show(string text, string caption, int timeout)
            {
                new AutoClosingMessageBox(text, caption, timeout);
            }
            void OnTimerElapsed(object state)
            {
                IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
                if (mbWnd != IntPtr.Zero)
                    SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                _timeoutTimer.Dispose();
            }
            const int WM_CLOSE = 0x0010;
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        }
    }
}

