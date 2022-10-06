namespace LabLinq22
{
    public partial class Form1 : Form
    {
        DataAccess dataAcc = new DataAccess();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataAcc.context.Students.ToList();

            dataGridView21Example.DataSource = dataAcc.Query21Example();
            label17.Text = dataGridView21Example.Rows.Count.ToString() + " rows";
            dataGridView21.DataSource = dataAcc.Query21();
            label18.Text = dataGridView21.Rows.Count.ToString() + " rows";

            dataGridView22Example.DataSource = dataAcc.Query22Example();
            label19.Text = dataGridView22Example.Rows.Count.ToString() + " rows";
            dataGridView22.DataSource = dataAcc.Query22();
            label20.Text = dataGridView22.Rows.Count.ToString() + " rows";
            if ((dataGridView21.RowCount > 0) || (dataGridView22.RowCount > 0))
                tabControl1.SelectedTab = tabControl1.TabPages["tabQuery2"];

            dataGridView3Example.DataSource = dataAcc.Query3Example();
            label21.Text = dataGridView3Example.Rows.Count.ToString() + " rows";
            dataGridView3.DataSource = dataAcc.Query3();
            label22.Text = dataGridView3.Rows.Count.ToString() + " rows";
            if (dataGridView3.RowCount > 0)
                tabControl1.SelectedTab = tabControl1.TabPages["tabQuery3"];

            dataGridView4Example.DataSource = dataAcc.Query4Example();
            label23.Text = dataGridView4Example.Rows.Count.ToString() + " rows";
            dataGridView4.DataSource = dataAcc.Query4();
            label24.Text = dataGridView4.Rows.Count.ToString() + " rows";
            if (dataGridView4.RowCount > 0)
                tabControl1.SelectedTab = tabControl1.TabPages["tabQuery4"];

            dataGridView51Example.DataSource = dataAcc.Query51Example();
            label25.Text = dataGridView51Example.Rows.Count.ToString() + " rows";
            dataGridView51.DataSource = dataAcc.Query51();
            label26.Text = dataGridView51.Rows.Count.ToString() + " rows";
            if (dataGridView51.RowCount > 0)
                tabControl1.SelectedTab = tabControl1.TabPages["tabQuery5"];

            dataGridView52Example.DataSource = dataAcc.Query52Example();
            label27.Text = dataGridView52Example.Rows.Count.ToString() + " rows";
            dataGridView52.DataSource = dataAcc.Query52();
            label28.Text = dataGridView52.Rows.Count.ToString() + " rows";

            labelAgrExample61.Text = dataAcc.Query61Example().ToString();
            labelAgr61.Text = dataAcc.Query61().ToString();
            labelAgrExample62.Text = dataAcc.Query62Example().ToString();
            labelAgr62.Text = dataAcc.Query62().ToString();
            if ((labelAgr61.Text != "-1") || (labelAgr62.Text != "-1"))
                tabControl1.SelectedTab = tabControl1.TabPages["tabQuery6"];

            dataGridViewComplex1.DataSource = dataAcc.ComplexQuery1();
            label29.Text = dataGridViewComplex1.Rows.Count.ToString() + " rows";
            if (dataGridViewComplex1.RowCount > 0)
                tabControl1.SelectedTab = tabControl1.TabPages["tabComplexQuery1"];

            dataGridViewComplex2.DataSource = dataAcc.ComplexQuery2();
            label30.Text = dataGridViewComplex2.Rows.Count.ToString() + " rows";
            if (dataGridViewComplex2.RowCount > 0)
                tabControl1.SelectedTab = tabControl1.TabPages["tabComplexQuery2"];

            dataGridViewComplex3.DataSource = dataAcc.ComplexQuery3();
            label31.Text = dataGridViewComplex3.Rows.Count.ToString() + " rows";
            if (dataGridViewComplex3.RowCount > 0)
                tabControl1.SelectedTab = tabControl1.TabPages["tabComplexQuery3"];
        }
    }
}