Imports System.Data.SqlClient

Public Class frmYearALert

    Private Sub frmYearALert_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Try
            If PnlHelp.Visible = True Then
                PnlHelp.Visible = False : PnlHelp.SendToBack()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmYearALert_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            lbltext.Text = "  The  --" & Now.Year & "-- Year  Is Not Generated Yet " & vbCrLf
            lbltext.Text &= "                 Generate The Year First.   "
            PnlHelp.Visible = False
            PbHelp.Image = ImgList.Images(1)
            Timer1.Start()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Pcb_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pcb.Click
        Dim cnsql As SqlConnection
        Dim cmsql As SqlCommand
        Dim trsql As SqlTransaction
        Dim strsql As String
        Dim frm As frmMonths
        Dim k As Integer = 1
        Try
            PnlStart.Visible = True : PnlStart.BringToFront()

            Pg1.Step = 1


            lblProgres.Text = "Generating Students Vouchers."
         
            Timer2.Start()

            While k > 0
                k = k + 1
                Application.DoEvents()
                If Pg1.Value = 25 Then
                    k = -1
                End If
            End While

            Timer2.Stop()

            cnsql = New SqlConnection(constr)
            cnsql.Open()

            trsql = cnsql.BeginTransaction()

            For i As Integer = 1 To 12

                strsql = "Insert Into tbl_vouchers Select distinct "
                strsql &= "vch_stdid, vch_prof, Year(getdate()), "
                strsql &= "'" & CDate(DateSerial(Now.Year, i, 1)).ToString("MMMM") & "',max(total),max(vch_perc),'N',getdate(),'Su',vch_Course," & i & " "
                strsql &= "from tbl_vouchers "
                strsql &= "left join ( "
                strsql &= "select  max(vch_total) as [total],MAX(vch_month) as [month],vch_stdid as [stdid], "
                strsql &= "MAX(vch_Course) as [course] from tbl_vouchers tb where  Vch_year=YEAR(getdate())-1  group by vch_stdid,vch_Course "
                strsql &= ")tb on tb.[stdid]=vch_stdid  and tb.[course]=vch_Course "
                strsql &= "where Vch_year=YEAR(getdate())-1 "
                strsql &= "group by  vch_stdid,vch_prof,vch_Course,vch_month "
                'strsql &= "having max(vch_month)='December' "

                cmsql = New SqlCommand(strsql, cnsql, trsql)
                cmsql.ExecuteNonQuery()

            Next

           

            trsql.Commit()


            lblProgres.Text = "Generating Professors Payments."

            Timer2.Start()
            k = 1
            While k > 0
                k = k + 1
                Application.DoEvents()
                If Pg1.Value = 50 Then
                    k = -1
                End If
            End While

            Timer2.Stop()

            lblProgres.Text = "Generating Special Months."

            frm = New frmMonths
            frm.ShowDialog()


            trsql = cnsql.BeginTransaction()

            If frm.DialogResult = Windows.Forms.DialogResult.OK Then

                'strsql = "Update tbl_vouchers "
                'strsql &= "set vch_total =  vch_total - (spc_Amount / case when  isnull(cnt,0) >0 then cnt else 1 end) "
                'strsql &= "from tbl_vouchers "
                'strsql &= "left join ( "
                'strsql &= "select max(vch_total) as [tot] , max(spc_Amount) as spc_Amount  , max(vch_stdid) as [stdid], "
                'strsql &= "COUNT(vch_Course) as[cnt]  from  tbl_vouchers "
                'strsql &= "inner join tbl_SpecMonths on Spc_Month=vch_numMonth and Spc_Year=YEAR(getdate()) "
                'strsql &= "where exists (select top 1 1 from tbl_Students where std_id=vch_stdid and Std_Special='Y') "
                'strsql &= "and  Vch_year=YEAR(getdate()) group by vch_stdid)tbl on [stdid]=vch_stdid"

                'cmsql = New SqlCommand(strsql, cnsql, trsql)
                'cmsql.ExecuteNonQuery()

                Timer2.Start()
                k = 1
                While k > 0
                    k = k + 1
                    Application.DoEvents()
                    If Pg1.Value = 75 Then
                        k = -1
                    End If
                End While

                Timer2.Stop()

            End If

            strsql = "Insert Into tbl_system select " & Now.Year & ",'Y'"
            cmsql = New SqlCommand(strsql, cnsql, trsql)
            cmsql.ExecuteNonQuery()

            trsql.Commit()

            Dim frmHol As frmVacations
            frmHol = New frmVacations
            frmHol.ShowDialog()

            '      If frmHol.DialogResult = Windows.Forms.DialogResult.OK Then

            lblProgres.Text = "Generating School Holidays."
            Timer2.Start()
            k = 1
            While k > 0
                k = k + 1
                Application.DoEvents()
                If Pg1.Value = 100 Then
                    k = -1
                End If
            End While

            Timer2.Stop()

            MessageBox.Show("The Year Is Succefully Generated.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)

            PnlStart.Visible = False
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Label3_Click(Label3, New System.EventArgs)
            ' End If



        Catch ex As Exception
            trsql.Rollback()
            MessageBox.Show(ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not cnsql Is Nothing Then cnsql = Nothing
            cmsql = Nothing : trsql = Nothing
        End Try
    End Sub

    Private Sub Pcb_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pcb.MouseHover
        Try
            Pcb.Width = Pcb.Width + 10
            Pcb.Height = Pcb.Height + 10
            ToolTip1.SetToolTip(Pcb, "   ")
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Pcb_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Pcb.MouseLeave
        Try
            Pcb.Width = 70
            Pcb.Height = 70
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        If PnlStart.Visible = False Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If PbHelp.Tag = "New" Then
            PbHelp.Image = ImgList.Images(1)
            PbHelp.Tag = "Old"
        Else
            PbHelp.Image = ImgList.Images(0)
            PbHelp.Tag = "New"
        End If
    End Sub

    Private Sub PbHelp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PbHelp.Click
        Try
            If PnlStart.Visible = False Then
                PnlHelp.Visible = True : PnlHelp.BringToFront()
                LblHelp.Text = " When Generating A Year Theese Steps Will Be Applied :" & vbCrLf & vbCrLf
                LblHelp.Text &= "*- If Data Exists Before All The Students Vouchers Will Be Generated Automaticly For The New year " & vbCrLf
                LblHelp.Text &= "*- If Data Exists Before All The Professors payments Will Be Generated Automaticly For The New year " & vbCrLf
                LblHelp.Text &= "*- A Form Will Open To Defined Special Months For Once In The Year  " & vbCrLf
                LblHelp.Text &= "*- A Form Will Open To Defined Holidays For The  Year  " & vbCrLf
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Pg1.PerformStep()
    End Sub
End Class