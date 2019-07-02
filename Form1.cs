using FPrintWin;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows.Forms;
using System.Xml;

namespace FPrintWin
{
    public partial class frmMain : Form
    {
        #region Fields

        //block concurrent attempt to connect
        bool tryingToConnect = false;

        private System.IO.Ports.SerialPort com;
        private string ecr, key, port, baud;
        private int writeTimeOut, writeBuffSize, readTimeOut, readBuffSize;
        //private Handshake handshake;

        private bool checkStatus, activeKeyb;

        #endregion Fields

        #region Properties

        public string ComPort
        {
            get { return cbPort.SelectedItem.ToString(); }
        }

        public string Model
        {
            get { return cbEcrModel.SelectedItem.ToString(); }
        }

        public int Baud
        {
            get { return Convert.ToInt32(cbBaudRate.SelectedItem.ToString()); }
        }

        public string Key
        {
            get { return txtKey.Text; }
            set { txtKey.Text = value; }
        }

        public string Serial
        {
            get { return txtSerial.Text; }
            set { txtSerial.Text = value; }
        }

        #endregion Properties

        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Tries to connect to the com port and throws an exeption if cannot connect
        /// </summary>
        /// <remarks></remarks>
        private void Connect()
        {
            if (com == null)
            {
                com = new System.IO.Ports.SerialPort();
                GetComSettings();
            }

            if (!isConnected())
            {
                try
                {
                    this.com.Open();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void CloseComm()
        {
            if (com != null)
            {
                com.Close();
                com.Dispose();
                com = null;
            }
        }

        /// <summary>
        /// check port status
        /// </summary>
        /// <returns></returns>
        private bool isConnected()
        {
            try
            {
                if (this.com.IsOpen)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (string s in SerialPort.GetPortNames())
            {
                this.cbPort.Items.Add(s);
            }

            try
            {
                //load settings from XML
                loadPrinterSettings();
            }
            catch (Exception x)
            { MessageBox.Show(x.Message); }
        }

        private void loadPrinterSettings()
        {
            XmlDocument xml = new XmlDocument();
            System.Xml.XmlNodeList nodeList = null;
            xml.Load(string.Format("{0}\\PrinterSettings.xml", System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)));
            nodeList = xml.SelectNodes("/PrintSettings/COMSettings");

            foreach (System.Xml.XmlNode node in nodeList)
            {
                port = (node["PortName"].InnerText);
                baud = node["BaudRate"].InnerText;
                //handshake = (Handshake)Enum.Parse(typeof(Handshake), node["HandShake"].InnerText, true);
                //writeTimeOut = Convert.ToInt32(node["WriteTimeOut"].InnerText);
                //writeBuffSize = Convert.ToInt32(node["WriteBufferSize"].InnerText);
                //readTimeOut = Convert.ToInt32(node["ReadTimeOut"].InnerText);
                //readBuffSize = Convert.ToInt32(node["ReadBufferSize"].InnerText);

                txtSerial.Text = node["Serial"].InnerText;
                key = node["Key"].InnerText;
                ecr = (node["ECRModel"].InnerText);
                checkStatus = Convert.ToBoolean(node["CheckStatus"].InnerText);
                activeKeyb = Convert.ToBoolean(node["ActiveKeyboard"].InnerText);

                this.cbPort.SelectedItem = port;
                this.cbBaudRate.SelectedItem = baud;
                //this.cbHandShake.SelectedItem = handshake.ToString();
                this.txtWriteTimeOut.Text = writeTimeOut.ToString();
                this.txtWriteBuffer.Text = writeBuffSize.ToString();
                this.txtReadTimeOut.Text = readTimeOut.ToString();
                this.txtReadbufferSize.Text = readBuffSize.ToString();

                this.txtKey.Text = key;
                this.cbEcrModel.SelectedItem = ecr;
                this.chkCheckStatus.Checked = checkStatus;
                this.chkAktiveKeyb.Checked = activeKeyb;
            }

            xml = null;
            nodeList = null;
        }

        private void savePrinterSettings()
        {
            System.Xml.XmlDocument xml = new System.Xml.XmlDocument();
            System.Xml.XmlNodeList nodeList = null;
            string xmlFilePath = string.Format("{0}\\PrinterSettings.xml", System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase));
            string path = new Uri(xmlFilePath).LocalPath;
            xml.Load(path);
            nodeList = xml.SelectNodes("/PrintSettings/COMSettings");

            foreach (System.Xml.XmlNode node in nodeList)
            {
                try
                {
                    node["PortName"].InnerText = this.cbPort.SelectedItem.ToString();
                    node["BaudRate"].InnerText = this.cbBaudRate.SelectedItem.ToString();
                    //node["HandShake"].InnerText = this.cbHandShake.SelectedItem.ToString();
                    //node["WriteTimeOut"].InnerText = this.txtWriteTimeOut.Text;
                    //node["WriteBufferSize"].InnerText = this.txtWriteBuffer.Text;
                    //node["ReadTimeOut"].InnerText = this.txtReadTimeOut.Text;
                    //node["ReadBufferSize"].InnerText = this.txtReadbufferSize.Text;
                    node["Serial"].InnerText = this.txtSerial.Text;
                    node["Key"].InnerText = this.txtKey.Text;
                    node["ECRModel"].InnerText = this.cbEcrModel.SelectedItem.ToString();
                    node["CheckStatus"].InnerText = chkCheckStatus.Checked.ToString();
                    node["ActiveKeyboard"].InnerText = this.chkAktiveKeyb.Checked.ToString();
                }
                catch { }
            }

            xml.Save(path);

            xml = null;
            nodeList = null;
        }

        private void GetComSettings()
        {
            XmlDocument xml = new XmlDocument();
            System.Xml.XmlNodeList nodeList = null;
            xml.Load(string.Format("{0}\\PrinterSettings.xml", System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)));
            nodeList = xml.SelectNodes("/PrintSettings/COMSettings");

            foreach (System.Xml.XmlNode node in nodeList)
            {
                this.com.PortName = (string.IsNullOrEmpty((node["PortName"].InnerText)) ? "COM1" : (node["PortName"].InnerText));
                this.com.BaudRate = Convert.ToInt32(node["BaudRate"].InnerText);
                this.com.DataBits = 8;
                this.com.Handshake = (Handshake)Enum.Parse(typeof(Handshake), node["HandShake"].InnerText, true);
                this.com.Parity = Parity.None;
                this.com.StopBits = StopBits.One;
                this.com.WriteTimeout = Convert.ToInt32(node["WriteTimeOut"].InnerText);
                this.com.WriteBufferSize = Convert.ToInt32(node["WriteBufferSize"].InnerText);
                this.com.ReadTimeout = Convert.ToInt32(node["ReadTimeOut"].InnerText);
                this.com.ReadBufferSize = Convert.ToInt32(node["ReadBufferSize"].InnerText);
            }
            xml = null;
            nodeList = null;
        }

        private void testInv()
        {
            int length = 2; //nr rreshtave test qe duam te printojme si test
            loadPrinterSettings();

            //nese nuk po punojme me active keyboard, checkstatus nuk ka kuptim
            if (!activeKeyb)
                checkStatus = false;

            IFiscalPrinter fp = PrinterFactory.Create(Model);
            try
            {
                if (string.IsNullOrEmpty(txtKey.Text))
                {
                    MessageBox.Show("Ju lutemi te vendosni numrin e licences!", "Kujdes!");
                    return;
                }
                int answer = fp.OpenPort(Model, Key, ComPort, Baud);
                if (answer == 1)
                {
                    try
                    {
                        List<string> inv = new List<string>();

                        if (activeKeyb)
                            inv.Add("H,1,______,_,__;");

                        //inv.Add("M,1,______,_,__;12345");
                        for (int i = 0; i < length; i++)
                        {
                            inv.Add("S,1,______,_,__;Artikulli " + i + " ; 70.00; 2.00; 2;1; 1; 0; 0;");
                            inv.Add("C,1,______,_,__;1;10;");
                            //inv.Add("V,1,______,_,__;");
                        }
                        inv.Add("T,1,______,_,__;4;");
                        inv.Add("C,1,______,_,__;1;10;");
                        inv.Add("T,1,______,_,__;");

                        //inv.Add("D,1,______,_,__;");

                        if (activeKeyb)
                            inv.Add("F,1,______,_,__;");

                        //print
                        string line, nextline = "";
                        for (int i = 0; i < inv.Count; i++)
                        {
                            line = inv[i];
                            //check if next line is discount
                            if (i < inv.Count -1) //nese ka akoma rreshta
                                nextline = inv[i + 1];

                            //nese rreshti dyte eshte me C qe nenkupton zbritje dergo te dy rreshtat bashke qe te aplikohet zbritja
                            if (nextline.StartsWith("C,1,______,_,__;", StringComparison.Ordinal))
                            {
                                fp.ExecuteScript(new string[] { line, nextline });
                            }
                            else if (fp.WriteLine(inv[i]) == 0)
                            {
                                Console.WriteLine("err: " + inv[i]);
                                MessageBox.Show($"Gabim kominikim me kasen!\rRreshti: {inv[i]}"
                                     , "Konfirmo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                                return;
                            }
                        }
                    }
                    catch (Exception err)
                    {
                        Console.WriteLine(err.Message);
                    }
                    finally
                    {
                        //fp.stopReading = true;
                        Console.WriteLine("Port disconnected!");
                    }
                }
                else
                {
                    //MessageBox.Show(getError(answer), "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MessageBox.Show(fp.getError(answer), "Cant Connect");
                    return;
                }
            }
            catch (Exception ex) { }
            finally { fp.Dispose(); }
        }

        //private string getError(int errorCode)
        //{
        //    string message = "";
        //    switch (errorCode)
        //    {
        //        case -3:
        //            message = "Nuk mund te ndizet bluetooth ne paijse!";// - Can't turn on Bluetooth!";
        //            break;

        //        case -2:
        //            message = "Mungon lidhja me kasen!";// - Can't wakeup!";
        //            break;
        //        case -1:
        //            message = "Nuk mund te lidhem me porten!";//"Can not connect to port!";
        //            break;
        //        case 0:
        //            message = "Ndodhi nje gabim!";// "An error occurred!";
        //            break;
        //        case 1:
        //            message = "Instruksioni u egzekutua";// "Executed Successfully!";
        //            break;
        //        case 2:
        //            message = "Licenca nuk perputhet me serialin e kases!";//"Provided key is not valid!";
        //            break;
        //        case 3:
        //            message = "Dokumenti eshte bosh!";// "File is empty!";
        //            break;
        //        case 4:
        //            message = "Instruksioni i derguar ka probleme, ju lutemi te provoni perseri!";// Processed line has an error. Retry to send the line!";
        //            break;
        //        case 5:
        //            message = "Dokumenti per ri-dergimin e instruksioneve nuk u krijua!";// "Retry file can not be created!";
        //            break;
        //        case 6:
        //            message = "Answer file can not be created!";
        //            break;
        //        case 7:
        //            message = "Retry file is not sent!";
        //            break;
        //        case 8:
        //            message = "Execute file could not be deleted!";
        //            break;
        //        case 9:
        //            message = "Retry file could not be deleted!";
        //            break;
        //    }
        //    return message;
        //}

        private void mnuSaveConfig_Click(object sender, EventArgs e)
        {
            //save parameteres to xml
            savePrinterSettings();
            //close and reopen BT port with new parameters
            if (isConnected())
            {
                this.com.Close();
            }
            loadPrinterSettings();
        }

        private void mnuRregjistro_Click(object sender, EventArgs e)
        {
            savePrinterSettings();
        }

        private void mnuCloseForm_Click(object sender, EventArgs e)
        {
            savePrinterSettings();
            this.Close();
        }

        private void btnGetSerial_Click(object sender, EventArgs e)
        {
            IFiscalPrinter fp = PrinterFactory.Create(Model);
            try
            {
                txtSerial.Text = fp.GetSerial(ComPort, Baud);
                if (txtSerial.Text.Length < 3 && !string.IsNullOrEmpty(txtSerial.Text))
                    fp.getError(Convert.ToInt32(txtSerial.Text));
                else
                    savePrinterSettings();
            }
            catch (Exception x) { MessageBox.Show(x.Message); }
            finally { fp.Dispose(); }
        }

        private void btnPrintTestPage_Click(object sender, EventArgs e)
        {
            testInv();
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            pnlAdvanced.Visible = true;
        }

        private void btnCheckKey_Click(object sender, EventArgs e)
        {
            loadPrinterSettings();

            IFiscalPrinter fp = PrinterFactory.Create(Model);
            try
            {
                int answer = fp.OpenPort(Model, Key, ComPort, Baud);
                if (answer == 1)
                {
                    MessageBox.Show("Key Registered Sucessfully");
                    savePrinterSettings();
                }
                else
                    //MessageBox.Show(getError(answer), "Kujdes!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    MessageBox.Show(fp.getError(answer), "Cant Connect");
            }
            catch { }
            finally { fp.Dispose(); }
        }

        private void txtKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            int start = txtKey.SelectionStart;

            if (txtKey.SelectionLength > 0)
                txtKey.SelectedText = string.Empty;

            if (txtKey.Text.Length == txtKey.MaxLength && e.KeyChar != (char)Keys.Back)
                e.Handled = true;

            else
            {
                if (char.IsLower(e.KeyChar))
                {
                    txtKey.Text = txtKey.Text.Insert(start, char.ToUpper(e.KeyChar).ToString());
                    txtKey.SelectionStart = start + 1;
                    e.Handled = true;
                }
            }
        }

        private void btnRefreshComPorts_Click(object sender, EventArgs e)
        {
            this.cbPort.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                this.cbPort.Items.Add(s);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IFiscalPrinter fp = PrinterFactory.Create(Model);
            int answer = fp.OpenPort(Model, Key, ComPort, Baud);
            if (answer == 1)
            {
                fp.WriteLine("T,1,______,_,__;");

                if (activeKeyb)
                    fp.WriteLine("F,1,______,_,__;");
            }

            fp.Dispose();
        }
    }
}