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
    public partial class EditVehicle : Form
    {
        private readonly CarRentalEntities1 _db;
        private TypesOfCar editedCar;
        public EditVehicle(TypesOfCar editCar)
        {
            InitializeComponent();
            editedCar = editCar;
            _db = new CarRentalEntities1();
            PopulateField(editCar);
        }

        private void PopulateField(TypesOfCar editCar)
        {
            mainHeading.Text = "Edit Vehicle ID " + editCar.id.ToString();
            makeTextBox.Text = editCar.Make;
            modelTextBox.Text = editCar.Model;
            vinTextBox.Text = editCar.VIN;
            yearTextBox.Text = editCar.Year.ToString();
            licensePlateTextBox.Text = editCar.LicensePlateNumber;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var id = editedCar.id;
            var car = _db.TypesOfCars.FirstOrDefault(t => t.id == id);
            try
            {
                car.Make = makeTextBox.Text;
                car.Model = modelTextBox.Text;
                car.VIN = vinTextBox.Text;
                car.Year = int.Parse(yearTextBox.Text);
                car.LicensePlateNumber = licensePlateTextBox.Text;

                _db.SaveChanges();

                MessageBox.Show("Car updated successfully in the entries");
                this.Close();

            }
            catch (Exception ex){
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
