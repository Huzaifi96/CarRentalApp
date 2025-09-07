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
    public partial class AddRentalRecord : Form
    {
        private readonly CarRentalEntities1 carRentalEntities;
        public static int _istanceCount = 0;
        public AddRentalRecord()
        {
            InitializeComponent();
            carRentalEntities = new CarRentalEntities1();
            _istanceCount++;
        }
        public static int GetInstanceCount {  get { return _istanceCount; } }

        private void SubmitButtonClicked(object sender, EventArgs e)
        {
            try
            {
                var isValid = true;
                var errorMessage = string.Empty;

                if (string.IsNullOrEmpty(tbCustomerName.Text) || string.IsNullOrWhiteSpace(tbCustomerName.Text))
                {
                    errorMessage += "Invalid Customer name: customer name is empty ! \n\r";
                    isValid = false;
                }

                if (string.IsNullOrEmpty(tbCost.Text))
                {
                    errorMessage += "Invalid Cost input: cost is empty ! \n\r";
                    isValid = false;
                }

                if (dateRentPicker.Value > dateReturnPicker.Value)
                {
                    errorMessage += "Invalid Date: Return date shall not be before Pick date \n\r";
                    isValid = false;
                }

                if (isValid)
                {
                    var rentalRecord = new CarRentalRecord();
                    rentalRecord.CustomerName = tbCustomerName.Text;
                    rentalRecord.DateRented = dateRentPicker.Value;
                    rentalRecord.DateReturned = dateReturnPicker.Value;
                    rentalRecord.Cost = decimal.Parse(tbCost.Text);
                    rentalRecord.TypeOfCarId = (int)cbCarSelected.SelectedValue;

                    carRentalEntities.CarRentalRecords.Add(rentalRecord);
                    carRentalEntities.SaveChanges();

                    MessageBox.Show(
                    $"Dear {tbCustomerName.Text}, Thank you for renting our {cbCarSelected.Text} car, from {dateRentPicker.Text} to {dateReturnPicker.Text}");
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                throw;
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var cars = carRentalEntities.TypesOfCars.ToList();
            var cars =  carRentalEntities.TypesOfCars
                .Select(q => new
                {
                    id = q.id,
                    Name = q.Make + " " + q.Model
                })
                .ToList();
            cbCarSelected.DisplayMember = "Name";
            cbCarSelected.ValueMember = "id";
            cbCarSelected.DataSource = cars;
        }

    }
}
