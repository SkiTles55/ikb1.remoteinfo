namespace ikb1.remoteinfo
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.connectBtn = new System.Windows.Forms.Button();
            this.ipBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statuslabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clearbtn = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.wmiBox = new System.Windows.Forms.GroupBox();
            this.startbutton = new System.Windows.Forms.Button();
            this.propsBox = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.wmiclass = new System.Windows.Forms.ListBox();
            this.CmdBox = new System.Windows.Forms.GroupBox();
            this.wmiCmdList = new System.Windows.Forms.ListBox();
            this.testOutput = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.wmiBox.SuspendLayout();
            this.CmdBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(125, 85);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(124, 26);
            this.userBox.TabIndex = 6;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(125, 119);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(124, 26);
            this.passBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.disconnectBtn);
            this.groupBox1.Controls.Add(this.connectBtn);
            this.groupBox1.Controls.Add(this.ipBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.statuslabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.passBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.userBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 162);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подключение";
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.Enabled = false;
            this.disconnectBtn.Location = new System.Drawing.Point(266, 119);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(121, 26);
            this.disconnectBtn.TabIndex = 13;
            this.disconnectBtn.Text = "Отключить";
            this.disconnectBtn.UseVisualStyleBackColor = true;
            this.disconnectBtn.Click += new System.EventHandler(this.disconnectBtn_Click);
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(266, 50);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(121, 60);
            this.connectBtn.TabIndex = 12;
            this.connectBtn.Text = "Подключить";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // ipBox
            // 
            this.ipBox.Location = new System.Drawing.Point(125, 50);
            this.ipBox.Mask = "##.##.###.###";
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(124, 26);
            this.ipBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "IP адрес";
            // 
            // statuslabel
            // 
            this.statuslabel.AutoSize = true;
            this.statuslabel.ForeColor = System.Drawing.Color.Red;
            this.statuslabel.Location = new System.Drawing.Point(125, 20);
            this.statuslabel.Name = "statuslabel";
            this.statuslabel.Size = new System.Drawing.Size(96, 20);
            this.statuslabel.TabIndex = 9;
            this.statuslabel.Text = "Отключено";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Статус";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clearbtn);
            this.groupBox2.Controls.Add(this.savebutton);
            this.groupBox2.Controls.Add(this.outputBox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(413, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 359);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вывод";
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(213, 304);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(190, 44);
            this.clearbtn.TabIndex = 2;
            this.clearbtn.Text = "Очистить";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(7, 304);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(190, 44);
            this.savebutton.TabIndex = 1;
            this.savebutton.Text = "Сохранить в файл";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(7, 20);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(396, 276);
            this.outputBox.TabIndex = 0;
            this.outputBox.Text = "";
            // 
            // wmiBox
            // 
            this.wmiBox.Controls.Add(this.startbutton);
            this.wmiBox.Controls.Add(this.propsBox);
            this.wmiBox.Controls.Add(this.label6);
            this.wmiBox.Controls.Add(this.label4);
            this.wmiBox.Controls.Add(this.wmiclass);
            this.wmiBox.Enabled = false;
            this.wmiBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wmiBox.Location = new System.Drawing.Point(12, 180);
            this.wmiBox.Name = "wmiBox";
            this.wmiBox.Size = new System.Drawing.Size(395, 426);
            this.wmiBox.TabIndex = 10;
            this.wmiBox.TabStop = false;
            this.wmiBox.Text = "WMI Запросы";
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(266, 376);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(121, 44);
            this.startbutton.TabIndex = 4;
            this.startbutton.Text = "Выполнить";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // propsBox
            // 
            this.propsBox.FormattingEnabled = true;
            this.propsBox.Location = new System.Drawing.Point(156, 217);
            this.propsBox.Name = "propsBox";
            this.propsBox.ScrollAlwaysVisible = true;
            this.propsBox.Size = new System.Drawing.Size(231, 151);
            this.propsBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Выбор свойств";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Выбор класса";
            // 
            // wmiclass
            // 
            this.wmiclass.FormattingEnabled = true;
            this.wmiclass.ItemHeight = 20;
            this.wmiclass.Location = new System.Drawing.Point(156, 31);
            this.wmiclass.Name = "wmiclass";
            this.wmiclass.ScrollAlwaysVisible = true;
            this.wmiclass.Size = new System.Drawing.Size(231, 164);
            this.wmiclass.Sorted = true;
            this.wmiclass.TabIndex = 0;
            this.wmiclass.SelectedIndexChanged += new System.EventHandler(this.wmiclass_SelectedIndexChanged);
            // 
            // CmdBox
            // 
            this.CmdBox.Controls.Add(this.testOutput);
            this.CmdBox.Controls.Add(this.wmiCmdList);
            this.CmdBox.Enabled = false;
            this.CmdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CmdBox.Location = new System.Drawing.Point(413, 378);
            this.CmdBox.Name = "CmdBox";
            this.CmdBox.Size = new System.Drawing.Size(403, 228);
            this.CmdBox.TabIndex = 11;
            this.CmdBox.TabStop = false;
            this.CmdBox.Text = "WMI команды";
            // 
            // wmiCmdList
            // 
            this.wmiCmdList.FormattingEnabled = true;
            this.wmiCmdList.ItemHeight = 20;
            this.wmiCmdList.Location = new System.Drawing.Point(7, 26);
            this.wmiCmdList.Name = "wmiCmdList";
            this.wmiCmdList.Size = new System.Drawing.Size(190, 144);
            this.wmiCmdList.TabIndex = 0;
            this.wmiCmdList.SelectedIndexChanged += new System.EventHandler(this.wmiCmdList_SelectedIndexChanged);
            // 
            // testOutput
            // 
            this.testOutput.Location = new System.Drawing.Point(213, 26);
            this.testOutput.Name = "testOutput";
            this.testOutput.Size = new System.Drawing.Size(184, 144);
            this.testOutput.TabIndex = 1;
            this.testOutput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(831, 618);
            this.Controls.Add(this.CmdBox);
            this.Controls.Add(this.wmiBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ikb1.remoteinfo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.wmiBox.ResumeLayout(false);
            this.wmiBox.PerformLayout();
            this.CmdBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label statuslabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox ipBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Button disconnectBtn;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.GroupBox wmiBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox wmiclass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox propsBox;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.GroupBox CmdBox;
        private System.Windows.Forms.ListBox wmiCmdList;
        private System.Windows.Forms.RichTextBox testOutput;
    }
}

