using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Junction_Maker
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();


        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            txtTargetDirectory.Text = folderBrowserDialog.SelectedPath;

        }

        private void btnMakeLink_Click(object sender, EventArgs e)
        {

            lblOutput.Text = "";
            
            //Check if both fields are filled with at least one character
            if (txtLinkName.Text.Length <= 0)
            {
                MessageBox.Show("Please enter a link name.", "Field required", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            //Check if both fields are filled with at least one character
            if (txtTargetDirectory.Text.Length <= 0)
            {
                MessageBox.Show("Please enter a target path.", "Field required", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            //check if the directory exists
            if (!Directory.Exists(txtTargetDirectory.Text))
            {
                MessageBox.Show("Directory does not exist, please try again.", "Field required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            DialogResult result = MessageBox.Show("Create a junction in this folder?\n\n" + Directory.GetCurrentDirectory() + "\n\n to this folder?\n\n" + txtTargetDirectory.Text, "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
            {
                //cancel operation
                return;
            }

            //everything okay, run mklink with admin rights
            string strCmdText;
            strCmdText = "/C mklink /J \"" + txtLinkName.Text + "\" \"" + txtTargetDirectory.Text + "\"";

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;                                       //hide window
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = strCmdText;
            startInfo.UseShellExecute = false;                                                                          //must be false to redirect output
            startInfo.RedirectStandardOutput = true;                                                                    //redirect the outputs
            startInfo.RedirectStandardError = true;
            startInfo.WorkingDirectory = Directory.GetCurrentDirectory();


            //start the command window
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();

            //dump out the output from the window
            string output = process.StandardOutput.ReadToEnd();
            string errorOutput = process.StandardError.ReadToEnd();

            lblOutput.Text = "Output: \n" + output + "\n" +
                 ((errorOutput.Length > 0) ? ("Error: " + errorOutput) : "Successfully created junction!");



            //inform user of results
            if (errorOutput.Length <= 0)
            {
                MessageBox.Show("Junction successfully created", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start("explorer.exe", "/select,\"" + Directory.GetCurrentDirectory() + "\\" + txtLinkName.Text + "\"");
            }
            else
            {
                MessageBox.Show("Junction creation failed, see output", "Error",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
