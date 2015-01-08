
Option Explicit On
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.Math
Public Class Form1
    <DllImport("hidapi.dll", EntryPoint:="hid_enumerate", CallingConvention:=CallingConvention.Cdecl)> Private Shared Function hid_enumerate(ByVal a As UShort, ByVal b As UShort) As Integer
    End Function
    <DllImport("hidapi.dll", EntryPoint:="hid_open", CallingConvention:=CallingConvention.Cdecl)> Private Shared Function hid_open(ByVal a As UShort, ByVal b As UShort, ByVal serial As Integer) As Integer
    End Function
    <DllImport("hidapi.dll", EntryPoint:="hid_get_manufacturer_string", CallingConvention:=CallingConvention.Cdecl)> Private Shared Function hid_get_manufacturer_string(ByVal handle As Integer, ByVal wstr() As Int16, ByVal MAX_STR As Integer) As Integer
    End Function
    <DllImport("hidapi.dll", EntryPoint:="hid_get_product_string", CallingConvention:=CallingConvention.Cdecl)> Private Shared Function hid_get_product_string(ByVal handle As Integer, ByVal wstr() As Int16, ByVal MAX_STR As Integer) As Integer
    End Function
    <DllImport("hidapi.dll", EntryPoint:="hid_get_serial_number_string", CallingConvention:=CallingConvention.Cdecl)> Private Shared Function hid_get_serial_number_string(ByVal handle As Integer, ByVal wstr() As Int16, ByVal MAX_STR As Integer) As Integer
    End Function
    <DllImport("hidapi.dll", EntryPoint:="hid_get_indexed_string", CallingConvention:=CallingConvention.Cdecl)> Private Shared Function hid_get_indexed_string(ByVal handle As Integer, ByVal index As Integer, ByVal wstr() As Int16, ByVal MAX_STR As Integer) As Integer
    End Function
    <DllImport("hidapi.dll", EntryPoint:="hid_set_nonblocking", CallingConvention:=CallingConvention.Cdecl)> Private Shared Function hid_set_nonblocking(ByVal handle As Integer, ByVal nonblock As Integer) As Integer
    End Function
    <DllImport("hidapi.dll", EntryPoint:="hid_send_feature_report", CallingConvention:=CallingConvention.Cdecl)> Private Shared Function hid_send_feature_report(ByVal handle As Integer, ByVal data() As Byte, ByVal length As Integer) As Integer
    End Function
    <DllImport("hidapi.dll", EntryPoint:="hid_get_feature_report", CallingConvention:=CallingConvention.Cdecl)> Private Shared Function hid_get_feature_report(ByVal handle As Integer, ByVal data() As Byte, ByVal length As Integer) As Integer
    End Function
    <DllImport("hidapi.dll", EntryPoint:="hid_read", CallingConvention:=CallingConvention.Cdecl)> Private Shared Function hid_read(ByVal handle As Integer, ByVal data() As Byte, ByVal length As Integer) As Integer
    End Function
    <DllImport("hidapi.dll", EntryPoint:="hid_write", CallingConvention:=CallingConvention.Cdecl)> Private Shared Function hid_write(ByVal handle As Integer, ByVal data() As Byte, ByVal length As Integer) As Integer
    End Function
    <DllImport("hidapi.dll", EntryPoint:="hid_close", CallingConvention:=CallingConvention.Cdecl)> Private Shared Function hid_close(ByVal handle As Integer) As Integer
    End Function

    Dim deviceIsAttached As Integer = 0
    Dim deviceIsReady As Integer = 0
    Dim programmedLoggerCounter As Integer = 0
    Dim isProgramming As Boolean
    Dim currentSerialNumber As String
    Dim hid_handle As Integer
    Dim template(141) As String
    Dim counter As Integer
    Dim Label As DYMO.Label.Framework.ILabel
    Dim DYMO_TEMPLATE_LABEL As String = "template.label"
    Dim num_of_loggers As Integer
    Dim logger_programmed As Boolean

    Private Sub attach_timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles attach_timer.Tick
        Dim dev_ptr As Integer
        Dim MyArrayOfBytes(0 To 255) As Int16
        Dim res As Int16

        dev_ptr = hid_enumerate(&HF1B, &H119)
        If (dev_ptr = 0) Then
            TS_Device_Attached.Text = "Device Attached : NO"
            TS_SerialNumber.Text = "Serial Number : XXXXXXX"
            deviceIsAttached = 0
            deviceIsReady = 0
        Else
            If (deviceIsAttached = 0) Then
                hid_handle = hid_open(&HF1B, &H119, &H0)
                If (hid_handle <> 0) Then
                    res = hid_get_serial_number_string(hid_handle, MyArrayOfBytes, 255)
                    hid_close(hid_handle)

                    currentSerialNumber = Val(wchar_to_string(MyArrayOfBytes)).ToString
                    TS_SerialNumber.Text = "Serial Number : " + currentSerialNumber
                    TS_Device_Attached.Text = "Device Attached : YES"
                    deviceIsAttached = 1
                    deviceIsReady = 1
                    logger_programmed = False
                End If
            End If
        End If
    End Sub

    Private Function wchar_to_string(ByVal charArray() As Int16) As String
        Dim x As Char
        Dim i As Integer
        Dim arr(255) As Char

        For i = 0 To 255
            If (charArray(i) > 0) Then
                arr(i) = ChrW(charArray(i))
            End If
        Next
        Dim value As String = New String(arr)
        Return value
    End Function

    Private Function Read_Template_File(ByVal file As String) As Integer
        Dim line As String
        Dim n As Integer
        Dim FileReader As StreamReader
        FileReader = New StreamReader(file)

        n = 0
        While (Not FileReader.EndOfStream)
            line = FileReader.ReadLine()
            If line.Substring(0, 3).Equals("URB", StringComparison.Ordinal) Then
                template(n) = Get_Data_From_Line(line.Substring(9, 23))
                Console.Write(line)
                n = n + 1
            End If
        End While
        FileReader.Close()
    End Function

    Private Function Modify_Template(ByVal description As String, ByVal timeToStartString As String, ByVal samplingInterval_txt As String, ByVal sensorType As String) As Integer
        'Description Modification
        'Dim description As String = TXTBDescription.Text
        Modify_Description(description)
        'current time (UTC) in second since 1/1/2000 modification
        Dim refDate As New System.DateTime(2000, 1, 1, 0, 0, 0)
        Dim currentTime2000 As String = DateDiff("s", refDate, DateTime.UtcNow).ToString("X8")
        Modify_Current_Relative_Time_2000(currentTime2000)
        'Modify current time (e.g. 7/22/2013 12:09:35 PM)
        Modify_Current_Time(Now) '.AddHours(+1))
        'Modify Time to start
        Dim timeToStart As String = (DateDiff("s", Now, DateTime.Parse(timeToStartString)) + 1).ToString("X6") ' I've added the 1 second to make it exactly the same as HOBO
        Modify_Time_to_Start(timeToStart)
        'Modify Serial Number
        'Dim SerialNumber As String = "393731373330"
        'Modify_Serial_Number(SerialNumber)
        'Modify Sampling Interval
        Dim samplingInterval As String
        'samplingInterval = Convert.ToInt16(TXTBLoggingInterval.Text, 10).ToString("X4")
        samplingInterval = Convert.ToInt16(samplingInterval_txt, 10).ToString("X4")
        Modify_Sampling_Interval(samplingInterval)
        'Modify Logger Type
        Mofify_Logger_Type(sensorType)
        'Modify startNow variable
        'startNow = 
    End Function

    Private Function Modify_Description(ByVal description As String)
        Dim i As Integer
        If description.Length > 40 Then
            description = description.Substring(0, 40)
        Else
            For i = (description.Length + 1) To 40
                description = description + "_"
            Next
        End If
        'template((125-1)/2).
        template(62) = template(62).Substring(0, 10) + Asc(description(0)).ToString("X2") + Asc(description(1)).ToString("X2") + Asc(description(2)).ToString("X2")
        For i = 1 To 9
            template(63 + i) = template(63 + i).Substring(0, 8) + Asc(description((i - 1) * 4 + 3)).ToString("X2") + Asc(description((i - 1) * 4 + 4)).ToString("X2") + Asc(description((i - 1) * 4 + 5)).ToString("X2") + Asc(description((i - 1) * 4 + 6)).ToString("X2")
        Next
        template(73) = template(73).Substring(0, 8) + Asc(description(39)).ToString("X2") + template(73).Substring(10, 6)
    End Function

    Private Function Modify_Serial_Number(ByVal serialNumber As String)
        Dim length As String = Convert.ToByte(serialNumber.Length / 2).ToString("X2")
        Dim number As String = serialNumber + "00000000000000"
        number = number.Substring(0, 14)
        template(55) = template(55).Substring(0, 10) + length + number.Substring(0, 4)
        template(56) = template(56).Substring(0, 8) + number.Substring(4, 8)
        'template(57) = template(57).Substring(0, 8) + number.Substring(12, 2) + template(57).Substring(10, 6)
    End Function

    Private Function Modify_Sampling_Interval(ByVal interval As String)
        template(11) = template(11).Substring(0, 6) + interval + template(11).Substring(10, 6)
        template(84) = template(84).Substring(0, 8) + interval + template(84).Substring(12, 4)
    End Function

    Private Function Mofify_Logger_Type(ByVal sensor As String)
        sensor = "8" + sensor
        template(10) = template(10).Substring(0, 2) + sensor + template(10).Substring(4, 12)
        template(30) = template(30).Substring(0, 10) + sensor + template(30).Substring(12, 4)
        template(105) = template(105).Substring(0, 12) + sensor + template(105).Substring(14, 2)
    End Function

    Private Function Modify_Current_Relative_Time_2000(ByVal numOfSeconds As String)
        template(19) = template(19).Substring(0, 12) + numOfSeconds.Substring(0, 4)
        template(20) = template(20).Substring(0, 8) + numOfSeconds.Substring(4, 4) + template(20).Substring(12, 4)
    End Function
    ' numOfSeconds should be 6 hexadecimal digits
    Private Function Modify_Time_to_Start(ByVal numOfSeconds As String) As Integer
        template(20) = template(20).Substring(0, 12) + numOfSeconds.Substring(0, 4)
        template(21) = template(21).Substring(0, 8) + numOfSeconds.Substring(4, 2) + template(21).Substring(10, 6)
        template(11) = template(11).Substring(0, 10) + numOfSeconds
        template(60) = template(60).Substring(0, 14) + numOfSeconds.Substring(0, 2)
        template(61) = template(61).Substring(0, 8) + numOfSeconds.Substring(2, 4) + template(61).Substring(12, 4)
    End Function

    Private Function Modify_Current_Time(ByVal time As Date) As Integer
        Dim year As String = (time.Year - 2000).ToString("X2")
        Dim month As String = time.Month.ToString("X2")
        Dim day As String = time.Day.ToString("X2")
        Dim hour As String = time.Hour.ToString("X2")
        Dim minute As String = time.Minute.ToString("X2")
        Dim second As String = time.Second.ToString("X2")
        template(58) = template(58).Substring(0, 8) + year + month + day + hour
        template(59) = template(59).Substring(0, 8) + minute + second + template(59).Substring(12, 4)
    End Function

    Private Function Get_Data_From_Line(ByVal line As String) As String
        Get_Data_From_Line = line.Substring(0, 2)
        Get_Data_From_Line = Get_Data_From_Line + line.Substring(3, 2)
        Get_Data_From_Line = Get_Data_From_Line + line.Substring(6, 2)
        Get_Data_From_Line = Get_Data_From_Line + line.Substring(9, 2)
        Get_Data_From_Line = Get_Data_From_Line + line.Substring(12, 2)
        Get_Data_From_Line = Get_Data_From_Line + line.Substring(15, 2)
        Get_Data_From_Line = Get_Data_From_Line + line.Substring(18, 2)
        Get_Data_From_Line = Get_Data_From_Line + line.Substring(21, 2)
    End Function
    Private Function Write_Data_To_Logger()
        LBL_Status.Text = "Programming the Logger ..."
        isProgramming = True
        TMR_Programming.Enabled = False
        Timer1.Enabled = True
        counter = 0
        BT_Program.Enabled = False
    End Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ' if logger is unplogged during programming process
        If deviceIsAttached = 0 Then
            DataGridView1.Rows(programmedLoggerCounter).Cells("status").Value = Image.FromFile("icons\cross.jpg")
            isProgramming = False
            TS_Progress.Value = 0
            Timer1.Enabled = False
        End If

        'deviceIsReady = 0
        Write(template(counter))
        TS_Progress.Value = (counter / 136) * 100 'fieldsToWrite.length
        counter = counter + 1

        If counter = 136 Then
            DataGridView1.Rows(programmedLoggerCounter).Cells("status").Value = Image.FromFile("icons\check.jpg")
            DataGridView1.Rows(programmedLoggerCounter).Cells("check").Value = False
            If CH_Print.Checked = True Then
                PrintLabel("Label to be printed")
            End If
            'deviceIsAttached = 0
            programmedLoggerCounter = programmedLoggerCounter + 1
            TS_Progress.Value = 0
            logger_programmed = True
            Timer1.Enabled = False
            isProgramming = False
            BT_Program.Enabled = True
            TMR_Programming.Enabled = True
        End If
    End Sub

    Public Sub SetupLabelObject()
        ' get the objects on the label
        Dim ObjName As String
        'Dim i As Integer
        If Label Is Nothing Then Exit Sub

    End Sub

    Private Sub UpdateControls()

    End Sub

    Private Sub SetupTraySelection()
        ' enable/disable tray based on selected printer
        Dim printerName As String
        Dim printer As DYMO.Label.Framework.ILabelWriterPrinter
        Dim printers As DYMO.Label.Framework.IPrinters


        printerName = LabelWriterCmb.Text
        printers = DYMO.Label.Framework.Framework.GetPrinters()

        If TypeOf printers(printerName) Is DYMO.Label.Framework.ILabelWriterPrinter Then
            printer = printers(printerName)

        End If

    End Sub

    Public Sub SetupLabelWriterSelection()
        'Dim PrtNames As String
        Dim Printer As DYMO.Label.Framework.IPrinter
        ' clear all items first
        LabelWriterCmb.Items.Clear()
        For Each Printer In DYMO.Label.Framework.Framework.GetPrinters
            LabelWriterCmb.Items.Add(Printer.Name)
        Next

        If LabelWriterCmb.Items.Count > 0 Then
            LabelWriterCmb.SelectedIndex = 0
            TS_LB_Printer.Text = "Printer: " + LabelWriterCmb.Text
        End If
        LabelWriterCmb.Enabled = LabelWriterCmb.Items.Count > 0
    End Sub

    Private Function Initialize_Printer() As Integer
        Label = DYMO.Label.Framework.Framework.Open(DYMO_TEMPLATE_LABEL)
        SetupLabelObject()
        UpdateControls()
    End Function

    Private Sub LabelWriterCmb_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs)
        'DymoAddIn.SelectPrinter(LabelWriterCmb.Text)
        'SetupLabelWriterSelection(False)
        SetupTraySelection()
    End Sub

    Private Function PrintLabel(ByVal textToPrint As String) As Integer
        ' ATTENTION: Every StartPrintJob() must have a matching EndPrintJob()
        'DymoAddIn.EndPrintJob()

        Dim printer As DYMO.Label.Framework.IPrinter
        Dim labelWriterPrinter As DYMO.Label.Framework.ILabelWriterPrinter
        Dim printParams As DYMO.Label.Framework.IPrintParams

        Label.SetObjectText("company", TB_CompanyName.Text + " (" + TB_Company_Code.Text + ")")
        Label.SetObjectText("equipment", DataGridView1.Rows(programmedLoggerCounter).Cells("description").Value)

        Dim properties As String
        properties = DataGridView1.Rows(programmedLoggerCounter).Cells("sensortype").Value + ", "
        properties = properties + "Phase " + DataGridView1.Rows(programmedLoggerCounter).Cells("phase").Value + ", "
        properties = properties + "Multiplier " + DataGridView1.Rows(programmedLoggerCounter).Cells("multiplier").Value + ", " + TX_Sampling_Interval.Text + " Sec" + vbCrLf
        properties = properties + DataGridView1.Rows(programmedLoggerCounter).Cells("powersystem").Value + vbCrLf
        properties = properties + TB_Assesment_Date.Text
        Label.SetObjectText("properties", properties)

        printer = DYMO.Label.Framework.Framework.GetPrinters()(LabelWriterCmb.Text)
        If (TypeOf printer Is DYMO.Label.Framework.ILabelWriterPrinter) Then
            labelWriterPrinter = printer
            If (labelWriterPrinter.IsTwinTurbo) Then
                printParams = New DYMO.Label.Framework.LabelWriterPrintParams
                printParams.RollSelection = [Enum].Parse(GetType(DYMO.Label.Framework.RollSelection), "Auto")

                Label.Print(printer, printParams)
            Else
                Label.Print(printer) ' // print with default params
            End If
        End If
    End Function
    Private Shared Sub OnThreadException(ByVal sender As Object, ByVal t As Threading.ThreadExceptionEventArgs)
        MessageBox.Show(t.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
    End Sub

    Private Sub BT_Program_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_Program.Click
        If TMR_Programming.Enabled = False Then
            Read_Template_File("template.txt")
            isProgramming = False
            num_of_loggers = DataGridView1.RowCount - 1
            programmedLoggerCounter = 0
            TMR_Programming.Enabled = True
            BT_Program.Text = "Stop"
        Else
            TMR_Programming.Enabled = False
            BT_Program.Text = "Start"
        End If
    End Sub

    Private Sub TMR_Programming_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMR_Programming.Tick
        If (isProgramming = False) Then

            Dim sensor_code As String = "A"
            Dim start_date As String = DateTimePicker1.Text + " " + TX_Start_Time.Text

            If programmedLoggerCounter < num_of_loggers Then
                If DataGridView1.Rows(programmedLoggerCounter).Cells("check").Value = True Then
                    'TMR_Programming.Interval = 500
                    If ((deviceIsAttached = 1) And (logger_programmed = False)) Then
                        attach_timer.Enabled = False

                        Dim description As String
                        Dim sensor_type As String

                        description = DataGridView1.Rows(programmedLoggerCounter).Cells("description").FormattedValue.ToString()
                        sensor_type = DataGridView1.Rows(programmedLoggerCounter).Cells("sensortype").FormattedValue.ToString()

                        Select Case sensor_type
                            Case "20 Amps"
                                sensor_code = "A"
                            Case "50 Amps"
                                sensor_code = "B"
                            Case "100 Amps"
                                sensor_code = "C"
                            Case "200 Amps"
                                sensor_code = "D"
                            Case "600 Amps"
                                sensor_code = "E"
                        End Select

                        Dim loggerDescription As String = TB_CompanyName.Text + "_" + TB_Company_Code.Text + "_" + currentSerialNumber + "_" + description
                        Dim timeToStart As String = DateTimePicker1.Text + " " + TX_Start_Time.Text
                        Dim samplingInterval As String = TX_Sampling_Interval.Text
                        Modify_Template(loggerDescription, timeToStart, samplingInterval, sensor_code)
                        DataGridView1.Rows(programmedLoggerCounter).Cells("serialnumber").Value = currentSerialNumber
                        DataGridView1.Rows(programmedLoggerCounter).Cells("status").Value = Image.FromFile("icons\warning.jpg")
                        Write_Data_To_Logger()
                    Else
                        LBL_Status.Text = "Waiting! Please Connect Next Logger."
                        attach_timer.Enabled = True
                    End If
                Else
                    programmedLoggerCounter = programmedLoggerCounter + 1
                    TMR_Programming.Interval = 1
                End If
            Else
                TMR_Programming.Enabled = False
                BT_Program.Text = "Start"
                LBL_Status.Text = "Programming Done!"
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellStyleContentChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellStyleContentChangedEventArgs) Handles DataGridView1.CellStyleContentChanged
        num_of_loggers = DataGridView1.RowCount - 1
        Dim num20Amps As Integer = 0
        Dim num50Amps As Integer = 0
        Dim num100Amps As Integer = 0
        Dim num200Amps As Integer = 0
        Dim num600Amps As Integer = 0
        Dim sensor_type As String
        Dim i As Integer

        For i = 0 To num_of_loggers - 1
            sensor_type = DataGridView1.Rows(programmedLoggerCounter).Cells("sensortype").FormattedValue.ToString()

            Select Case sensor_type
                Case "20 Amps"
                    num20Amps = num20Amps + 1
                Case "50 Amps"
                    num50Amps = num50Amps + 1
                Case "100 Amps"
                    num100Amps = num100Amps + 1
                Case "200 Amps"
                    num200Amps = num200Amps + 1
                Case "600 Amps"
                    num600Amps = num600Amps + 1
            End Select
        Next

        TB_20Amps.Text = num20Amps.ToString
        TB_50Amps.Text = num50Amps.ToString
        TB_100Amps.Text = num100Amps.ToString
        TB_200Amps.Text = num200Amps.ToString
        TB_600Amps.Text = num600Amps.ToString
    End Sub

    Private Sub DataGridView1_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged

    End Sub

    Private Sub DataGridView1_UserAddedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DataGridView1.UserAddedRow
        DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells("status").Value = Image.FromFile("icons\question.jpg")
        DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells("check").Value = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim xlFile As String = "d:\file.xlsx"
        If File.Exists(xlFile) Then
            File.Delete(xlFile)
        End If

        Dim oExcel As Object
        oExcel = CreateObject("Excel.Application")
        Dim oBook As Excel.Workbook
        Dim oSheet As Excel.Worksheet
        oBook = oExcel.Workbooks.add
        oSheet = oExcel.Worksheets(1)
        oSheet.Name = "Test Name"
        oSheet.Range("A1").Value = TB_CompanyName.Text
        oSheet.Range("B1").Value = TB_Company_Code.Text
        oSheet.Range("A2").Value = TB_Assesment_Date.Text
        Dim timeToStart As String = DateTimePicker1.Text + " " + TX_Start_Time.Text
        oSheet.Range("B2").Value = timeToStart

        num_of_loggers = DataGridView1.RowCount - 1
        Dim i As Integer
        For i = 1 To num_of_loggers
            oSheet.Range("A" + (i + 3).ToString).Value = DataGridView1.Rows(i - 1).Cells("serialnumber").Value
            oSheet.Range("B" + (i + 3).ToString).Value = DataGridView1.Rows(i - 1).Cells("description").Value
            oSheet.Range("C" + (i + 3).ToString).Value = DataGridView1.Rows(i - 1).Cells("powersystem").Value
            oSheet.Range("D" + (i + 3).ToString).Value = DataGridView1.Rows(i - 1).Cells("sensortype").Value
            oSheet.Range("E" + (i + 3).ToString).Value = DataGridView1.Rows(i - 1).Cells("phase").Value
            oSheet.Range("F" + (i + 3).ToString).Value = DataGridView1.Rows(i - 1).Cells("multiplier").Value
        Next

        oBook.SaveAs(xlFile)
        oBook.Close()
        oBook = Nothing
        oExcel.Quit()
        oExcel = Nothing
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        num_of_loggers = DataGridView1.RowCount - 1
        Dim num20Amps As Integer = 0
        Dim num50Amps As Integer = 0
        Dim num100Amps As Integer = 0
        Dim num200Amps As Integer = 0
        Dim num600Amps As Integer = 0
        Dim sensor_type As String
        Dim i As Integer

        For i = 0 To num_of_loggers - 1
            sensor_type = DataGridView1.Rows(i).Cells("sensortype").FormattedValue.ToString()

            Select Case sensor_type
                Case "20 Amps"
                    num20Amps = num20Amps + 1
                Case "50 Amps"
                    num50Amps = num50Amps + 1
                Case "100 Amps"
                    num100Amps = num100Amps + 1
                Case "200 Amps"
                    num200Amps = num200Amps + 1
                Case "600 Amps"
                    num600Amps = num600Amps + 1
            End Select
        Next

        TB_20Amps.Text = num20Amps.ToString
        TB_50Amps.Text = num50Amps.ToString
        TB_100Amps.Text = num100Amps.ToString
        TB_200Amps.Text = num200Amps.ToString
        TB_600Amps.Text = num600Amps.ToString
    End Sub

    Private Function CalculateAmps(ByVal system As String, ByVal power As Double, ByVal voltage As Double, ByVal powerFactor As Double) As Double
        Select Case system
            Case "DC"
                CalculateAmps = power / voltage
            Case "AC - Single Phase"
                CalculateAmps = power / (powerFactor * voltage)
            Case "AC - Three Phase"
                CalculateAmps = power / (Sqrt(3) * powerFactor * voltage)
        End Select
    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If Not (Convert.ToInt32(TX_Voltage.Text) > 0) Then
            MsgBox("Bad Voltage Value")
            Return
        End If

        If Not ((Convert.ToDouble(TX_PF.Text) > 0) And (Convert.ToDouble(TX_PF.Text) <= 1)) Then
            MsgBox("Bad Power Factor Value")
            Return
        End If

        TX_Current.Text = CalculateAmps(CMB_Conversion.Text, Convert.ToDouble(TX_Power.Text), Convert.ToDouble(TX_Voltage.Text), Convert.ToDouble(TX_PF.Text)).ToString

    End Sub

    Private Sub BT_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_Clear.Click
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
    End Sub
    Private Function Write(ByVal txtData As String) As Integer
        Dim buf(0 To 20) As Byte
        Dim res As Integer

        buf(0) = &H0
        buf(1) = Convert.ToByte(txtData.Substring(0, 2), 16)
        buf(2) = Convert.ToByte(txtData.Substring(2, 2), 16)
        buf(3) = Convert.ToByte(txtData.Substring(4, 2), 16)
        buf(4) = Convert.ToByte(txtData.Substring(6, 2), 16)
        buf(5) = Convert.ToByte(txtData.Substring(8, 2), 16)
        buf(6) = Convert.ToByte(txtData.Substring(10, 2), 16)
        buf(7) = Convert.ToByte(txtData.Substring(12, 2), 16)
        buf(8) = Convert.ToByte(txtData.Substring(14, 2), 16)

        hid_handle = hid_open(&HF1B, &H119, &H0)
        If (hid_handle <> 0) Then
            res = hid_send_feature_report(hid_handle, buf, 9)
            'hid_set_nonblocking(Handle, 1)
            res = hid_read(hid_handle, buf, 8)
            If res = 8 Then
                hid_close(hid_handle)
            Else
                'error
            End If
        End If
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TX_Start_Time.Text = TimeOfDay
        TS_LB_Date.Text = Now
        TB_Assesment_Date.Text = Today

        SetupLabelWriterSelection()
        UpdateControls()
        Initialize_Printer()
    End Sub
End Class
