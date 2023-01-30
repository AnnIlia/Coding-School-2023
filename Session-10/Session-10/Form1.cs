namespace Session_10
{

    //TODO: changes to Run without bugs//
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private University _university;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> names = new List<string>();
            names.Add("Alex");
            names.Add("Anna");




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Serializer serializer = new Serializer();
            serializer.SerializeToFile(_university, "test.json");
            MessageBox.Show("Save Done");
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            Serializer serializer = new Serializer();
            _university = serializer.Deserialize<University>("test.json");
            MessageBox.Show("Load Done");
        }
    }
}