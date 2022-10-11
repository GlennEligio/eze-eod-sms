using GSM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EODSMS
{
    public partial class EodSmsForm : MetroFramework.Forms.MetroForm
    {

        private GSMsms gsmSms;
        private BorrowEquipmentsClassRepository repository;

        public EodSmsForm()
        {
            InitializeComponent();
        }

        private void SendThreadStart(List<BorrowEquipmentsClass> borrows)
        {
            foreach (BorrowEquipmentsClass borrow in borrows)
            {
                string message = "Hi " + borrow.Borrower + " , you forgot to return the item below\n" +
                    borrow.Equipment_Borrowed + "\n" +
                    "Please return it tomorrow.";
                bool success = gsmSms.Send(borrow.Student_Contact_Number, message);
                pbEodSms.PerformStep();
                if(success)
                {
                    lblMessages.Text = (Int32.Parse(lblMessages.Text) + 1).ToString();
                }
                Thread.Sleep(2000);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            // Setup the Control
            lblItems.Text = 0.ToString();
            lblMessages.Text = 0.ToString();

            // Setting up the GSM module
            txtBoxStatus.AppendText("Setting up GSM module\n");
            gsmSms = GSMsms.getInstance();
            gsmSms.Connect();

            // Setting up the database connection
            txtBoxStatus.AppendText("Setting up database connection\n");
            string cnUrl = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            repository = BorrowEquipmentsClassRepository.getInstance(cnUrl);

            pbEodSms.Value = 0;

            // Fetching the borrow transactions from database
            txtBoxStatus.AppendText("Fetching the borrow transactions from database\n");
            List<BorrowEquipmentsClass> borrows = repository.getBorrowEquipmentsByStatus("VERIFIED");

            // Found X amount of borrow transaction not returned
            txtBoxStatus.AppendText("Found " + borrows.Count + " amount of borrow transaction not returned\n");
            lblItems.Text = borrows.Count.ToString();
            pbEodSms.Maximum = borrows.Count;

            // Sending SMS for each borrow transactions
            txtBoxStatus.AppendText("Sending SMS for each borrow transactions. Please do not close the app until it is finished");

            if(gsmSms.isConnected)
            {
                Thread sendThread = new Thread(() => SendThreadStart(borrows));
                sendThread.Start();
            }
        }
    }
}
