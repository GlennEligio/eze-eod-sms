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
            txtBoxStatus.AppendText("Checking the GSM module connection" + Environment.NewLine);
            gsmSms = GSMsms.getInstance();
            gsmSms.Connect();

            if(!gsmSms.isConnected)
            {
                txtBoxStatus.AppendText("GSM module not found. Check the GSM connection in the App.config file." + Environment.NewLine);
                txtBoxStatus.AppendText("Application will now close" + Environment.NewLine);
                Thread.Sleep(5000);
                Application.Exit();
                return;
            }

            // Setting up the database connection
            txtBoxStatus.AppendText("Checking the database connection" + Environment.NewLine);
            string cnUrl = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            repository = BorrowEquipmentsClassRepository.getInstance(cnUrl);

            pbEodSms.Value = 0;

            // Fetching the borrow transactions from database
            txtBoxStatus.AppendText("Fetching the borrow transactions from database" + Environment.NewLine);
            List<BorrowEquipmentsClass> borrows = repository.getBorrowEquipmentsByStatus("VERIFIED");

            if(borrows.Count == 0)
            {
                txtBoxStatus.AppendText("No pending borrow transaction was found." + Environment.NewLine);
                txtBoxStatus.AppendText("Application will now close" + Environment.NewLine);
                Thread.Sleep(5000);
                Application.Exit();
                return;
            }

            // Found X amount of borrow transaction not returned
            txtBoxStatus.AppendText("Found " + borrows.Count + " amount of borrow transaction not returned" + Environment.NewLine);
            lblItems.Text = borrows.Count.ToString();
            pbEodSms.Maximum = borrows.Count;

            // Sending SMS for each borrow transactions
            txtBoxStatus.AppendText("Sending SMS for each borrow transactions. Please do not close the app until it is finished" + Environment.NewLine);

            if(gsmSms.isConnected)
            {
                Thread sendThread = new Thread(() => SendThreadStart(borrows));
                sendThread.Start();
            }
        }
    }
}
