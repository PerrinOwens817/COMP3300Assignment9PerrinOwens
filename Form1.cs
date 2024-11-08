using System.Text.Json;

namespace COMP3300Assignment9PerrinOwens
{
    public partial class Form1 : Form
    {

        private List<SavingsAccount> savingsAccounts;
        private List<CheckingAccount> checkingAccounts;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                var jsonString = File.ReadAllText(filePath);
                var accounts = JsonSerializer.Deserialize<List<BankAccount>>(jsonString);

                List<SavingsAccount> savingsAccounts = new List<SavingsAccount>();
                List<CheckingAccount> checkingAccounts = new List<CheckingAccount>();

                foreach (var account in accounts)
                {
                    switch (account.Type)
                    {
                        case "Savings:":
                            savingsAccounts.Add(new SavingsAccount(account.OwnerName, account.Balance, account.MonthOpened, account.InterestRate, account.Type));
                            break;
                        case "Checking:":
                            checkingAccounts.Add(new CheckingAccount(account.OwnerName, account.Balance, account.MonthOpened, account.InterestRate, account.Type));
                            break;
                    }
                }
            }
        }
    }
}
