using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace CMNCOM
{
    /// <summary>
    /// 用于有界面引用，相对EMoudle而言是半自动引用
    /// </summary>
    public partial class FormDiag : Form
    {
        internal EMoudle EMoudleInstance;

        /// <summary>
        /// 初始化，必须指定DeviceName.Text
        /// </summary>
        public FormDiag(string devName)
        {
            EMoudleInstance = new EMoudle(devName);
            InitializeComponent();
            cbCKS.SelectedIndex = 0;
            Conf_Load();
            EMoudleInstance.EmoudleDispose(); //释放占用的COM口
        }

        internal void Conf_Load()
        {
            try
            {
                string path = System.Windows.Forms.Application.StartupPath + @"\MoudleSettingFiles\";
                tools.pcheck(path);
                path += EMoudleInstance.DeviceUI.MoudleConnString + "_" + EMoudleInstance.DeviceUI.DeviceName.Text + ".cmdset";

                if (File.Exists(path))
                {
                    using (StreamReader sr = new StreamReader(path, System.Text.Encoding.GetEncoding("GB2312")))
                    {
                        Set_CMD(sr.ReadLine(),checkBox1,textBox1,button1);
                        Set_CMD(sr.ReadLine(), checkBox2, textBox2, button2);
                        Set_CMD(sr.ReadLine(), checkBox3, textBox3, button3);
                        Set_CMD(sr.ReadLine(), checkBox4, textBox4, button4);
                        Set_CMD(sr.ReadLine(), checkBox5, textBox5, button5);
                        Set_CMD(sr.ReadLine(), checkBox6, textBox6, button6);
                        Set_CMD(sr.ReadLine(), checkBox7, textBox7, button7);
                    }
                }           
            }
            catch
            {           
            }

        }

        private void Set_CMD(string str,CheckBox cb, TextBox tb,Button btn)
        {
            string[] rst = null;
            rst = str.Split('|');
            if (rst.Length == 3)
            {
                if (rst[0].ToUpper() == "H") { cb.Checked = true; }
                else { cb.Checked = false; }
                tb.Text = rst[1];btn.Text = rst[2];
            }
            else
            {
                cb.Checked = false; 
                tb.Text = null; btn.Text = "Send";

            }
        }

        private string Read_CMD(CheckBox cb, TextBox tb, Button btn)
        {
            string[] rst = new string[3];string str = null;
            if (cb.Checked) { rst[0] = "H"; }
            else { rst[0] = "A"; }
            rst[1] = tb.Text;rst[2] = btn.Text;
            str = rst[0] + "|" + rst[1] + "|" + rst[2];
            return str;
        }

        private void FormDiag_FormClosing(object sender, FormClosingEventArgs e)
        {
            Conf_Save();
            EMoudleInstance.DeviceClose();
        }

        private void Conf_Save()
        {
            try
            {
                string path = System.Windows.Forms.Application.StartupPath + @"\MoudleSettingFiles\";
                tools.pcheck(path);
                path += EMoudleInstance.DeviceUI.MoudleConnString + "_" + EMoudleInstance.DeviceUI.DeviceName.Text + ".cmdset";
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.GetEncoding("GB2312")))
                    {
                        string rst = "";
                        rst += Read_CMD(checkBox1, textBox1, button1) + "\r\n";
                        rst += Read_CMD(checkBox2, textBox2, button2) + "\r\n";
                        rst += Read_CMD(checkBox3, textBox3, button3) + "\r\n";
                        rst += Read_CMD(checkBox4, textBox4, button4) + "\r\n";
                        rst += Read_CMD(checkBox5, textBox5, button5) + "\r\n";
                        rst += Read_CMD(checkBox6, textBox6, button6) + "\r\n";
                        rst += Read_CMD(checkBox7, textBox7, button7) + "\r\n";
                        sw.Write(rst);

                    }
              }
            catch
            {
            }
        }

        private void SendMsg_Click1(object sender, EventArgs e)
        {
            ButtonSend(cb_T_HEX, tb_SendMsg,5);
        }      

        private void ButtonSend(CheckBox cb,TextBox tb)
        {

            ButtonSend(cb, tb, 1);
          
        }

        private void ButtonSend_NoRecive(CheckBox cb, TextBox tb)
        {
            tbCKS_Value.Text = EMoudleInstance.GetCKSByType(tb.Text, cbCKS.SelectedItem.ToString(), Convert.ToInt32(tbStartFromIndex.Text), Convert.ToInt32(tbEndToIndex.Text));
            WriteLog(rtb_ReciveMsg, "Send: " + tb.Text + " " + tbCKS_Value.Text);
            rtb_ReciveMsg.Update();
            EMoudleInstance.SendMsg(cb.Checked, tb.Text + tbCKS_Value.Text, cb0D.Checked, cb0A.Checked);           
            EMoudleInstance.DeviceClose();
        }

        private void ButtonSend(CheckBox cb, TextBox tb, int TimeOut)
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            tbCKS_Value.Text = EMoudleInstance.GetCKSByType(tb.Text, cbCKS.SelectedItem.ToString(), Convert.ToInt32(tbStartFromIndex.Text), Convert.ToInt32(tbEndToIndex.Text));
            WriteLog(rtb_ReciveMsg, "Send: " + tb.Text + " " + tbCKS_Value.Text);
            rtb_ReciveMsg.Update();
            string rst = EMoudleInstance.SendReciveMsg(cb.Checked, tb.Text + tbCKS_Value.Text, cb_R_HEX.Checked, TimeOut,500, cb0D.Checked, cb0A.Checked);
            WriteLog(rtb_ReciveMsg, "Receive: " + rst + "\r\n");
            //EMoudleInstance.DeviceClose();
            stopwatch.Stop();
            TimeSpan timeSpan = stopwatch.Elapsed;
            double milliseconds = timeSpan.TotalMilliseconds;
            Console.WriteLine("milliseconds: " + milliseconds.ToString());
        }

        #region 利用委托解决跨线程调用问题方法(WriteLog)
        //private delegate void WriteLogUnSafe(RichTextBox logRichTxt, string strLog);
        private static void WriteLog(RichTextBox logRichTxt, string strLog)
        {
            if (logRichTxt.InvokeRequired)
            {
                //WriteLogUnSafe InvokeWriteLog = new WriteLogUnSafe(WriteLog);
                //logRichTxt.Invoke(InvokeWriteLog, new object[] { logRichTxt, strLog });
                logRichTxt.Invoke((MethodInvoker) delegate ()
                {
                    WriteLog(logRichTxt, strLog);
                }

                );
            }
            else
            {
                logRichTxt.AppendText(strLog + "\r\n");
                logRichTxt.Select(logRichTxt.Text.Length, 0);
                logRichTxt.ScrollToCaret();

            }
        }



        #endregion

        #region"Button1-7 and TextBox1-7 事件"
        private void button1_Click(object sender, EventArgs e)
        {
            ButtonSend(checkBox1, textBox1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ButtonSend(checkBox2, textBox2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonSend(checkBox3, textBox3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButtonSend(checkBox4, textBox4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonSend(checkBox5, textBox5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ButtonSend(checkBox6, textBox6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ButtonSend(checkBox7, textBox7);
        }

        private void ModifyBtnText(Button btn)
        {
            string str = Interaction.InputBox("请输入右边按钮的注释文字", "提示", btn.Text, -1, -1);  //-1表示在屏幕的中间  

            if (!string.IsNullOrEmpty(str)) btn.Text = str;      
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            ModifyBtnText(button1);
        }


        private void textBox2_DoubleClick(object sender, EventArgs e)
        {
            ModifyBtnText(button2);
        }

        private void textBox3_DoubleClick(object sender, EventArgs e)
        {
            ModifyBtnText(button3);
        }

        private void textBox4_DoubleClick(object sender, EventArgs e)
        {
            ModifyBtnText(button4);
        }

        private void textBox5_DoubleClick(object sender, EventArgs e)
        {
            ModifyBtnText(button5);
        }

        private void textBox6_DoubleClick(object sender, EventArgs e)
        {
            ModifyBtnText(button6);
        }

        private void textBox7_DoubleClick(object sender, EventArgs e)
        {
            ModifyBtnText(button7);
        }
        #endregion

        private void cbCKS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCKS.SelectedItem.ToString() != "None") {
                cb_R_HEX.Checked = true;
                cb_R_HEX.Enabled = false;
                cb_T_HEX.Checked = true;
                cb_T_HEX.Enabled = false;
            } else
            {
                cb_R_HEX.Enabled = true;
                cb_T_HEX.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Checktb_Text(textBox1);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Checktb_Text(textBox2);
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Checktb_Text(textBox3);
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Checktb_Text(textBox4);
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Checktb_Text(textBox5);
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Checktb_Text(textBox6);
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            Checktb_Text(textBox7);
        }
        private void Checktb_Text(TextBox tb)
        {
            if (tb.Text.Contains("|"))
            {
                MessageBox.Show("命令暂不支持保存含有 '|'的字符串！！");
                tb.Text = tb.Text.Replace("|", "");
                tb.Focus();
            }
        }

        private void cb_R_Continue_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_R_Continue.Checked)
            {
                EMoudleInstance.DeviceOpen();
                EMoudleInstance.DeviceUI.ComDevice.DataReceived += new SerialDataReceivedEventHandler(ReceiveWaiter);

            } else
            {
                EMoudleInstance.DeviceClose();
                EMoudleInstance.DeviceUI.ComDevice.DataReceived -= new SerialDataReceivedEventHandler(ReceiveWaiter);
            }
            
        }
        private void ReceiveWaiter(object sender, SerialDataReceivedEventArgs e)
        {
            if (e.EventType != SerialData.Chars)
            {
                return;
            }

            if (EMoudleInstance.DeviceUI.ComDevice.BytesToRead <= 0)
            {
                return;
            }
            string str = EMoudleInstance.RecieveMsg(cb_R_HEX.Checked, 1);           
            WriteLog(rtb_ReciveMsg, "AutoReceive: " + str + "\r\n");
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            EMoudleInstance.DeviceOpen();
            string str = EMoudleInstance.RecieveMsg(cb_R_HEX.Checked, 1);
            WriteLog(rtb_ReciveMsg, "ReadReceive: " + str + "\r\n");
        }
    }
}
