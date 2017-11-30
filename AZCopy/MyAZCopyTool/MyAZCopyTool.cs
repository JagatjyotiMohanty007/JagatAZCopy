using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Net;
using System.IO;

using System.Diagnostics;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;

// Test comment

namespace MyAZCopyTool
{
    public partial class MyAZCopyTool : Form
    {
        public MyAZCopyTool()
        {
            InitializeComponent();
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            try
            {
                //var result = InitializeOpenFileDialog("Road Sign");
                //InitializeOpenFileDialog();

                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtbrowse.Text = folderBrowserDialog1.SelectedPath;
                }

                // if (result != null && result != "")
                // MessageBox.Show(result, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void InitializeOpenFileDialog()
        {
            //try
            //{
            //    // Set the file dialog to filter for graphics files.
            //    Openfolder x = new OpenFileDialog();
            //    x.Multiselect = true;
            //   // x.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            //    x.ShowDialog();
            //    string[] result = x.FileNames;
            //    if (result.Count() <= 0)
            //    {
                    
            //    }
            //    //Uncomment this tej
              

            //    foreach (string y in result)
            //    {
            //        string Ftype = y.Split('.').Last();
            //        //Fname += "#" + Tid;
            //        String guid = Guid.NewGuid().ToString();
            //        guid += "." + Ftype;
            //        string Fname = y.Split('\\').Last();
                   

            //    }


            //}
            //catch (Exception ex)
            //{

            //    throw ex;
            //}

        }

        public void DataMovementUsingAZCopyTool(string onpremisepath,string containername,string deststoragekey,string storageurl)
        {
            string StorageAccountKey = ConfigurationManager.ConnectionStrings["StorageConnectionString"].ConnectionString; ;

            CloudStorageAccount sourceCloudStorageAccount = CloudStorageAccount.Parse(StorageAccountKey);

            CloudBlobClient sourceCloudBlobClient = sourceCloudStorageAccount.CreateCloudBlobClient();

            List<string> outputLines = new List<string>();

            IEnumerable<CloudBlobContainer> containers = sourceCloudBlobClient.ListContainers();

            Process cmd = new Process();

            System.Diagnostics.ProcessStartInfo StartInfo = new System.Diagnostics.ProcessStartInfo();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = false; 
            cmd.StartInfo.UseShellExecute = false;
           // cmd.StartInfo.Verb = "runas";
           cmd.Start();


         

            int i = 0;

            //  foreach (CloudBlobContainer oneContainer in containers)
            {


                // string strCmdText = @"AzCopy /Source:D:\VisualStudioProjects\WabtecOne\Doc\ToBlob" + @" /Dest:https://manasastorage.blob.core.windows.net/" + "samples" + @" /DestKey:Qh9w7jHzTtmtOaHytuKhxdAk5PIHhiAyqxP2LQzxRRlYqiABlNpgdAZkfjlecYGW5PWZi+AZAAKgwmnHU3KE4Q== /S /NC:8 /XO /Y";

                // string strCmdText = @"AzCopy /Source:" + onpremisepath + @" /Dest:" +storageurl  + containername + @" /DestKey:" + deststoragekey + " /S /NC:8 /XO /Y";

                string strCmdText = @"AzCopy /Source:D:\VisualStudioProjects\WabtecOne\Doc\ToBlob" + @" /Dest:https://manasastorage.blob.core.windows.net/samples"  + @" /DestKey:Qh9w7jHzTtmtOaHytuKhxdAk5PIHhiAyqxP2LQzxRRlYqiABlNpgdAZkfjlecYGW5PWZi+AZAAKgwmnHU3KE4Q== /S /NC:8 /XO /Y";

                string location = @"cd C:\Program Files (x86)\Microsoft SDKs\Azure\AzCopy";

          
             
                cmd.StandardInput.WriteLine(location);
                cmd.StandardInput.WriteLine(strCmdText);

                //cmd.StartInfo.Arguments = location;
                //cmd.StartInfo.Arguments = strCmdText;

                //System.Threading.Thread.Sleep(20000);
                //cmd.WaitForExit();
                //i++;
                //if (i == 15)
                //{
                //    break;
                //}

            }

            string[] outputText = outputLines.ToArray();

            System.IO.File.WriteAllLines(@"C:\AzureTests\CopyData.txt", outputText);

            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());

            Console.ReadLine();

            MessageBox.Show("Successfully Copied", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataMovementUsingAZCopyTool(txtbrowse.Text, cmbContainerName.Text.ToString(), txtStKey.Text , "https://manasastorage.blob.core.windows.net/");
        }

        private void MyAZCopyTool_Load(object sender, EventArgs e)
        {
            ToolTip t1 = new ToolTip();
            toolTip1.SetToolTip(btnstartcopy, "Start Copy");

            //GetStorageAccountNames("e2186114-ebc1-4579-87b0-d455b33cd6cf");
            //GetStorageKeys("manasastorage");


            List<string> str = new List<string>();

            str = GetContainerList(txtStAc.Text, txtStKey.Text);

            cmbContainerName.Items.Clear();
            foreach (string lst in str)
            {
                cmbContainerName.Items.Add(lst);
            }

            

        }



        private List<string> GetContainerList(string azureStorageAccountName,string azureKeyValue)
        {

            StorageCredentials creds = new StorageCredentials(azureStorageAccountName, azureKeyValue);
            CloudStorageAccount account = new CloudStorageAccount(creds, useHttps: true);

            CloudBlobClient client = account.CreateCloudBlobClient();
            var list = client.ListContainers(null, ContainerListingDetails.None, null, null);


            //listing out containers
            List<string> Containernames_list = new List<string>();

            foreach (var lst in list)
            {
                Containernames_list.Add(lst.Name);
            }


            return Containernames_list;

        }



        private void GetStorageAccountNames(string AZsubscription)
        {
            //var url = "https://management.core.windows.net/e2186114-ebc1-4579-87b0-d455b33cd6cf/services/storageservices";

            var url = "https://management.core.windows.net/"+ AZsubscription + "/services/storageservices";

            HttpWebRequest webrequest = (HttpWebRequest)System.Net.WebRequest.Create(url);

           // webrequest.Headers.Add("x-prd-api-token", "AKIAJ2SSLN5ZZNDBGWHQ");

            webrequest.ContentType = "application/xml";

            // webrequest.Headers.Add("Content-Type", "text/xml");

            webrequest.ContentType = "application/json; charset=utf-8";

            using (var response = webrequest.GetResponse())
            {
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    var result = reader.ReadToEnd();
                    string s = Convert.ToString(result);
                  
                }
            }
        }



        private void GetStorageKeys(string storagename)
        {
            //var url = "https://management.core.windows.net/<subscription-id>/services/storageservices/<service-name>/keys";

            string url = "https://management.core.windows.net/<subscription-id>/services/storageservices/" + storagename + "/keys";

            HttpWebRequest webrequest = (HttpWebRequest)System.Net.WebRequest.Create(url);

            webrequest.Headers.Add("x-prd-api-token", "AKIAJ2SSLN5ZZNDBGWHQ");

            webrequest.ContentType = "application/xml";

            // webrequest.Headers.Add("Content-Type", "text/xml");

            webrequest.ContentType = "application/json; charset=utf-8";

            using (var response = webrequest.GetResponse())
            {
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    var result = reader.ReadToEnd();
                    string s = Convert.ToString(result);

                }
            }
        }



    }
}
