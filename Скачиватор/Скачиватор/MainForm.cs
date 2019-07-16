using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Net;
using Microsoft.Win32;
using System.Management;

namespace Скачиватор
{
    public partial class MainForm : Form
    {

        public delegate void InvokeDelegate();



        public string domain;
        public bool server_work;

        System.Threading.Thread thread_wathcher;

        string files_directory;

        public FileSystemWatcher watcher = new FileSystemWatcher()
        {
            Path = Directory.GetCurrentDirectory(),
            NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName,
        };





        public void for_watcher()
        {
            while (true)
            {
               watcher.WaitForChanged(WatcherChangeTypes.All);
            }

        }




        public static void Error_mes(string mes)
        {

            MessageBox.Show(mes, "Ошибка !", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }



        private void set_status(UInt16 percent, string status)
        {

            GlobalProgressBar.Value = percent;
            GlobalStatus.Text = status;

        }



















        public MainForm()
        {

            OnServerStart += ServerStart;
            OnServerStop += ServerStop;

            watcher.Changed += domench;

            files_directory = "";

            domain = "";

            server_work = false;


            thread_wathcher = new System.Threading.Thread(for_watcher);

            thread_wathcher.Start();




            //System.Diagnostics.Process.Start("cmd.exe", "/C echo hello");
            
            
            

            FormClosing += ProgramClose;







            InitializeComponent();
        }







        private const string node = "nodeformrhag";

        private Process server_process;
        private Process tunnel_process;

        private bool Process_is_work(string name)
        {

            return System.Diagnostics.Process.GetProcessesByName(name).Length > 0;
            
        }

        private bool Process_is_work(int ID)
        {

            return Process.GetProcessById(ID) != null;

        }



        public delegate void ZeroDeleg();

        public event ZeroDeleg OnServerStart;

        public event ZeroDeleg OnServerStop;





        void refresh_status()
        {
            set_status(25, "Обновление");
            try
            {
                if(server_process != null && !server_process.HasExited)
                {

                    start_server_status.Text = "OK";
                    start_server_status.ForeColor = Color.Green;

                }
                else
                {

                    start_server_status.Text = "Error";
                    start_server_status.ForeColor = Color.Red;

                }

                if (tunnel_process != null && !tunnel_process.HasExited)
                {

                    start_tunnelserver_status.Text = "OK";
                    start_tunnelserver_status.ForeColor = Color.Green;

                }
                else
                {

                    start_tunnelserver_status.Text = "Error";
                    start_tunnelserver_status.ForeColor = Color.Red;

                }

                using (FileStream fs = File.Create(files_directory + "\\test.mrhagtesting"))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes("TEST");
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                    fs.Close();
                }


                try
                {
                    if (GET("http://127.0.0.1:" + port_number.Value, "/test.mrhagtesting") == "TEST")
                    {

                        connection_server_status.Text = "OK";
                        connection_server_status.ForeColor = Color.Green;

                    }
                    else
                    {

                        connection_server_status.Text = "Error";
                        connection_server_status.ForeColor = Color.Red;

                    }
                }
                catch (Exception e)
                {

                    Error_mes("Ошибка: \n" + e.Message);

                    connection_server_status.Text = "Error";
                    connection_server_status.ForeColor = Color.Red;

                }

                try
                {

                    if (domain != "" && GET("http://" + domain, "/test.mrhagtesting") == "TEST")
                    {

                        connection_tunnelserver_status.Text = "OK";
                        connection_tunnelserver_status.ForeColor = Color.Green;

                    }
                    else
                    {

                        connection_tunnelserver_status.Text = "Error";
                        connection_tunnelserver_status.ForeColor = Color.Red;

                    }
                }
                catch (Exception e)
                {
                    set_status(0, "Ок");
                    Error_mes("Ошибка: \n" + e.Message);

                    connection_tunnelserver_status.Text = "Error";
                    connection_tunnelserver_status.ForeColor = Color.Red;

                }


                File.Delete(files_directory+"\\test.mrhagtesting");
                set_status(0, "Ок");
            }
            catch(Exception e)
            {
                set_status(0, "Ок");
                Error_mes("Ошибка: \n" + e.Message);

            }


        }

        void reset_status()
        {
            BeginInvoke(new InvokeDelegate(() => {



                start_server_status.Text = "";
                start_tunnelserver_status.Text = "";
                connection_server_status.Text = "";
                connection_tunnelserver_status.Text = "";

                domain = "";
                result_url.Text = "";



            }));
            

        }







