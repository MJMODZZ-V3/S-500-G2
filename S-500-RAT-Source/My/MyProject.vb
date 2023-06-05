Imports System
Imports System.CodeDom.Compiler
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.Diagnostics
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.CompilerServices

Namespace S500RAT.My
	' Token: 0x02000005 RID: 5
	<HideModuleName()>
	<GeneratedCode("MyTemplate", "11.0.0.0")>
	Friend NotInheritable Module MyProject
		' Token: 0x17000001 RID: 1
		' (get) Token: 0x0600000A RID: 10 RVA: 0x0000210C File Offset: 0x0000030C
		<HelpKeyword("My.Computer")>
		Friend ReadOnly Property Computer As MyComputer
			<DebuggerHidden()>
			Get
				Return MyProject.m_ComputerObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000002 RID: 2
		' (get) Token: 0x0600000B RID: 11 RVA: 0x00002128 File Offset: 0x00000328
		<HelpKeyword("My.Application")>
		Friend ReadOnly Property Application As MyApplication
			<DebuggerHidden()>
			Get
				Return MyProject.m_AppObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000003 RID: 3
		' (get) Token: 0x0600000C RID: 12 RVA: 0x00002144 File Offset: 0x00000344
		<HelpKeyword("My.User")>
		Friend ReadOnly Property User As User
			<DebuggerHidden()>
			Get
				Return MyProject.m_UserObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000004 RID: 4
		' (get) Token: 0x0600000D RID: 13 RVA: 0x00002160 File Offset: 0x00000360
		<HelpKeyword("My.Forms")>
		Friend ReadOnly Property Forms As MyProject.MyForms
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyFormsObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x17000005 RID: 5
		' (get) Token: 0x0600000E RID: 14 RVA: 0x0000217C File Offset: 0x0000037C
		<HelpKeyword("My.WebServices")>
		Friend ReadOnly Property WebServices As MyProject.MyWebServices
			<DebuggerHidden()>
			Get
				Return MyProject.m_MyWebServicesObjectProvider.GetInstance
			End Get
		End Property

		' Token: 0x04000001 RID: 1
		Private m_ComputerObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyComputer) = New MyProject.ThreadSafeObjectProvider(Of MyComputer)()

		' Token: 0x04000002 RID: 2
		Private m_AppObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyApplication) = New MyProject.ThreadSafeObjectProvider(Of MyApplication)()

		' Token: 0x04000003 RID: 3
		Private m_UserObjectProvider As MyProject.ThreadSafeObjectProvider(Of User) = New MyProject.ThreadSafeObjectProvider(Of User)()

		' Token: 0x04000004 RID: 4
		Private m_MyFormsObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyForms)()

		' Token: 0x04000005 RID: 5
		Private m_MyWebServicesObjectProvider As MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices) = New MyProject.ThreadSafeObjectProvider(Of MyProject.MyWebServices)()

		' Token: 0x02000079 RID: 121
		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")>
		Friend NotInheritable Class MyForms
			' Token: 0x06001294 RID: 4756 RVA: 0x000A8040 File Offset: 0x000A6240
			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As{Form, New})(Instance As T) As T
				Dim flag As Boolean = Instance Is Nothing OrElse Instance.IsDisposed
				If flag Then
					Dim flag2 As Boolean = MyProject.MyForms.m_FormBeingCreated IsNot Nothing
					If flag2 Then
						Dim flag3 As Boolean = MyProject.MyForms.m_FormBeingCreated.ContainsKey(GetType(T))
						If flag3 Then
							Throw New InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", New String(-1) {}))
						End If
					Else
						MyProject.MyForms.m_FormBeingCreated = New Hashtable()
					End If
					MyProject.MyForms.m_FormBeingCreated.Add(GetType(T), Nothing)
					Try
						Return Activator.CreateInstance(Of T)()
					Catch ex As TargetInvocationException When ex.InnerException IsNot Nothing
						Dim resourceString As String = Utils.GetResourceString("WinForms_SeeInnerException", New String() { ex.InnerException.Message })
						Throw New InvalidOperationException(resourceString, ex.InnerException)
					Finally
						MyProject.MyForms.m_FormBeingCreated.Remove(GetType(T))
					End Try
				End If
				Return Instance
			End Function

			' Token: 0x06001295 RID: 4757 RVA: 0x000A8168 File Offset: 0x000A6368
			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T As Form)(ByRef instance As T)
				instance.Dispose()
				instance = Nothing
			End Sub

			' Token: 0x06001296 RID: 4758 RVA: 0x000A817F File Offset: 0x000A637F
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub

			' Token: 0x06001297 RID: 4759 RVA: 0x000A818C File Offset: 0x000A638C
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			' Token: 0x06001298 RID: 4760 RVA: 0x000A81AC File Offset: 0x000A63AC
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x06001299 RID: 4761 RVA: 0x000A81C4 File Offset: 0x000A63C4
			<EditorBrowsable(EditorBrowsableState.Never)>
			Friend Function [GetType]() As Type
				Return GetType(MyProject.MyForms)
			End Function

			' Token: 0x0600129A RID: 4762 RVA: 0x000A81E0 File Offset: 0x000A63E0
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x17000742 RID: 1858
			' (get) Token: 0x0600129B RID: 4763 RVA: 0x000A81F8 File Offset: 0x000A63F8
			' (set) Token: 0x060012C8 RID: 4808 RVA: 0x000A86B7 File Offset: 0x000A68B7
			Public Property FormAdmin As FormAdmin
				<DebuggerHidden()>
				Get
					Me.m_FormAdmin = MyProject.MyForms.Create__Instance__(Of FormAdmin)(Me.m_FormAdmin)
					Return Me.m_FormAdmin
				End Get
				<DebuggerHidden()>
				Set(value As FormAdmin)
					If value IsNot Me.m_FormAdmin Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormAdmin)(Me.m_FormAdmin)
					End If
				End Set
			End Property

			' Token: 0x17000743 RID: 1859
			' (get) Token: 0x0600129C RID: 4764 RVA: 0x000A8213 File Offset: 0x000A6413
			' (set) Token: 0x060012C9 RID: 4809 RVA: 0x000A86E3 File Offset: 0x000A68E3
			Public Property FormAntiMalware As FormAntiMalware
				<DebuggerHidden()>
				Get
					Me.m_FormAntiMalware = MyProject.MyForms.Create__Instance__(Of FormAntiMalware)(Me.m_FormAntiMalware)
					Return Me.m_FormAntiMalware
				End Get
				<DebuggerHidden()>
				Set(value As FormAntiMalware)
					If value IsNot Me.m_FormAntiMalware Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormAntiMalware)(Me.m_FormAntiMalware)
					End If
				End Set
			End Property

			' Token: 0x17000744 RID: 1860
			' (get) Token: 0x0600129D RID: 4765 RVA: 0x000A822E File Offset: 0x000A642E
			' (set) Token: 0x060012CA RID: 4810 RVA: 0x000A870F File Offset: 0x000A690F
			Public Property FormCamera As FormCamera
				<DebuggerHidden()>
				Get
					Me.m_FormCamera = MyProject.MyForms.Create__Instance__(Of FormCamera)(Me.m_FormCamera)
					Return Me.m_FormCamera
				End Get
				<DebuggerHidden()>
				Set(value As FormCamera)
					If value IsNot Me.m_FormCamera Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormCamera)(Me.m_FormCamera)
					End If
				End Set
			End Property

			' Token: 0x17000745 RID: 1861
			' (get) Token: 0x0600129E RID: 4766 RVA: 0x000A8249 File Offset: 0x000A6449
			' (set) Token: 0x060012CB RID: 4811 RVA: 0x000A873B File Offset: 0x000A693B
			Public Property FormChat As FormChat
				<DebuggerHidden()>
				Get
					Me.m_FormChat = MyProject.MyForms.Create__Instance__(Of FormChat)(Me.m_FormChat)
					Return Me.m_FormChat
				End Get
				<DebuggerHidden()>
				Set(value As FormChat)
					If value IsNot Me.m_FormChat Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormChat)(Me.m_FormChat)
					End If
				End Set
			End Property

			' Token: 0x17000746 RID: 1862
			' (get) Token: 0x0600129F RID: 4767 RVA: 0x000A8264 File Offset: 0x000A6464
			' (set) Token: 0x060012CC RID: 4812 RVA: 0x000A8767 File Offset: 0x000A6967
			Public Property FormClient As FormClient
				<DebuggerHidden()>
				Get
					Me.m_FormClient = MyProject.MyForms.Create__Instance__(Of FormClient)(Me.m_FormClient)
					Return Me.m_FormClient
				End Get
				<DebuggerHidden()>
				Set(value As FormClient)
					If value IsNot Me.m_FormClient Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormClient)(Me.m_FormClient)
					End If
				End Set
			End Property

			' Token: 0x17000747 RID: 1863
			' (get) Token: 0x060012A0 RID: 4768 RVA: 0x000A827F File Offset: 0x000A647F
			' (set) Token: 0x060012CD RID: 4813 RVA: 0x000A8793 File Offset: 0x000A6993
			Public Property FormClipboard As FormClipboard
				<DebuggerHidden()>
				Get
					Me.m_FormClipboard = MyProject.MyForms.Create__Instance__(Of FormClipboard)(Me.m_FormClipboard)
					Return Me.m_FormClipboard
				End Get
				<DebuggerHidden()>
				Set(value As FormClipboard)
					If value IsNot Me.m_FormClipboard Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormClipboard)(Me.m_FormClipboard)
					End If
				End Set
			End Property

			' Token: 0x17000748 RID: 1864
			' (get) Token: 0x060012A1 RID: 4769 RVA: 0x000A829A File Offset: 0x000A649A
			' (set) Token: 0x060012CE RID: 4814 RVA: 0x000A87BF File Offset: 0x000A69BF
			Public Property FormCMD As FormCMD
				<DebuggerHidden()>
				Get
					Me.m_FormCMD = MyProject.MyForms.Create__Instance__(Of FormCMD)(Me.m_FormCMD)
					Return Me.m_FormCMD
				End Get
				<DebuggerHidden()>
				Set(value As FormCMD)
					If value IsNot Me.m_FormCMD Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormCMD)(Me.m_FormCMD)
					End If
				End Set
			End Property

			' Token: 0x17000749 RID: 1865
			' (get) Token: 0x060012A2 RID: 4770 RVA: 0x000A82B5 File Offset: 0x000A64B5
			' (set) Token: 0x060012CF RID: 4815 RVA: 0x000A87EB File Offset: 0x000A69EB
			Public Property FormCustomOpen As FormCustomOpen
				<DebuggerHidden()>
				Get
					Me.m_FormCustomOpen = MyProject.MyForms.Create__Instance__(Of FormCustomOpen)(Me.m_FormCustomOpen)
					Return Me.m_FormCustomOpen
				End Get
				<DebuggerHidden()>
				Set(value As FormCustomOpen)
					If value IsNot Me.m_FormCustomOpen Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormCustomOpen)(Me.m_FormCustomOpen)
					End If
				End Set
			End Property

			' Token: 0x1700074A RID: 1866
			' (get) Token: 0x060012A3 RID: 4771 RVA: 0x000A82D0 File Offset: 0x000A64D0
			' (set) Token: 0x060012D0 RID: 4816 RVA: 0x000A8817 File Offset: 0x000A6A17
			Public Property FormDDos As FormDDos
				<DebuggerHidden()>
				Get
					Me.m_FormDDos = MyProject.MyForms.Create__Instance__(Of FormDDos)(Me.m_FormDDos)
					Return Me.m_FormDDos
				End Get
				<DebuggerHidden()>
				Set(value As FormDDos)
					If value IsNot Me.m_FormDDos Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormDDos)(Me.m_FormDDos)
					End If
				End Set
			End Property

			' Token: 0x1700074B RID: 1867
			' (get) Token: 0x060012A4 RID: 4772 RVA: 0x000A82EB File Offset: 0x000A64EB
			' (set) Token: 0x060012D1 RID: 4817 RVA: 0x000A8843 File Offset: 0x000A6A43
			Public Property FormDotNetEditor As FormDotNetEditor
				<DebuggerHidden()>
				Get
					Me.m_FormDotNetEditor = MyProject.MyForms.Create__Instance__(Of FormDotNetEditor)(Me.m_FormDotNetEditor)
					Return Me.m_FormDotNetEditor
				End Get
				<DebuggerHidden()>
				Set(value As FormDotNetEditor)
					If value IsNot Me.m_FormDotNetEditor Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormDotNetEditor)(Me.m_FormDotNetEditor)
					End If
				End Set
			End Property

			' Token: 0x1700074C RID: 1868
			' (get) Token: 0x060012A5 RID: 4773 RVA: 0x000A8306 File Offset: 0x000A6506
			' (set) Token: 0x060012D2 RID: 4818 RVA: 0x000A886F File Offset: 0x000A6A6F
			Public Property FormDownloadFile As FormDownloadFile
				<DebuggerHidden()>
				Get
					Me.m_FormDownloadFile = MyProject.MyForms.Create__Instance__(Of FormDownloadFile)(Me.m_FormDownloadFile)
					Return Me.m_FormDownloadFile
				End Get
				<DebuggerHidden()>
				Set(value As FormDownloadFile)
					If value IsNot Me.m_FormDownloadFile Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormDownloadFile)(Me.m_FormDownloadFile)
					End If
				End Set
			End Property

			' Token: 0x1700074D RID: 1869
			' (get) Token: 0x060012A6 RID: 4774 RVA: 0x000A8321 File Offset: 0x000A6521
			' (set) Token: 0x060012D3 RID: 4819 RVA: 0x000A889B File Offset: 0x000A6A9B
			Public Property FormFileManager As FormFileManager
				<DebuggerHidden()>
				Get
					Me.m_FormFileManager = MyProject.MyForms.Create__Instance__(Of FormFileManager)(Me.m_FormFileManager)
					Return Me.m_FormFileManager
				End Get
				<DebuggerHidden()>
				Set(value As FormFileManager)
					If value IsNot Me.m_FormFileManager Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormFileManager)(Me.m_FormFileManager)
					End If
				End Set
			End Property

			' Token: 0x1700074E RID: 1870
			' (get) Token: 0x060012A7 RID: 4775 RVA: 0x000A833C File Offset: 0x000A653C
			' (set) Token: 0x060012D4 RID: 4820 RVA: 0x000A88C7 File Offset: 0x000A6AC7
			Public Property FormFun As FormFun
				<DebuggerHidden()>
				Get
					Me.m_FormFun = MyProject.MyForms.Create__Instance__(Of FormFun)(Me.m_FormFun)
					Return Me.m_FormFun
				End Get
				<DebuggerHidden()>
				Set(value As FormFun)
					If value IsNot Me.m_FormFun Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormFun)(Me.m_FormFun)
					End If
				End Set
			End Property

			' Token: 0x1700074F RID: 1871
			' (get) Token: 0x060012A8 RID: 4776 RVA: 0x000A8357 File Offset: 0x000A6557
			' (set) Token: 0x060012D5 RID: 4821 RVA: 0x000A88F3 File Offset: 0x000A6AF3
			Public Property FormHBrowser As FormHBrowser
				<DebuggerHidden()>
				Get
					Me.m_FormHBrowser = MyProject.MyForms.Create__Instance__(Of FormHBrowser)(Me.m_FormHBrowser)
					Return Me.m_FormHBrowser
				End Get
				<DebuggerHidden()>
				Set(value As FormHBrowser)
					If value IsNot Me.m_FormHBrowser Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormHBrowser)(Me.m_FormHBrowser)
					End If
				End Set
			End Property

			' Token: 0x17000750 RID: 1872
			' (get) Token: 0x060012A9 RID: 4777 RVA: 0x000A8372 File Offset: 0x000A6572
			' (set) Token: 0x060012D6 RID: 4822 RVA: 0x000A891F File Offset: 0x000A6B1F
			Public Property FormHiddenProgram As FormHiddenProgram
				<DebuggerHidden()>
				Get
					Me.m_FormHiddenProgram = MyProject.MyForms.Create__Instance__(Of FormHiddenProgram)(Me.m_FormHiddenProgram)
					Return Me.m_FormHiddenProgram
				End Get
				<DebuggerHidden()>
				Set(value As FormHiddenProgram)
					If value IsNot Me.m_FormHiddenProgram Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormHiddenProgram)(Me.m_FormHiddenProgram)
					End If
				End Set
			End Property

			' Token: 0x17000751 RID: 1873
			' (get) Token: 0x060012AA RID: 4778 RVA: 0x000A838D File Offset: 0x000A658D
			' (set) Token: 0x060012D7 RID: 4823 RVA: 0x000A894B File Offset: 0x000A6B4B
			Public Property FormHosts As FormHosts
				<DebuggerHidden()>
				Get
					Me.m_FormHosts = MyProject.MyForms.Create__Instance__(Of FormHosts)(Me.m_FormHosts)
					Return Me.m_FormHosts
				End Get
				<DebuggerHidden()>
				Set(value As FormHosts)
					If value IsNot Me.m_FormHosts Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormHosts)(Me.m_FormHosts)
					End If
				End Set
			End Property

			' Token: 0x17000752 RID: 1874
			' (get) Token: 0x060012AB RID: 4779 RVA: 0x000A83A8 File Offset: 0x000A65A8
			' (set) Token: 0x060012D8 RID: 4824 RVA: 0x000A8977 File Offset: 0x000A6B77
			Public Property FormHRDP As FormHRDP
				<DebuggerHidden()>
				Get
					Me.m_FormHRDP = MyProject.MyForms.Create__Instance__(Of FormHRDP)(Me.m_FormHRDP)
					Return Me.m_FormHRDP
				End Get
				<DebuggerHidden()>
				Set(value As FormHRDP)
					If value IsNot Me.m_FormHRDP Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormHRDP)(Me.m_FormHRDP)
					End If
				End Set
			End Property

			' Token: 0x17000753 RID: 1875
			' (get) Token: 0x060012AC RID: 4780 RVA: 0x000A83C3 File Offset: 0x000A65C3
			' (set) Token: 0x060012D9 RID: 4825 RVA: 0x000A89A3 File Offset: 0x000A6BA3
			Public Property FormHVNC As FormHVNC
				<DebuggerHidden()>
				Get
					Me.m_FormHVNC = MyProject.MyForms.Create__Instance__(Of FormHVNC)(Me.m_FormHVNC)
					Return Me.m_FormHVNC
				End Get
				<DebuggerHidden()>
				Set(value As FormHVNC)
					If value IsNot Me.m_FormHVNC Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormHVNC)(Me.m_FormHVNC)
					End If
				End Set
			End Property

			' Token: 0x17000754 RID: 1876
			' (get) Token: 0x060012AD RID: 4781 RVA: 0x000A83DE File Offset: 0x000A65DE
			' (set) Token: 0x060012DA RID: 4826 RVA: 0x000A89CF File Offset: 0x000A6BCF
			Public Property FormInformation As FormInformation
				<DebuggerHidden()>
				Get
					Me.m_FormInformation = MyProject.MyForms.Create__Instance__(Of FormInformation)(Me.m_FormInformation)
					Return Me.m_FormInformation
				End Get
				<DebuggerHidden()>
				Set(value As FormInformation)
					If value IsNot Me.m_FormInformation Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormInformation)(Me.m_FormInformation)
					End If
				End Set
			End Property

			' Token: 0x17000755 RID: 1877
			' (get) Token: 0x060012AE RID: 4782 RVA: 0x000A83F9 File Offset: 0x000A65F9
			' (set) Token: 0x060012DB RID: 4827 RVA: 0x000A89FB File Offset: 0x000A6BFB
			Public Property FormInstalledSoftware As FormInstalledSoftware
				<DebuggerHidden()>
				Get
					Me.m_FormInstalledSoftware = MyProject.MyForms.Create__Instance__(Of FormInstalledSoftware)(Me.m_FormInstalledSoftware)
					Return Me.m_FormInstalledSoftware
				End Get
				<DebuggerHidden()>
				Set(value As FormInstalledSoftware)
					If value IsNot Me.m_FormInstalledSoftware Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormInstalledSoftware)(Me.m_FormInstalledSoftware)
					End If
				End Set
			End Property

			' Token: 0x17000756 RID: 1878
			' (get) Token: 0x060012AF RID: 4783 RVA: 0x000A8414 File Offset: 0x000A6614
			' (set) Token: 0x060012DC RID: 4828 RVA: 0x000A8A27 File Offset: 0x000A6C27
			Public Property FormKeylogger As FormKeylogger
				<DebuggerHidden()>
				Get
					Me.m_FormKeylogger = MyProject.MyForms.Create__Instance__(Of FormKeylogger)(Me.m_FormKeylogger)
					Return Me.m_FormKeylogger
				End Get
				<DebuggerHidden()>
				Set(value As FormKeylogger)
					If value IsNot Me.m_FormKeylogger Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormKeylogger)(Me.m_FormKeylogger)
					End If
				End Set
			End Property

			' Token: 0x17000757 RID: 1879
			' (get) Token: 0x060012B0 RID: 4784 RVA: 0x000A842F File Offset: 0x000A662F
			' (set) Token: 0x060012DD RID: 4829 RVA: 0x000A8A53 File Offset: 0x000A6C53
			Public Property FormLogin As FormLogin
				<DebuggerHidden()>
				Get
					Me.m_FormLogin = MyProject.MyForms.Create__Instance__(Of FormLogin)(Me.m_FormLogin)
					Return Me.m_FormLogin
				End Get
				<DebuggerHidden()>
				Set(value As FormLogin)
					If value IsNot Me.m_FormLogin Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormLogin)(Me.m_FormLogin)
					End If
				End Set
			End Property

			' Token: 0x17000758 RID: 1880
			' (get) Token: 0x060012B1 RID: 4785 RVA: 0x000A844A File Offset: 0x000A664A
			' (set) Token: 0x060012DE RID: 4830 RVA: 0x000A8A7F File Offset: 0x000A6C7F
			Public Property FormMessageBox As FormMessageBox
				<DebuggerHidden()>
				Get
					Me.m_FormMessageBox = MyProject.MyForms.Create__Instance__(Of FormMessageBox)(Me.m_FormMessageBox)
					Return Me.m_FormMessageBox
				End Get
				<DebuggerHidden()>
				Set(value As FormMessageBox)
					If value IsNot Me.m_FormMessageBox Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormMessageBox)(Me.m_FormMessageBox)
					End If
				End Set
			End Property

			' Token: 0x17000759 RID: 1881
			' (get) Token: 0x060012B2 RID: 4786 RVA: 0x000A8465 File Offset: 0x000A6665
			' (set) Token: 0x060012DF RID: 4831 RVA: 0x000A8AAB File Offset: 0x000A6CAB
			Public Property FormNote As FormNote
				<DebuggerHidden()>
				Get
					Me.m_FormNote = MyProject.MyForms.Create__Instance__(Of FormNote)(Me.m_FormNote)
					Return Me.m_FormNote
				End Get
				<DebuggerHidden()>
				Set(value As FormNote)
					If value IsNot Me.m_FormNote Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormNote)(Me.m_FormNote)
					End If
				End Set
			End Property

			' Token: 0x1700075A RID: 1882
			' (get) Token: 0x060012B3 RID: 4787 RVA: 0x000A8480 File Offset: 0x000A6680
			' (set) Token: 0x060012E0 RID: 4832 RVA: 0x000A8AD7 File Offset: 0x000A6CD7
			Public Property FormOptions As FormOptions
				<DebuggerHidden()>
				Get
					Me.m_FormOptions = MyProject.MyForms.Create__Instance__(Of FormOptions)(Me.m_FormOptions)
					Return Me.m_FormOptions
				End Get
				<DebuggerHidden()>
				Set(value As FormOptions)
					If value IsNot Me.m_FormOptions Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormOptions)(Me.m_FormOptions)
					End If
				End Set
			End Property

			' Token: 0x1700075B RID: 1883
			' (get) Token: 0x060012B4 RID: 4788 RVA: 0x000A849B File Offset: 0x000A669B
			' (set) Token: 0x060012E1 RID: 4833 RVA: 0x000A8B03 File Offset: 0x000A6D03
			Public Property FormPasswordBrowser As FormPasswordBrowser
				<DebuggerHidden()>
				Get
					Me.m_FormPasswordBrowser = MyProject.MyForms.Create__Instance__(Of FormPasswordBrowser)(Me.m_FormPasswordBrowser)
					Return Me.m_FormPasswordBrowser
				End Get
				<DebuggerHidden()>
				Set(value As FormPasswordBrowser)
					If value IsNot Me.m_FormPasswordBrowser Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormPasswordBrowser)(Me.m_FormPasswordBrowser)
					End If
				End Set
			End Property

			' Token: 0x1700075C RID: 1884
			' (get) Token: 0x060012B5 RID: 4789 RVA: 0x000A84B6 File Offset: 0x000A66B6
			' (set) Token: 0x060012E2 RID: 4834 RVA: 0x000A8B2F File Offset: 0x000A6D2F
			Public Property FormPasswordView As FormPasswordView
				<DebuggerHidden()>
				Get
					Me.m_FormPasswordView = MyProject.MyForms.Create__Instance__(Of FormPasswordView)(Me.m_FormPasswordView)
					Return Me.m_FormPasswordView
				End Get
				<DebuggerHidden()>
				Set(value As FormPasswordView)
					If value IsNot Me.m_FormPasswordView Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormPasswordView)(Me.m_FormPasswordView)
					End If
				End Set
			End Property

			' Token: 0x1700075D RID: 1885
			' (get) Token: 0x060012B6 RID: 4790 RVA: 0x000A84D1 File Offset: 0x000A66D1
			' (set) Token: 0x060012E3 RID: 4835 RVA: 0x000A8B5B File Offset: 0x000A6D5B
			Public Property FormPowerShell As FormPowerShell
				<DebuggerHidden()>
				Get
					Me.m_FormPowerShell = MyProject.MyForms.Create__Instance__(Of FormPowerShell)(Me.m_FormPowerShell)
					Return Me.m_FormPowerShell
				End Get
				<DebuggerHidden()>
				Set(value As FormPowerShell)
					If value IsNot Me.m_FormPowerShell Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormPowerShell)(Me.m_FormPowerShell)
					End If
				End Set
			End Property

			' Token: 0x1700075E RID: 1886
			' (get) Token: 0x060012B7 RID: 4791 RVA: 0x000A84EC File Offset: 0x000A66EC
			' (set) Token: 0x060012E4 RID: 4836 RVA: 0x000A8B87 File Offset: 0x000A6D87
			Public Property FormRansomware As FormRansomware
				<DebuggerHidden()>
				Get
					Me.m_FormRansomware = MyProject.MyForms.Create__Instance__(Of FormRansomware)(Me.m_FormRansomware)
					Return Me.m_FormRansomware
				End Get
				<DebuggerHidden()>
				Set(value As FormRansomware)
					If value IsNot Me.m_FormRansomware Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormRansomware)(Me.m_FormRansomware)
					End If
				End Set
			End Property

			' Token: 0x1700075F RID: 1887
			' (get) Token: 0x060012B8 RID: 4792 RVA: 0x000A8507 File Offset: 0x000A6707
			' (set) Token: 0x060012E5 RID: 4837 RVA: 0x000A8BB3 File Offset: 0x000A6DB3
			Public Property FormRegistryE As FormRegistryE
				<DebuggerHidden()>
				Get
					Me.m_FormRegistryE = MyProject.MyForms.Create__Instance__(Of FormRegistryE)(Me.m_FormRegistryE)
					Return Me.m_FormRegistryE
				End Get
				<DebuggerHidden()>
				Set(value As FormRegistryE)
					If value IsNot Me.m_FormRegistryE Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormRegistryE)(Me.m_FormRegistryE)
					End If
				End Set
			End Property

			' Token: 0x17000760 RID: 1888
			' (get) Token: 0x060012B9 RID: 4793 RVA: 0x000A8522 File Offset: 0x000A6722
			' (set) Token: 0x060012E6 RID: 4838 RVA: 0x000A8BDF File Offset: 0x000A6DDF
			Public Property FormRemoteDesktop As FormRemoteDesktop
				<DebuggerHidden()>
				Get
					Me.m_FormRemoteDesktop = MyProject.MyForms.Create__Instance__(Of FormRemoteDesktop)(Me.m_FormRemoteDesktop)
					Return Me.m_FormRemoteDesktop
				End Get
				<DebuggerHidden()>
				Set(value As FormRemoteDesktop)
					If value IsNot Me.m_FormRemoteDesktop Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormRemoteDesktop)(Me.m_FormRemoteDesktop)
					End If
				End Set
			End Property

			' Token: 0x17000761 RID: 1889
			' (get) Token: 0x060012BA RID: 4794 RVA: 0x000A853D File Offset: 0x000A673D
			' (set) Token: 0x060012E7 RID: 4839 RVA: 0x000A8C0B File Offset: 0x000A6E0B
			Public Property FormReverseProxy As FormReverseProxy
				<DebuggerHidden()>
				Get
					Me.m_FormReverseProxy = MyProject.MyForms.Create__Instance__(Of FormReverseProxy)(Me.m_FormReverseProxy)
					Return Me.m_FormReverseProxy
				End Get
				<DebuggerHidden()>
				Set(value As FormReverseProxy)
					If value IsNot Me.m_FormReverseProxy Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormReverseProxy)(Me.m_FormReverseProxy)
					End If
				End Set
			End Property

			' Token: 0x17000762 RID: 1890
			' (get) Token: 0x060012BB RID: 4795 RVA: 0x000A8558 File Offset: 0x000A6758
			' (set) Token: 0x060012E8 RID: 4840 RVA: 0x000A8C37 File Offset: 0x000A6E37
			Public Property FormS500 As FormS500
				<DebuggerHidden()>
				Get
					Me.m_FormS500 = MyProject.MyForms.Create__Instance__(Of FormS500)(Me.m_FormS500)
					Return Me.m_FormS500
				End Get
				<DebuggerHidden()>
				Set(value As FormS500)
					If value IsNot Me.m_FormS500 Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormS500)(Me.m_FormS500)
					End If
				End Set
			End Property

			' Token: 0x17000763 RID: 1891
			' (get) Token: 0x060012BC RID: 4796 RVA: 0x000A8573 File Offset: 0x000A6773
			' (set) Token: 0x060012E9 RID: 4841 RVA: 0x000A8C63 File Offset: 0x000A6E63
			Public Property FormSC As FormSC
				<DebuggerHidden()>
				Get
					Me.m_FormSC = MyProject.MyForms.Create__Instance__(Of FormSC)(Me.m_FormSC)
					Return Me.m_FormSC
				End Get
				<DebuggerHidden()>
				Set(value As FormSC)
					If value IsNot Me.m_FormSC Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormSC)(Me.m_FormSC)
					End If
				End Set
			End Property

			' Token: 0x17000764 RID: 1892
			' (get) Token: 0x060012BD RID: 4797 RVA: 0x000A858E File Offset: 0x000A678E
			' (set) Token: 0x060012EA RID: 4842 RVA: 0x000A8C8F File Offset: 0x000A6E8F
			Public Property FormSendFile As FormSendFile
				<DebuggerHidden()>
				Get
					Me.m_FormSendFile = MyProject.MyForms.Create__Instance__(Of FormSendFile)(Me.m_FormSendFile)
					Return Me.m_FormSendFile
				End Get
				<DebuggerHidden()>
				Set(value As FormSendFile)
					If value IsNot Me.m_FormSendFile Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormSendFile)(Me.m_FormSendFile)
					End If
				End Set
			End Property

			' Token: 0x17000765 RID: 1893
			' (get) Token: 0x060012BE RID: 4798 RVA: 0x000A85A9 File Offset: 0x000A67A9
			' (set) Token: 0x060012EB RID: 4843 RVA: 0x000A8CBB File Offset: 0x000A6EBB
			Public Property FormServices As FormServices
				<DebuggerHidden()>
				Get
					Me.m_FormServices = MyProject.MyForms.Create__Instance__(Of FormServices)(Me.m_FormServices)
					Return Me.m_FormServices
				End Get
				<DebuggerHidden()>
				Set(value As FormServices)
					If value IsNot Me.m_FormServices Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormServices)(Me.m_FormServices)
					End If
				End Set
			End Property

			' Token: 0x17000766 RID: 1894
			' (get) Token: 0x060012BF RID: 4799 RVA: 0x000A85C4 File Offset: 0x000A67C4
			' (set) Token: 0x060012EC RID: 4844 RVA: 0x000A8CE7 File Offset: 0x000A6EE7
			Public Property FormStartup As FormStartup
				<DebuggerHidden()>
				Get
					Me.m_FormStartup = MyProject.MyForms.Create__Instance__(Of FormStartup)(Me.m_FormStartup)
					Return Me.m_FormStartup
				End Get
				<DebuggerHidden()>
				Set(value As FormStartup)
					If value IsNot Me.m_FormStartup Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormStartup)(Me.m_FormStartup)
					End If
				End Set
			End Property

			' Token: 0x17000767 RID: 1895
			' (get) Token: 0x060012C0 RID: 4800 RVA: 0x000A85DF File Offset: 0x000A67DF
			' (set) Token: 0x060012ED RID: 4845 RVA: 0x000A8D13 File Offset: 0x000A6F13
			Public Property FormTaskManager As FormTaskManager
				<DebuggerHidden()>
				Get
					Me.m_FormTaskManager = MyProject.MyForms.Create__Instance__(Of FormTaskManager)(Me.m_FormTaskManager)
					Return Me.m_FormTaskManager
				End Get
				<DebuggerHidden()>
				Set(value As FormTaskManager)
					If value IsNot Me.m_FormTaskManager Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormTaskManager)(Me.m_FormTaskManager)
					End If
				End Set
			End Property

			' Token: 0x17000768 RID: 1896
			' (get) Token: 0x060012C1 RID: 4801 RVA: 0x000A85FA File Offset: 0x000A67FA
			' (set) Token: 0x060012EE RID: 4846 RVA: 0x000A8D3F File Offset: 0x000A6F3F
			Public Property FormTCPConnection As FormTCPConnection
				<DebuggerHidden()>
				Get
					Me.m_FormTCPConnection = MyProject.MyForms.Create__Instance__(Of FormTCPConnection)(Me.m_FormTCPConnection)
					Return Me.m_FormTCPConnection
				End Get
				<DebuggerHidden()>
				Set(value As FormTCPConnection)
					If value IsNot Me.m_FormTCPConnection Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormTCPConnection)(Me.m_FormTCPConnection)
					End If
				End Set
			End Property

			' Token: 0x17000769 RID: 1897
			' (get) Token: 0x060012C2 RID: 4802 RVA: 0x000A8615 File Offset: 0x000A6815
			' (set) Token: 0x060012EF RID: 4847 RVA: 0x000A8D6B File Offset: 0x000A6F6B
			Public Property FormWiFi As FormWiFi
				<DebuggerHidden()>
				Get
					Me.m_FormWiFi = MyProject.MyForms.Create__Instance__(Of FormWiFi)(Me.m_FormWiFi)
					Return Me.m_FormWiFi
				End Get
				<DebuggerHidden()>
				Set(value As FormWiFi)
					If value IsNot Me.m_FormWiFi Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormWiFi)(Me.m_FormWiFi)
					End If
				End Set
			End Property

			' Token: 0x1700076A RID: 1898
			' (get) Token: 0x060012C3 RID: 4803 RVA: 0x000A8630 File Offset: 0x000A6830
			' (set) Token: 0x060012F0 RID: 4848 RVA: 0x000A8D97 File Offset: 0x000A6F97
			Public Property FormWindowsActive As FormWindowsActive
				<DebuggerHidden()>
				Get
					Me.m_FormWindowsActive = MyProject.MyForms.Create__Instance__(Of FormWindowsActive)(Me.m_FormWindowsActive)
					Return Me.m_FormWindowsActive
				End Get
				<DebuggerHidden()>
				Set(value As FormWindowsActive)
					If value IsNot Me.m_FormWindowsActive Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormWindowsActive)(Me.m_FormWindowsActive)
					End If
				End Set
			End Property

			' Token: 0x1700076B RID: 1899
			' (get) Token: 0x060012C4 RID: 4804 RVA: 0x000A864B File Offset: 0x000A684B
			' (set) Token: 0x060012F1 RID: 4849 RVA: 0x000A8DC3 File Offset: 0x000A6FC3
			Public Property FormXMR As FormXMR
				<DebuggerHidden()>
				Get
					Me.m_FormXMR = MyProject.MyForms.Create__Instance__(Of FormXMR)(Me.m_FormXMR)
					Return Me.m_FormXMR
				End Get
				<DebuggerHidden()>
				Set(value As FormXMR)
					If value IsNot Me.m_FormXMR Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of FormXMR)(Me.m_FormXMR)
					End If
				End Set
			End Property

			' Token: 0x1700076C RID: 1900
			' (get) Token: 0x060012C5 RID: 4805 RVA: 0x000A8666 File Offset: 0x000A6866
			' (set) Token: 0x060012F2 RID: 4850 RVA: 0x000A8DEF File Offset: 0x000A6FEF
			Public Property Microphone As Microphone
				<DebuggerHidden()>
				Get
					Me.m_Microphone = MyProject.MyForms.Create__Instance__(Of Microphone)(Me.m_Microphone)
					Return Me.m_Microphone
				End Get
				<DebuggerHidden()>
				Set(value As Microphone)
					If value IsNot Me.m_Microphone Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of Microphone)(Me.m_Microphone)
					End If
				End Set
			End Property

			' Token: 0x1700076D RID: 1901
			' (get) Token: 0x060012C6 RID: 4806 RVA: 0x000A8681 File Offset: 0x000A6881
			' (set) Token: 0x060012F3 RID: 4851 RVA: 0x000A8E1B File Offset: 0x000A701B
			Public Property ReportWindows As ReportWindows
				<DebuggerHidden()>
				Get
					Me.m_ReportWindows = MyProject.MyForms.Create__Instance__(Of ReportWindows)(Me.m_ReportWindows)
					Return Me.m_ReportWindows
				End Get
				<DebuggerHidden()>
				Set(value As ReportWindows)
					If value IsNot Me.m_ReportWindows Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of ReportWindows)(Me.m_ReportWindows)
					End If
				End Set
			End Property

			' Token: 0x1700076E RID: 1902
			' (get) Token: 0x060012C7 RID: 4807 RVA: 0x000A869C File Offset: 0x000A689C
			' (set) Token: 0x060012F4 RID: 4852 RVA: 0x000A8E47 File Offset: 0x000A7047
			Public Property UploadFromLink As UploadFromLink
				<DebuggerHidden()>
				Get
					Me.m_UploadFromLink = MyProject.MyForms.Create__Instance__(Of UploadFromLink)(Me.m_UploadFromLink)
					Return Me.m_UploadFromLink
				End Get
				<DebuggerHidden()>
				Set(value As UploadFromLink)
					If value IsNot Me.m_UploadFromLink Then
						If value IsNot Nothing Then
							Throw New ArgumentException("Property can only be set to Nothing")
						End If
						Me.Dispose__Instance__(Of UploadFromLink)(Me.m_UploadFromLink)
					End If
				End Set
			End Property

			' Token: 0x04000826 RID: 2086
			<ThreadStatic()>
			Private Shared m_FormBeingCreated As Hashtable

			' Token: 0x04000827 RID: 2087
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormAdmin As FormAdmin

			' Token: 0x04000828 RID: 2088
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormAntiMalware As FormAntiMalware

			' Token: 0x04000829 RID: 2089
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormCamera As FormCamera

			' Token: 0x0400082A RID: 2090
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormChat As FormChat

			' Token: 0x0400082B RID: 2091
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormClient As FormClient

			' Token: 0x0400082C RID: 2092
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormClipboard As FormClipboard

			' Token: 0x0400082D RID: 2093
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormCMD As FormCMD

			' Token: 0x0400082E RID: 2094
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormCustomOpen As FormCustomOpen

			' Token: 0x0400082F RID: 2095
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormDDos As FormDDos

			' Token: 0x04000830 RID: 2096
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormDotNetEditor As FormDotNetEditor

			' Token: 0x04000831 RID: 2097
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormDownloadFile As FormDownloadFile

			' Token: 0x04000832 RID: 2098
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormFileManager As FormFileManager

			' Token: 0x04000833 RID: 2099
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormFun As FormFun

			' Token: 0x04000834 RID: 2100
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormHBrowser As FormHBrowser

			' Token: 0x04000835 RID: 2101
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormHiddenProgram As FormHiddenProgram

			' Token: 0x04000836 RID: 2102
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormHosts As FormHosts

			' Token: 0x04000837 RID: 2103
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormHRDP As FormHRDP

			' Token: 0x04000838 RID: 2104
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormHVNC As FormHVNC

			' Token: 0x04000839 RID: 2105
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormInformation As FormInformation

			' Token: 0x0400083A RID: 2106
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormInstalledSoftware As FormInstalledSoftware

			' Token: 0x0400083B RID: 2107
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormKeylogger As FormKeylogger

			' Token: 0x0400083C RID: 2108
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormLogin As FormLogin

			' Token: 0x0400083D RID: 2109
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormMessageBox As FormMessageBox

			' Token: 0x0400083E RID: 2110
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormNote As FormNote

			' Token: 0x0400083F RID: 2111
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormOptions As FormOptions

			' Token: 0x04000840 RID: 2112
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormPasswordBrowser As FormPasswordBrowser

			' Token: 0x04000841 RID: 2113
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormPasswordView As FormPasswordView

			' Token: 0x04000842 RID: 2114
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormPowerShell As FormPowerShell

			' Token: 0x04000843 RID: 2115
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormRansomware As FormRansomware

			' Token: 0x04000844 RID: 2116
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormRegistryE As FormRegistryE

			' Token: 0x04000845 RID: 2117
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormRemoteDesktop As FormRemoteDesktop

			' Token: 0x04000846 RID: 2118
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormReverseProxy As FormReverseProxy

			' Token: 0x04000847 RID: 2119
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormS500 As FormS500

			' Token: 0x04000848 RID: 2120
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormSC As FormSC

			' Token: 0x04000849 RID: 2121
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormSendFile As FormSendFile

			' Token: 0x0400084A RID: 2122
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormServices As FormServices

			' Token: 0x0400084B RID: 2123
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormStartup As FormStartup

			' Token: 0x0400084C RID: 2124
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormTaskManager As FormTaskManager

			' Token: 0x0400084D RID: 2125
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormTCPConnection As FormTCPConnection

			' Token: 0x0400084E RID: 2126
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormWiFi As FormWiFi

			' Token: 0x0400084F RID: 2127
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormWindowsActive As FormWindowsActive

			' Token: 0x04000850 RID: 2128
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_FormXMR As FormXMR

			' Token: 0x04000851 RID: 2129
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_Microphone As Microphone

			' Token: 0x04000852 RID: 2130
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_ReportWindows As ReportWindows

			' Token: 0x04000853 RID: 2131
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public m_UploadFromLink As UploadFromLink
		End Class

		' Token: 0x0200007A RID: 122
		<EditorBrowsable(EditorBrowsableState.Never)>
		<MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")>
		Friend NotInheritable Class MyWebServices
			' Token: 0x060012F5 RID: 4853 RVA: 0x000A8E74 File Offset: 0x000A7074
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function Equals(o As Object) As Boolean
				Return MyBase.Equals(RuntimeHelpers.GetObjectValue(o))
			End Function

			' Token: 0x060012F6 RID: 4854 RVA: 0x000A8E94 File Offset: 0x000A7094
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function GetHashCode() As Integer
				Return MyBase.GetHashCode()
			End Function

			' Token: 0x060012F7 RID: 4855 RVA: 0x000A8EAC File Offset: 0x000A70AC
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Friend Function [GetType]() As Type
				Return GetType(MyProject.MyWebServices)
			End Function

			' Token: 0x060012F8 RID: 4856 RVA: 0x000A8EC8 File Offset: 0x000A70C8
			<EditorBrowsable(EditorBrowsableState.Never)>
			<DebuggerHidden()>
			Public Overrides Function ToString() As String
				Return MyBase.ToString()
			End Function

			' Token: 0x060012F9 RID: 4857 RVA: 0x000A8EE0 File Offset: 0x000A70E0
			<DebuggerHidden()>
			Private Shared Function Create__Instance__(Of T As New)(instance As T) As T
				Dim flag As Boolean = instance Is Nothing
				Dim result As T
				If flag Then
					result = Activator.CreateInstance(Of T)()
				Else
					result = instance
				End If
				Return result
			End Function

			' Token: 0x060012FA RID: 4858 RVA: 0x000A8F09 File Offset: 0x000A7109
			<DebuggerHidden()>
			Private Sub Dispose__Instance__(Of T)(ByRef instance As T)
				instance = Nothing
			End Sub

			' Token: 0x060012FB RID: 4859 RVA: 0x000A8F13 File Offset: 0x000A7113
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub
		End Class

		' Token: 0x0200007B RID: 123
		<EditorBrowsable(EditorBrowsableState.Never)>
		<ComVisible(False)>
		Friend NotInheritable Class ThreadSafeObjectProvider(Of T As New)
			' Token: 0x1700076F RID: 1903
			' (get) Token: 0x060012FC RID: 4860 RVA: 0x000A8F20 File Offset: 0x000A7120
			Friend ReadOnly Property GetInstance As T
				<DebuggerHidden()>
				Get
					Dim flag As Boolean = MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue Is Nothing
					If flag Then
						MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue = Activator.CreateInstance(Of T)()
					End If
					Return MyProject.ThreadSafeObjectProvider(Of T).m_ThreadStaticValue
				End Get
			End Property

			' Token: 0x060012FD RID: 4861 RVA: 0x000A8F52 File Offset: 0x000A7152
			<DebuggerHidden()>
			<EditorBrowsable(EditorBrowsableState.Never)>
			Public Sub New()
			End Sub

			' Token: 0x04000854 RID: 2132
			<CompilerGenerated()>
			<ThreadStatic()>
			Private Shared m_ThreadStaticValue As T
		End Class
	End Module
End Namespace
