namespace Asignacion_Barberia
{
    public partial class Form1 : Form
    {
        
        List<string> barberos=new List<string>();

        public Form1()
        {
            InitializeComponent();
            llenarhoras();
            fillbarberos();
        }

        private void fillbarberos()
        {
            barberos.Add("Carlos");
            barberos.Add("Leonel");
            barberos.Add("Carlitos");
            ListBarb.DataSource = barberos;
        }

        private void llenarhoras()
        {
            var horas = Enumerable.Range(00, 22).Select(i => (DateTime.MinValue.AddHours(i)).ToString("hh.mm tt"));
            Hora.DataSource=horas.ToList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Barbero_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Borrarcontrol();
            PorDefault();
            Informacion.Enabled = true;
        }

        private void PorDefault()
        {
            ListBarb.SelectedIndex = 0;
            fechaselect.Value = DateTime.Now;
            Hora.SelectedText = DateTime.Now.ToString("hh");
        }

        private void Borrarcontrol()
        {
            NomClnt.Text = String.Empty;
            NumClnt.Text = String.Empty;
            CorreoClnt.Text = String.Empty;
       
        }

        private void SaveBtt_Click(object sender, EventArgs e)
        {

        }

        private void Namelbl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void CancelBtt_Click(object sender, EventArgs e)
        {
            Informacion.Enabled = false;
        }

        private void NomClnt_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}