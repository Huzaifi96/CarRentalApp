using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp
{
    public partial class ManageVehicleListing : Form
    {
        private readonly CarRentalEntities1 _db;
        public ManageVehicleListing()
        {
            InitializeComponent();
            _db = new CarRentalEntities1();
        }

        private void ManageVehicleListing_Load(object sender, EventArgs e)
        {
            //select column id and car name column from table TypesOfCars
            var cars = _db.TypesOfCars
                .Select(q => new 
                {  Make = q.Make,
                   Model = q.Model,
                   VIN = q.VIN,
                   Year = q.Year,
                   LicensePlateNumber = q.LicensePlateNumber,
                   q.id
                })
                .ToList();
            gvVehicleList.DataSource = cars;
            gvVehicleList.Columns[4].HeaderText = "License Plate Number";
            gvVehicleList.Columns[5].Visible = false;
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            var addVehicleForm = new AddVehicle();
            addVehicleForm.ShowDialog();

            ManageVehicleListing_Load(sender, e);
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            var id = (int)gvVehicleList.SelectedRows[0].Cells["id"].Value;

            var car = _db.TypesOfCars.FirstOrDefault(q => q.id == id);

            var editVehicle = new EditVehicle(car);
            editVehicle.ShowDialog();
            ManageVehicleListing_Load(sender,e);
        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            var id = (int)gvVehicleList.SelectedRows[0].Cells["id"].Value;

            var car = _db.TypesOfCars.FirstOrDefault(q => q.id == id);

            _db.TypesOfCars.Remove(car);
            _db.SaveChanges();

            MessageBox.Show($"Item {id} successfully deleted ");
            ManageVehicleListing_Load(sender, e);
        }
    }
}
