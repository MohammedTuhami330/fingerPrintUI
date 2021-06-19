using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BioBridgeSDKDLL;


namespace FingerPrintRecord.Forms
{

    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();

        }
        BioBridgeSDKClass axBioBridgeSDK1 = new BioBridgeSDKClass();

        private void AxBioBridgeSDK1_OnConnected()
        {
            List1.Items.Add("On Connect!!!");
        }
        private void AxBioBridgeSDK1_OnDisConnected()
        {
            List1.Items.Add("On Disconnect!!!");
        }
        private void AxBioBridgeSDK1_OnFinger()
        {
            List1.Items.Add("On Finger Event!!!");

        }
        private void AxBioBridgeSDK1_OnAttTransactionEx(string EnrollNumber, int IsInValid, int AttState, int VerifyMethod, int Year, int Month, int Day, int Hour, int Minute, int Second, int WorkCode)
        {
            try
            {
                List1.Items.Add("onAttTransactioEx");
                Console.WriteLine("on att Enroll : " + EnrollNumber + " verifymode : " + VerifyMethod);
            }
            catch (Exception ex)
            { Console.WriteLine("err : " + ex.ToString()); }
        }
        private void RegisterEvent()
        {
            axBioBridgeSDK1.OnConnected += AxBioBridgeSDK1_OnConnected;
            axBioBridgeSDK1.OnDisConnected += AxBioBridgeSDK1_OnDisConnected;
            axBioBridgeSDK1.OnFinger += AxBioBridgeSDK1_OnFinger;
            axBioBridgeSDK1.OnAttTransactionEx += AxBioBridgeSDK1_OnAttTransactionEx;
            //axBioBridgeSDK1.OnDoor += new AxBioBridgeSDKLib._DBioBridgeSDKEvents_OnDoorEventHandler(axBioBridgeSDK1_OnDoor);
            //axBioBridgeSDK1.OnAlarm += new AxBioBridgeSDKLib._DBioBridgeSDKEvents_OnAlarmEventHandler(axBioBridgeSDK1_OnAlarm);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            int portNo = 0;
            string devModel = "";
            int devNo = 0;
            string ipAdd = "";
            int comm = 0;
            string sdkVer = "";
            string firmware = "";
            string sdk = "";
            string firm = "";
            string time = "";

            int yr = 0;
            int mth = 0;
            int day_Renamed = 0;
            int hr = 0;
            int min = 0;
            int sec = 0;
            int commPort = 0;
            int baudRate = 0;
            int i = 0;

            devModel = txtModel.Text;
            devNo = Convert.ToInt32(txtDeviceNo.Text);
            ipAdd = txtIPAdd.Text;
            portNo = Convert.ToInt32(txtPort.Text);
            comm = Convert.ToInt32(txtCommKey.Text);
            commPort = Convert.ToInt32(txtCommPort.Text);
            baudRate = Convert.ToInt32(txtBaudRate.Text);

            //option to connect to ip address
            if (rBtnIP.Checked)
            {
                if (axBioBridgeSDK1.Connect_TCPIP(devModel, devNo, ipAdd, portNo, comm) == 0)
                {
                    RegisterEvent();

                    btnConnect.Enabled = false;
                    btnDisconnect.Enabled = true;

                    txtIPAdd.Enabled = false;
                    txtPort.Enabled = false;

                    if (axBioBridgeSDK1.GetSDKVersion(ref sdkVer, 0) == 0)
                    {
                        sdk = "SDK Version: " + sdkVer;
                    }
                    else
                    {
                        sdk = "SDK Version Error";
                    }

                    if (axBioBridgeSDK1.GetFirmwareVersion(ref firmware) == 0)
                    {
                        firm = "Firmware Version: " + firmware;
                    }
                    else
                    {
                        firm = "Firmware Error";
                    }

                    if (axBioBridgeSDK1.GetDeviceTime(ref yr, ref mth, ref day_Renamed, ref hr, ref min, ref sec) == 0)
                    {
                        time = "Device Date and Time: " + Convert.ToString(day_Renamed) + "/" + Convert.ToString(mth) + "/" + Convert.ToString(yr) + " " + Convert.ToString(hr) + ":" + Convert.ToString(min) + ":" + Convert.ToString(sec);
                    }
                    else
                    {
                        time = "!Date and Time";
                    }
                    List1.Items.Add(("-------------------------------------------------------------------"));
                    List1.Items.Add((sdk));
                    List1.Items.Add((firm));
                    List1.Items.Add((time));
                    List1.Items.Add(("Manufacturer: " + axBioBridgeSDK1.VC));
                    List1.Items.Add(("Serial No: " + axBioBridgeSDK1.SN));
                    List1.Items.Add(("Mac Add: " + axBioBridgeSDK1.MAC));
                    List1.Items.Add(("Model Name: " + axBioBridgeSDK1.DC));

                    if (axBioBridgeSDK1.Finger10 == 1)
                    {
                        List1.Items.Add(("This is a FP10 reader"));
                    }
                    else
                    {
                        List1.Items.Add(("This is not a FP10 reader"));
                    }

                    if (axBioBridgeSDK1.GetDeviceStatus(1, ref i) == 0)
                    {
                        List1.Items.Add(("Administrator: " + Convert.ToString(i)));
                    }
                    if (axBioBridgeSDK1.GetDeviceStatus(2, ref i) == 0)
                    {
                        List1.Items.Add(("Users: " + Convert.ToString(i)));
                    }
                    if (axBioBridgeSDK1.GetDeviceStatus(3, ref i) == 0)
                    {
                        List1.Items.Add(("Fingerprints: " + Convert.ToString(i)));
                    }
                    if (axBioBridgeSDK1.GetDeviceStatus(4, ref i) == 0)
                    {
                        List1.Items.Add(("Passwords: " + Convert.ToString(i)));
                    }
                    if (axBioBridgeSDK1.GetDeviceStatus(6, ref i) == 0)
                    {
                        List1.Items.Add(("Logs: " + Convert.ToString(i)));
                    }

                    List1.Items.Add(("------------------------------------------------------------------"));



                }
                else
                {
                    List1.Items.Add(("Unable to Connect to IP Address!!"));
                    List1.Items.Add(("Error: " + axBioBridgeSDK1.VC));
                }
            }

            //option to connect to COMM Port
            if (rBtnCOM.Checked)
            {
                if (axBioBridgeSDK1.Connect_COMM(devModel, devNo, commPort, baudRate, comm) == 0)
                {
                    RegisterEvent();

                    btnConnect.Enabled = false;
                    btnDisconnect.Enabled = true;

                    txtBaudRate.Enabled = false;
                    txtCommPort.Enabled = false;

                    if (axBioBridgeSDK1.GetSDKVersion(ref sdkVer, 0) == 0)
                    {
                        sdk = "SDK Version: " + sdkVer;
                    }
                    else
                    {
                        sdk = "SDK Version Error";
                    }

                    if (axBioBridgeSDK1.GetFirmwareVersion(ref firmware) == 0)
                    {
                        firm = "Firmware Version: " + firmware;
                    }
                    else
                    {
                        firm = "Firmware Error";
                    }

                    if (axBioBridgeSDK1.GetDeviceTime(ref yr, ref mth, ref day_Renamed, ref hr, ref min, ref sec) == 0)
                    {
                        time = "Device Date and Time: " + Convert.ToString(day_Renamed) + "/" + Convert.ToString(mth) + "/" + Convert.ToString(yr) + " " + Convert.ToString(hr) + ":" + Convert.ToString(min) + ":" + Convert.ToString(sec);
                    }
                    else
                    {
                        time = "!Date and Time";
                    }
                    List1.Items.Add(("-------------------------------------------------------------------"));
                    List1.Items.Add((sdk));
                    List1.Items.Add((firm));
                    List1.Items.Add((time));
                    List1.Items.Add(("Manufacturer: " + axBioBridgeSDK1.VC));
                    List1.Items.Add(("Serial No: " + axBioBridgeSDK1.SN));
                    List1.Items.Add(("Mac Add: " + axBioBridgeSDK1.MAC));
                    List1.Items.Add(("Model Name: " + axBioBridgeSDK1.DC));

                    //if (axBioBridgeSDK1.Finger10 == 1)
                    //{
                    //    List1.Items.Add(("This is a FP10 reader"));
                    //}
                    //else
                    //{
                    //    List1.Items.Add(("This is not a FP10 reader"));
                    //}

                    if (axBioBridgeSDK1.GetDeviceStatus(1, ref i) == 0)
                    {
                        List1.Items.Add(("Administrator: " + Convert.ToString(i)));
                    }
                    if (axBioBridgeSDK1.GetDeviceStatus(2, ref i) == 0)
                    {
                        List1.Items.Add(("Users: " + Convert.ToString(i)));
                    }
                    if (axBioBridgeSDK1.GetDeviceStatus(3, ref i) == 0)
                    {
                        List1.Items.Add(("Fingerprints: " + Convert.ToString(i)));
                    }
                    if (axBioBridgeSDK1.GetDeviceStatus(4, ref i) == 0)
                    {
                        List1.Items.Add(("Passwords: " + Convert.ToString(i)));
                    }
                    if (axBioBridgeSDK1.GetDeviceStatus(6, ref i) == 0)
                    {
                        List1.Items.Add(("Logs: " + Convert.ToString(i)));
                    }

                    List1.Items.Add(("------------------------------------------------------------------"));
                }
                else
                {
                    List1.Items.Add(("Unable to Connect to COMM Port!!"));
                    List1.Items.Add(("Error: " + axBioBridgeSDK1.VC));
                }
            }

            //option to connect to USB Client
            if (rBtnUSB.Checked)
            {
                if (axBioBridgeSDK1.Connect_USB(devModel, devNo, comm) == 0)
                {
                    btnConnect.Enabled = false;
                    btnDisconnect.Enabled = true;

                    txtIPAdd.Enabled = false;
                    txtPort.Enabled = false;

                    if (axBioBridgeSDK1.GetSDKVersion(ref sdkVer, 0) == 0)
                    {
                        sdk = "SDK Version: " + sdkVer;
                    }
                    else
                    {
                        sdk = "SDK Version Error";
                    }

                    if (axBioBridgeSDK1.GetFirmwareVersion(ref firmware) == 0)
                    {
                        firm = "Firmware Version: " + firmware;
                    }
                    else
                    {
                        firm = "Firmware Error";
                    }

                    if (axBioBridgeSDK1.GetDeviceTime(ref yr, ref mth, ref day_Renamed, ref hr, ref min, ref sec) == 0)
                    {
                        time = "Device Date and Time: " + Convert.ToString(day_Renamed) + "/" + Convert.ToString(mth) + "/" + Convert.ToString(yr) + " " + Convert.ToString(hr) + ":" + Convert.ToString(min) + ":" + Convert.ToString(sec);
                    }
                    else
                    {
                        time = "!Date and Time";
                    }
                    List1.Items.Add(("-------------------------------------------------------------------"));
                    List1.Items.Add((sdk));
                    List1.Items.Add((firm));
                    List1.Items.Add((time));
                    List1.Items.Add(("Manufacturer: " + axBioBridgeSDK1.VC));
                    List1.Items.Add(("Serial No: " + axBioBridgeSDK1.SN));
                    List1.Items.Add(("Mac Add: " + axBioBridgeSDK1.MAC));
                    List1.Items.Add(("Model Name: " + axBioBridgeSDK1.DC));

                    if (axBioBridgeSDK1.Finger10 == 1)
                    {
                        List1.Items.Add(("This is a FP10 reader"));
                    }
                    else
                    {
                        List1.Items.Add(("This is not a FP10 reader"));
                    }

                    if (axBioBridgeSDK1.GetDeviceStatus(1, ref i) == 0)
                    {
                        List1.Items.Add(("Administrator: " + Convert.ToString(i)));
                    }
                    if (axBioBridgeSDK1.GetDeviceStatus(2, ref i) == 0)
                    {
                        List1.Items.Add(("Users: " + Convert.ToString(i)));
                    }
                    if (axBioBridgeSDK1.GetDeviceStatus(3, ref i) == 0)
                    {
                        List1.Items.Add(("Fingerprints: " + Convert.ToString(i)));
                    }
                    if (axBioBridgeSDK1.GetDeviceStatus(4, ref i) == 0)
                    {
                        List1.Items.Add(("Passwords: " + Convert.ToString(i)));
                    }
                    if (axBioBridgeSDK1.GetDeviceStatus(6, ref i) == 0)
                    {
                        List1.Items.Add(("Logs: " + Convert.ToString(i)));
                    }

                    List1.Items.Add(("------------------------------------------------------------------"));
                }
                else
                {
                    List1.Items.Add(("Unable to Connect to IP Address!!"));
                    List1.Items.Add(("Error: " + axBioBridgeSDK1.VC));
                }
                //}
            }
        }

        private void List1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }
    }
}
