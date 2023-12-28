using EndPoint_Part05.CustomControl;
using Models.Shopping;
using System;
using System.Windows.Forms;
using SadrTools.Extension;
using Models.Personel;
using System.Linq;
using System.Drawing;
using ViewModels.Personel;

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
            Button button = new Button();

            Button button1 = new SuccessButton();

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
            //Models.Personel_Adv.Person[] people = SampleData.Personel.GetPeopleYasamin();

            var people = SampleData.Personel.GetPeople();

            Grid.DataSource = people;

            var resultInText = people.PrintMe<Person>();

            MessageBox.Show(resultInText);

        }

        private void BtnDisplayOrders_Click(object sender, EventArgs e)
        {

            var customer1 = new Customer(fullName: "باید فول نیم در لحظه ایجاد آبجکت مقدار بگیرد");


            var orders = SampleData.Shopping.GetOrders();
            Grid.DataSource = orders;


        }

        private void SuccessButton1_Click(object sender, EventArgs e)
        {

            //ToDo : Yasamin : Linq Examples on Orders ( GRP , ... ) 

            //ToDo : Intamedia




        }

        private void BtnPersonDTO_Click(object sender, EventArgs e)
        {
            // DTO       : DATA TRANSFER OBJECT

            // ViewModel : برای نمایش برای گرید ....و لزوما در دیتابیس یا در لایه دامین شما به این شکل وجود ندارد

            // PersonDto
            // PersonViewModel


            var people = SampleData.Personel.GetPeople().Select(x => new
            {
                MyFullName = x.FullName,
                MyAlaki = x.Age
            }).ToList();


            Grid.DataSource = people;

            MessageBox.Show("Continue ..........? ");


            var people2 = SampleData.Personel.GetPeople().Select(x =>
            new PersonViewModel
            {
                PersonID = x.ID,
                Age = x.Age,
                Birthday = x.PersianBirthDate,
                PersonLastName = x.LastName,
                PersonName = x.FirstName
            }).ToList();

            Grid.DataSource = people2;
        }
    }
}
