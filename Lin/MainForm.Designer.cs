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
            this._rescanPortNames = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._portNames = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this._monitor = new System.Windows.Forms.TabPage();
            this._trace = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this._speed = new System.Windows.Forms.NumericUpDown();
            this._connect = new System.Windows.Forms.Button();
            this._disconnect = new System.Windows.Forms.Button();
            this._monitorText = new System.Windows.Forms.TextBox();
            this._traceText = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this._version1x = new System.Windows.Forms.RadioButton();
            this._version2x = new System.Windows.Forms.RadioButton();
            this._clearmonitor = new System.Windows.Forms.Button();
            this._cleartrace = new System.Windows.Forms.Button();
            this._isTrace = new System.Windows.Forms.CheckBox();
            this._groupByFunc = new System.Windows.Forms.CheckBox();
            this._isFiltered = new System.Windows.Forms.CheckBox();
            this._filter = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this._monitor.SuspendLayout();
            this._trace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._speed)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(746, 484);
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
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port settings";
            // 
            // _rescanPortNames
            // 
            this._rescanPortNames.Location = new System.Drawing.Point(200, 17);
            this._rescanPortNames.Name = "_rescanPortNames";
            this._rescanPortNames.Size = new System.Drawing.Size(78, 23);
            this._rescanPortNames.TabIndex = 2;
            this._rescanPortNames.Text = "Rescan";
            this._rescanPortNames.UseVisualStyleBackColor = true;
            this._rescanPortNames.Click += new System.EventHandler(this._rescanPortNames_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port name:";
            // 
            // _portNames
            // 
            this._portNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._portNames.FormattingEnabled = true;
            this._portNames.Location = new System.Drawing.Point(73, 19);
            this._portNames.Name = "_portNames";
            this._portNames.Size = new System.Drawing.Size(121, 21);
            this._portNames.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this._monitor);
            this.tabControl1.Controls.Add(this._trace);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 113);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(740, 368);
            this.tabControl1.TabIndex = 1;
            // 
            // _monitor
            // 
            this._monitor.Controls.Add(this._monitorText);
            this._monitor.Location = new System.Drawing.Point(4, 22);
            this._monitor.Name = "_monitor";
            this._monitor.Padding = new System.Windows.Forms.Padding(3);
            this._monitor.Size = new System.Drawing.Size(732, 342);
            this._monitor.TabIndex = 0;
            this._monitor.Text = "Monitor";
            this._monitor.UseVisualStyleBackColor = true;
            // 
            // _trace
            // 
            this._trace.Controls.Add(this._traceText);
            this._trace.Location = new System.Drawing.Point(4, 22);
            this._trace.Name = "_trace";
            this._trace.Padding = new System.Windows.Forms.Padding(3);
            this._trace.Size = new System.Drawing.Size(732, 369);
            this._trace.TabIndex = 1;
            this._trace.Text = "Trace";
            this._trace.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Speed:";
            // 
            // _speed
            // 
            this._speed.Location = new System.Drawing.Point(331, 20);
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
            this._speed.Size = new System.Drawing.Size(120, 20);
            this._speed.TabIndex = 4;
            this._speed.Value = new decimal(new int[] {
            9600,
            0,
            0,
            0});
            // 
            // _connect
            // 
            this._connect.Location = new System.Drawing.Point(457, 17);
            this._connect.Name = "_connect";
            this._connect.Size = new System.Drawing.Size(75, 23);
            this._connect.TabIndex = 5;
            this._connect.Text = "Connect";
            this._connect.UseVisualStyleBackColor = true;
            this._connect.Click += new System.EventHandler(this._connect_Click);
            // 
            // _disconnect
            // 
            this._disconnect.Location = new System.Drawing.Point(538, 17);
            this._disconnect.Name = "_disconnect";
            this._disconnect.Size = new System.Drawing.Size(75, 23);
            this._disconnect.TabIndex = 6;
            this._disconnect.Text = "Disconnect";
            this._disconnect.UseVisualStyleBackColor = true;
            this._disconnect.Click += new System.EventHandler(this._disconnect_Click);
            // 
            // _monitorText
            // 
            this._monitorText.Dock = System.Windows.Forms.DockStyle.Fill;
            this._monitorText.Location = new System.Drawing.Point(3, 3);
            this._monitorText.MaxLength = 500000;
            this._monitorText.Multiline = true;
            this._monitorText.Name = "_monitorText";
            this._monitorText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._monitorText.Size = new System.Drawing.Size(726, 336);
            this._monitorText.TabIndex = 0;
            // 
            // _traceText
            // 
            this._traceText.Dock = System.Windows.Forms.DockStyle.Fill;
            this._traceText.Location = new System.Drawing.Point(3, 3);
            this._traceText.MaxLength = 500000;
            this._traceText.Multiline = true;
            this._traceText.Name = "_traceText";
            this._traceText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._traceText.Size = new System.Drawing.Size(726, 363);
            this._traceText.TabIndex = 1;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // _version1x
            // 
            this._version1x.AutoSize = true;
            this._version1x.Location = new System.Drawing.Point(12, 49);
            this._version1x.Name = "_version1x";
            this._version1x.Size = new System.Drawing.Size(65, 17);
            this._version1x.TabIndex = 7;
            this._version1x.Text = "LIN v1.x";
            this._version1x.UseVisualStyleBackColor = true;
            // 
            // _version2x
            // 
            this._version2x.AutoSize = true;
            this._version2x.Checked = true;
            this._version2x.Location = new System.Drawing.Point(83, 49);
            this._version2x.Name = "_version2x";
            this._version2x.Size = new System.Drawing.Size(65, 17);
            this._version2x.TabIndex = 8;
            this._version2x.TabStop = true;
            this._version2x.Text = "LIN v2.x";
            this._version2x.UseVisualStyleBackColor = true;
            // 
            // _clearmonitor
            // 
            this._clearmonitor.Location = new System.Drawing.Point(154, 46);
            this._clearmonitor.Name = "_clearmonitor";
            this._clearmonitor.Size = new System.Drawing.Size(124, 23);
            this._clearmonitor.TabIndex = 9;
            this._clearmonitor.Text = "Clear Monitor";
            this._clearmonitor.UseVisualStyleBackColor = true;
            this._clearmonitor.Click += new System.EventHandler(this._clearmonitor_Click);
            // 
            // _cleartrace
            // 
            this._cleartrace.Location = new System.Drawing.Point(284, 46);
            this._cleartrace.Name = "_cleartrace";
            this._cleartrace.Size = new System.Drawing.Size(124, 23);
            this._cleartrace.TabIndex = 10;
            this._cleartrace.Text = "Clear Trace";
            this._cleartrace.UseVisualStyleBackColor = true;
            this._cleartrace.Click += new System.EventHandler(this._cleartrace_Click);
            // 
            // _isTrace
            // 
            this._isTrace.AutoSize = true;
            this._isTrace.Location = new System.Drawing.Point(414, 50);
            this._isTrace.Name = "_isTrace";
            this._isTrace.Size = new System.Drawing.Size(54, 17);
            this._isTrace.TabIndex = 11;
            this._isTrace.Text = "Trace";
            this._isTrace.UseVisualStyleBackColor = true;
            // 
            // _groupByFunc
            // 
            this._groupByFunc.AutoSize = true;
            this._groupByFunc.Location = new System.Drawing.Point(474, 50);
            this._groupByFunc.Name = "_groupByFunc";
            this._groupByFunc.Size = new System.Drawing.Size(179, 17);
            this._groupByFunc.TabIndex = 12;
            this._groupByFunc.Text = "Group only by Function (Monitor)";
            this._groupByFunc.UseVisualStyleBackColor = true;
            this._groupByFunc.CheckedChanged += new System.EventHandler(this._groupByFunc_CheckedChanged);
            // 
            // _isFiltered
            // 
            this._isFiltered.AutoSize = true;
            this._isFiltered.Location = new System.Drawing.Point(12, 77);
            this._isFiltered.Name = "_isFiltered";
            this._isFiltered.Size = new System.Drawing.Size(90, 17);
            this._isFiltered.TabIndex = 13;
            this._isFiltered.Text = "Filter (AA|DF):";
            this._isFiltered.UseVisualStyleBackColor = true;
            this._isFiltered.CheckedChanged += new System.EventHandler(this._isFiltered_CheckedChanged);
            // 
            // _filter
            // 
            this._filter.Location = new System.Drawing.Point(108, 75);
            this._filter.Name = "_filter";
            this._filter.Size = new System.Drawing.Size(545, 20);
            this._filter.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 484);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Lin (Azarenko S.A.)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this._monitor.ResumeLayout(false);
            this._monitor.PerformLayout();
            this._trace.ResumeLayout(false);
            this._trace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._speed)).EndInit();
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
    }
}

