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
    public partial class MainWindow : Form
    {
        public static int _instanceCount = 0;
        public MainWindow()
        {
            InitializeComponent();
            _instanceCount++;
        }

        public static int InstanceCount {  get { return _instanceCount; } }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageRentalRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addRentalRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
             var addRentalRecord = new AddRentalRecord();
             //addRentalRecord.MdiParent = this;
             addRentalRecord.ShowDialog();            
        }

        private void managingVehicleListingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var vehicleListing = new ManageVehicleListing();
            vehicleListing.ShowDialog();
        }
    }
}
