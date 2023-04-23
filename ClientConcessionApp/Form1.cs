using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClientConcessionApp
{
    public partial class Form1 : Form
    {
        // Initialize a list of user data
        private List<string[]> userData = new List<string[]>
        {
            new[] {"0001", "Jake Decker", "1"},
            new[] {"0002", "Michaela Mercado", "1"},
            new[] {"0003", "Esther Owens", "1"},
            new[] {"0004", "Saira Cline", "1"},
            new[] {"0005", "Kaya Velazquez", "1"},
            new[] {"0006", "Francis Ashley", "1"},
            new[] {"0007", "Zachary Johnson", "1"},
            new[] {"0008", "Sahar Marquez", "1"},
            new[] {"0009", "Miles Lester", "1"},
            new[] {"0010", "Ruth Meadows", "1"},
            new[] {"0011", "Andrea Vega", "1"},
            new[] {"0012", "Zachariah Gray", "1"},
            new[] {"0013", "Ruairi Fisher", "1"},
            new[] {"0014", "Dorothy Ford", "1"},
            new[] {"0015", "Haseed Parker", "1"},
            new[] {"0016", "Maisha Holland", "1"},
            new[] {"0017", "Josephine Morales", "1"},
            new[] {"0018", "Jaxon Ochoa", "1"},
        };

        // Constructor for Form1
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for the submit button
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                int id = int.Parse(txtID.Text);
                string name = txtName.Text;
                DateTime birthday = dtpBirthday.Value;
                string concession = txtConcession.Text;

                UpdateUserList();

                Client client = new Client(id, name, birthday, concession);
                MessageBox.Show(client.ToString(), "Client Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Validate input values from the form
        private bool ValidateInput()
        {
            if (!int.TryParse(txtID.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Please enter a valid positive integer ID.", "Invalid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text) || !Regex.IsMatch(txtName.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Please enter a valid name containing only letters and spaces.", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtConcession.Text))
            {
                MessageBox.Show("Please enter a valid concession.", "Invalid Concession", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // Event handler for the button1 click
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string id = txtID.Text;
                string name = txtName.Text;
                string concessions = txtConcession.Text; // Get the value from the txtConcession input box

                userData.Add(new[] { id, name, concessions }); // Use the value from the txtConcession input box

                // Update the user list
                UpdateUserList();
            }
        }

        // Update the user list in the UI
        private void UpdateUserList()
        {
            lstUserList.Items.Clear();
            foreach (string[] user in userData)
            {
                lstUserList.Items.Add($"ID: {user[0]}, Name: {user[1]}, Concessions: {user[2]}");
            }
        }

        // Event handler for when the form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateUserList();
        }

        // Event handler for when a list box item is selected
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUserList.SelectedIndex >= 0 && lstUserList.SelectedIndex < userData.Count)
            {
                string[] selectedUser = userData[lstUserList.SelectedIndex];
                string id = selectedUser[0];
                string name = selectedUser[1];
                string concessions = selectedUser[2];

                // Display the user's current concessions
                MessageBox.Show($"Concessions for {name} (ID: {id}): {concessions}", "Current Concessions", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Event handler for adding a concession
        private void AddConcession_Click(object sender, EventArgs e)
        {
            if (lstUserList.SelectedIndex >= 0 && lstUserList.SelectedIndex < userData.Count)
            {
                string[] selectedUser = userData[lstUserList.SelectedIndex];
                int concessions = int.Parse(selectedUser[2]);
                concessions += 1;
                selectedUser[2] = concessions.ToString();
                UpdateUserList();
            }
        }

        // Event handler for removing a concession
        private void RemoveConcession_Click(object sender, EventArgs e)
        {
            if (lstUserList.SelectedIndex >= 0 && lstUserList.SelectedIndex < userData.Count)
            {
                string[] selectedUser = userData[lstUserList.SelectedIndex];
                int concessions = int.Parse(selectedUser[2]);
                if (concessions > 0)
                {
                    concessions -= 1;
                }
                selectedUser[2] = concessions.ToString();
                UpdateUserList();
            }
        }

        // Event handler for adding 5 concessions
        private void btnAdd5_Click(object sender, EventArgs e)
        {
            if (lstUserList.SelectedIndex >= 0 && lstUserList.SelectedIndex < userData.Count)
            {
                string[] selectedUser = userData[lstUserList.SelectedIndex];
                int concessions = int.Parse(selectedUser[2]);

                // Add 5 concessions
                concessions += 5;
                selectedUser[2] = concessions.ToString();

                // Update the user list
                UpdateUserList();
            }
        }

        // Event handler for removing 5 concessions
        private void btnRemove5_Click(object sender, EventArgs e)
        {
            if (lstUserList.SelectedIndex >= 0 && lstUserList.SelectedIndex < userData.Count)
            {
                string[] selectedUser = userData[lstUserList.SelectedIndex];
                int concessions = int.Parse(selectedUser[2]);

                // Remove 5 concessions, ensuring the concession number doesn't go below 0
                concessions = Math.Max(0, concessions - 5);
                selectedUser[2] = concessions.ToString();

                // Update the user list
                UpdateUserList();
            }
        }
    }
}
