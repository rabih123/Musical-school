﻿Imports C1.C1Schedule
Imports System.Data.SqlClient



Public Class frmSchedules
    Private DtSrc As DataTable
    Private lctitle, LcScheType, lcStep, profId, ProfName, course, SessCount As String
    Private LcFstdate, LcLstDate As Date
    Private lcChanges, Addstudent, STdLocked As Boolean
    Private AppoData(,) As String
    Private stdCount As Integer

    Public Overloads Sub show(ByVal _Steps As String, Optional ByVal _ProfId As String = "", Optional ByVal _ProfName As String = "", _
                              Optional ByVal _AddStd As Boolean = False, Optional ByVal _course As String = "")
        Dim frm As frmschLoad
        Try
            lcStep = _Steps
            If lcStep <> "&B-Students Courses" Then
                frm = New frmschLoad
                frm.StartPosition = FormStartPosition.CenterScreen
                If Not frm.ShowDialog(lcStep) = Windows.Forms.DialogResult.OK Then
                    '  uncheckStripMneu(frmMain, "MnuProfSched")
                    frmMain.MnuProfSched.Checked = False
                    Me.Close()
                    Exit Try
                    'Me.BeginInvoke(New MethodInvoker(AddressOf CloseIt))
                Else
                    profId = frm.CbProff.SelectedValue
                    ProfName = frm.CbProff.Text
                    LblName.Text = ProfName
                End If
                Left = 0
                Top = 0
                Size = ParentForm.ClientRectangle.Size
                Me.Show()
            Else

                profId = _ProfId
                ProfName = _ProfName
                Addstudent = _AddStd
                course = _course
                Me.ShowDialog()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmSchedules_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            frmload.MnuProfSched.Checked = False
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmSchedules_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If lcStep = "&B-Students Courses" AndAlso Addstudent = True AndAlso STdLocked = False Then
                MessageBox.Show("Choose The Class First", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True : Exit Try
            End If

            If lcStep <> "&B-Students Courses" Then
                If lcChanges = True AndAlso MessageBox.Show("Are you sure do you want to close", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                    e.Cancel = True : Exit Try
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmSchedules_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            frmMain.MnuProfSched.Checked = True
            AdjustTabledate()
            fillSchedule()

            If lcStep = "&A-Professors Schedule" Then
                BtnPrint.Visible = False
                ' BtnView.Visible = True
                LblCount.Visible = True
                labelss.Visible = True
                Me.Height = Screen.PrimaryScreen.WorkingArea.Height - 110
            End If

            If lcStep = "&B-Students Courses" Then
                BtnPrint.Visible = False
                'Label8.Visible = False : Label9.Visible = False
                Btnsave.Visible = False
                BtnProf.Visible = False : Label3.Visible = False
                LblName.Text = ProfName
                Schedule.Settings.AllowCategoriesEditing = False
                Schedule.EditOptions = C1.Win.C1Schedule.EditOptions.None
                If Addstudent = True Then
                    ' MessageBox.Show("Double Click On session To Register the Student.", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmMain.NotifyIcon1.ShowBalloonTip(3000)

                    LblStdName.Visible = True : LblStdName.BringToFront()
                    LblStdName.Text = dtsession(dtsession.Rows.Count - 1)("StdName")
                End If
                fillregStd()
                STdLocked = False
            End If
            lctitle = "Schedule"


        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
    Private Sub fillSchedule()
        Dim cnsql As SqlConnection
        Dim dasql As SqlDataAdapter
        Dim strsql As String
        Dim lbl As Label
        Dim Apt As Appointment


        Try
            strsql = "Select cast(Ses_Counter as varchar(10)) as Ses_Counter ,Ses_StartTime,Ses_EndTime,std_name+' '+std_Lname as [StdName] "
            strsql &= " from tbl_sessions "
            strsql &= " Left Join tbl_Students  On std_id = Ses_StdId "
            strsql &= " Where Ses_ProfId=" & profId

            If lcStep = "&B-Students Courses" Then
                strsql &= " And Ses_CrsCode='" & course & "'"
            End If

            cnsql = New SqlConnection(constr)
            cnsql.Open()

            dasql = New SqlDataAdapter(strsql, cnsql)

            DtSrc = New DataTable

            dasql.Fill(DtSrc)

            Schedule.DataStorage.AppointmentStorage.Mappings("Subject").MappingName = "StdName"
            Schedule.DataStorage.AppointmentStorage.Mappings("Location").MappingName = "Ses_Counter"
            Schedule.DataStorage.AppointmentStorage.Mappings("End").MappingName = "Ses_EndTime"
            Schedule.DataStorage.AppointmentStorage.Mappings("Body").MappingName = "Ses_Counter"
            Schedule.DataStorage.AppointmentStorage.Mappings("Start").MappingName = "Ses_StartTime"

            Schedule.DataStorage.AppointmentStorage.DataSource = DtSrc



            'Schedule.DataStorage.AppointmentStorage.Appointments(0).GetRecurrencePattern.RecurrenceType = RecurrenceTypeEnum.Weekly

            'Schedule.DataStorage.AppointmentStorage.Appointments(1).GetRecurrencePattern.Occurrences = RecurrenceStateEnum.Master
            'Schedule.DataStorage.AppointmentStorage.Appointments(1).GetRecurrencePattern.RecurrenceType = RecurrenceTypeEnum.Weekly



            lbl = New Label(Color.Firebrick, "", "")

            ' Schedule.DataStorage.AppointmentStorage.Appointments(1).Label.BeginEdit()
            'Schedule.DataStorage.AppointmentStorage.Appointments(1).Label.Color = Color.Red
            ' Schedule.DataStorage.AppointmentStorage.Appointments(1).Label.EndEdit()

            'Schedule.Refresh()

            stdCount = 0 : SessCount = 0
            For Each Apt In Schedule.DataStorage.AppointmentStorage.Appointments
                If Apt.Subject.Trim <> "" Then
                    Apt.Label = lbl
                    stdCount = stdCount + 1
                End If
                SessCount = SessCount + 1
            Next


            LblCount.Text = stdCount & " / " & SessCount
            'Schedule.DataStorage.AppointmentStorage.Appointments(0).Label = lbl

            Schedule.CalendarInfo.FirstDate = LcFstdate
            Schedule.CalendarInfo.LastDate = LcLstDate

            lcChanges = False

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            dasql = Nothing
        End Try
    End Sub

    Private Sub Schedule_AppointmentAdded(ByVal sender As Object, ByVal e As C1.C1Schedule.AppointmentEventArgs) Handles Schedule.AppointmentAdded
        Try
            If e.Appointment.Body.Trim = "" Then
                e.Appointment.Body = Schedule.DataStorage.AppointmentStorage.Count
            End If

            e.Appointment.Location = e.Appointment.Start.ToString("hh:mm tt") & " " & e.Appointment.End.ToString("hh:mm tt")
            SessCount = SessCount + 1
            LblCount.Text = stdCount & " / " & SessCount
            lcChanges = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Schedule_AppointmentChanged(ByVal sender As Object, ByVal e As C1.C1Schedule.AppointmentEventArgs) Handles Schedule.AppointmentChanged
        Dim lbl As Label
        Try


            e.Appointment.Location = e.Appointment.Start.ToString("hh:mm tt") & " " & e.Appointment.End.ToString("hh:mm tt")
            e.Appointment.Label.CancelEdit()
            lbl = New Label(Color.Firebrick, "sssssssssssssssss", "sssssssssssssss")
            If e.Appointment.Tag Is Nothing Then e.Appointment.Tag = "Update"
            'If e.Appointment.Tag = "New" Then
            '    If Not AppoData Is Nothing Then
            '        For i As Integer = 0 To AppoData.GetUpperBound(1)

            '        Next
            '    End If
            'End If

            lcChanges = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Schedule_BeforeAppointmentDelete(ByVal sender As Object, ByVal e As C1.C1Schedule.CancelAppointmentEventArgs) Handles Schedule.BeforeAppointmentDelete
        Dim Apt As Appointment
        Try
            If lcStep = "&A-Professors Schedule" Then
                If e.Appointment.Subject <> "" Then
                    MessageBox.Show("Session Is Registred Unable to Delete", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    e.Cancel = True : Exit Try
                End If

                If MessageBox.Show("Are you do you want to delete This Session !", lctitle, MessageBoxButtons.YesNo, _
                                   MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes Then
                    If e.Appointment.Body <> Schedule.DataStorage.AppointmentStorage.Count Then
                        For Each Apt In Schedule.DataStorage.AppointmentStorage.Appointments
                            If Apt.Body > e.Appointment.Body Then
                                Apt.Body = Apt.Body - 1
                            End If
                        Next
                        SessCount = SessCount - 1
                        LblCount.Text = stdCount & " / " & SessCount
                    End If

                    If e.Appointment.Tag = "New" Then
                        For i As Integer = 1 To AppoData.GetUpperBound(1)
                            If AppoData(0, i) = e.Appointment.Start Then
                                AppoData(4, i) = "D"
                            End If
                        Next
                    End If
                    lcChanges = True
                Else
                    e.Cancel = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Apt = Nothing
        End Try
    End Sub

    Private Sub Schedule_BeforeAppointmentDrop(ByVal sender As Object, ByVal e As C1.C1Schedule.CancelAppointmentEventArgs) Handles Schedule.BeforeAppointmentDrop
        Try
            If e.Appointment.Tag = "New" Then
                MessageBox.Show("Cannot Moving Or resizing The New Added Session", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Schedule_BeforeAppointmentResize(ByVal sender As Object, ByVal e As C1.C1Schedule.CancelAppointmentEventArgs) Handles Schedule.BeforeAppointmentResize
        Try
            If e.Appointment.Tag = "New" Then
                MessageBox.Show("Cannot Moving Or resizing The New Added Session", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

   

    Private Sub Schedule_BeforeAppointmentShow(ByVal sender As Object, ByVal e As C1.C1Schedule.CancelAppointmentEventArgs) Handles Schedule.BeforeAppointmentShow
        e.Cancel = True
    End Sub

    Private Sub Schedule_BeforeContextMenuShow(ByVal sender As Object, ByVal e As C1.Win.C1Schedule.BeforeContextMenuShowEventArgs) Handles Schedule.BeforeContextMenuShow
        Try

            If e.SelectionType = C1.Win.C1Schedule.SelectionType.TimeInterval Then
                LcScheType = "TimeInterval"
                'CreateContextMenu(1)
                ContextMenuStrip1.Items(0).Visible = True
                ContextMenuStrip1.Items(1).Visible = False
            Else
                LcScheType = "Appointment"
                ContextMenuStrip1.Items(0).Visible = False
                ContextMenuStrip1.Items(1).Visible = True
                'CreateContextMenu(2)
            End If

            Schedule.ContextMenuStrip = Nothing
            Schedule.ContextMenuStrip.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub Schedule_BeforeViewChange(ByVal sender As Object, ByVal e As C1.Win.C1Schedule.BeforeViewChangeEventArgs) Handles Schedule.BeforeViewChange
        If e.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.DayView Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Schedule_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Schedule.DoubleClick
        Dim lbl As Label
        Try
            If lcStep = "&B-Students Courses" AndAlso Addstudent = True Then
                If Schedule.SelectedAppointments.Count > 0 Then
                    If Schedule.SelectedAppointments(0).Subject <> "" Then
                        MessageBox.Show("This session is Reserved !", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Try
                    End If

                    If MessageBox.Show("Are You Sure do You want to register in this session ?", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        dtsession(dtsession.Rows.Count - 1)("SessId") = Schedule.SelectedAppointments(0).Body
                        dtsession(dtsession.Rows.Count - 1)("Sts") = "O"
                        lbl = New Label(Color.Yellow, "", "")
                        Schedule.SelectedAppointments(0).Label = lbl
                        Schedule.SelectedAppointments(0).Subject = dtsession(dtsession.Rows.Count - 1)("StdName")
                        STdLocked = True
                        MessageBox.Show("The Student Will Attend the course " & vbCrLf & _
                                        " ---- " & CDate(Schedule.SelectedAppointments(0).Start).ToString("dddd") & " ---- " & vbCrLf & _
                                        "** Starting : " & CDate(Schedule.SelectedAppointments(0).Start).ToString("hh:mm tt") & "  " & vbCrLf & _
                                        "** Ending :" & CDate(Schedule.SelectedAppointments(0).End).ToString("hh:mm tt") & " " _
                                        , lctitle, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    Btnclose_Click(Btnclose, New System.EventArgs)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            lbl = Nothing
        End Try
    End Sub
    Private Sub Schedule_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Schedule.MouseUp

        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then


                'If LcScheType = "TimeInterval" Then
                '    CreateContextMenu(1)
                'Else
                '    CreateContextMenu(2)
                'End If
                Schedule.ContextMenuStrip = Nothing
                Schedule.ContextMenuStrip.Dispose()

                Schedule.ContextMenuStrip = ContextMenuStrip1


            End If

            'For Each Itm In Schedule.ContextMenuStrip.Items
            '    Schedule.ContextMenuStrip.Items(i).Visible = False
            '    i = i + 1
            'Next

            '    If e.Button = Windows.Forms.MouseButtons.Right AndAlso Schedule.ContextMenuStrip.Items.Count = 14 Then
            '        Schedule.ContextMenuStrip.Items(1).Visible = False
            '        Schedule.ContextMenuStrip.Items(4).Visible = False
            '        Schedule.ContextMenuStrip.Items(12).Visible = False
            '        Schedule.ContextMenuStrip.Items(13).Visible = False
            '   ElseIf Schedule.ContextMenuStrip.Items.Count = 11 Then
            '        Schedule.ContextMenuStrip.Items(1).Visible = False
            '        Schedule.ContextMenuStrip.Items(2).Visible = False
            '        Schedule.ContextMenuStrip.Items(3).Visible = False
            '        Schedule.ContextMenuStrip.Items(4).Visible = False
            '        Schedule.ContextMenuStrip.Items(5).Visible = False
            '        Schedule.ContextMenuStrip.Items(6).Visible = False
            '        Schedule.ContextMenuStrip.Items(7).Visible = False
            '        Schedule.ContextMenuStrip.Items(8).Visible = False
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsave.Click
        Dim dr As DataRow
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim trsql As SqlTransaction
        Dim strsql As String
        Dim i As Integer = 0
        Dim K As Integer = 0
        Try

            If lcChanges = False Then
                MessageBox.Show("No Changes Made To Save.", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Try
            End If

            Schedule.Update()

            cnsql = New SqlConnection(constr)
            cnsql.Open()

            trsql = cnsql.BeginTransaction

            strsql = "select isnull(Max(Ses_Counter),0) + 1 from tbl_sessions where Ses_ProfId=" & profId

            cmsql = New SqlCommand(strsql, cnsql, trsql)
            i = cmsql.ExecuteScalar

            For Each dr In DtSrc.Rows
                If dr.RowState = DataRowState.Added Then
                    strsql = "Insert into tbl_sessions values(" & profId & " ,'" & i & "','" & dr.Item("Ses_StartTime") & "','" & dr.Item("Ses_EndTime") & "','N',NULL,'" & AppoData(2, K) & "')"
                    i = i + 1
                    K = K + 1
                    cmsql.CommandText = strsql
                    cmsql.ExecuteNonQuery()

                ElseIf dr.RowState = DataRowState.Deleted Then
                    strsql = "Delete From tbl_Classes where Cls_Prof=" & profId & " And Cls_Session="
                    strsql &= "(select Ses_Counter from "
                    strsql &= " tbl_sessions Where Ses_StartTime='" & dr.Item("Ses_StartTime", DataRowVersion.Original) & "' "
                    strsql &= " And Ses_EndTime='" & dr.Item("Ses_EndTime", DataRowVersion.Original) & "' And Ses_ProfId=" & profId & ")"



                    cmsql.CommandText = strsql
                    cmsql.ExecuteNonQuery()



                    strsql = "Delete From tbl_sessions Where Ses_StartTime='" & dr.Item("Ses_StartTime", DataRowVersion.Original) & "' "
                    strsql &= " And Ses_EndTime='" & dr.Item("Ses_EndTime", DataRowVersion.Original) & "' And Ses_ProfId=" & profId

                    cmsql.CommandText = strsql
                    cmsql.ExecuteNonQuery()

                ElseIf dr.RowState = DataRowState.Modified Then
                    strsql = " Update tbl_sessions set Ses_StartTime='" & dr.Item("Ses_StartTime") & "' ,  Ses_EndTime='" & dr.Item("Ses_EndTime") & "'"
                    strsql &= " Where Ses_StartTime='" & dr.Item("Ses_StartTime", DataRowVersion.Original) & "' "
                    strsql &= " And Ses_EndTime='" & dr.Item("Ses_EndTime", DataRowVersion.Original) & "' And Ses_ProfId=" & profId

                    cmsql.CommandText = strsql
                    cmsql.ExecuteNonQuery()
                End If

            Next

            If Not AppoData Is Nothing Then
                For j As Integer = 0 To AppoData.GetUpperBound(1)
                    If AppoData(4, j) = "N" Then


                        strsql = "Insert into tbl_Classes values(" & profId & ",'" & AppoData(3, j) & "',"
                        strsql &= " (select Ses_Counter  from tbl_sessions where Ses_ProfId=" & profId & " And"
                        strsql &= " Ses_StartTime='" & AppoData(0, j) & "' "
                        strsql &= " And Ses_EndTime='" & AppoData(1, j) & "') )"
                        cmsql.CommandText = strsql
                        cmsql.ExecuteNonQuery()

                    End If
                Next
            End If

            trsql.Commit()

            MessageBox.Show("Schedule updated successfully", lctitle, MessageBoxButtons.OK, MessageBoxIcon.Information)

            '' to adjust the counter in the courses form
            If lcStep = "&A-Professors Schedule" Then
                Dim frm As frmCourses
                For z As Integer = 0 To Me.ParentForm.MdiChildren.GetUpperBound(0)
                    If Me.ParentForm.MdiChildren.ElementAt(z).Name = "frmCourses" Then
                        frm = Me.ParentForm.MdiChildren.ElementAt(z)
                        If frm.CbProff.SelectedValue = profId Then
                            frm.SessionsCount()
                        End If
                    End If
                Next
            End If

            DtSrc = Nothing
            Schedule.DataStorage.Clear()
            Schedule.Refresh()
            AppoData = Nothing

            If MessageBox.Show("Choose Another Professor", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                BtnProf_Click(BtnProf, New System.EventArgs)
            Else
                lcChanges = False
                Me.Close()
            End If


        Catch ex As Exception
            trsql.Rollback()
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            cmsql = Nothing : dr = Nothing
        End Try
    End Sub


    Private Sub BtnMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMin.Click
        Try
            If Schedule.CalendarInfo.TimeInterval = TimeScaleEnum.FifteenMinutes Then
                Schedule.CalendarInfo.TimeInterval = TimeScaleEnum.ThirtyMinutes
            Else
                Schedule.CalendarInfo.TimeInterval = TimeScaleEnum.OneHour
            End If
            Schedule.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMax.Click
        Try
            If Schedule.CalendarInfo.TimeInterval = TimeScaleEnum.OneHour Then
                Schedule.CalendarInfo.TimeInterval = TimeScaleEnum.ThirtyMinutes
            Else
                Schedule.CalendarInfo.TimeInterval = TimeScaleEnum.FifteenMinutes
            End If
            Schedule.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Private Sub Schedule_SelectedIntervalChanged(ByVal sender As Object, ByVal e As C1.Win.C1Schedule.SelectedIntervalChangedEventArgs) Handles Schedule.SelectedIntervalChanged
    '    Try
    '        If e.Interval.Start.ToString("HH:mm") = "00:00" OrElse e.Interval.Start.ToString("HH:mm") = "" Then

    '            'Schedule.PrintInfo.CurrentStyle.DateHeadingsFon()
    '            'Schedule.ContextMenuStrip.Show()
    '            'Schedule.ContextMenuStrip.Items(7).PerformClick()
    '            'Schedule.GoToDate("12/01/2014")

    '            'Schedule.Refresh()
    '            'SendKeys.Send("{right}")
    '            ''Schedule.GoToDate("12/01/2014")
    '            ''Schedule.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.WorkWeekView
    '            'Application.DoEvents()

    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub Schedule_SelectionChanged(ByVal sender As Object, ByVal e As C1.Win.C1Schedule.SelectionChangedEventArgs) Handles Schedule.SelectionChanged
    '    Try
    '        'Schedule.WeekTabFormat = C1.Win.C1Schedule.WeekTabFormat.Short
    '        'Schedule.AutoSize = False
    '        'Schedule.AutoValidate = Windows.Forms.AutoValidate.Disable
    '        'Schedule.ShowEmptyGroupItem = False
    '        'Schedule.ShowGroupNavigation = False
    '        'Schedule.HorizontalScroll.Enabled = False
    '        'Schedule.CalendarInfo.FirstDate = CDate("12/01/2014")
    '        'Schedule.Refresh()
    '        'Schedule.GroupPageSize = 1
    '        'Schedule.ScrollControlIntoView(Schedule)
    '        'SendKeys.Send("{Right}")
    '        'Application.DoEvents()
    '        Schedule.ShowGroupNavigation = False
    '    Catch ex As Exception
    '        MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub


    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click

        Try


            'Schedule.PrintInfo.PrintSelectedCalendar = False

            'Schedule.PrintInfo.PrintSelectedCalendar = False
            'Schedule.PrintInfo.ShowOptionsForm = False
            ''Schedule.PrintInfo.PrintDocumentHelper.GetDocumentInfoProperty
            ''Schedule.PrintInfo.CurrentStyle.StyleName = "Weekly Style"


            'Schedule.PrintInfo.LoadStyle(Schedule.PrintInfo.PrintStyles.Item(2))
            'Schedule.PrintInfo.CurrentStyle.Load(Nothing)
            'Schedule.Refresh()
            'Schedule.PrintInfo.Print()

            Schedule.PrintInfo.Preview()

        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnView_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AdjustTabledate()
        Dim strsql As String
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim drsql As SqlDataReader

        Try
            cnsql = New SqlConnection(constr)
            cnsql.Open()

            'strsql = "update tbl_sessions set Ses_StartTime=[Monday],"
            'strsql &= "Ses_EndTime = [Saturday] "
            'strsql &= "from tbl_sessions "
            'strsql &= "left join( "
            'strsql &= "select convert(datetime,convert(varchar(10),dateadd(Year, datediff(Year, Ses_StartTime, getdate()), Ses_StartTime),101) +' ' "
            'strsql &= "+ CONVERT(varchar(10),Ses_StartTime,108)) as [Monday],  "
            'strsql &= "convert(datetime,convert(varchar(10),DATEADD(Year, DATEDIFF(Year, Ses_EndTime, getdate()), Ses_EndTime),101) +' ' "
            'strsql &= "+ CONVERT(varchar(10),Ses_EndTime,108)) as [Saturday] ,"
            'strsql &= "t1.Ses_ProfId as [ProfId] ,t1.Ses_Counter as [Counter] "
            'strsql &= "from tbl_sessions t1 "
            'strsql &= ")tbl on [ProfId] = tbl_sessions.Ses_ProfId and [Counter]=tbl_sessions.Ses_Counter "


            'cmsql = New SqlCommand(strsql, cnsql)
            'cmsql.ExecuteNonQuery()

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

            cmsql = New SqlCommand(strsql, cnsql)
            cmsql.ExecuteNonQuery()

            strsql = "SELECT DATEADD(wk, DATEDIFF(wk, 7, CURRENT_TIMESTAMP), 7) AS START_OF_WEEK ,"
            strsql &= "DATEADD(wk, DATEDIFF(wk, 6, CURRENT_TIMESTAMP), 6 + 6) AS END_OF_WEEK "

            cmsql.CommandText = strsql
            drsql = cmsql.ExecuteReader

            drsql.Read()
            LcFstdate = CDate(drsql.Item("START_OF_WEEK"))
            LcLstDate = CDate(drsql.Item("END_OF_WEEK"))
            drsql.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            cmsql = Nothing
        End Try
    End Sub
    Private Sub CreateContextMenu(ByVal _Type As Integer)
        ' '' Type 1 For Schedule
        ' '' Type 2 for Appointment

        'Try
        '    Cntx = New ContextMenuStrip
        '    If _Type = 1 Then
        '        'Cntx.MenuItems.Add("Add New Session")
        '        Cntx.Items.Add("Add New Session")
        '        Cntx.Items(0).Image = ImageList1.Images(0)


        '    Else

        '        Cntx.Items.Add("Add ssssssssssssNew Session")
        '        Cntx.Items(0).Image = ImageList1.Images(0)



        '    End If

        '    Schedule.ContextMenuStrip = Nothing
        '    Schedule.ContextMenuStrip.Dispose()
        '    Schedule.ContextMenuStrip = Cntx
        '    Schedule.ContextMenuStrip.Refresh()
        '    Schedule.ContextMenuStrip.Select()

        '    Schedule.ContextMenuStrip.CreateControl()
        '    Schedule.Refresh()
        '    Application.DoEvents()

        'Catch ex As Exception
        '    MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub
    Private Sub AddAppointment()
        Dim frm As frmAddApoint
        Dim apt As Appointment
        Dim lbl As Label
        Try
            If Schedule.SelectedAppointments.Count > 0 Then Exit Try
            If Schedule.SelectedInterval.Start <> "12:00 AM" AndAlso Schedule.SelectedInterval.End <> "12:00 AM" Then
                apt = New Appointment
                frm = New frmAddApoint
                frm.StartPosition = FormStartPosition.CenterParent
                If frm.ShowDialog(Schedule.SelectedInterval.Start, Schedule.SelectedInterval.End, profId, AppoData) = Windows.Forms.DialogResult.OK Then


                    apt.Start = CDate(Schedule.SelectedInterval.Start.ToString("yyyy-MM-dd ") & CDate(frm.txtstartTime.Text).ToString("hh:mm tt"))
                    apt.End = CDate(Schedule.SelectedInterval.End.ToString("yyyy-MM-dd ") & CDate(frm.TxtEndTime.Text).ToString("hh:mm tt"))
                    'apt.End = Schedule.SelectedInterval.End
                    apt.Tag = "New"
                    lbl = New Label(Color.LightGreen, "", "")
                    apt.Label = lbl
                    Schedule.SelectedInterval.End = Nothing
                    Schedule.SelectedInterval.Start = Nothing
                    Schedule.DataStorage.AppointmentStorage.BeginEdit(Schedule)
                    Schedule.DataStorage.AppointmentStorage.Appointments.Add(apt)
                    Schedule.DataStorage.AppointmentStorage.FinishAddNew()
                    Schedule.DataStorage.AppointmentStorage.EndEdit(Schedule)
                Else
                    Schedule.SelectedInterval.End = Nothing
                    Schedule.SelectedInterval.Start = Nothing
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            apt = Nothing
        End Try
    End Sub

    Private Sub ContextMenuStrip1_ItemClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked
        Dim frm As frmInfo
        Dim data As String
        Try
            If e.ClickedItem Is ContextMenuStrip1.Items(0) Then
                AddAppointment()
            ElseIf e.ClickedItem Is ContextMenuStrip1.Items(1) Then
                frm = New frmInfo

                If lcStep = "&B-Students Courses" Then
                    data = Schedule.SelectedAppointments(0).Start & "|" & Schedule.SelectedAppointments(0).End & "|" & Schedule.SelectedAppointments(0).Subject
                    frm.ShowDialog(Schedule.SelectedAppointments(0).Body, profId, False, data, True)
                    Schedule.SelectedInterval.End = Nothing
                    Schedule.SelectedInterval.Start = Nothing
                Else

                    If Not Schedule.SelectedAppointments(0).Tag Is Nothing AndAlso (Schedule.SelectedAppointments(0).Tag = "New") Then
                        data = Schedule.SelectedAppointments(0).Start & "|" & Schedule.SelectedAppointments(0).End

                        For i As Integer = 0 To AppoData.GetUpperBound(1)
                            If AppoData(0, i) = Schedule.SelectedAppointments(0).Start Then
                                data = data & "|" & AppoData(2, i) & "|" & AppoData(3, i)
                            End If
                        Next

                        frm.ShowDialog(Schedule.SelectedAppointments(0).Body, profId, True, data)
                    Else
                        data = Schedule.SelectedAppointments(0).Start & "|" & Schedule.SelectedAppointments(0).End
                        frm.ShowDialog(Schedule.SelectedAppointments(0).Body, profId, False, data)
                        Schedule.SelectedInterval.End = Nothing
                        Schedule.SelectedInterval.Start = Nothing
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CloseIt()
        Me.Close()
    End Sub

    Private Sub BtnProf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProf.Click
        Dim frm As frmschLoad
        Try
            If Me.ActiveControl Is BtnProf AndAlso MessageBox.Show("Do You Want to Discard Changes !", lctitle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) _
                        = Windows.Forms.DialogResult.Yes Then
                frm = New frmschLoad
                frm.StartPosition = FormStartPosition.CenterScreen
                If Not frm.ShowDialog(lcStep) = Windows.Forms.DialogResult.OK Then
                    Me.BeginInvoke(New MethodInvoker(AddressOf CloseIt))
                Else
                    profId = frm.CbProff.SelectedValue
                    ProfName = frm.CbProff.Text
                    LblName.Text = ProfName
                    fillSchedule()
                End If
            ElseIf Not Me.ActiveControl Is BtnProf Then
                frm = New frmschLoad
                frm.StartPosition = FormStartPosition.CenterScreen
                If Not frm.ShowDialog(lcStep) = Windows.Forms.DialogResult.OK Then
                    Me.BeginInvoke(New MethodInvoker(AddressOf CloseIt))
                Else
                    profId = frm.CbProff.SelectedValue
                    ProfName = frm.CbProff.Text
                    LblName.Text = ProfName
                    fillSchedule()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ContextMenuStrip1_Opened(ByVal sender As Object, ByVal e As System.EventArgs) Handles ContextMenuStrip1.Opened
        Try
            If lcStep = "&B-Students Courses" Then
                ContextMenuStrip1.Items(0).Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub fillregStd()
        Dim dr As DataRow
        Dim apt As Appointment
        Dim lbl As Label
        Try
            If dtsession Is Nothing Then Exit Try
            lbl = New Label(Color.Yellow, "", "")

            For Each dr In dtsession.Select("sts='O'")
                For Each apt In Schedule.DataStorage.AppointmentStorage.Appointments
                    If dr.Item("SessId") = apt.Body Then
                        apt.Label = lbl
                        apt.Subject = dr.Item("StdName")
                    End If
                Next
            Next
            Schedule.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, lctitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclose.Click
        Me.Close()
    End Sub

    
End Class