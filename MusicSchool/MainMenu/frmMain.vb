Imports System.Data.SqlClient

Public Class frmMain
    Dim lctitle As String = "Main menu"
    Dim lcPasswordTrue As Boolean
    Dim frm2 As Alerts
    Dim posY As Integer = 0

    Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim MnuPriv, MnuUserss As Boolean
        Try
            If e.KeyCode = Keys.Escape AndAlso PnlPass.Visible = True Then
                PnlPass.Visible = False : TxtPass.Text = ""
                For i = 0 To Me.MdiChildren.GetUpperBound(0)
                    If Me.MdiChildren.ElementAt(i).Text = "frmUsers" AndAlso MnuUser.Checked = True Then
                        MnuUserss = True
                    End If

                    If Me.MdiChildren.ElementAt(i).Text = "frmUsrPriv" AndAlso MnuPrivUser.Checked = True Then
                        MnuPriv = True
                    End If
                Next
                If MnuUserss = False Then MnuUser.Checked = False
                If MnuPriv = False Then MnuPrivUser.Checked = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Frmmain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            CheckGeneratedYear()
            Stslbluser.Text &= usercode & "   -   " & username
            Time.Start()
            stsLbldate.Text = Now.ToString("dddd - dd,MMMM,yyyy")
            PnlPass.Visible = False
            'generatesteps()
            AdjustSchedule()

            frm2 = New Alerts
            frm2.MdiParent = Me
            'frm2.LblText.Text = "you have 2 pending students payments"

            frm2.Show()
            frm2.SetDesktopLocation(Me.Width - 320, Me.Height - 250)
            'Timer1.Interval = 300
            Timer1.Start()
            ' usercode = "SU"

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        
    End Sub

    Private Sub Time_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Time.Tick
        Try
            If FindWindow(vbNullString, "About C1Schedule") <> IntPtr.Zero Then
                PostMessage(FindWindow(vbNullString, "About C1Schedule"), Wm_close, IntPtr.Zero, IntPtr.Zero)
            End If

            If FindWindow(vbNullString, "About C1Input") <> IntPtr.Zero Then
                PostMessage(FindWindow(vbNullString, "About C1Input"), Wm_close, IntPtr.Zero, IntPtr.Zero)
            End If
            If FindWindow(vbNullString, "About C1SuperTooltip") <> IntPtr.Zero Then
                PostMessage(FindWindow(vbNullString, "About C1SuperTooltip"), Wm_close, IntPtr.Zero, IntPtr.Zero)
            End If
            If FindWindow(vbNullString, "About C1TrueDBGrid") <> IntPtr.Zero Then
                PostMessage(FindWindow(vbNullString, "About C1TrueDBGrid"), Wm_close, IntPtr.Zero, IntPtr.Zero)
            End If
            Stslbltime.Text = Now.ToString("hh:mm:ss tt")
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AStudentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuStudents.Click
        Dim frm As frmStudents
        Try
            If MnuStudents.Checked = True Then
                MessageBox.Show("The Students Form is already opened .", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If
            frm = New frmStudents
            frm.MdiParent = Me
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.Show(MnuStudents.Text)
            MnuStudents.Checked = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frm = Nothing
        End Try
    End Sub
    'Public Sub generatesteps()
    '    Dim cnsql As SqlConnection
    '    Dim cmsql As SqlCommand
    '    Dim drsql As SqlDataReader
    '    Dim strsql, items1(), items2(), strsql2 As String
    '    Dim menuItem, menuItem2 As ToolStripMenuItem
    '    Dim count As Integer = 0
    '    Dim i As Integer = 0
    '    Try
    '        cnsql = New SqlConnection(constr)
    '        cnsql.Open()

    '        strsql = "select count(distinct(priv_form)) from tbl_privileges "

    '        cmsql = New SqlCommand(strsql, cnsql)

    '        For Each menuItem In MenuStrip1.Items
    '            If menuItem.Tag = Nothing Then
    '                For Each menuItem2 In menuItem.DropDownItems
    '                    If menuItem2.Tag.ToString = "Menu" Then
    '                        count = count + 1
    '                        If items1 Is Nothing Then ReDim items1(count - 1)
    '                        ReDim Preserve items1(count - 1)
    '                        items1(count - 1) = menuItem2.Text
    '                    End If
    '                Next
    '            End If
    '        Next

    '        strsql = "select distinct(priv_form)  from tbl_privileges "
    '        cmsql.CommandText = strsql
    '        drsql = cmsql.ExecuteReader
    '        drsql.Read()
    '        For j = 0 To items1.GetUpperBound(0)
    '            If drsql.Item("priv_form") <> items1(j) Then
    '                i = i + 1
    '                If items2 Is Nothing Then ReDim items2(i - 1)
    '                ReDim Preserve items2(i - 1)
    '                items1(j).r()
    '                items2(i - 1) = items1(j)
    '            End If
    '        Next
    '        drsql.Close()

    '        strsql2 = ""
    '        If Not items2 Is Nothing Then
    '            strsql = "select usr_code from tbl_users "
    '            cmsql.CommandText = strsql
    '            drsql = cmsql.ExecuteReader()
    '            If drsql.HasRows Then
    '                For j = 0 To items2.GetUpperBound(0)
    '                    While drsql.Read
    '                        strsql2 &= " Insert into tbl_privileges values('" & drsql.Item("usr_code") & "','" & items2(j) & "','N') "
    '                    End While
    '                Next
    '            End If


    '            drsql.Close()
    '            cmsql = New SqlCommand(strsql2, cnsql)
    '            cmsql.ExecuteNonQuery()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub MnuProff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuProff.Click
        Dim frm As frmProff
        Try
            If MnuProff.Checked = True Then
                MessageBox.Show("The Professors Form is already opened .", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If
            frm = New frmProff
            frm.MdiParent = Me
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.Show(MnuProff.Text)
            MnuProff.Checked = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frm = Nothing
        End Try
    End Sub

    Private Sub CInstrumentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuInst.Click
        Dim frm As frmInstruments
        Try
            If MnuInst.Checked = True Then
                MessageBox.Show("The Instruments Form is already opened .", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If
            frm = New frmInstruments
            frm.MdiParent = Me
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.Show(MnuInst.Text)
            MnuInst.Checked = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frm = Nothing
        End Try
    End Sub

    Private Sub MnuCourses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuCourses.Click
        Dim frm As frmCourses
        Try
            If MnuCourses.Checked = True Then
                MessageBox.Show("The Courses Form is already opened .", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If
            frm = New frmCourses
            frm.MdiParent = Me
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.Show(MnuCourses.Text)
            MnuCourses.Checked = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frm = Nothing
        End Try
    End Sub

    Private Sub MnuProfSched_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuProfSched.Click
        'Dim frm As frmSchedule
        'Try
        '    If MnuProfSched.Checked = True Then
        '        MessageBox.Show("The Schedule Form is already opened .", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        Exit Try
        '    End If
        '    frm = New frmSchedule
        '    frm.MdiParent = Me
        '    frm.StartPosition = FormStartPosition.CenterScreen
        '    frm.Show(MnuProfSched.Text)
        '    MnuProfSched.Checked = True
        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        'Finally
        '    frm = Nothing
        'End Try

        Dim frm As frmSchedules
        Try
            If MnuProfSched.Checked = True Then
                MessageBox.Show("The Schedule Form is already opened .", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If
            frm = New frmSchedules
            frm.MdiParent = Me
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.show(MnuProfSched.Text)
            'MnuProfSched.Checked = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frm = Nothing
        End Try
    End Sub

    Private Sub MnuUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuUser.Click
        Dim frm As frmUsers
        Try
            If MnuUser.Checked = True AndAlso lcPasswordTrue = False Then
                MessageBox.Show("The Users Form is already opened .", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If
            MnuUser.Checked = True
            If PnlPass.Visible = False Then PnlPass.Visible = True : TxtPass.Focus() : lcPasswordTrue = False

            If lcPasswordTrue = True Then
                PnlPass.Visible = False
                frm = New frmUsers
                frm.MdiParent = Me
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.Show(MnuUser.Text) : lcPasswordTrue = False
                MnuUser.Checked = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub TxtPass_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPass.KeyDown
        Dim i As Integer
        Dim MnuPriv, MnuUserss As Boolean
        Try
            If PnlPass.Visible = True Then
                If e.KeyCode = Keys.Enter Then
                    If TxtPass.Text.Trim <> Now.ToString("ddMMyyyy") & usercode Then
                        lcPasswordTrue = False : TxtPass.Text = ""
                        MessageBox.Show("Invalid Password", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        : TxtPass.Text = "" : lcPasswordTrue = True
                        If Me.MdiChildren.GetUpperBound(0) = -1 Then
                            If MnuUser.Checked = True Then
                                MnuUser_Click(MnuUser, New System.EventArgs)
                            End If

                            If MnuPrivUser.Checked = True Then
                                MnuPrivUser_Click(MnuPrivUser, New System.EventArgs)
                            End If
                        Else
                            For i = 0 To Me.MdiChildren.GetUpperBound(0)
                                If Me.MdiChildren.ElementAt(i).Text = "frmUsers" AndAlso MnuUser.Checked = True Then
                                    MnuUserss = True
                                End If

                                If Me.MdiChildren.ElementAt(i).Text = "frmUsrPriv" AndAlso MnuPrivUser.Checked = True Then
                                    MnuPriv = True
                                End If
                            Next
                            If MnuUser.Checked = True AndAlso MnuUserss = False Then
                                MnuUser_Click(MnuUser, New System.EventArgs)
                            End If

                            If MnuPrivUser.Checked = True AndAlso MnuPriv = False Then
                                MnuPrivUser_Click(MnuPrivUser, New System.EventArgs)
                            End If

                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MnuPrivUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuPrivUser.Click
        Dim frm As frmUsrPriv
        Try
            If MnuPrivUser.Checked = True AndAlso lcPasswordTrue = False Then
                MessageBox.Show("The Users Privileges Form is already opened .", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If
            MnuPrivUser.Checked = True
            If PnlPass.Visible = False Then PnlPass.Visible = True : TxtPass.Focus() : lcPasswordTrue = False

            If lcPasswordTrue = True Then
                PnlPass.Visible = False
                frm = New frmUsrPriv
                frm.MdiParent = Me
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.Show(MnuPrivUser.Text) : lcPasswordTrue = False
                MnuPrivUser.Checked = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub MnuVoucher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuVoucher.Click
        Dim frm As frmVouchers
        Try
            If MnuVoucher.Checked = True Then
                MessageBox.Show("The Vouchers Form is already opened .", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If
            frm = New frmVouchers
            frm.MdiParent = Me
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.Show(MnuVoucher.Text)
            MnuVoucher.Checked = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frm = Nothing
        End Try
    End Sub

    Private Sub MnuProfPay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuProfPay.Click
        Dim frm As frmProfPay
        Try
            If MnuProfPay.Checked = True Then
                MessageBox.Show("The Professor payments Form is already opened .", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If
            frm = New frmProfPay
            frm.MdiParent = Me
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.Show(MnuProfPay.Text)
            MnuProfPay.Checked = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frm = Nothing
        End Try
    End Sub

    Private Sub MnuRptStd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuRptStd.Click
        Dim frm As frmPrintStd
        Try
            If MnuRptStd.Checked = True Then
                MessageBox.Show("The Professor payments Form is already opened .", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If
            frm = New frmPrintStd
            frm.MdiParent = Me
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.Show(MnuRptStd.Text)
            MnuRptStd.Checked = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frm = Nothing
        End Try
    End Sub


    Private Sub UsersPrivilegesToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UsersPrivilegesToolStripMenuItem.Click
        Dim MnuPriv, MnuUserss As Boolean
        Try
            If PnlPass.Visible = True Then PnlPass.Visible = False

            For i = 0 To Me.MdiChildren.GetUpperBound(0)
                If Me.MdiChildren.ElementAt(i).Text = "frmUsers" AndAlso MnuUser.Checked = True Then
                    MnuUserss = True
                End If

                If Me.MdiChildren.ElementAt(i).Text = "frmUsrPriv" AndAlso MnuPrivUser.Checked = True Then
                    MnuPriv = True
                End If
            Next
            If MnuUserss = False Then MnuUser.Checked = False
            If MnuPriv = False Then MnuPrivUser.Checked = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MnuRooms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuRooms.Click
        Dim frm As frmRooms
        Try
            If MnuRooms.Checked = True Then
                MessageBox.Show("The Rooms Form is already opened .", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If
            frm = New frmRooms
            frm.MdiParent = Me
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.Show(MnuRooms.Text)
            MnuRooms.Checked = True

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Try
            posY = posY + 10

            If posY <= 450 Then
                frm2.SetDesktopLocation(Me.Width - 320, Me.Height - 250 - posY)
            Else
                Timer1.Stop()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub MnuSpecialMonth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuSpecialMonth.Click
        Dim frm As frmMonths
        Try
            If MnuSpecialMonth.Checked = True Then
                MessageBox.Show("The Special Months Form is already opened .", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If
            frm = New frmMonths
            frm.MdiParent = Me
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.Show(MnuSpecialMonth.Text)
            MnuSpecialMonth.Checked = True

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub CheckGeneratedYear()
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim strsql As String
        Dim frm As frmYearALert
        Try
            strsql = "Select Top 1 1 from tbl_system where Sys_Year=" & Now.Year

            cnsql = New SqlConnection(constr)
            cnsql.Open()

            cmsql = New SqlCommand(strsql, cnsql)


            If cmsql.ExecuteScalar Is Nothing Then
                frm = New frmYearALert
                frm.ShowDialog()

                If frm.DialogResult = Windows.Forms.DialogResult.Cancel Then
                    Me.Close()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            cmsql = Nothing
        End Try
    End Sub
   
    Private Sub MnuHolidays_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuHolidays.Click
        Dim frm As frmVacations
        Try
            If MnuSpecialMonth.Checked = True Then
                MessageBox.Show("The Holidays Form is already opened .", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If
            frm = New frmVacations
            frm.MdiParent = Me
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.Show(MnuHolidays.Text)
            MnuHolidays.Checked = True

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    
    Private Sub MnuChgStdSess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuChgStdSess.Click
        Dim frm As frmChngSess
        Try
            If MnuChgStdSess.Checked = True Then
                MessageBox.Show("The Changing Student  Sessions Form is already opened .", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If
            frm = New frmChngSess
            frm.MdiParent = Me
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.Show(MnuChgStdSess.Text)
            MnuChgStdSess.Checked = True

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MnuMangProfSes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuMangProfSes.Click
        Dim frm As frmProfManSess
        Try
            If MnuMangProfSes.Checked = True Then
                MessageBox.Show("The Managing Professors Sessions Form is already opened .", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If
            frm = New frmProfManSess
            frm.MdiParent = Me
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.Show(MnuMangProfSes.Text)
            MnuMangProfSes.Checked = True

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AdjustSchedule()
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand

        Try
            strsql = "update tbl_sessions set Ses_StartTime=[Monday],"
            strsql &= "Ses_EndTime = [Saturday] "
            strsql &= "from tbl_sessions "
            strsql &= "left join( "
            strsql &= "select convert(datetime,convert(varchar(10),dateadd(week, datediff(week, Ses_StartTime, getdate()), Ses_StartTime),101) +' ' "
            strsql &= "+ CONVERT(varchar(10),Ses_StartTime,108)) as [Monday],  "
            strsql &= "convert(datetime,convert(varchar(10),DATEADD(week, DATEDIFF(week, Ses_EndTime, getdate()), Ses_EndTime),101) +' ' "
            strsql &= "+ CONVERT(varchar(10),Ses_EndTime,108)) as [Saturday] ,"
            strsql &= "t1.Ses_ProfId as [ProfId] ,t1.Ses_Counter as [Counter] "
            strsql &= "from tbl_sessions t1 "
            strsql &= ")tbl on [ProfId] = tbl_sessions.Ses_ProfId and [Counter]=tbl_sessions.Ses_Counter "

            cnsql = New SqlConnection(constr)
            cnsql.Open()

            cmsql = New SqlCommand(strsql, cnsql)
            cmsql.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            cmsql = Nothing
        End Try
    End Sub

    Private Sub MnuProfStdMnthDisc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuProfStdMnthDisc.Click
        Dim frm As frmProfStdMnthDisc
        Try
            If MnuProfStdMnthDisc.Checked = True Then
                MessageBox.Show("The Professors \ Students Monthly Discounts Form is already opened .", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If
            frm = New frmProfStdMnthDisc
            frm.MdiParent = Me
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.Show(MnuProfStdMnthDisc.Text)
            MnuProfStdMnthDisc.Checked = True

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MnuProfRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuProfRpt.Click
        Dim frm As frmPrintProf
        Try
            If MnuProfRpt.Checked = True Then
                MessageBox.Show("The Professors Reports Form is already opened .", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If
            frm = New frmPrintProf
            frm.MdiParent = Me
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.Show(MnuProfRpt.Text)
            MnuProfRpt.Checked = True

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MnuProfSchRpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuProfSchRpt.Click
        Dim frm As frmSchedulesRpt
        Try
            If MnuProfSchRpt.Checked = True Then
                MessageBox.Show("The Weekly Schedule Form is already opened .", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If
            frm = New frmSchedulesRpt
            frm.MdiParent = Me
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.Show(MnuProfSchRpt.Text)
            'MnuProfSched.Checked = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frm = Nothing
        End Try
    End Sub

   
    Private Sub MnuDaiSchoolSch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuDaiSchoolSch.Click
        Dim frm As frmPrintDailySch
        Try
            If MnuDaiSchoolSch.Checked = True Then
                MessageBox.Show("The Daily School Schedule Form is already opened .", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If
            frm = New frmPrintDailySch
            frm.MdiParent = Me
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.Show(MnuDaiSchoolSch.Text)
            MnuDaiSchoolSch.Checked = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frm = Nothing
        End Try
    End Sub

    Private Sub MnuLstAdmStd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuLstAdmStd.Click
        Dim frm As frmPrintListStd
        Try
            If MnuLstAdmStd.Checked = True Then
                MessageBox.Show("The List Of Admitting Students Form is already opened .", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If
            frm = New frmPrintListStd
            frm.MdiParent = Me
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.Show(MnuLstAdmStd.Text)
            MnuLstAdmStd.Checked = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frm = Nothing
        End Try
    End Sub

   
    Private Sub MnuMonthPaym_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuMonthPaym.Click
        Dim frm As frmPayments
        Try
            If MnuMonthPaym.Checked = True Then
                MessageBox.Show("The Monthly Payments Form is already opened .", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If
            frm = New frmPayments
            frm.MdiParent = Me
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.Show(MnuMonthPaym.Text)
            MnuMonthPaym.Checked = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frm = Nothing
        End Try
    End Sub

    Private Sub MnuScholPayInc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuScholPayInc.Click
        Dim frm As frmSchIncProf
        Try
            If MnuScholPayInc.Checked = True Then
                MessageBox.Show("The School Payment & Income Form is already opened .", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If
            frm = New frmSchIncProf
            frm.MdiParent = Me
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.Show(MnuScholPayInc.Text)
            MnuScholPayInc.Checked = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frm = Nothing
        End Try
    End Sub

    Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class