using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Configuration;
using System.ServiceProcess;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;

namespace urlmonitoring
{
    public class monitor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("URL Monitoring Started at {0}", DateTime.Now.ToString());
            string[] url = ConfigurationSettings.AppSettings["URL"].Split(',');

            List<string> nonrespondingurl = new List<string>();
            testurl(url, ref nonrespondingurl, false);
            url = ConfigurationSettings.AppSettings["URLwithpassword"].Split(',');
            testurl(url, ref nonrespondingurl, true);
            Console.Write("\n\n\n\n");
            Console.WriteLine("These Url are down");
            foreach (var value in nonrespondingurl)
                Console.WriteLine(value.ToString());
            addurl("a", "b", "c", "d", "e", 0);
        }

        public static void addurl(string monitor,string url,string username, string password,string email,decimal poll)
        {
            //string path = ConfigurationSettings.AppSettings["FILEPATH"];
            //FileStream fp = new FileStream(path, FileMode.Append);
            //string value;
            //if((service==string.Empty) && (username==string.Empty))
            //{   value=url;  }
            //else if(username==string.Empty)
            //{   value=string.Format("{0}|{1}",url,service); }
            //else
            //{   value = string.Format("{0}|{1}|{2}|{3}", url, service, username, password); }

            //StreamWriter sw = new StreamWriter(fp);
            //sw.WriteLine(value);
            //sw.Close();
            //sw.Dispose();
            string connectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename='C:\\Documents and Settings\\harsingh\\My Documents\\Visual Studio 2008\\Projects\\urlmonitoring\\UserInterface\\URLMonitring.mdf';Integrated Security=True;User Instance=True";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = string.Format("INSERT INTO URLDetails(MonitorName,URL,Email,PollTime) VALUES({0},{1},{2},3)", monitor, url, username);
                connection.Open();
                SqlCommand mycommand = new SqlCommand(query, connection);
                mycommand.ExecuteNonQuery();
                Console.WriteLine("connected");
            }
            catch
            {
                Console.WriteLine("not");
            }
            finally
            {
                connection.Close();
            }
           
            
        }


        public static void testurl(string[] url, ref List<string> nonrespondingurl,bool password)
        {
            foreach (string urlvalue in url)
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlvalue);
                try
                {
                    if (password)
                    {
                        CredentialCache credcache = new CredentialCache();
                        credcache.Add(new Uri(urlvalue), "Digest", new NetworkCredential("ankur", "p@ssw0rd"));
                        request.Credentials = credcache;
                    }
                    Console.WriteLine("Accessing Url: {0}", urlvalue);
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    Console.WriteLine("Status is {0}", response.StatusCode.ToString());
                    response.Close();
                }
                catch (WebException webError)
                {
                    nonrespondingurl.Add(urlvalue);
                    Console.WriteLine("Error Msg: {0}", webError.Message.ToString());
                }
            }
        }
    }
}


            //string dbfile = new System.IO.FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).DirectoryName + "\\URLMonitoring.sdf";
            //SqlCeConnection conn = new SqlCeConnection("datasource=" + dbfile);
            //string query = string.Format("INSERT INTO URLDetails Values(,{0},{1},{2},{3},{4},{5})", monitor, url, username, password, email, poll);
            //SqlCeDataAdapter adapter = new SqlCeDataAdapter(query, conn);
            //DataSet data=new DataSet;
            //data.Tables[0].Rows.Add(new object[]{
