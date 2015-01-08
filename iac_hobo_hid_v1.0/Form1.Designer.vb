<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TB_600Amps = New System.Windows.Forms.TextBox
        Me.TB_200Amps = New System.Windows.Forms.TextBox
        Me.TB_100Amps = New System.Windows.Forms.TextBox
        Me.TB_50Amps = New System.Windows.Forms.TextBox
        Me.TB_20Amps = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.TMR_Programming = New System.Windows.Forms.Timer(Me.components)
        Me.LBL_Status = New System.Windows.Forms.Label
        Me.CH_Print = New System.Windows.Forms.CheckBox
        Me.BT_Program = New System.Windows.Forms.Button
        Me.BT_Clear = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.check = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.powersystem = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.sensortype = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.phase = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.multiplier = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.serialnumber = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.status = New System.Windows.Forms.DataGridViewImageColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        Me.TX_Power = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.TX_PF = New System.Windows.Forms.TextBox
        Me.TX_Voltage = New System.Windows.Forms.TextBox
        Me.TX_Current = New System.Windows.Forms.TextBox
        Me.CMB_Conversion = New System.Windows.Forms.ComboBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LabelWriterCmb = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TB_Company_Code = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TX_Sampling_Interval = New System.Windows.Forms.TextBox
        Me.TX_Start_Time = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TB_Assesment_Date = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TB_CompanyName = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.TS_Device_Attached = New System.Windows.Forms.ToolStripStatusLabel
        Me.TS_SerialNumber = New System.Windows.Forms.ToolStripStatusLabel
        Me.TS_LB_Printer = New System.Windows.Forms.ToolStripStatusLabel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tabDevices = New System.Windows.Forms.TabControl
        Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.TS_LB_Date = New System.Windows.Forms.ToolStripStatusLabel
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.TS_Progress = New System.Windows.Forms.ToolStripProgressBar
        Me.Logo = New System.Windows.Forms.PictureBox
        Me.txtLog = New System.Windows.Forms.TextBox
        Me.attach_timer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(938, 131)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(105, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 96
        Me.PictureBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(21, 143)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = "600 Amps"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "200 Amps"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TB_600Amps)
        Me.GroupBox2.Controls.Add(Me.TB_200Amps)
        Me.GroupBox2.Controls.Add(Me.TB_100Amps)
        Me.GroupBox2.Controls.Add(Me.TB_50Amps)
        Me.GroupBox2.Controls.Add(Me.TB_20Amps)
        Me.GroupBox2.Location = New System.Drawing.Point(429, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(189, 215)
        Me.GroupBox2.TabIndex = 93
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Number of CTs"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(63, 186)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 72
        Me.Button2.Text = "Calculate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "100 Amps"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "50 Amps"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "20 Amps"
        '
        'TB_600Amps
        '
        Me.TB_600Amps.Location = New System.Drawing.Point(95, 140)
        Me.TB_600Amps.Name = "TB_600Amps"
        Me.TB_600Amps.Size = New System.Drawing.Size(65, 20)
        Me.TB_600Amps.TabIndex = 71
        '
        'TB_200Amps
        '
        Me.TB_200Amps.Location = New System.Drawing.Point(95, 114)
        Me.TB_200Amps.Name = "TB_200Amps"
        Me.TB_200Amps.Size = New System.Drawing.Size(65, 20)
        Me.TB_200Amps.TabIndex = 70
        '
        'TB_100Amps
        '
        Me.TB_100Amps.Location = New System.Drawing.Point(95, 88)
        Me.TB_100Amps.Name = "TB_100Amps"
        Me.TB_100Amps.Size = New System.Drawing.Size(65, 20)
        Me.TB_100Amps.TabIndex = 69
        '
        'TB_50Amps
        '
        Me.TB_50Amps.Location = New System.Drawing.Point(95, 62)
        Me.TB_50Amps.Name = "TB_50Amps"
        Me.TB_50Amps.Size = New System.Drawing.Size(65, 20)
        Me.TB_50Amps.TabIndex = 68
        '
        'TB_20Amps
        '
        Me.TB_20Amps.Location = New System.Drawing.Point(95, 36)
        Me.TB_20Amps.Name = "TB_20Amps"
        Me.TB_20Amps.Size = New System.Drawing.Size(65, 20)
        Me.TB_20Amps.TabIndex = 67
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(329, 148)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 23)
        Me.Button1.TabIndex = 92
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TMR_Programming
        '
        '
        'LBL_Status
        '
        Me.LBL_Status.AutoSize = True
        Me.LBL_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Status.Location = New System.Drawing.Point(35, 578)
        Me.LBL_Status.Name = "LBL_Status"
        Me.LBL_Status.Size = New System.Drawing.Size(76, 20)
        Me.LBL_Status.TabIndex = 91
        Me.LBL_Status.Text = "Status: ..."
        '
        'CH_Print
        '
        Me.CH_Print.AutoSize = True
        Me.CH_Print.Location = New System.Drawing.Point(331, 188)
        Me.CH_Print.Name = "CH_Print"
        Me.CH_Print.Size = New System.Drawing.Size(76, 17)
        Me.CH_Print.TabIndex = 90
        Me.CH_Print.Text = "Print Label"
        Me.CH_Print.UseVisualStyleBackColor = True
        '
        'BT_Program
        '
        Me.BT_Program.Location = New System.Drawing.Point(329, 28)
        Me.BT_Program.Name = "BT_Program"
        Me.BT_Program.Size = New System.Drawing.Size(78, 23)
        Me.BT_Program.TabIndex = 84
        Me.BT_Program.Text = "Start"
        Me.BT_Program.UseVisualStyleBackColor = True
        '
        'BT_Clear
        '
        Me.BT_Clear.Location = New System.Drawing.Point(329, 68)
        Me.BT_Clear.Name = "BT_Clear"
        Me.BT_Clear.Size = New System.Drawing.Size(78, 23)
        Me.BT_Clear.TabIndex = 89
        Me.BT_Clear.Text = "Clear List"
        Me.BT_Clear.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.check, Me.description, Me.powersystem, Me.sensortype, Me.phase, Me.multiplier, Me.serialnumber, Me.status})
        Me.DataGridView1.Location = New System.Drawing.Point(22, 259)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1029, 304)
        Me.DataGridView1.TabIndex = 85
        '
        'check
        '
        Me.check.HeaderText = ""
        Me.check.Name = "check"
        Me.check.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.check.Width = 30
        '
        'description
        '
        Me.description.HeaderText = "Description"
        Me.description.Name = "description"
        Me.description.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.description.Width = 200
        '
        'powersystem
        '
        Me.powersystem.HeaderText = "Power System"
        Me.powersystem.Items.AddRange(New Object() {"1-Phase, 2-Wire 120 V with Neutral", "1-Phase, 2-Wire 230 V with Neutral", "1-Phase, 2-Wire 208 V no Neutral", "1-Phase, 2-Wire 240 V no Neutral", "1-Phase, 3-Wire 120/240 V", "3-Phase, 3-Wire 208 V Delta", "3-Phase, 3-Wire 400 V Delta", "3-Phase, 3-Wire 480 V Delta", "3-Phase, 3-Wire 600 V Delta", "3-Phase, 4-Wire 208Y/120 V", "3-Phase, 4-Wire 400Y/230 V", "3-Phase, 4-Wire 415Y/240 V", "3-Phase, 4-Wire 480Y/277 V", "3-Phase, 4-Wire 600Y/347 V", "3-Phase, 4-Wire Delta 120/208/240 V Wild Phase", "3-Phase, 4-Wire Delta 240/415/480 V Wild Phase"})
        Me.powersystem.Name = "powersystem"
        Me.powersystem.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.powersystem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.powersystem.Width = 350
        '
        'sensortype
        '
        Me.sensortype.HeaderText = "Sensor Type"
        Me.sensortype.Items.AddRange(New Object() {"20 Amps", "50 Amps", "100 Amps", "200 Amps", "600 Amps"})
        Me.sensortype.Name = "sensortype"
        Me.sensortype.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.sensortype.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'phase
        '
        Me.phase.HeaderText = "Phase"
        Me.phase.Items.AddRange(New Object() {"A", "B", "C", "N"})
        Me.phase.Name = "phase"
        '
        'multiplier
        '
        Me.multiplier.HeaderText = "Multiplier"
        Me.multiplier.Name = "multiplier"
        Me.multiplier.Width = 60
        '
        'serialnumber
        '
        Me.serialnumber.HeaderText = "Serial Number"
        Me.serialnumber.Name = "serialnumber"
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.Image = CType(resources.GetObject("status.Image"), System.Drawing.Image)
        Me.status.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.status.Name = "status"
        Me.status.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.status.Width = 40
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.TX_Power)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.TX_PF)
        Me.GroupBox3.Controls.Add(Me.TX_Voltage)
        Me.GroupBox3.Controls.Add(Me.TX_Current)
        Me.GroupBox3.Controls.Add(Me.CMB_Conversion)
        Me.GroupBox3.Location = New System.Drawing.Point(633, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(189, 215)
        Me.GroupBox3.TabIndex = 94
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Wats to Amps Conversion"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(65, 181)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Calculate"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(11, 120)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 13)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Power"
        '
        'TX_Power
        '
        Me.TX_Power.Location = New System.Drawing.Point(98, 117)
        Me.TX_Power.Name = "TX_Power"
        Me.TX_Power.Size = New System.Drawing.Size(71, 20)
        Me.TX_Power.TabIndex = 7
        Me.TX_Power.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 94)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Power Factor"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 66)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Voltage"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 146)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 13)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Current"
        '
        'TX_PF
        '
        Me.TX_PF.Location = New System.Drawing.Point(98, 91)
        Me.TX_PF.Name = "TX_PF"
        Me.TX_PF.Size = New System.Drawing.Size(71, 20)
        Me.TX_PF.TabIndex = 3
        Me.TX_PF.Text = "0.8"
        '
        'TX_Voltage
        '
        Me.TX_Voltage.Location = New System.Drawing.Point(98, 63)
        Me.TX_Voltage.Name = "TX_Voltage"
        Me.TX_Voltage.Size = New System.Drawing.Size(71, 20)
        Me.TX_Voltage.TabIndex = 2
        Me.TX_Voltage.Text = "0"
        '
        'TX_Current
        '
        Me.TX_Current.Location = New System.Drawing.Point(98, 143)
        Me.TX_Current.MaxLength = 8
        Me.TX_Current.Name = "TX_Current"
        Me.TX_Current.ReadOnly = True
        Me.TX_Current.Size = New System.Drawing.Size(71, 20)
        Me.TX_Current.TabIndex = 1
        Me.TX_Current.Text = "0"
        '
        'CMB_Conversion
        '
        Me.CMB_Conversion.FormattingEnabled = True
        Me.CMB_Conversion.Items.AddRange(New Object() {"DC", "AC - Single Phase", "AC - Three Phase"})
        Me.CMB_Conversion.Location = New System.Drawing.Point(14, 31)
        Me.CMB_Conversion.Name = "CMB_Conversion"
        Me.CMB_Conversion.Size = New System.Drawing.Size(155, 21)
        Me.CMB_Conversion.TabIndex = 0
        Me.CMB_Conversion.Text = "AC - Three Phase"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(329, 108)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(78, 23)
        Me.Button4.TabIndex = 95
        Me.Button4.Text = "Delete Item"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelWriterCmb)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TB_Company_Code)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TX_Sampling_Interval)
        Me.GroupBox1.Controls.Add(Me.TX_Start_Time)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TB_Assesment_Date)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TB_CompanyName)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 215)
        Me.GroupBox1.TabIndex = 88
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Assessment Info"
        '
        'LabelWriterCmb
        '
        Me.LabelWriterCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LabelWriterCmb.Location = New System.Drawing.Point(9, 182)
        Me.LabelWriterCmb.Name = "LabelWriterCmb"
        Me.LabelWriterCmb.Size = New System.Drawing.Size(282, 21)
        Me.LabelWriterCmb.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(6, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 16)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Select a LabelWriter here:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(229, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Code"
        '
        'TB_Company_Code
        '
        Me.TB_Company_Code.Location = New System.Drawing.Point(232, 46)
        Me.TB_Company_Code.MaxLength = 30
        Me.TB_Company_Code.Name = "TB_Company_Code"
        Me.TB_Company_Code.Size = New System.Drawing.Size(54, 20)
        Me.TB_Company_Code.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(229, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Seconds"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(158, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Sampling Interval"
        '
        'TX_Sampling_Interval
        '
        Me.TX_Sampling_Interval.Location = New System.Drawing.Point(161, 87)
        Me.TX_Sampling_Interval.MaxLength = 30
        Me.TX_Sampling_Interval.Name = "TX_Sampling_Interval"
        Me.TX_Sampling_Interval.Size = New System.Drawing.Size(62, 20)
        Me.TX_Sampling_Interval.TabIndex = 14
        Me.TX_Sampling_Interval.Text = "15"
        '
        'TX_Start_Time
        '
        Me.TX_Start_Time.Location = New System.Drawing.Point(207, 129)
        Me.TX_Start_Time.MaxLength = 30
        Me.TX_Start_Time.Name = "TX_Start_Time"
        Me.TX_Start_Time.Size = New System.Drawing.Size(84, 20)
        Me.TX_Start_Time.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Start Logging at:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Assesment Date"
        '
        'TB_Assesment_Date
        '
        Me.TB_Assesment_Date.Location = New System.Drawing.Point(9, 87)
        Me.TB_Assesment_Date.MaxLength = 30
        Me.TB_Assesment_Date.Name = "TB_Assesment_Date"
        Me.TB_Assesment_Date.Size = New System.Drawing.Size(99, 20)
        Me.TB_Assesment_Date.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 30)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Company Name"
        '
        'TB_CompanyName
        '
        Me.TB_CompanyName.Location = New System.Drawing.Point(12, 46)
        Me.TB_CompanyName.MaxLength = 30
        Me.TB_CompanyName.Name = "TB_CompanyName"
        Me.TB_CompanyName.Size = New System.Drawing.Size(214, 20)
        Me.TB_CompanyName.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(9, 130)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(196, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'TS_Device_Attached
        '
        Me.TS_Device_Attached.Name = "TS_Device_Attached"
        Me.TS_Device_Attached.Size = New System.Drawing.Size(120, 15)
        Me.TS_Device_Attached.Text = "Device Attached : NO"
        '
        'TS_SerialNumber
        '
        Me.TS_SerialNumber.Name = "TS_SerialNumber"
        Me.TS_SerialNumber.Size = New System.Drawing.Size(134, 15)
        Me.TS_SerialNumber.Text = "Serial Number:XXXXXXX"
        '
        'TS_LB_Printer
        '
        Me.TS_LB_Printer.Name = "TS_LB_Printer"
        Me.TS_LB_Printer.Size = New System.Drawing.Size(42, 15)
        Me.TS_LB_Printer.Text = "Printer"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'tabDevices
        '
        Me.tabDevices.ItemSize = New System.Drawing.Size(350, 18)
        Me.tabDevices.Location = New System.Drawing.Point(1123, 3)
        Me.tabDevices.Name = "tabDevices"
        Me.tabDevices.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabDevices.SelectedIndex = 0
        Me.tabDevices.Size = New System.Drawing.Size(88, 83)
        Me.tabDevices.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabDevices.TabIndex = 82
        '
        'openFileDialog1
        '
        Me.openFileDialog1.DefaultExt = "lwl"
        Me.openFileDialog1.Filter = "DYMO Label File (*.label)|*.label"
        Me.openFileDialog1.Title = "Open DYMO Label File"
        '
        'TS_LB_Date
        '
        Me.TS_LB_Date.Name = "TS_LB_Date"
        Me.TS_LB_Date.Size = New System.Drawing.Size(121, 15)
        Me.TS_LB_Date.Text = "ToolStripStatusLabel1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_LB_Date, Me.TS_LB_Printer, Me.TS_SerialNumber, Me.TS_Device_Attached, Me.TS_Progress})
        Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 618)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1075, 21)
        Me.StatusStrip1.TabIndex = 86
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TS_Progress
        '
        Me.TS_Progress.Name = "TS_Progress"
        Me.TS_Progress.Size = New System.Drawing.Size(100, 15)
        '
        'Logo
        '
        Me.Logo.Image = CType(resources.GetObject("Logo.Image"), System.Drawing.Image)
        Me.Logo.Location = New System.Drawing.Point(938, 27)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(105, 96)
        Me.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Logo.TabIndex = 87
        Me.Logo.TabStop = False
        '
        'txtLog
        '
        Me.txtLog.Location = New System.Drawing.Point(1123, 108)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLog.Size = New System.Drawing.Size(88, 83)
        Me.txtLog.TabIndex = 83
        '
        'attach_timer
        '
        Me.attach_timer.Enabled = True
        Me.attach_timer.Interval = 500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 639)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LBL_Status)
        Me.Controls.Add(Me.CH_Print)
        Me.Controls.Add(Me.BT_Program)
        Me.Controls.Add(Me.BT_Clear)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tabDevices)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.txtLog)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TB_600Amps As System.Windows.Forms.TextBox
    Friend WithEvents TB_200Amps As System.Windows.Forms.TextBox
    Friend WithEvents TB_100Amps As System.Windows.Forms.TextBox
    Friend WithEvents TB_50Amps As System.Windows.Forms.TextBox
    Friend WithEvents TB_20Amps As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TMR_Programming As System.Windows.Forms.Timer
    Friend WithEvents LBL_Status As System.Windows.Forms.Label
    Friend WithEvents CH_Print As System.Windows.Forms.CheckBox
    Friend WithEvents BT_Program As System.Windows.Forms.Button
    Friend WithEvents BT_Clear As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents check As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents powersystem As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents sensortype As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents phase As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents multiplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents serialnumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TX_Power As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TX_PF As System.Windows.Forms.TextBox
    Friend WithEvents TX_Voltage As System.Windows.Forms.TextBox
    Friend WithEvents TX_Current As System.Windows.Forms.TextBox
    Friend WithEvents CMB_Conversion As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelWriterCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TB_Company_Code As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TX_Sampling_Interval As System.Windows.Forms.TextBox
    Friend WithEvents TX_Start_Time As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TB_Assesment_Date As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TB_CompanyName As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TS_Device_Attached As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TS_SerialNumber As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TS_LB_Printer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents tabDevices As System.Windows.Forms.TabControl
    Friend WithEvents openFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TS_LB_Date As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TS_Progress As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents Logo As System.Windows.Forms.PictureBox
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents attach_timer As System.Windows.Forms.Timer

End Class
