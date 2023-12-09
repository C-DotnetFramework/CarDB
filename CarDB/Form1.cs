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
                //��Ż ���
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
                        MakerName = item.Car.Maker.Name, //Include(p => p.Car.Maker) �̰� �߰� �����ν� ������ ������ ����
                        RentalDate = item.RentalDate,
                        ReturnDate = item.ReturnDate
                    });
                }

                //���� ���
                listBox1.DisplayMember = "ModelName";
                foreach (var item in db.Cars)
                {
                    listBox1.Items.Add(item);
                }

                //�� ���
                listBox2.DisplayMember = "Name";
                foreach (var item in db.Customers)
                {
                    listBox2.Items.Add(item);
                }
            }
            dataGridView1.DataSource = list;
        }

        //��Ż ��ư
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
                View(); //ȭ�� ����
            }
        }

        //�ݳ� ��ư
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in dataGridView1.SelectedRows)
            {
                System.Diagnostics.Debug.WriteLine(((item as DataGridViewRow).DataBoundItem as RentalForView).RentalId);
            }
        }
    }
}