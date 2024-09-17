Imports System.Drawing
Imports System.Windows.Forms
Imports System.Runtime.InteropServices ' For P/Invoke

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AutoClickerForm
    Inherits System.Windows.Forms.Form

    ' Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    ' Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    ' NOTE: The following procedure is required by the Windows Form Designer
    ' It can be modified using the Windows Form Designer.  
    ' Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.PictureBoxColorDisplay = New System.Windows.Forms.PictureBox()
        Me.btnAutoClick = New System.Windows.Forms.Button()
        Me.btnColorPick = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtClickValue = New System.Windows.Forms.TextBox()
        Me.AutoClickTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBoxColorDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        ' Timer1
        '
        '
        ' btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(12, 12)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(129, 46)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "START"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        ' btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(147, 12)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(129, 46)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "STOP"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        ' PictureBoxColorDisplay
        '
        Me.PictureBoxColorDisplay.Location = New System.Drawing.Point(596, 12)
        Me.PictureBoxColorDisplay.Name = "PictureBoxColorDisplay"
        Me.PictureBoxColorDisplay.Size = New System.Drawing.Size(291, 106)
        Me.PictureBoxColorDisplay.TabIndex = 3
        Me.PictureBoxColorDisplay.TabStop = False
        '
        ' btnAutoClick
        '
        Me.btnAutoClick.Location = New System.Drawing.Point(14, 69)
        Me.btnAutoClick.Name = "btnAutoClick"
        Me.btnAutoClick.Size = New System.Drawing.Size(127, 49)
        Me.btnAutoClick.TabIndex = 4
        Me.btnAutoClick.Text = "PLAY"
        Me.btnAutoClick.UseVisualStyleBackColor = True
        '
        ' btnColorPick
        '
        Me.btnColorPick.Location = New System.Drawing.Point(686, 124)
        Me.btnColorPick.Name = "btnColorPick"
        Me.btnColorPick.Size = New System.Drawing.Size(127, 49)
        Me.btnColorPick.TabIndex = 5
        Me.btnColorPick.Text = "Color Picker"
        Me.btnColorPick.UseVisualStyleBackColor = True
        '
        ' DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(173, 230)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(560, 296)
        Me.DataGridView1.TabIndex = 6
        '
        ' txtName
        '
        Me.txtName.Location = New System.Drawing.Point(87, 146)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 7
        '
        ' Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Name:"
        '
        ' Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Value:"
        '
        ' txtClickValue
        '
        Me.txtClickValue.Location = New System.Drawing.Point(87, 172)
        Me.txtClickValue.Name = "txtClickValue"
        Me.txtClickValue.Size = New System.Drawing.Size(100, 20)
        Me.txtClickValue.TabIndex = 10
        '
        ' AutoClickTimer
        '
        Me.AutoClickTimer.Interval = 100 ' Default interval, will be updated based on Click_Value
        '
        ' AutoClickerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 555)
        Me.Controls.Add(Me.txtClickValue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnColorPick)
        Me.Controls.Add(Me.btnAutoClick)
        Me.Controls.Add(Me.PictureBoxColorDisplay)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "AutoClickerForm"
        Me.Text = "Auto Clicker with Color Detection"
        CType(Me.PictureBoxColorDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents PictureBoxColorDisplay As PictureBox
    Friend WithEvents btnAutoClick As Button
    Friend WithEvents btnColorPick As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtClickValue As TextBox
    Friend WithEvents AutoClickTimer As Timer

    Private targetColor As Color = Color.Empty

    Private Sub AutoClickerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the timer interval for real-time color detection
        Timer1.Interval = 100 ' 100 milliseconds (adjust as needed)
        Timer1.Stop() ' Initially stop the timer

        ' Set the timer interval for auto-clicking
        AutoClickTimer.Stop()

        InitializeDataGridView()

        ' Enable form-wide key events
        Me.KeyPreview = True
    End Sub

    Private Sub InitializeDataGridView()
        ' Create and configure columns
        DataGridView1.Columns.Clear() ' Clear any existing columns

        Dim nameColumn As New DataGridViewTextBoxColumn()
        nameColumn.Name = "Name"
        nameColumn.HeaderText = "Name"

        Dim clickValueColumn As New DataGridViewTextBoxColumn()
        clickValueColumn.Name = "Click_Value"
        clickValueColumn.HeaderText = "Click_Value"

        Dim colorColumn As New DataGridViewImageColumn()
        colorColumn.Name = "Color"
        colorColumn.HeaderText = "Color"

        ' Add columns to DataGridView
        DataGridView1.Columns.Add(nameColumn)
        DataGridView1.Columns.Add(clickValueColumn)
        DataGridView1.Columns.Add(colorColumn)
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Timer1.Stop() ' Stop the timer when the Stop button is clicked
        AutoClickTimer.Stop() ' Stop auto-clicking
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Start() ' Start the timer when the Start button is clicked
    End Sub

    Private Function GetPixelColor(x As Integer, y As Integer) As Color
        Dim bmp As New Bitmap(1, 1)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.CopyFromScreen(New Point(x, y), Point.Empty, New Size(1, 1))
        End Using
        Return bmp.GetPixel(0, 0)
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Get the current cursor position using System.Drawing.Point
        Dim mousePos As Point = Cursor.Position

        ' Get the color at the cursor position
        Dim pixelColor As Color = GetPixelColor(mousePos.X, mousePos.Y)

        ' Update the PictureBox to display the color
        UpdatePictureBoxColor(pixelColor)

        ' If the detected color matches the target color, perform a click
        If targetColor = pixelColor Then
            PerformClick()
        End If
    End Sub

    Private Sub btnColorPick_Click(sender As Object, e As EventArgs) Handles btnColorPick.Click
        ' Get the current cursor position using System.Drawing.Point
        Dim mousePos As Point = Cursor.Position

        ' Get the color at the cursor position
        targetColor = GetPixelColor(mousePos.X, mousePos.Y)

        ' Display the selected color in the PictureBox
        UpdatePictureBoxColor(targetColor)

        ' Add the color and text box values to the DataGridView
        AddColorToDataGridView(txtName.Text, txtClickValue.Text, targetColor)
    End Sub

    Private Sub UpdatePictureBoxColor(color As Color)
        ' Create a new bitmap to display the color in the PictureBox
        Dim bmp As New Bitmap(PictureBoxColorDisplay.Width, PictureBoxColorDisplay.Height)

        ' Fill the bitmap with the detected color
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(color)
        End Using

        ' Set the PictureBox image to the newly created bitmap
        PictureBoxColorDisplay.Image = bmp
    End Sub

    Private Sub AddColorToDataGridView(name As String, clickValue As String, color As Color)
        ' Add a row with the name, click value, and color to the DataGridView
        Dim rowIndex As Integer = DataGridView1.Rows.Add()
        Dim row As DataGridViewRow = DataGridView1.Rows(rowIndex)
        row.Cells("Name").Value = name
        row.Cells("Click_Value").Value = clickValue
        row.Cells("Color").Value = CreateColorImage(color)
    End Sub

    Private Function CreateColorImage(color As Color) As Image
        Dim bmp As New Bitmap(50, 20) ' Adjust size as needed
        Using g As Graphics = Graphics.FromImage(bmp)
            g.Clear(color)
        End Using
        Return bmp
    End Function

    Private Sub PerformClick()
        Const MOUSEEVENTF_LEFTDOWN As Integer = &H2
        Const MOUSEEVENTF_LEFTUP As Integer = &H4

        Dim p As New Point()
        GetCursorPos(p)
        mouse_event(MOUSEEVENTF_LEFTDOWN, p.X, p.Y, 0, 0)
        mouse_event(MOUSEEVENTF_LEFTUP, p.X, p.Y, 0, 0)
    End Sub

    ' Declare external functions for simulating mouse clicks
    <DllImport("user32.dll", CallingConvention:=CallingConvention.StdCall)>
    Private Shared Function GetCursorPos(ByRef lpPoint As Point) As Boolean
    End Function

    <DllImport("user32.dll", CallingConvention:=CallingConvention.StdCall)>
    Private Shared Sub mouse_event(dwFlags As Integer, dx As Integer, dy As Integer, dwData As Integer, dwExtraInfo As Integer)
    End Sub

    Private Sub AutoClickerForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Check if F10 key was pressed
        If e.KeyCode = Keys.F10 Then
            btnColorPick_Click(sender, e)
        End If
    End Sub

    Private Sub btnAutoClick_Click(sender As Object, e As EventArgs) Handles btnAutoClick.Click
        ' Retrieve the click interval from the selected row
        Dim interval As Integer = 1000 ' Default value
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)
            If Integer.TryParse(selectedRow.Cells("Click_Value").Value.ToString(), interval) Then
                interval *= 1000 ' Convert to milliseconds
                AutoClickTimer.Interval = interval
                AutoClickTimer.Start() ' Start auto-clicking
            End If
        End If
    End Sub

    Private Sub AutoClickTimer_Tick(sender As Object, e As EventArgs) Handles AutoClickTimer.Tick
        ' Check the color at the current cursor position
        Dim mousePos As Point = Cursor.Position
        Dim pixelColor As Color = GetPixelColor(mousePos.X, mousePos.Y)

        ' Perform a click if the color matches the target color
        If targetColor = pixelColor Then
            PerformClick()
        End If
    End Sub

End Class