        private string GET(string Url, string Data)
        {
            WebRequest req = WebRequest.Create(Url + Data);
            WebResponse resp = req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string Out = sr.ReadToEnd();
            sr.Close();
            return Out;
        }

        private static string GetDefaultBrowserPath()
        {
            string key = @"HTTP\shell\open\command";
            using (RegistryKey registrykey = Registry.ClassesRoot.OpenSubKey(key, false))
            {
                return ((string)registrykey.GetValue(null, null)).Split('"')[1];
            }
        }

        //List<Process> GetChildProcesses(Process process)
        //{
        //    List<Process> children = new List<Process>();
        //    ManagementObjectSearcher mos = new ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" + process.Id);

        //    foreach (ManagementObject mo in mos.Get())
        //    {
        //        children.Add(Process.GetProcessById(Convert.ToInt32(mo["ProcessID"])));
        //    }

        //    return children;
        //}


        Process Start_hidden_program(string Name, string Arguments)
        {

            Process Hidden_process = new Process();
            Hidden_process.StartInfo.FileName = Name;
            Hidden_process.StartInfo.Arguments = Arguments;
            Hidden_process.StartInfo.UseShellExecute = false;
            Hidden_process.StartInfo.CreateNoWindow = false;
            Hidden_process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Hidden_process.Start();
            return Hidden_process;

        }


        void ServerStart()
        {

            server_work = true;
            toogleServer_button.Text = "Остановить";

            errorProvider1.SetError(Directory_text, null);

        }
        
        void ServerStop()
        {
          

            BeginInvoke(new InvokeDelegate(()=> {

                toogleServer_button.Text = "Запустить";

                subdomen_text.Enabled = true;

                port_number.Enabled = true;


            }));
            server_work = false;

            reset_status();

        }


        void ProgramClose(object sender, FormClosingEventArgs args)
        {

            thread_wathcher.Abort();
            StopServer();

        }



