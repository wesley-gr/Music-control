Module Functions

    Public Sub Resize_form_buttons_Control()

        FRM_Control.Height = My.Settings.Frm_Control_Btn_Frm_Size + 47.5
        FRM_Control.Width = (My.Settings.Frm_Control_Btn_Frm_Size * 6) + 20 + (6 * 5)

        FRM_Control.btn_Play.Height = My.Settings.Frm_Control_Btn_Frm_Size
        FRM_Control.btn_Play.Width = My.Settings.Frm_Control_Btn_Frm_Size

        FRM_Control.Btn_Previous.Height = My.Settings.Frm_Control_Btn_Frm_Size
        FRM_Control.Btn_Previous.Width = My.Settings.Frm_Control_Btn_Frm_Size
        FRM_Control.Btn_Previous.Location = New Point((My.Settings.Frm_Control_Btn_Frm_Size + 10), 5)

        FRM_Control.Btn_Next.Height = My.Settings.Frm_Control_Btn_Frm_Size
        FRM_Control.Btn_Next.Width = My.Settings.Frm_Control_Btn_Frm_Size
        FRM_Control.Btn_Next.Location = New Point(((My.Settings.Frm_Control_Btn_Frm_Size * 2) + 10 + (5)), 5)

        FRM_Control.Btn_Mute.Height = My.Settings.Frm_Control_Btn_Frm_Size
        FRM_Control.Btn_Mute.Width = My.Settings.Frm_Control_Btn_Frm_Size
        FRM_Control.Btn_Mute.Location = New Point(((My.Settings.Frm_Control_Btn_Frm_Size * 3) + 10 + (5 * 2)), 5)

        FRM_Control.Btn_Volume_Lower.Height = My.Settings.Frm_Control_Btn_Frm_Size
        FRM_Control.Btn_Volume_Lower.Width = My.Settings.Frm_Control_Btn_Frm_Size
        FRM_Control.Btn_Volume_Lower.Location = New Point(((My.Settings.Frm_Control_Btn_Frm_Size * 4) + 10 + (5 * 3)), 5)

        FRM_Control.Btn_Volume_Higher.Height = My.Settings.Frm_Control_Btn_Frm_Size
        FRM_Control.Btn_Volume_Higher.Width = My.Settings.Frm_Control_Btn_Frm_Size
        FRM_Control.Btn_Volume_Higher.Location = New Point(((My.Settings.Frm_Control_Btn_Frm_Size * 5) + 10 + (5 * 4)), 5)

    End Sub

End Module
