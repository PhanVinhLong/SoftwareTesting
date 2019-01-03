Imports System.Windows.Forms

Public Class AddTab
    Public Sub AddTab(ByVal XtraTabParent As DevExpress.XtraTab.XtraTabControl, ByVal TabNameAdd As String, ByVal UserControl As System.Windows.Forms.UserControl)
        'Khởi tạo 1 Tab Con (XtraTabPage) 
        Dim PageAdd As DevExpress.XtraTab.XtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        'Đặt tên
        PageAdd.Name = "Default"
        'Lấy tên làm đối số
        PageAdd.Text = TabNameAdd
        'Add UserControl vào Tab con vừa khởi tạo ở trên
        PageAdd.Controls.Add(UserControl)
        'Dock tràn hết Tab con
        UserControl.Dock = DockStyle.Fill
        'Hiện nút close
        PageAdd.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True
        'Đổi màu
        PageAdd.BackColor = Drawing.Color.Silver
        'Add vào Tab Cha 
        XtraTabParent.TabPages.Add(PageAdd)
        'Focus vào tab vừa add
        XtraTabParent.SelectedTabPage = XtraTabParent.TabPages.Last
    End Sub
End Class