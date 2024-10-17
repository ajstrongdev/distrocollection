using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using DistroCollection;
using System.Diagnostics.Metrics;
using System.Windows.Forms;

// Refactored code
namespace DistroCollection
{
    public partial class Form1 : Form
    {
        Distribution distro = new Distribution();
        int operation = 0;
        int addDistroCount = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) // On load: Go home
        {
            if (Directory.Exists(@"C:\Distros"))
            {
                // Do nothing
            }
            else
            {
                Directory.CreateDirectory(@"C:\Distros");
            }
            Home();
        }

        private void btnHome_Click(object sender, EventArgs e) // On press: Go home
        {
            Home();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            operation = 1;
            HideOperations();
            rtbxInfo.Text = "Please select a distribution from the list to view.";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operation = 2;
            HideOperations();
            rtbxInfo.Text = "Input distribution name:";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            operation = 3;
            HideOperations();
            rtbxInfo.Text = "Select a distribution from the list that you wish to remove.";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (operation == 0) // If on home screen
            {
                // Do nothing
            }
            if (operation == 1) // If viewing is clicked
            {
                Viewing(tbxInput.Text);
            }
            if (operation == 2) // If adding a distribution
            {
                if (addDistroCount == 0)
                {
                    distro.name = tbxInput.Text;
                    Clearer();
                    rtbxInfo.Text = "Input distribution desktop environment:";
                    addDistroCount++;
                }
                else if (addDistroCount == 1)
                {
                    distro.desktop = tbxInput.Text;
                    Clearer();
                    rtbxInfo.Text = "What is the distribution based on?";
                    addDistroCount++;
                }
                else if (addDistroCount == 2)
                {
                    distro.based = tbxInput.Text;
                    Clearer();
                    rtbxInfo.Text = "Give a summary of the distribution:";
                    addDistroCount++;
                }
                else
                {
                    distro.summary = tbxInput.Text;
                    Clearer();
                    addDistroCount = 0;
                    if (distro.name != "")
                    {
                        string filePath = @$"C:\Distros\{distro.name}.txt";
                        string[] distributionInformation = { $"Distribution: {distro.name}", $"Desktop Environment: {distro.desktop}", $"Based on: {distro.based}", $"Summary: {distro.summary}" };
                        File.WriteAllLines(filePath, distributionInformation);
                        DistributionList();
                        rtbxInfo.Text = "Distribution added!";
                    }
                    else
                    {
                        rtbxInfo.Text = "Error: Distribution name cannot be null!";
                    }
                    btnHome.Show();
                }
            }
            if (operation == 3)
            {
                string deleteDistro = tbxInput.Text;
                File.Delete(@$"C:\Distros\{deleteDistro}.txt");
                Clearer();
                DistributionList();
                rtbxInfo.Text = "Distribution removed!";
                btnHome.Show();
            }
        }

        // UI Handling
        void Home() // Home screen
        {
            operation = 0;
            Clearer();
            DistributionList();
            ShowOperations();
            rtbxInfo.Text = "Welcome to DistroCollection! Please select an operation at the top!";
        }
        void Clearer()
        {
            tbxInput.Clear();
        }
        void DistributionList() // Show distribution list
        {
            // Loading files from directory: https://stackoverflow.com/questions/1277222/how-to-list-text-files-in-the-selected-directory-in-a-listbox
            DirectoryInfo dinfo = new DirectoryInfo(@"C:\Distros");
            FileInfo[] Files = dinfo.GetFiles("*.txt");
            lbxDistributions.Items.Clear();
            foreach (FileInfo file in Files)
            {
                string unformattedName = file.Name.Remove(file.Name.Length - 4, 4); // https://learn.microsoft.com/en-us/dotnet/api/system.string.substring?view=net-8.0
                lbxDistributions.Items.Add(unformattedName);
            }
        }
        void ShowOperations()
        {
            btnView.Show();
            btnAdd.Show();
            btnDelete.Show();
            btnHome.Hide();
        }
        void HideOperations()
        {
            btnView.Hide();
            btnAdd.Hide();
            btnDelete.Hide();
        }
        void Viewing(string distribution)
        {
            btnHome.Show();
            if (File.Exists($@"C:\Distros\{distribution}.txt"))
            {
                rtbxInfo.Text = File.ReadAllText($@"C:\Distros\{distribution}.txt");
            }
            else
            {
                rtbxInfo.Text = "Error: Distribution is not saved on device.";
            }
            Clearer();
        }

        private void tbxInput_KeyDown(object sender, KeyEventArgs e) // If enter is pressed - Act as if btnSubmit is clicked - Ref: https://stackoverflow.com/questions/299086/c-sharp-how-do-i-click-a-button-by-hitting-enter-whilst-textbox-has-focus
        {
            if (e.KeyCode == Keys.Enter) // Fixed bug: '"System.EventArgs" does not contain a definition for "KeyCode"' - Ref: https://stackoverflow.com/questions/11321289/why-am-i-not-able-to-access-the-keycode-member-of-system-eventargs
            {
                btnSubmit.PerformClick();
            }
        }
    }
}