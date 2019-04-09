using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CMNCOM
{
    /// <summary>
    /// 用于无界面引用，相对FormDiag窗口而言是自动引用
    /// </summary>
    public class EMoudle
    {
        /// <summary>
        /// 声明DeviceUI为UserControl_UI
        /// </summary>
        public UserControl_UI DeviceUI;

        /// <summary>
        /// 初始化，必须指定DeviceName.Text
        /// </summary>
        public EMoudle(string devName)
        {
            DeviceUI = new UserControl_UI(devName);
            DeviceUI.User_Load(true);
            EmoudleDispose();//这里最好也释放掉COM口        
        }

      

        /// <summary>
        /// 
        /// </summary>
        public void EmoudleDispose()
        {
            DeviceUI.ComDevice.Close();
        }



        /// <summary>
        /// 适用于无需接收数据返回的情况
        /// </summary>
        /// <param name="hexBool">代表发送的字符串是否为Hex</param>
        /// <param name="Msg">代表发送的字符串</param>
        /// <param name="b0D"></param>
        /// <param name="b0A"></param>
        public bool SendMsg(bool hexBool, string Msg, bool b0D, bool b0A)
        {

            if (DeviceOpen())
            {
                DeviceUI.ComDevice.ReadExisting();
                DeviceUI.ComDevice.DiscardInBuffer();
                //MessageBox.Show("Pause", "Pause", MessageBoxButtons.OK);
                if (hexBool)
                {
                    Msg = Msg.Replace(" ", "");
                    Msg = Msg.Replace("-", "");
                    Msg = Msg.Replace("0x", "");
                    Msg = Msg.Replace("0X", "");
                    if (Msg.Length % 2 != 0) { MessageBox.Show("16进制必须为偶数位，请检查！", "Error", MessageBoxButtons.OK); return false; }
                    if (b0D) Msg += "0D";
                    if (b0A) Msg += "0A";
                    byte[] buf = HexStringToByteArray(Msg);
                    //Console.WriteLine(BitConverter.ToString(buf));                   
                    DeviceUI.ComDevice.Write(buf, 0, buf.Length);
                    return true;
                }
                else
                {
                    if (b0D) Msg += "\r";
                    if (b0A) Msg += "\n";
                    DeviceUI.ComDevice.Write(Msg);
                    return true;
                }
            }
            else
            {
                //MessageBox.Show("COM处于断开状态，请检查！", DeviceUI.MoudleConnString_Ext + " - " + DeviceUI.ComDevice.DeviceDiscription);
                Console.WriteLine(DeviceUI.MoudleConnString_Ext + " - " + DeviceUI.ComDevice.DeviceDiscription + ":\rCOM处于断开状态，请检查！\r");
                return false;
            }
        }

        /// <summary>
        /// SendMsg精简版，默认尾部不添加0D或0A
        /// </summary>
        /// <param name="hexBool"></param>
        /// <param name="Msg"></param>
        /// <returns></returns>
        public bool SendMsg(bool hexBool, string Msg)
        {
           return SendMsg(hexBool, Msg, false, false);
        }


        /// <summary>
        /// 接收数据包个数为0时，等待超时会提醒,可配置接收消息前延时，避免数据接收不完全
        /// </summary>
        /// <param name="hexBool">代表发送的字符串是否为Hex</param>
        /// <param name="timeout">代表接收串口数据的最大超时时间(S)</param>
        /// <param name="delayms_BeforeRecieve"></param>
        /// <returns>返回字符串类型的接收到的数据</returns>
        public string RecieveMsg(bool hexBool, int timeout,int delayms_BeforeRecieve)
        {
            if (timeout == 0)
            {
                return null;
            }
            string str = null;
            int inti = 0, ByteNum = 0, TempByteNum = 0;
            int ByteNum_No_Increase_Times = 0;
            try
            {
                do
                {
                    TempByteNum = DeviceUI.ComDevice.BytesToRead;
                    if (TempByteNum !=0)
                    {
                        if (TempByteNum > ByteNum)
                        {
                            ByteNum = TempByteNum;
                            ByteNum_No_Increase_Times = 0;
                        }
                        else
                        {
                            ByteNum_No_Increase_Times += 1;
                        }
                    }                   
                    Thread.Sleep(3);
                    inti += 1;
                    //Console.WriteLine("ByteNum：" + ByteNum); //ByteNum从0往上递增,如果0.2S内没有新增ByteNumber,证明接受数据完毕
                }
                while ((ByteNum_No_Increase_Times <66 ) && (inti < timeout * 400));
                if (ByteNum == 0)
                {
                    if (timeout != 1) Console.WriteLine("读取数据包个数为0，等待超时！(" + timeout + "S)", DeviceUI.MoudleConnString_Ext + " - " + DeviceUI.ComDevice.DeviceDiscription);
                    return str;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace, DeviceUI.MoudleConnString_Ext + " - " + DeviceUI.ComDevice.DeviceDiscription);
                return null;
            }
            //Thread.Sleep(delayms_BeforeRecieve); 
            try
            {
                //string response = DeviceUI.ComDevice.ReadLine();//当返回值没有换行符时,就死了
                if (hexBool)
                {
                    int buffersize = ByteNum;   //十六进制数的大小（可调整数字大小）
                    byte[] buffer = new Byte[buffersize];   //创建缓冲区
                    DeviceUI.ComDevice.Read(buffer, 0, buffersize);
                    str = ByteArrayToHexString(buffer);
                }
                else
                {
                    while (DeviceUI.ComDevice.BytesToRead > 0)
                    {
                        Thread.Sleep(10);
                        str += DeviceUI.ComDevice.ReadExisting();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace, DeviceUI.MoudleConnString_Ext + " - " + DeviceUI.ComDevice.DeviceDiscription);
                return null;
            }
            return str;
        }

        /// <summary>
        /// 接收数据包个数为0时，等待超时会提醒
        /// </summary>
        /// <param name="hexBool">代表发送的字符串是否为Hex</param>
        /// <param name="timeout">代表接收串口数据的最大超时时间(S)</param>
        /// <returns>返回字符串类型的接收到的数据</returns>
        public string RecieveMsg(bool hexBool, int timeout)
        {
            if (timeout == 0 )
            {
                return null;
            }
            string str = null;
            int inti = 0, ByteNum = 0;
            try
            {
                do
                {
                    ByteNum = DeviceUI.ComDevice.BytesToRead;
                    Thread.Sleep(10);
                    inti += 1;
                    //Console.WriteLine("inti："+inti);
                }
                while ((ByteNum == 0) && (inti < timeout * 40));
                if (ByteNum == 0)
                {
                    if (timeout != 1) MessageBox.Show("读取数据包个数为0，等待超时！(" + timeout + "S)", DeviceUI.MoudleConnString_Ext + " - " + DeviceUI.ComDevice.DeviceDiscription);
                    return str;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace, DeviceUI.MoudleConnString_Ext + " - " + DeviceUI.ComDevice.DeviceDiscription);
                return null;
            }
            Thread.Sleep(10); //为何要等待？
            try
            {
                //string response = DeviceUI.ComDevice.ReadLine();//当返回值没有换行符时,就死了
                if (hexBool)
                {
                    int buffersize = ByteNum;   //十六进制数的大小（可调整数字大小）
                    byte[] buffer = new Byte[buffersize];   //创建缓冲区
                    DeviceUI.ComDevice.Read(buffer, 0, buffersize);
                    str = ByteArrayToHexString(buffer);
                }
                else
                {
                    while (DeviceUI.ComDevice.BytesToRead > 0)
                    {
                        Thread.Sleep(150);
                        str += DeviceUI.ComDevice.ReadExisting();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace, DeviceUI.MoudleConnString_Ext + " - " + DeviceUI.ComDevice.DeviceDiscription);
                return null;
            }
            return str;
        }

        /// <summary>
        /// RecieveMsg精简版，接收数据包个数为0时，最多只等待1S，且超时不提醒
        /// </summary>
        /// <param name="hexBool">代表发送的字符串是否为Hex</param>
        /// <returns>返回字符串类型的接收到的数据</returns>
        public string RecieveMsg(bool hexBool)
        {
            return RecieveMsg(hexBool, 1);
        }




        /// <summary>
        /// SendMsg精简版+RecieveMsg精简版，默认不发送回车换行和接收超时不提醒
        /// </summary>
        /// <param name="Send_hexBool"></param>
        /// <param name="Msg"></param>
        /// <param name="Recive_hexBool"></param>
        /// <returns></returns>
        public string SendReciveMsg(bool Send_hexBool, string Msg, bool Recive_hexBool)
        {
           return SendReciveMsg(Send_hexBool, Msg, Recive_hexBool, false, false);
        }

        /// <summary>
        ///  SendMsg+RecieveMsg精简版，可发送回车换行和接收超时不提醒
        /// </summary>
        /// <param name="Send_hexBool"></param>
        /// <param name="Msg"></param>
        /// <param name="Recive_hexBool"></param>
        /// <param name="b0D"></param>
        /// <param name="b0A"></param>
        public string SendReciveMsg(bool Send_hexBool, string Msg,bool Recive_hexBool, bool b0D, bool b0A)
        {
            if (!SendMsg(Send_hexBool, Msg, b0D, b0A)) return null;
            string str = RecieveMsg(Recive_hexBool);
            return str;
        }

        /// <summary>
        /// SendMsg精简版+RecieveMsg，默认不发送回车换行和可接收超时提醒
        /// </summary>
        /// <param name="Send_hexBool"></param>
        /// <param name="Msg"></param>
        /// <param name="Recive_hexBool"></param>
        /// <param name="RTimeOut"></param>
        /// <returns></returns>
        public string SendReciveMsg(bool Send_hexBool, string Msg, bool Recive_hexBool, int RTimeOut)
        {
            return SendReciveMsg(Send_hexBool, Msg, Recive_hexBool, RTimeOut, false, false);
        }

        /// <summary>
        /// SendMsg+RecieveMsg，可发送回车换行和可接收超时提醒,可配置接收消息前延时，避免数据接收不完全
        /// </summary>
        /// <param name="Send_hexBool"></param>
        /// <param name="Msg"></param>
        /// <param name="Recive_hexBool"></param>
        /// <param name="RTimeOut"></param>
        /// <param name="delayms_BeforeRecieve"></param>
        /// <param name="b0D"></param>
        /// <param name="b0A"></param>
        /// <returns></returns>
        public string SendReciveMsg(bool Send_hexBool, string Msg, bool Recive_hexBool, int RTimeOut,int delayms_BeforeRecieve, bool b0D, bool b0A)
        {
            if (!SendMsg(Send_hexBool, Msg, b0D, b0A)) return null;
            string str = RecieveMsg(Recive_hexBool, RTimeOut, delayms_BeforeRecieve);
            return str;
        }
        /// <summary>
        /// SendMsg+RecieveMsg，可发送回车换行和可接收超时提醒
        /// </summary>
        /// <param name="Send_hexBool"></param>
        /// <param name="Msg"></param>
        /// <param name="Recive_hexBool"></param>
        /// <param name="RTimeOut"></param>
        /// <param name="b0D"></param>
        /// <param name="b0A"></param>
        /// <returns></returns>
        public string SendReciveMsg(bool Send_hexBool, string Msg, bool Recive_hexBool,int RTimeOut, bool b0D, bool b0A)
        {
            if (!SendMsg(Send_hexBool, Msg,b0D,b0A)) return null;
            string str = RecieveMsg(Recive_hexBool,RTimeOut);
            return str;
        }




        internal string GetCKSByType(string Msg, string CKSType, int StartFromIndex, int EndToIndex)
        {
            string data = Msg.Replace(" ", "");
            StartFromIndex = 2 * StartFromIndex - 2;
            EndToIndex = 2 * EndToIndex - 2;
            if (StartFromIndex < 0) StartFromIndex = 0;
            if (EndToIndex < 0) EndToIndex = 0;
            data = data.Substring(StartFromIndex, data.Length - EndToIndex - StartFromIndex);
            string StrCKS = "";
            switch (CKSType.ToUpper())
            {
                case "BCC":
                    StrCKS = getChkSum.EModule.BCC(data);
                    break;
                case "LRC":
                    StrCKS = getChkSum.EModule.LRC(data);
                    break;
                default:
                    StrCKS = "";
                    break;
            }
            return StrCKS;
        }


        /// <summary>
        /// Hex模式，可加CHKSUM，SendMsg精简版+RecieveMsg，默认不发送回车换行和可接收超时提醒
        /// </summary>
        /// <param name="Msg"></param>
        /// <param name="RTimeOut"></param>
        /// <param name="CKSType"></param>
        /// <param name="StartFromIndex">开始字节Index，>=1，=1代表无Head</param>
        /// <param name="EndToIndex">尾字节Index，>=1，=1代表无Tail,（1,1）代表全长</param>
        /// <returns></returns>
        public string SendReciveMsg(string Msg, int RTimeOut, string CKSType, int StartFromIndex, int EndToIndex)
        {
            string StrCKS = GetCKSByType(Msg, CKSType, StartFromIndex, EndToIndex);
            if (!SendMsg(true, Msg + StrCKS)) return null;
            string str = RecieveMsg(true, RTimeOut);
            return str;
        }

        /// <summary>
        /// Hex模式，可加CHKSUM，SendMsg精简版+RecieveMsg精简版，默认不发送回车换行和不接收超时提醒
        /// </summary>
        /// <param name="Msg"></param>
        /// <param name="CKSType"></param>
        /// <param name="StartFromIndex">开始字节Index，>=1，=1代表无Head</param>
        /// <param name="EndToIndex">尾字节Index，>=1，=1代表无Tail,（1,1）代表全长</param>
        /// <returns></returns>
        public string SendReciveMsg(string Msg, string CKSType, int StartFromIndex, int EndToIndex)
        {
            return SendReciveMsg(Msg, 1, CKSType, StartFromIndex, EndToIndex);
        }

  

      
        /// <summary>
        ///  检查Device 是否Open，未Open自动Open
        /// </summary>
        /// <returns></returns>
        public bool DeviceOpen()
        {
            try
            {

                if (!DeviceUI.ComDevice.IsOpen)
                {
                    Console.WriteLine("DeviceOpen...");
                    DeviceUI.ComDevice.Open();                  
                }       
                return true;
                  
            }
            catch
            {
                Console.WriteLine(DeviceUI.MoudleConnString_Ext + " - " + DeviceUI.ComDevice.DeviceDiscription + ":\rCOM无法打开，请检查！\r");
                return false;
            }
            
        }

        /// <summary>
        /// 检查Device Close，未Close自动Close
        /// </summary>
        public void DeviceClose()
        {
            try
            {
                if (DeviceUI.ComDevice.IsOpen)
                    DeviceUI.ComDevice.Close();
            } catch 
            {
                Console.WriteLine(DeviceUI.MoudleConnString_Ext + " - " + DeviceUI.ComDevice.DeviceDiscription + ":\rCOM无法关闭，请检查！\r");
            }
         
        }

        private static byte[] HexStringToByteArray(string s)
        {
            s = s.Replace(" ", "");
            byte[] buffer = new byte[s.Length / 2];
            //Console.WriteLine(s.Length / 2);
            for (int i = 0; i < s.Length; i += 2)
            {
                buffer[i / 2] = (byte)Convert.ToByte(s.Substring(i, 2), 16);
            }
            return buffer;
        }

        //字节数组转16进制字符串
        private static string ByteArrayToHexString(byte[] bytes)
        {
            string returnStr = "";
            if (bytes != null)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    returnStr += bytes[i].ToString("X2");
                }
            }
            return returnStr;
        }


    }
}
