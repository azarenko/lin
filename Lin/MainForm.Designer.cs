namespace Lin
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._filter = new System.Windows.Forms.TextBox();
            this._isFiltered = new System.Windows.Forms.CheckBox();
            this._groupByFunc = new System.Windows.Forms.CheckBox();
            this._isTrace = new System.Windows.Forms.CheckBox();
            this._cleartrace = new System.Windows.Forms.Button();
            this._clearmonitor = new System.Windows.Forms.Button();
            this._version2x = new System.Windows.Forms.RadioButton();
            this._version1x = new System.Windows.Forms.RadioButton();
            this._disconnect = new System.Windows.Forms.Button();
            this._connect = new System.Windows.Forms.Button();
            this._speed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this._rescanPortNames = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._portNames = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this._monitor = new System.Windows.Forms.TabPage();
            this._monitorText = new System.Windows.Forms.TextBox();
            this._trace = new System.Windows.Forms.TabPage();
            this._traceText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._send = new System.Windows.Forms.Button();
            this._transmmit = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._speed)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this._monitor.SuspendLayout();
            this._trace.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(995, 596);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._filter);
            this.groupBox1.Controls.Add(this._isFiltered);
            this.groupBox1.Controls.Add(this._groupByFunc);
            this.groupBox1.Controls.Add(this._isTrace);
            this.groupBox1.Controls.Add(this._cleartrace);
            this.groupBox1.Controls.Add(this._clearmonitor);
            this.groupBox1.Controls.Add(this._version2x);
            this.groupBox1.Controls.Add(this._version1x);
            this.groupBox1.Controls.Add(this._disconnect);
            this.groupBox1.Controls.Add(this._connect);
            this.groupBox1.Controls.Add(this._speed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._rescanPortNames);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this._portNames);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(987, 127);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port settings";
            // 
            // _filter
            // 
            this._filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._filter.Location = new System.Drawing.Point(144, 92);
            this._filter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._filter.Name = "_filter";
            this._filter.Size = new System.Drawing.Size(830, 22);
            this._filter.TabIndex = 14;
            // 
            // _isFiltered
            // 
            this._isFiltered.AutoSize = true;
            this._isFiltered.Location = new System.Drawing.Point(16, 95);
            this._isFiltered.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._isFiltered.Name = "_isFiltered";
            this._isFiltered.Size = new System.Drawing.Size(111, 20);
            this._isFiltered.TabIndex = 13;
            this._isFiltered.Text = "Filter (AA|DF):";
            this._isFiltered.UseVisualStyleBackColor = true;
            this._isFiltered.CheckedChanged += new System.EventHandler(this._isFiltered_CheckedChanged);
            // 
            // _groupByFunc
            // 
            this._groupByFunc.AutoSize = true;
            this._groupByFunc.Location = new System.Drawing.Point(632, 62);
            this._groupByFunc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._groupByFunc.Name = "_groupByFunc";
            this._groupByFunc.Size = new System.Drawing.Size(220, 20);
            this._groupByFunc.TabIndex = 12;
            this._groupByFunc.Text = "Group only by Function (Monitor)";
            this._groupByFunc.UseVisualStyleBackColor = true;
            this._groupByFunc.CheckedChanged += new System.EventHandler(this._groupByFunc_CheckedChanged);
            // 
            // _isTrace
            // 
            this._isTrace.AutoSize = true;
            this._isTrace.Location = new System.Drawing.Point(552, 62);
            this._isTrace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._isTrace.Name = "_isTrace";
            this._isTrace.Size = new System.Drawing.Size(65, 20);
            this._isTrace.TabIndex = 11;
            this._isTrace.Text = "Trace";
            this._isTrace.UseVisualStyleBackColor = true;
            // 
            // _cleartrace
            // 
            this._cleartrace.Location = new System.Drawing.Point(379, 57);
            this._cleartrace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._cleartrace.Name = "_cleartrace";
            this._cleartrace.Size = new System.Drawing.Size(165, 28);
            this._cleartrace.TabIndex = 10;
            this._cleartrace.Text = "Clear Trace";
            this._cleartrace.UseVisualStyleBackColor = true;
            this._cleartrace.Click += new System.EventHandler(this._cleartrace_Click);
            // 
            // _clearmonitor
            // 
            this._clearmonitor.Location = new System.Drawing.Point(205, 57);
            this._clearmonitor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._clearmonitor.Name = "_clearmonitor";
            this._clearmonitor.Size = new System.Drawing.Size(165, 28);
            this._clearmonitor.TabIndex = 9;
            this._clearmonitor.Text = "Clear Monitor";
            this._clearmonitor.UseVisualStyleBackColor = true;
            this._clearmonitor.Click += new System.EventHandler(this._clearmonitor_Click);
            // 
            // _version2x
            // 
            this._version2x.AutoSize = true;
            this._version2x.Checked = true;
            this._version2x.Location = new System.Drawing.Point(111, 60);
            this._version2x.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._version2x.Name = "_version2x";
            this._version2x.Size = new System.Drawing.Size(74, 20);
            this._version2x.TabIndex = 8;
            this._version2x.TabStop = true;
            this._version2x.Text = "LIN v2.x";
            this._version2x.UseVisualStyleBackColor = true;
            // 
            // _version1x
            // 
            this._version1x.AutoSize = true;
            this._version1x.Location = new System.Drawing.Point(16, 60);
            this._version1x.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._version1x.Name = "_version1x";
            this._version1x.Size = new System.Drawing.Size(74, 20);
            this._version1x.TabIndex = 7;
            this._version1x.Text = "LIN v1.x";
            this._version1x.UseVisualStyleBackColor = true;
            // 
            // _disconnect
            // 
            this._disconnect.Location = new System.Drawing.Point(717, 21);
            this._disconnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._disconnect.Name = "_disconnect";
            this._disconnect.Size = new System.Drawing.Size(100, 28);
            this._disconnect.TabIndex = 6;
            this._disconnect.Text = "Disconnect";
            this._disconnect.UseVisualStyleBackColor = true;
            this._disconnect.Click += new System.EventHandler(this._disconnect_Click);
            // 
            // _connect
            // 
            this._connect.Location = new System.Drawing.Point(609, 21);
            this._connect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._connect.Name = "_connect";
            this._connect.Size = new System.Drawing.Size(100, 28);
            this._connect.TabIndex = 5;
            this._connect.Text = "Connect";
            this._connect.UseVisualStyleBackColor = true;
            this._connect.Click += new System.EventHandler(this._connect_Click);
            // 
            // _speed
            // 
            this._speed.Location = new System.Drawing.Point(441, 25);
            this._speed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._speed.Maximum = new decimal(new int[] {
            192000,
            0,
            0,
            0});
            this._speed.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this._speed.Name = "_speed";
            this._speed.Size = new System.Drawing.Size(160, 22);
            this._speed.TabIndex = 4;
            this._speed.Value = new decimal(new int[] {
            9600,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Speed:";
            // 
            // _rescanPortNames
            // 
            this._rescanPortNames.Location = new System.Drawing.Point(267, 21);
            this._rescanPortNames.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._rescanPortNames.Name = "_rescanPortNames";
            this._rescanPortNames.Size = new System.Drawing.Size(104, 28);
            this._rescanPortNames.TabIndex = 2;
            this._rescanPortNames.Text = "Rescan";
            this._rescanPortNames.UseVisualStyleBackColor = true;
            this._rescanPortNames.Click += new System.EventHandler(this._rescanPortNames_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port name:";
            // 
            // _portNames
            // 
            this._portNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._portNames.FormattingEnabled = true;
            this._portNames.Location = new System.Drawing.Point(97, 23);
            this._portNames.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._portNames.Name = "_portNames";
            this._portNames.Size = new System.Drawing.Size(160, 24);
            this._portNames.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 139);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(987, 453);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this._monitor);
            this.tabControl1.Controls.Add(this._trace);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(979, 267);
            this.tabControl1.TabIndex = 1;
            // 
            // _monitor
            // 
            this._monitor.Controls.Add(this._monitorText);
            this._monitor.Location = new System.Drawing.Point(4, 25);
            this._monitor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._monitor.Name = "_monitor";
            this._monitor.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._monitor.Size = new System.Drawing.Size(971, 238);
            this._monitor.TabIndex = 0;
            this._monitor.Text = "Monitor";
            this._monitor.UseVisualStyleBackColor = true;
            // 
            // _monitorText
            // 
            this._monitorText.Dock = System.Windows.Forms.DockStyle.Fill;
            this._monitorText.Location = new System.Drawing.Point(4, 4);
            this._monitorText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._monitorText.MaxLength = 500000;
            this._monitorText.Multiline = true;
            this._monitorText.Name = "_monitorText";
            this._monitorText.ReadOnly = true;
            this._monitorText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._monitorText.Size = new System.Drawing.Size(963, 230);
            this._monitorText.TabIndex = 0;
            // 
            // _trace
            // 
            this._trace.Controls.Add(this._traceText);
            this._trace.Location = new System.Drawing.Point(4, 25);
            this._trace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._trace.Name = "_trace";
            this._trace.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._trace.Size = new System.Drawing.Size(971, 238);
            this._trace.TabIndex = 1;
            this._trace.Text = "Trace";
            this._trace.UseVisualStyleBackColor = true;
            // 
            // _traceText
            // 
            this._traceText.Dock = System.Windows.Forms.DockStyle.Fill;
            this._traceText.Location = new System.Drawing.Point(4, 4);
            this._traceText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._traceText.MaxLength = 500000;
            this._traceText.Multiline = true;
            this._traceText.Name = "_traceText";
            this._traceText.ReadOnly = true;
            this._traceText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._traceText.Size = new System.Drawing.Size(963, 230);
            this._traceText.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._send);
            this.groupBox2.Controls.Add(this._transmmit);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(4, 279);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(979, 170);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transmmit";
            // 
            // _send
            // 
            this._send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._send.Location = new System.Drawing.Point(799, 23);
            this._send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._send.Name = "_send";
            this._send.Size = new System.Drawing.Size(171, 28);
            this._send.TabIndex = 1;
            this._send.Text = "Send";
            this._send.UseVisualStyleBackColor = true;
            this._send.Click += new System.EventHandler(this._send_Click);
            // 
            // _transmmit
            // 
            this._transmmit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._transmmit.Location = new System.Drawing.Point(8, 23);
            this._transmmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._transmmit.Multiline = true;
            this._transmmit.Name = "_transmmit";
            this._transmmit.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._transmmit.Size = new System.Drawing.Size(781, 138);
            this._transmmit.TabIndex = 0;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 596);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Lin viewer (created by Azarenko S.A.)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._speed)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this._monitor.ResumeLayout(false);
            this._monitor.PerformLayout();
            this._trace.ResumeLayout(false);
            this._trace.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _portNames;
        private System.Windows.Forms.Button _rescanPortNames;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage _monitor;
        private System.Windows.Forms.TabPage _trace;
        private System.Windows.Forms.NumericUpDown _speed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _connect;
        private System.Windows.Forms.Button _disconnect;
        private System.Windows.Forms.TextBox _monitorText;
        private System.Windows.Forms.TextBox _traceText;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton _version2x;
        private System.Windows.Forms.RadioButton _version1x;
        private System.Windows.Forms.Button _cleartrace;
        private System.Windows.Forms.Button _clearmonitor;
        private System.Windows.Forms.CheckBox _isTrace;
        private System.Windows.Forms.CheckBox _groupByFunc;
        private System.Windows.Forms.TextBox _filter;
        private System.Windows.Forms.CheckBox _isFiltered;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox _transmmit;
        private System.Windows.Forms.Button _send;
    }
}

