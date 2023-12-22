using Models.Shopping;
using System;
using System.Windows.Forms;

namespace EndPoint_Part05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            foreach (var item in groupBox1.Controls)
            {
                if (item is Label)
                {

                }

                if (item is Button)
                {

                }
            }
            */
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            var people = SampleData.Personel.GetPeopleYasamin();

            Grid.DataSource = people;
           
        }

        private void BtnDisplayOrders_Click(object sender, EventArgs e)
        {

            var customer1 = new Customer(fullName:"باید فول نیم در لحظه ایجاد آبجکت مقدار بگیرد");


            var orders = SampleData.Shopping.GetOrders();
            Grid.DataSource = orders;
            

        }

        private void successButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
