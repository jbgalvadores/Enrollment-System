con.Open()
        Try
            cmd = New OleDbCommand("insert into Grade (lrn,ay_code,full_name,grade_level,strand,subject_code,subject_description,units,grade) values (@lrn,@ay_code,@full_name,@grade_level,@strand,@subject_code,@subject_description,@units,@grade)", con)
            With cmd
                .Parameters.AddWithValue("@lrn", frmrecord.txtlrn.Text)
                .Parameters.AddWithValue("@ay_code", frmrecord.txtaycode.Text)
                .Parameters.AddWithValue("@full_name", frmrecord.txtfullname.Text)
                .Parameters.AddWithValue("@grade_level", frmrecord.txtgradelevel.Text)
                .Parameters.AddWithValue("@strand", frmrecord.cbostrand.Text)
                '.Parameters.AddWithValue("@section", frmrecord.cbosection.Text)
                .Parameters.AddWithValue("@subject_code", txtsubjectcode.Text)
                .Parameters.AddWithValue("@subject_description", txtsubdesc.Text)
                .Parameters.AddWithValue("@units", txtunits.Text)
                .Parameters.AddWithValue("@grade", textsubgrade.Text)
                .ExecuteNonQuery()

            End With
            MsgBox("Grade added.", vbInformation)
            con.Close()
            frmrecord.loadgraderecord()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

