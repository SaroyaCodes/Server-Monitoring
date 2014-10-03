using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Microsoft.Win32;
using System.Configuration;
using System.IO;
using Microsoft.Reporting.WinForms;
using System.ServiceProcess;



namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {  
        List<Info> Systeminfo = new List<Info>();
        string folderName;
        string choice = "Current system";
        ArrayList server = new ArrayList();
        ArrayList client = new ArrayList();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void browsebutton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderName = folderBrowserDialog1.SelectedPath;
                this.txtReportloc.Text = folderName;
            }
            else
            {
                this.txtReportloc.Text = ConfigurationSettings.AppSettings["FILEPATH"].ToString();
            }
        }

        public void radioButtongrp_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCurrentSystem.Checked == true)
            {
                chkboxServers.Enabled = false;
                choice = rbCurrentSystem.Text;
                chkboxServices.Enabled = true;
            }
            else if (rbIPAddressrange.Checked == true)
            {
                chkboxServers.Enabled = true;
                choice = rbIPAddressrange.Text;
                chkboxServices.Enabled = false;
            }
            else
            {
                chkboxServers.Enabled = true;
                choice = rbIPAddress.Text;
                chkboxServices.Enabled = false;
            }
        }
        
        public void selectionAccessDetails(string system)
        {
            if (system.Equals("Current system"))
            {
                ArrayList machinename = new ArrayList();
                machinename.Add(System.Environment.MachineName);
                var networkComputers = machinename;
                currSysteminfo(networkComputers);
            }
            else if (system.Equals(""))
            {
                var networkComputers = GetIPAddressRange();
                IPAddressinfo(networkComputers);
            }
            else
            {
                var networkComputers = NetworkBrowser.getNetworkComputers(); 
                //var networkComputers = GetIPAddress();
                IPAddressinfo(networkComputers);
            }
           
        }

        public void IPAddressinfo(ArrayList networkComputers)
        {
            string otherkey = @"Software\Microsoft\Windows NT\CurrentVersion\";
            foreach (var computer in networkComputers)
            {
                try
                {
                    using (RegistryKey registerKey = RegistryKey.OpenRemoteBaseKey(
                        RegistryHive.LocalMachine, computer.ToString()).OpenSubKey(otherkey))
                    {
                        string ab = registerKey.GetValue("ProductName").ToString();
                        if ((ab.ToLower().Contains("server")) || (ab.ToLower().Contains("Premium")))
                        {
                            server.Add(computer);
                        }
                        else
                        {
                            client.Add(computer);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            if (this.chkboxServers.Checked)
            {
                if (server != null)
                {
                 //   GetSoftwareInstalled(server, "server");
                }
                else
                {
                    MessageBox.Show("There are no servers in the current scheme.");
                }

            }
            if (this.chkboxClient.Checked)
            {
                if (client != null)
                {
                    GetSoftwareInstalled(client, "client");
                }
                else
                {
                    MessageBox.Show("There are no clients in the current scheme.");
                
                }
                }
            if (this.chkboxServices.Checked)
            {
                GetServicesInstalled(networkComputers);
            }

            GetReport(Systeminfo); 

        }

        public void currSysteminfo(ArrayList networkComputers)
        { 
       
            if (this.chkboxClient.Checked)
            {
              GetSoftwareInstalled(networkComputers,"client");
            }

            if (this.chkboxServices.Checked)
            {
                GetServicesInstalled(networkComputers);
            }
            
            if (!chkboxClient.Checked && !chkboxServices.Checked)
            {
                MessageBox.Show("Please choose any option");
            }
                            
            GetReport(Systeminfo);

        }

        public void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Report is being processed..");
        
            selectionAccessDetails(choice);
            }
        
        public  void GetSoftwareInstalled(ArrayList systems,string systype)
        {
            string registryKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            string[] filter = ConfigurationSettings.AppSettings["FILTERS"].Split(',');
            foreach (var pc in systems)
            {
                try
                {
                    using (RegistryKey registerKey = RegistryKey.OpenRemoteBaseKey(
                        RegistryHive.LocalMachine, pc.ToString()).OpenSubKey(registryKey))
                    {

                        var query = from a in
                                        registerKey.GetSubKeyNames()
                                    let r = registerKey.OpenSubKey(a)
                                    select new Info
                                    {
                                        SystemName = pc.ToString()
                                        ,
                                        Software = r.GetValue("DisplayName") != null ? r.GetValue("DisplayName").ToString() : string.Empty
                                        ,
                                        InstalledOn = r.GetValue("InstallDate") != null ? r.GetValue("InstallDate").ToString() : string.Empty
                                        ,
                                        LastUsed = string.Empty
                                        ,
                                        Type = systype
                                        //Application = r.GetValue("DisplayName")
                                    };
                        foreach (var s in query)
                        {
                            if (s.Software != string.Empty)
                            {
                                if (s.InstalledOn != string.Empty)
                                {DateTime d = DateTime.ParseExact(s.InstalledOn, "yyyyMMdd", null);
                                s.InstalledOn = d.Day + "/" + d.Month + "/" + d.Year;
                                }
                                Systeminfo.Add(s);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               // GetReport(Systeminfo);

            }
          
        }
        public ArrayList GetIPAddress()
        {
            string data = txtIPAddress.Text;
            string[] IPAddress = data.Split(',');
            ArrayList arraylist1 = new ArrayList();
            if (IPAddress.Count() == 0 || data.Length <= 0)
            {
                MessageBox.Show("please enter the IP Address");
            }
            if (IPAddress.Count() > 1)
            {
                foreach (string IP in IPAddress)
                {
                    arraylist1.Add(IP);
                }
            }
            else
            {
                arraylist1.Add(IPAddress[0]);
            }

            return arraylist1;     
        }
        public ArrayList GetIPAddressRange()
        {
            string strtrange = startrange.Text;
            string edrange = endrange.Text;
            ArrayList arraylist = new ArrayList();
            try
            {
                int StartIP = strtrange.LastIndexOf('.');
                string IPSeries = strtrange.Remove(StartIP + 1);
                int IPStart = Convert.ToInt32(strtrange.Remove(0, StartIP + 1));
                int indexEndIP = edrange.LastIndexOf('.');
                int IPEnd = Convert.ToInt32(edrange.Remove(0, indexEndIP + 1));
                for (int tempIP = StartIP; tempIP <= IPEnd; tempIP++)
                {
                    string IPt = IPSeries + tempIP.ToString();
                    arraylist.Add(IPt);
                    //Console.WriteLine(IP);
                }


                return arraylist;
            }

            catch (Exception ex)
            {
                return null;
            }
        }

        public void  GetReport(List<Info> source1)
        {  
            string format, extension;
            ReportViewer rViewer = new ReportViewer();
            rViewer.LocalReport.ReportPath = ConfigurationSettings.AppSettings["REPORTPATH"].ToString();
            ReportDataSource dsSoftwareList = new ReportDataSource("SystemInfoUtility_Info");;
            dsSoftwareList.Value = source1;
            rViewer.LocalReport.DataSources.Add(dsSoftwareList);
            rViewer.LocalReport.Refresh();
            string filename = this.txtfilename.Text.ToString();
            if (this.radioButton1.Checked)
            {
                format = "excel";
                extension = "xls";

            }
            else
            {
                format = "PDF";
                extension = "pdf";
            }
            var report = GetReport(rViewer,format);
            var path = this.txtReportloc.Text.ToString();
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            using (FileStream fs = File.Open(path + "/" + filename +"."+ extension, FileMode.Create))
            {
                fs.Write(report, 0, report.Length);
            }
        }

        public void GetServicesInstalled(ArrayList computers)
        {
           
            foreach (var sys in computers)
            {
                //ServiceController[] service = ServiceController.GetServices(sys.ToString());
                ServiceController[] service = ServiceController.GetServices();
                var query = from a in service
                            let r = a.DisplayName
                            select new Info
                            {
                                SystemName = sys.ToString()
                                ,
                                Software = r
                                ,
                                InstalledOn = string.Empty
                                ,
                                LastUsed = string.Empty
                                ,
                                Type="Services"

                            };
                foreach (var s in query)
                {
                    if (s.Software != string.Empty)
                        Systeminfo.Add(s);
                }
                
            }

            
        }        

        public static byte[] GetReport(ReportViewer reportViewer,string form)
        {
            try
            {
                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string extension;
                byte[] bytes = null;
                bytes = reportViewer.LocalReport.Render(form, null, out mimeType, out encoding, out extension, out streamids, out warnings);
                return bytes;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }               
         public sealed class NetworkBrowser
        {
            #region Dll Imports

            [DllImport("Netapi32", CharSet = CharSet.Auto,
            SetLastError = true),
            SuppressUnmanagedCodeSecurityAttribute]

            public static extern int NetServerEnum(
                string ServerNane, // must be null

                int dwLevel,
                ref IntPtr pBuf,
                int dwPrefMaxLen,
                out int dwEntriesRead,
                out int dwTotalEntries,
                int dwServerType,
                string domain, // null for login domain

                out int dwResumeHandle
                );


            [DllImport("Netapi32", SetLastError = true),
            SuppressUnmanagedCodeSecurityAttribute]

            public static extern int NetApiBufferFree(
                IntPtr pBuf);

            [StructLayout(LayoutKind.Sequential)]
            public struct _SERVER_INFO_100
            {
                internal int sv100_platform_id;
                [MarshalAs(UnmanagedType.LPWStr)]
                internal string sv100_name;
            }
            #endregion

            #region Public Constructor
            public NetworkBrowser()
            {

            }
            #endregion

            #region Public Methods

            public static ArrayList getNetworkComputers()
            {
                //local fields

                ArrayList networkComputers = new ArrayList();
                const int MAX_PREFERRED_LENGTH = -1;
                int SV_TYPE_WORKSTATION = 1;
                int SV_TYPE_SERVER = 2;
                IntPtr buffer = IntPtr.Zero;
                IntPtr tmpBuffer = IntPtr.Zero;
                int entriesRead = 0;
                int totalEntries = 0;
                int resHandle = 0;
                int sizeofINFO = Marshal.SizeOf(typeof(_SERVER_INFO_100));


                try
                {
                    int ret = NetServerEnum(null, 100, ref buffer,
                        MAX_PREFERRED_LENGTH,
                        out entriesRead,
                        out totalEntries, SV_TYPE_WORKSTATION |
                        SV_TYPE_SERVER, null, out 
                    resHandle);

                    if (ret == 0)
                    {

                        for (int i = 0; i < totalEntries; i++)
                        {
                            tmpBuffer = new IntPtr((int)buffer +
                                       (i * sizeofINFO));
                            _SERVER_INFO_100 svrInfo = (_SERVER_INFO_100)
                                Marshal.PtrToStructure(tmpBuffer,
                                        typeof(_SERVER_INFO_100));

                            networkComputers.Add(svrInfo.sv100_name);
                        }
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Problem with acessing " +
                    //    "network computers in NetworkBrowser " +
                    //    "\r\n\r\n\r\n" + ex.Message,
                    //    "Error", MessageBoxButtons.OK,
                    //    MessageBoxIcon.Error);
                    return null;
                }
                finally
                {

                    NetApiBufferFree(buffer);
                }

                return networkComputers;

            }
            #endregion
        }
    }
}

  
    


