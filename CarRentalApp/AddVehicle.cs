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
    public partial class AddVehicle : Form
    {
        private readonly CarRentalEntities1 _db;
        public AddVehicle()
        {
            InitializeComponent();
            _db = new CarRentalEntities1();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var isValid = true;
            var errorMessage = new List<string>();

            try { 

                if (string.IsNullOrEmpty(makeTextBox.Text))         { errorMessage.Add("Make");          isValid = false; }
                if (string.IsNullOrEmpty(modelTextBox.Text))        { errorMessage.Add("Model");         isValid = false; }
                if (string.IsNullOrEmpty(vinTextBox.Text))          { errorMessage.Add("VIN");           isValid = false; }
                if (string.IsNullOrEmpty(yearTextBox.Text))         { errorMessage.Add("Year");          isValid = false; }
                if (string.IsNullOrEmpty(licensePlateTextBox.Text)) { errorMessage.Add("License Plate"); isValid = false; }

                if(isValid == true)
                {
                    var newCarEntry = new TypesOfCar();
                    newCarEntry.Make = makeTextBox.Text;
                    newCarEntry.Model = modelTextBox.Text;
                    newCarEntry.VIN = vinTextBox.Text;
                    newCarEntry.Year = int.Parse(yearTextBox.Text);
                    newCarEntry.LicensePlateNumber = licensePlateTextBox.Text;

                    _db.TypesOfCars.Add(newCarEntry);
                    _db.SaveChanges();
                    MessageBox.Show("New car added successfully in the entries");
                    this.Close();
                    //DialogResult.OK;
                    
                }
                else
                {
                    if (errorMessage.Count() == 1)
                    {
                        MessageBox.Show($"{errorMessage[0]} is blank or missing !");
                    }
                    else
                    {
                        var errStr = string.Empty;

                        for (int i = 0; i < errorMessage.Count(); i++)
                        {
                            if (i == errorMessage.Count() - 1) { errStr += $" and {errorMessage[i]}"; }
                            else if (i == 0) { errStr += errorMessage[i]; }
                            else { errStr += $", {errorMessage[i]}"; }
                        }

                        MessageBox.Show($"{errStr} are blank or missing !");
                    }
                    //MessageBox.Show($"{errorMessage.Count()} of the entries is mising !");
       
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                //throw ex;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
