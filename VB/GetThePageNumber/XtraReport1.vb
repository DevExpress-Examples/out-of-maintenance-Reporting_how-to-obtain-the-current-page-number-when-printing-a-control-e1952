Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
' ...

Namespace GetThePageNumber
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub xrLabel1_PrintOnPage(ByVal sender As Object, ByVal e As PrintOnPageEventArgs) Handles xrLabel1.PrintOnPage
			If e.PageCount > 0 Then
				' Check if the control is printed on the first page.
				If e.PageIndex = 0 Then
					' Cancels the control's printing.
					e.Cancel = True
				End If
			End If
		End Sub

	End Class
End Namespace
