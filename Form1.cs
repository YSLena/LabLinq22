namespace LabLinq22
{
    public partial class Form1 : Form
    {
        DataAccess dataAccess = new DataAccess();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ExampleDataGrid.DataSource = dataAccess.context.Students.ToList();
        }
    }
}