using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Недвижимость_клиенты_и_просмотры
{
    public partial class Form1 : Form
    {
        private readonly DBService dBService;
        public Form1()
        {
            InitializeComponent();
            button3.Text = "Показать историю \n просмотров";
            dBService = new DBService(
                "Data Source = Cab109,49172;"
                    + "Initial Catalog = Nedviga;"
                    + "Integrated Security = True"
            );
            dataGridView1.DataSource = dBService.GetAvailableProperties(); 
            dataGridView1.Columns["PropertyId"].Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void button1_Click(object sender, EventArgs e) { }

        private void dataGridView1_CellContentClick_1(
            object sender,
            DataGridViewCellEventArgs e
        ) { }
    }
}
