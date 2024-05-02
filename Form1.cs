using System;
using System.Windows.Forms;

namespace PartyOrganizer
{
    // Main form for the party organizer application
    public partial class MainForm : Form
    {
        private Party party; 

        // Constructor for the MainForm class
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI(); 
        }

        // Method to initialize the graphical user interface
        private void InitializeGUI()
        {
            // reset various labels and text boxes to default values
            lblTotalGuestsOutput.Text = "0";
            lblTotalCostOutput.Text = "0.0";
            lblTotalFeesOutput.Text = "0.0";
            lblTotalSurplusOutput.Text = "0.0";
            lstGuestList.Items.Clear();
            grpAddGuests.Enabled = false;
            grpNewParty.Enabled = true;

            txtMaxNum.Text = string.Empty;
            txtAmount.Text = string.Empty;
            txtFee.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
        }

        // Method to validate numeric input
        private bool ValidateNumericInput(string input, string fieldName)
        {
            if (!double.TryParse(input, out double value) || value <= 0)
            {
                MessageBox.Show($"Please enter a valid {fieldName}.", "Error");
                return false;
            }
            return true;
        }

        // Method to validate text input
        private bool ValidateTextInput(string text, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show($"Please provide a valid {fieldName}.", "Error");
                return false;
            }
            return true;
        }

        // Method to create a new party
        private bool CreateParty()
        {
            // Validate input fields
            if (!ValidateNumericInput(txtMaxNum.Text, "maximum number") ||
                !ValidateNumericInput(txtAmount.Text, "cost amount") ||
                !ValidateNumericInput(txtFee.Text, "fee amount"))
            {
                return false;
            }
         
            int maxNumber = int.Parse(txtMaxNum.Text);
            double costPerPerson = double.Parse(txtAmount.Text);
            double feePerPerson = double.Parse(txtFee.Text);

            
            party = new Party(maxNumber);
            party.CostPerGuest = costPerPerson;
            party.FeePerGuest = feePerPerson;

            MessageBox.Show($"Party List Created for {maxNumber} guests!");

            return true;
        }

        // Method to update the graphical user interface
        private void UpdateGUI()
        {
            lstGuestList.Items.Clear();
            string[] guestList = party.GetGuestList();

            // Populate guest list in the list box
            if (guestList != null)
            {
                for (int i = 0; i < guestList.Length; i++)
                {
                    string str = $"{i + 1,4} {guestList[i],-20} ";
                    lstGuestList.Items.Add(str);
                }
            }

            // Update labels with party statistics
            int numOfGuests = party.NumOfGuests();
            double totalCost = party.CalcTotalCost();
            double totalFees = party.CalcTotalFees();
            double surplus = CalculateSurplus(totalCost, totalFees);

            lblTotalGuestsOutput.Text = numOfGuests.ToString(); // Update total guests label
            lblTotalFeesOutput.Text = totalFees.ToString("0.0");
            lblTotalCostOutput.Text = totalCost.ToString("0.0");
            lblTotalSurplusOutput.Text = surplus.ToString("0.0");
        }

        // Method to calculate surplus/deficit
        private double CalculateSurplus(double totalCost, double totalFees)
        {
            return totalFees - totalCost;
        }

        // Event handler for the "Create Party" button click
        private void btnCreateParty_Click(object sender, EventArgs e)
        {
            if (CreateParty())
            {
                grpAddGuests.Enabled = true;
                UpdateGUI(); // Update GUI after creating the party
            }
        }

        // Adding new names to list or write list is full
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateTextInput(txtFirstName.Text, "first name") &&
                ValidateTextInput(txtLastName.Text, "last name"))
            {
                txtFirstName.Text = txtFirstName.Text.Trim();
                txtLastName.Text = txtLastName.Text.Trim();
                bool ok = party.AddNewGuest(txtFirstName.Text, txtLastName.Text);
                if (!ok)
                {
                    MessageBox.Show("List is full, Error");
                }
                else
                {
                    UpdateGUI();
                }
            }
        }

        // Event handler for the Change button click
        private void btnChange_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstGuestList.SelectedIndex;

            if (selectedIndex < 0 || party == null)
                return;

            if (ValidateTextInput(txtFirstName.Text, "First name") &&
                ValidateTextInput(txtLastName.Text, "last name"))
            {
                txtFirstName.Text = txtFirstName.Text.Trim();
                txtLastName.Text = txtLastName.Text.Trim();
                if (party.ChangeGuest(selectedIndex, txtFirstName.Text, txtLastName.Text))
                {
                    MessageBox.Show("Guest Changed", "Success");
                }
                else
                {
                    MessageBox.Show("Guest Not Changed!", "Error");
                }

                UpdateGUI();
            }
        }

        // Event handler for the Delete button click
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            int selectedIndex = lstGuestList.SelectedIndex;

            if ((selectedIndex < 0) || (party == null))
                return;

            if (selectedIndex >= 0 && party.DeleteGuest(selectedIndex))
            {
                MessageBox.Show("Guest Deleted", "Success");
            }
            else
            {
                MessageBox.Show("Guest Not Deleted!", "Error");
            }

            UpdateGUI();
        }

        // Event handler for the selection change in the guest list
        private void lstGuestList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = lstGuestList.SelectedIndex;

            if (selectedIndex < 0 || party == null)
                return;

            string[] name = party.GetGuestName(selectedIndex);

            if (name != null)
            {
                txtLastName.Text = name[0].Trim();
                txtFirstName.Text = name[1].Trim();
            }
        }

        // Unused event handlers
        private void txtAmount_TextChanged(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
    }
}


