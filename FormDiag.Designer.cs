namespace CMNCOM
{
    partial class FormDiag
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.rtb_ReciveMsg = new System.Windows.Forms.RichTextBox();
            this.tb_SendMsg = new System.Windows.Forms.TextBox();
            this.cb_T_HEX = new System.Windows.Forms.CheckBox();
            this.cb_R_HEX = new System.Windows.Forms.CheckBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cb0D = new System.Windows.Forms.CheckBox();
            this.cb0A = new System.Windows.Forms.CheckBox();
            this.cbCKS = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbStartFromIndex = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEndToIndex = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCKS_Value = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_ReciveMsg
            // 
            this.rtb_ReciveMsg.Location = new System.Drawing.Point(22, 40);
            this.rtb_ReciveMsg.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.rtb_ReciveMsg.Name = "rtb_ReciveMsg";
            this.rtb_ReciveMsg.Size = new System.Drawing.Size(484, 316);
            this.rtb_ReciveMsg.TabIndex = 56;
            this.rtb_ReciveMsg.Text = "";
            // 
            // tb_SendMsg
            // 
            this.tb_SendMsg.Location = new System.Drawing.Point(149, 374);
            this.tb_SendMsg.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tb_SendMsg.Name = "tb_SendMsg";
            this.tb_SendMsg.Size = new System.Drawing.Size(527, 25);
            this.tb_SendMsg.TabIndex = 57;
            // 
            // cb_T_HEX
            // 
            this.cb_T_HEX.AutoSize = true;
            this.cb_T_HEX.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_T_HEX.Location = new System.Drawing.Point(22, 376);
            this.cb_T_HEX.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cb_T_HEX.Name = "cb_T_HEX";
            this.cb_T_HEX.Size = new System.Drawing.Size(113, 18);
            this.cb_T_HEX.TabIndex = 59;
            this.cb_T_HEX.Text = "Hex Transmit";
            this.cb_T_HEX.UseVisualStyleBackColor = true;
            // 
            // cb_R_HEX
            // 
            this.cb_R_HEX.AutoSize = true;
            this.cb_R_HEX.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_R_HEX.Location = new System.Drawing.Point(22, 12);
            this.cb_R_HEX.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cb_R_HEX.Name = "cb_R_HEX";
            this.cb_R_HEX.Size = new System.Drawing.Size(99, 18);
            this.cb_R_HEX.TabIndex = 60;
            this.cb_R_HEX.Text = "Hex Recive";
            this.cb_R_HEX.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(683, 372);
            this.btnSend.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(91, 29);
            this.btnSend.TabIndex = 61;
            this.btnSend.Text = "Send/Read";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.SendMsg_Click1);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(545, 90);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 25);
            this.textBox1.TabIndex = 62;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.DoubleClick += new System.EventHandler(this.textBox1_DoubleClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(519, 93);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 64;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(513, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 315);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "常用指令";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 92;
            this.label3.Text = "|点击发送";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(43, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 15);
            this.label2.TabIndex = 91;
            this.label2.Text = "双击输入右边按钮注释";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 90;
            this.label1.Text = "Hex|";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(32, 138);
            this.textBox4.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(228, 25);
            this.textBox4.TabIndex = 89;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.DoubleClick += new System.EventHandler(this.textBox4_DoubleClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(267, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 25);
            this.button1.TabIndex = 88;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(267, 80);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 25);
            this.button2.TabIndex = 87;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(6, 203);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(18, 17);
            this.checkBox6.TabIndex = 86;
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(6, 233);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(18, 17);
            this.checkBox7.TabIndex = 85;
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(6, 173);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(18, 17);
            this.checkBox5.TabIndex = 84;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(267, 168);
            this.button5.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(144, 25);
            this.button5.TabIndex = 81;
            this.button5.Text = "Send";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(267, 228);
            this.button7.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(144, 25);
            this.button7.TabIndex = 83;
            this.button7.Text = "Send";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(267, 198);
            this.button6.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(144, 25);
            this.button6.TabIndex = 82;
            this.button6.Text = "Send";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Location = new System.Drawing.Point(32, 198);
            this.textBox6.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(228, 25);
            this.textBox6.TabIndex = 80;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            this.textBox6.DoubleClick += new System.EventHandler(this.textBox6_DoubleClick);
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(32, 168);
            this.textBox5.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(228, 25);
            this.textBox5.TabIndex = 78;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox5.DoubleClick += new System.EventHandler(this.textBox5_DoubleClick);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 112);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(18, 17);
            this.checkBox3.TabIndex = 77;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.Location = new System.Drawing.Point(32, 228);
            this.textBox7.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(228, 25);
            this.textBox7.TabIndex = 79;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            this.textBox7.DoubleClick += new System.EventHandler(this.textBox7_DoubleClick);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(32, 108);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(228, 25);
            this.textBox3.TabIndex = 76;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.DoubleClick += new System.EventHandler(this.textBox3_DoubleClick);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 142);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(18, 17);
            this.checkBox4.TabIndex = 74;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(267, 138);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 25);
            this.button4.TabIndex = 75;
            this.button4.Text = "Send";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 83);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 68;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(267, 108);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 25);
            this.button3.TabIndex = 71;
            this.button3.Text = "Send";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(32, 80);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(228, 25);
            this.textBox2.TabIndex = 66;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.DoubleClick += new System.EventHandler(this.textBox2_DoubleClick);
            // 
            // cb0D
            // 
            this.cb0D.AutoSize = true;
            this.cb0D.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb0D.Location = new System.Drawing.Point(788, 377);
            this.cb0D.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cb0D.Name = "cb0D";
            this.cb0D.Size = new System.Drawing.Size(71, 18);
            this.cb0D.TabIndex = 66;
            this.cb0D.Text = "0D回车";
            this.cb0D.UseVisualStyleBackColor = true;
            // 
            // cb0A
            // 
            this.cb0A.AutoSize = true;
            this.cb0A.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb0A.Location = new System.Drawing.Point(860, 376);
            this.cb0A.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.cb0A.Name = "cb0A";
            this.cb0A.Size = new System.Drawing.Size(71, 18);
            this.cb0A.TabIndex = 67;
            this.cb0A.Text = "0A换行";
            this.cb0A.UseVisualStyleBackColor = true;
            // 
            // cbCKS
            // 
            this.cbCKS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCKS.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbCKS.FormattingEnabled = true;
            this.cbCKS.Items.AddRange(new object[] {
            "None",
            "BCC",
            "LRC"});
            this.cbCKS.Location = new System.Drawing.Point(83, 420);
            this.cbCKS.Name = "cbCKS";
            this.cbCKS.Size = new System.Drawing.Size(69, 21);
            this.cbCKS.TabIndex = 68;
            this.cbCKS.SelectedIndexChanged += new System.EventHandler(this.cbCKS_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(30, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 93;
            this.label4.Text = "加校验";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(232, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 14);
            this.label5.TabIndex = 94;
            this.label5.Text = "第";
            // 
            // tbStartFromIndex
            // 
            this.tbStartFromIndex.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbStartFromIndex.Location = new System.Drawing.Point(251, 420);
            this.tbStartFromIndex.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbStartFromIndex.Name = "tbStartFromIndex";
            this.tbStartFromIndex.Size = new System.Drawing.Size(35, 22);
            this.tbStartFromIndex.TabIndex = 95;
            this.tbStartFromIndex.Text = "1";
            this.tbStartFromIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(292, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 14);
            this.label6.TabIndex = 96;
            this.label6.Text = "字节 至尾数第";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbEndToIndex
            // 
            this.tbEndToIndex.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbEndToIndex.Location = new System.Drawing.Point(396, 420);
            this.tbEndToIndex.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbEndToIndex.Name = "tbEndToIndex";
            this.tbEndToIndex.Size = new System.Drawing.Size(35, 22);
            this.tbEndToIndex.TabIndex = 97;
            this.tbEndToIndex.Text = "1";
            this.tbEndToIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(436, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 14);
            this.label7.TabIndex = 98;
            this.label7.Text = "字节 ps:(1,1)代表全长";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbCKS_Value
            // 
            this.tbCKS_Value.Font = new System.Drawing.Font("宋体", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCKS_Value.Location = new System.Drawing.Point(160, 419);
            this.tbCKS_Value.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.tbCKS_Value.Name = "tbCKS_Value";
            this.tbCKS_Value.ReadOnly = true;
            this.tbCKS_Value.Size = new System.Drawing.Size(61, 22);
            this.tbCKS_Value.TabIndex = 99;
            this.tbCKS_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(21, 400);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 53);
            this.groupBox2.TabIndex = 100;
            this.groupBox2.TabStop = false;
            // 
            // FormDiag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 465);
            this.Controls.Add(this.tbCKS_Value);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbEndToIndex);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbStartFromIndex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCKS);
            this.Controls.Add(this.cb0A);
            this.Controls.Add(this.cb0D);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.cb_R_HEX);
            this.Controls.Add(this.cb_T_HEX);
            this.Controls.Add(this.tb_SendMsg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtb_ReciveMsg);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "FormDiag";
            this.Text = "COM Transmit and Recive";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDiag_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtb_ReciveMsg;
        private System.Windows.Forms.TextBox tb_SendMsg;
        private System.Windows.Forms.CheckBox cb_T_HEX;
        private System.Windows.Forms.CheckBox cb_R_HEX;
        private System.Windows.Forms.Button btnSend;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox3;


        private System.Windows.Forms.CheckBox checkBox4;

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cb0D;
        private System.Windows.Forms.CheckBox cb0A;
        private System.Windows.Forms.ComboBox cbCKS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbStartFromIndex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEndToIndex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCKS_Value;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

