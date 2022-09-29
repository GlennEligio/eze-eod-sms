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

        private void EodSmsForm_Load(object sender, EventArgs e)
        {
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
            txtBoxStatus.AppendText("Found " + borrows.Count +  " amount of borrow transaction not returned\n");
            pbEodSms.Maximum = borrows.Count;

            // Sending SMS for each borrow transactions
            txtBoxStatus.AppendText("Sending SMS for each borrow transactions. Please do not close the app until it is finished");
            Thread sendThread = new Thread(() => SendThreadStart(borrows));
            sendThread.Start();
        }

        private void SendThreadStart(List<BorrowEquipmentsClass> borrows)
        {
            foreach (BorrowEquipmentsClass borrow in borrows)
            {
                string message = "Hi " + borrow.Borrower + " , you forgot to return the item below\n" +
                    borrow.Equipment_Borrowed + "\n" +
                    "Please return it tomorrow.";
                gsmSms.Send(borrow.Student_Contact_Number, message);
                pbEodSms.PerformStep();
                Thread.Sleep(2000);
            }
        }
    }
}
