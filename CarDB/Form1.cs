using CarDB.carDB;
using Microsoft.EntityFrameworkCore;

namespace CarDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            View();
        }

        void View()
        {
            List<RentalForView> list = new List<RentalForView>();
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            using (var db = new CarDbContext())
            {
                //렌탈 목록
                foreach (var item in db.Rentals
                                    .Include(p => p.Car)
                                    .Include(p => p.Car.Maker)
                                    .Include(p => p.Customer))
                {
                    list.Add(new RentalForView()
                    {
                        RentalId = item.Id,
                        CarModel = item.Car.ModelName,
                        CarColor = item.Car.Color,
                        CustomerName = item.Customer.Name,
                        MakerName = item.Car.Maker.Name, //Include(p => p.Car.Maker) 이걸 추가 함으로써 오류가 나오지 않음
                        RentalDate = item.RentalDate,
                        ReturnDate = item.ReturnDate
                    });
                }

                //차량 목록
                listBox1.DisplayMember = "ModelName";
                foreach (var item in db.Cars)
                {
                    listBox1.Items.Add(item);
                }

                //고객 목록
                listBox2.DisplayMember = "Name";
                foreach (var item in db.Customers)
                {
                    listBox2.Items.Add(item);
                }
            }
            dataGridView1.DataSource = list;
        }

        //렌탈 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            var selectedCar = listBox1.SelectedItem as Car;
            var selectedCustomer = listBox2.SelectedItem as Customer;

            if (selectedCar != null && selectedCustomer != null)
            {
                using (var db = new CarDbContext())
                {
                    db.Rentals.Add(new Rental()
                    {
                        CarId = selectedCar.Id,
                        CustomerId = selectedCustomer.Id,
                        RentalDate = dateTimePicker1.Value,
                        ReturnDate = null
                    });
                    db.SaveChanges();
                }
                View(); //화면 갱신
            }
        }

        //반납 버튼
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in dataGridView1.SelectedRows)
            {
                System.Diagnostics.Debug.WriteLine(((item as DataGridViewRow).DataBoundItem as RentalForView).RentalId);
            }
        }
    }
}