        void StartServer()
        {

            subdomen_text.Enabled = false;
            port_number.Enabled = false;
            set_status(25, "Запуск сервера");

            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Process proc = Start_hidden_program(node + ".exe", "http-server\\bin\\http-server "+files_directory+"\\ --p " + port_number.Value);
                    


                    System.Threading.Thread.Sleep(2000);


                    if (Process_is_work(proc.Id))
                    {
                        if (StartTunnel())
                        {
                            server_process = proc;
                            server_process.EnableRaisingEvents = true;
                            server_process.Exited += ServerClose;
                            OnServerStart();
                            
                        }
                        else
                        {

                            StopServer();

                        }

                        break;

                    }
                    else
                    {
                        if (i == 4)
                        {

                            Error_mes("Не удалось запустить сервер");
                            subdomen_text.Enabled = true;
                            port_number.Enabled = true;

                        }
                    }

                }
                catch(Exception e)
                {

                    System.Threading.Thread.Sleep(2000);
                    if (i == 4)
                    {
                        set_status(0, "Ок");
                        Error_mes("Не удалось запустить сервер\n" + e.Message);
                        subdomen_text.Enabled = true;
                        port_number.Enabled = true;
                    }
                }

            }
            set_status(0, "Ок");

        }

        void StopServer()
        {
            if (server_process !=null && !server_process.HasExited)
            {
                server_process.Kill();
            }
            else
            {

                server_process = null;

            }
            if (server_process != null && !tunnel_process.HasExited)
            {
                tunnel_process.Kill();
            }
            else
            {

                tunnel_process = null;

            }

            OnServerStop();

        }

        void ServerClose(object sender, EventArgs args)
        {

            StopServer();

        }


        void TunnelClose(object sender, EventArgs args)
        {

            if (server_process != null && !server_process.HasExited)
            {
                System.Threading.Thread.Sleep(2000);
                if (!StartTunnel())
                    StopServer();

            }
        }

        bool StartTunnel()
        {

            
                for (int j = 0; j < 5; j++)
                {
                    try
                    {
                    Process proc2;
                    if (subdomen_text.Text == "")
                    {

                        proc2 = Start_hidden_program(node + ".exe", "localtunnel\\bin\\client --port " + port_number.Value);

                    }
                    else
                    {

                        proc2 = Start_hidden_program(node + ".exe", "localtunnel\\bin\\client --port " + port_number.Value + " --s " + subdomen_text.Text);

                    }
                        System.Threading.Thread.Sleep(2000);


                        if (Process_is_work(proc2.Id))
                        {

                            tunnel_process = proc2;
                            tunnel_process.EnableRaisingEvents = true;
                            tunnel_process.Exited += TunnelClose;

                            return true;
                        }
                        else
                        {

                            if (j == 4)
                            {

                                Error_mes("Не удалось запустить тунельный сервер");
                                BeginInvoke(new InvokeDelegate(() =>
                                {
                                    subdomen_text.Enabled = true;
                                    port_number.Enabled = true;
                                }));
                            return false;
                        }

                        }
                    }
                    catch (Exception e)
                    {

                        System.Threading.Thread.Sleep(2000);
                        if (j == 4)
                        {
                            Error_mes("Не удалось запустить тунельный сервер\n" + e.Message);
                            BeginInvoke(new InvokeDelegate(() =>
                            {
                                subdomen_text.Enabled = true;
                                port_number.Enabled = true;
                            }));
                            return false;
                    }

                    }
                }

            return false;


        }


        public void domench(object sender, System.IO.FileSystemEventArgs e)
        {

            if (e.ChangeType == System.IO.WatcherChangeTypes.Changed && e.Name == "domen")
            {
                for (int i = 0; i < 5; i++)
                {
                    try
                    {




                        StreamReader reader = System.IO.File.OpenText(e.FullPath);
                        if (reader != null)
                            domain = reader.ReadToEnd();
                        BeginInvoke(new InvokeDelegate(() =>
                        {

                            result_url.Text = "http://"+domain;
                            refresh_status();
                        }));
                        
                        reader.Close();

                        break;

                    }
                    catch (Exception ex)
                    {

                        System.Threading.Thread.Sleep(2000);
                        if (i == 4)
                            Error_mes("Ошибка чтения файла\n" + ex.Message);
                    }

                }
                //MessageBox.Show(Directory.GetCurrentDirectory());


            }

        }














        private void MainForm_Load(object sender, EventArgs e)
        {
            reset_status();

            defaultFolder_check.Checked = true;
            folderBrowser.SelectedPath = files_directory;

            FilesList.MouseDown += FilesList_Clicked;

            if (Process_is_work(node))
            {
                Process[] proc = Process.GetProcessesByName(node);
                for (int i = 0; i < proc.Length; i++)
                {

                    proc[i].Kill();

                }

            }





        }





        private void URL_design_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(domain != "") 
            System.Diagnostics.Process.Start(GetDefaultBrowserPath(), domain);

        }

        private void OpenFolder_button_Click(object sender, EventArgs e)
        {

            folderBrowser.ShowDialog();
            if (folderBrowser.SelectedPath != "")
            {
                files_directory = folderBrowser.SelectedPath;
                Directory_text.Text = files_directory;

                errorProvider1.SetError(Directory_text, "Папка применится после перезагрузки сервера.");
                refresh_files_list();
            }

            

        }

        private void toogleServer_button_Click(object sender, EventArgs e)
        {
            toogleServer_button.Enabled = false;

            if (server_work)
            {

                StopServer();

            }
            else
            {

                StartServer();
                
            }
            toogleServer_button.Enabled = true;
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {

            refresh_status();

        }



        void refresh_files_list()
        {

            if (files_directory != "")
            {
                FilesList.Items.Clear();
                DirectoryInfo directory = new DirectoryInfo(files_directory);
                FileInfo[] files = directory.GetFiles();

                foreach (FileInfo file in files)
                {
                    FilesList.Items.Add(file.Name);
                }

            }

        }


        private void refresh_files_Click(object sender, EventArgs e)
        {
            refresh_files_list();
        }



        private void defaultFolder_check_CheckedChanged(object sender, EventArgs e)
        {

            if (defaultFolder_check.Checked)
            {
                files_directory = Directory.GetCurrentDirectory() + "\\Files";
                OpenFolder_button.Enabled = false;
            }
            else
            {
                files_directory = folderBrowser.SelectedPath;
                OpenFolder_button.Enabled = true;
            }



            Directory_text.Text = files_directory;
            
            errorProvider1.SetError(Directory_text, "Папка применится после перезагрузки сервера.");
            if (files_directory == "")
                errorProvider1.SetError(Directory_text, null);

            refresh_files_list();


        }

        private void FilesList_Clicked(object sender, EventArgs e)
        {

            MouseEventArgs ar = (MouseEventArgs)e;
            if (ar.Button == MouseButtons.Right)
            {

                копироватьToolStripMenuItem.Enabled = FilesList.SelectedIndex >= 0 && domain != "";
                
                FilesList_contextMenu.Show(Cursor.Position);

            }

        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("http://" + domain +"/"+ FilesList.SelectedItem);
        }
    }
}
