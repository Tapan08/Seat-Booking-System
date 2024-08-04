using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Button[,] buttons = new Button[3, 4]; // 2D array to store the buttons representing each seat
        private bool[,] seatStatus = new bool[3, 4]; // 2D array to store the status of each seat: true for booked, false for available
        private List<string> waitList = new List<string> { }; // List of waitlisted people
        ToolTip buttonToolTip = new ToolTip(); // ToolTip of the buttons
        ToolTip buttonToolTip2 = new ToolTip(); // Secondary tooltip for renwing the buttons after moving the customers from WL to the seats
        double count = 12; // Tracks the number of available seats

        public Form1()
        {
            InitializeComponent();

            // Clear any existing iteams in the List Box to avoid duplication

            rowListBox.Items.Clear();
            seatNumberListBox.Items.Clear();

            // Populate the rowListBox with the rows (A to C)
            for (char row = 'A'; row <= 'C'; row++)
            {
                rowListBox.Items.Add(row);
            }

            // Populate the seatNumberListBox with the seat numbers (1 to 4)
            for (int seatNumber = 1; seatNumber <= 4; seatNumber++)
            {
                seatNumberListBox.Items.Add(seatNumber);
            }

            // Initialize the buttons and seatStatus arrays
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[0, 0] = buttonA1;
                    buttons[0, 1] = buttonA2;
                    buttons[0, 2] = buttonA3;
                    buttons[0, 3] = buttonA4;
                    buttons[1, 0] = buttonB1;
                    buttons[1, 1] = buttonB2;
                    buttons[1, 2] = buttonB3;
                    buttons[1, 3] = buttonB4;
                    buttons[2, 0] = buttonC1;
                    buttons[2, 1] = buttonC2;
                    buttons[2, 2] = buttonC3;
                    buttons[2, 3] = buttonC4;

                    buttons[i, j].Text = (char)('A' + i) + (j + 1).ToString();
                    buttons[i, j].BackColor = System.Drawing.Color.Green;
                    this.Controls.Add(buttons[i, j]);

                    seatStatus[i, j] = false;

                    buttonToolTip.SetToolTip(this.buttons[i, j], "Available");
                }
            }
            label4.Text = "Total capacity: 12 " + " Seats available: 12 (i.e) at " + Math.Round(count * 100 / 12, 2) + "% capacity.";
            label5.Text = "Waitlist: ";
            bookButton.Click += new System.EventHandler(this.BookButtonClick);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // BookButtonClick method is for adding the customers to the seats after verifying every informations
        private void BookButtonClick(object sender, EventArgs e)
        {
            label5.Text = "";

            if (rowListBox.SelectedIndex != -1 && seatNumberListBox.SelectedIndex != -1)
            {
                int row = rowListBox.SelectedIndex;
                int col = seatNumberListBox.SelectedIndex;

                if (!seatStatus[row, col])
                {
                    string customerName = customerNameTextBox.Text;

                    if (!string.IsNullOrEmpty(customerName))
                    {
                        // Set up the delays for the ToolTip.
                        buttonToolTip.AutoPopDelay = 5000;
                        buttonToolTip.InitialDelay = 1000;
                        buttonToolTip.ReshowDelay = 500;
                        // Force the ToolTip text to be displayed whether or not the form is active.
                        buttonToolTip.ShowAlways = true;

                        // Set up the ToolTip text for the Button and Checkbox.
                        buttonToolTip.SetToolTip(this.buttons[row, col], "Booked by: " + customerName);
                        buttonToolTip2.SetToolTip(this.buttons[row, col], "");
                        seatStatus[row, col] = true;
                        buttons[row, col].BackColor = System.Drawing.Color.Red;
                        label5.Text = customerName + " was booked in this seat.";
                        count--;
                        label4.Text = "Total capacity: 12 " + " Seats available: " + count + " (i.e) at " + Math.Round((12 - count) * 100 / 12, 2) + "% capacity.";
                    }
                    else
                    {
                        label5.Text = "Please enter customer name.";
                    }
                }
                else if (seatStatus[row, col] && count == 0)
                {
                    // Shifting the method from BookButtonClick to WL if the available seats are 0
                    buttonWL_Click(sender, e);
                }
                else
                {
                    label5.Text = "Seat is already booked.";
                }
            }
            else
            {
                label5.Text = "Please select a row and seat number.";
            }

        }
        // CA = Clear All, This method clears all booked seats and WL
        private void buttonCA_Click(object sender, EventArgs e)
        {
            label5.Text = "All seats are now available.";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    seatStatus[i, j] = false;
                    buttons[i, j].BackColor = System.Drawing.Color.Green;
                    count = 12;
                    waitList.Clear();
                    label4.Text = "Total capacity: 12 " + " Seats available: " + count + " (i.e) at " + Math.Round((12 - count) * 100 / 12, 2) + "% capacity.";
                    label5.Text = "Waitlist: " + String.Join(", ", waitList);
                    buttonToolTip.SetToolTip(this.buttons[i, j], "Available");
                    buttonToolTip2.SetToolTip(this.buttons[i, j], "");
                }
            }
        }
        // Cancel method clears the picked seat information and make it available if listbox information is correct 
        private void buttonCancel_Click(object sender, EventArgs e)
        {

            label5.Text = "";

            if (rowListBox.SelectedIndex != -1 && seatNumberListBox.SelectedIndex != -1)
            {
                int row = rowListBox.SelectedIndex;
                int col = seatNumberListBox.SelectedIndex;
                if (seatStatus[row, col])
                {
                    // Asking for confirmation of cancelation
                    DialogResult dialogResult = MessageBox.Show("Are you sure about the cancelation?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        buttonToolTip.SetToolTip(this.buttons[row, col], "Available");
                        buttonToolTip2.SetToolTip(this.buttons[row, col], "");
                        seatStatus[row, col] = false;
                        buttons[row, col].BackColor = System.Drawing.Color.Green;
                        label5.Text = "The seat is now available.";
                        count++;
                        label4.Text = "Total capacity: 12 " + " Seats available: " + count + " (i.e) at " + Math.Round((12 - count) * 100 / 12, 2) + "% capacity.";
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        label5.Text = "You canceled the cancelation.";
                    }
                }
                else
                {
                    label5.Text = "Seat is already available.";
                }
            }
            else
            {
                label5.Text = "Please select a row and seat number.";
            }
            // If waitlist is not empty and any seat is available the if brings the first perosn added to the WL and puts him/her in the canceled seat
            if (waitList.Count() > 0 && count > 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (seatStatus[i, j] == false)
                        {
                            seatStatus[i, j] = true;
                            buttonToolTip.SetToolTip(this.buttons[i, j], "");
                            buttonToolTip2.SetToolTip(this.buttons[i, j], "Booked by: " + waitList[0]);
                            buttons[i, j].BackColor = System.Drawing.Color.Red;
                            label5.Text = waitList[0] + " added from the waitlist to the canceled seat.";
                            waitList.RemoveAt(0);
                            count--;
                            label4.Text = "Total capacity: 12 " + " Seats available: " + count + " (i.e) at " + Math.Round((12 - count) * 100 / 12, 2) + "% capacity.";
                            label5.Text = "Waitlist: " + String.Join(", ", waitList);
                        }
                    }
                }
            }
        }
        // Fills all empty seats and name them after the typed name in the textbox
        private void buttonFA_Click(object sender, EventArgs e)
        {
            label5.Text = "All seats now are filled.";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (!seatStatus[i, j] && !string.IsNullOrEmpty(customerNameTextBox.Text))
                    {
                        seatStatus[i, j] = true;
                        buttons[i, j].BackColor = System.Drawing.Color.Red;
                        count = 0;
                        label4.Text = "Total capacity: 12 " + " Seats available: " + count + " (i.e) at " + Math.Round((12 - count) * 100 / 12, 2) + "% capacity.";
                        label5.Text = "Waitlist: " + String.Join(", ", waitList);
                        buttonToolTip.SetToolTip(this.buttons[i, j], "Booked by: " + customerNameTextBox.Text);
                        label5.Text = "All remaining empty seats now are book under name: " + customerNameTextBox.Text;
                    }
                    else if (string.IsNullOrEmpty(customerNameTextBox.Text))
                    {
                        label5.Text = "Please enter the name of the customer that you are willing to fill the rest of the seats with.";
                    }
                    else
                    {
                        label5.Text = "All seats are already filled";
                    }
                }
            }
        }

        private void stat_Click(object sender, EventArgs e)
        {

        }
        // Adds customers to the WL if not seat is available
        private void buttonWL_Click(object sender, EventArgs e)
        {
            label5.Text = "";

            int track = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (seatStatus[i, j])
                    {
                        track++;
                    }
                }
            }
            if (track == 12)
            {
                if (!(customerNameTextBox.Text == string.Empty))
                {
                    waitList.Add(customerNameTextBox.Text);
                    label5.Text = customerNameTextBox.Text + " has been added to the waitlist";
                    label5.Text = "Waitlist: " + String.Join(", ", waitList);
                }
                else
                {
                    label5.Text = "Please type customer's name that you are willing to waitlist.";
                }
            }
            else
            {
                label5.Text = "The seats are not all occupied yet.";
            }
        }

        private void bookButton_Click(object sender, EventArgs e)
        {

        }

        private void buttonA1_Click(object sender, EventArgs e)
        {

        }

        private void rowListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void seatNumberListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

