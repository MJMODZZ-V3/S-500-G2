Namespace S500RAT
	' Token: 0x02000077 RID: 119
	<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
	Public Partial Class FormReverseProxy
		Inherits Global.System.Windows.Forms.Form

		' Token: 0x0600123E RID: 4670 RVA: 0x000A3F90 File Offset: 0x000A2190
		<Global.System.Diagnostics.DebuggerNonUserCode()>
		Protected Overrides Sub Dispose(disposing As Boolean)
			Try
				Dim flag As Boolean = disposing AndAlso Me.components IsNot Nothing
				If flag Then
					Me.components.Dispose()
				End If
			Finally
				MyBase.Dispose(disposing)
			End Try
		End Sub

		' Token: 0x0600123F RID: 4671 RVA: 0x000A3FE0 File Offset: 0x000A21E0
		<Global.System.Diagnostics.DebuggerStepThrough()>
		Private Sub InitializeComponent()
			Me.components = New Global.System.ComponentModel.Container()
			Dim componentResourceManager As Global.System.ComponentModel.ComponentResourceManager = New Global.System.ComponentModel.ComponentResourceManager(GetType(Global.S500RAT.FormReverseProxy))
			Me.lstClients = New Global.Gry.Helper.AeroListView()
			Me.ColumnHeader1 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader2 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader3 = New Global.System.Windows.Forms.ColumnHeader()
			Me.ColumnHeader4 = New Global.System.Windows.Forms.ColumnHeader()
			Me.imgFlags = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.PictureBox1 = New Global.System.Windows.Forms.PictureBox()
			Me.State = New Global.Sunny.UI.UILabel()
			Me.Timer1 = New Global.System.Windows.Forms.Timer(Me.components)
			Me.Guna2Elipse2 = New Global.Guna.UI2.WinForms.Guna2Elipse(Me.components)
			Me.ImageList1 = New Global.System.Windows.Forms.ImageList(Me.components)
			Me.Start = New Global.Guna.UI2.WinForms.Guna2GradientButton()
			Me.UiLabel1 = New Global.Sunny.UI.UILabel()
			Me.ClientInfo = New Global.System.Windows.Forms.Label()
			Me.Port = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.ServerPort = New Global.Guna.UI2.WinForms.Guna2TextBox()
			Me.StateConnection = New Global.Sunny.UI.UILabel()
			Me.ID = New Global.Sunny.UI.UILabel()
			Me.ErrorState = New Global.Sunny.UI.UILabel()
			Me.Guna2BorderlessForm1 = New Global.Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
			Me.Mini = New Global.S500RAT.ValleyMini()
			Me.ExitForm = New Global.S500RAT.ValleyClose()
			Me.Guna2DragControl1 = New Global.Guna.UI2.WinForms.Guna2DragControl(Me.components)
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			MyBase.SuspendLayout()
			Me.lstClients.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.lstClients.BackColor = Global.System.Drawing.SystemColors.Control
			Me.lstClients.Columns.AddRange(New Global.System.Windows.Forms.ColumnHeader() { Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4 })
			Me.lstClients.ContextMenuStrip = Me.ContextMenuStrip
			Me.lstClients.FullRowSelect = True
			Me.lstClients.HeaderStyle = Global.System.Windows.Forms.ColumnHeaderStyle.Nonclickable
			Me.lstClients.HideSelection = False
			Me.lstClients.LargeImageList = Me.imgFlags
			Me.lstClients.Location = New Global.System.Drawing.Point(583, 592)
			Me.lstClients.Name = "lstClients"
			Me.lstClients.Size = New Global.System.Drawing.Size(30, 19)
			Me.lstClients.SmallImageList = Me.imgFlags
			Me.lstClients.StateImageList = Me.imgFlags
			Me.lstClients.TabIndex = 1
			Me.lstClients.UseCompatibleStateImageBehavior = False
			Me.lstClients.View = Global.System.Windows.Forms.View.Details
			Me.ColumnHeader1.Width = 161
			Me.ColumnHeader2.Width = 154
			Me.ColumnHeader3.Width = 96
			Me.ColumnHeader4.Width = 159
			Me.imgFlags.ImageStream = CType(componentResourceManager.GetObject("imgFlags.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.imgFlags.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.imgFlags.Images.SetKeyName(0, "ad.png")
			Me.imgFlags.Images.SetKeyName(1, "ae.png")
			Me.imgFlags.Images.SetKeyName(2, "af.png")
			Me.imgFlags.Images.SetKeyName(3, "ag.png")
			Me.imgFlags.Images.SetKeyName(4, "ai.png")
			Me.imgFlags.Images.SetKeyName(5, "al.png")
			Me.imgFlags.Images.SetKeyName(6, "am.png")
			Me.imgFlags.Images.SetKeyName(7, "an.png")
			Me.imgFlags.Images.SetKeyName(8, "ao.png")
			Me.imgFlags.Images.SetKeyName(9, "ar.png")
			Me.imgFlags.Images.SetKeyName(10, "as.png")
			Me.imgFlags.Images.SetKeyName(11, "at.png")
			Me.imgFlags.Images.SetKeyName(12, "au.png")
			Me.imgFlags.Images.SetKeyName(13, "aw.png")
			Me.imgFlags.Images.SetKeyName(14, "ax.png")
			Me.imgFlags.Images.SetKeyName(15, "az.png")
			Me.imgFlags.Images.SetKeyName(16, "ba.png")
			Me.imgFlags.Images.SetKeyName(17, "bb.png")
			Me.imgFlags.Images.SetKeyName(18, "bd.png")
			Me.imgFlags.Images.SetKeyName(19, "be.png")
			Me.imgFlags.Images.SetKeyName(20, "bf.png")
			Me.imgFlags.Images.SetKeyName(21, "bg.png")
			Me.imgFlags.Images.SetKeyName(22, "bh.png")
			Me.imgFlags.Images.SetKeyName(23, "bi.png")
			Me.imgFlags.Images.SetKeyName(24, "bj.png")
			Me.imgFlags.Images.SetKeyName(25, "bm.png")
			Me.imgFlags.Images.SetKeyName(26, "bn.png")
			Me.imgFlags.Images.SetKeyName(27, "bo.png")
			Me.imgFlags.Images.SetKeyName(28, "br.png")
			Me.imgFlags.Images.SetKeyName(29, "bs.png")
			Me.imgFlags.Images.SetKeyName(30, "bt.png")
			Me.imgFlags.Images.SetKeyName(31, "bv.png")
			Me.imgFlags.Images.SetKeyName(32, "bw.png")
			Me.imgFlags.Images.SetKeyName(33, "by.png")
			Me.imgFlags.Images.SetKeyName(34, "bz.png")
			Me.imgFlags.Images.SetKeyName(35, "ca.png")
			Me.imgFlags.Images.SetKeyName(36, "catalonia.png")
			Me.imgFlags.Images.SetKeyName(37, "cc.png")
			Me.imgFlags.Images.SetKeyName(38, "cd.png")
			Me.imgFlags.Images.SetKeyName(39, "cf.png")
			Me.imgFlags.Images.SetKeyName(40, "cg.png")
			Me.imgFlags.Images.SetKeyName(41, "ch.png")
			Me.imgFlags.Images.SetKeyName(42, "ci.png")
			Me.imgFlags.Images.SetKeyName(43, "ck.png")
			Me.imgFlags.Images.SetKeyName(44, "cl.png")
			Me.imgFlags.Images.SetKeyName(45, "cm.png")
			Me.imgFlags.Images.SetKeyName(46, "cn.png")
			Me.imgFlags.Images.SetKeyName(47, "co.png")
			Me.imgFlags.Images.SetKeyName(48, "cr.png")
			Me.imgFlags.Images.SetKeyName(49, "cs.png")
			Me.imgFlags.Images.SetKeyName(50, "cu.png")
			Me.imgFlags.Images.SetKeyName(51, "cv.png")
			Me.imgFlags.Images.SetKeyName(52, "cx.png")
			Me.imgFlags.Images.SetKeyName(53, "cy.png")
			Me.imgFlags.Images.SetKeyName(54, "cz.png")
			Me.imgFlags.Images.SetKeyName(55, "de.png")
			Me.imgFlags.Images.SetKeyName(56, "dj.png")
			Me.imgFlags.Images.SetKeyName(57, "dk.png")
			Me.imgFlags.Images.SetKeyName(58, "dm.png")
			Me.imgFlags.Images.SetKeyName(59, "do.png")
			Me.imgFlags.Images.SetKeyName(60, "dz.png")
			Me.imgFlags.Images.SetKeyName(61, "ec.png")
			Me.imgFlags.Images.SetKeyName(62, "ee.png")
			Me.imgFlags.Images.SetKeyName(63, "eg.png")
			Me.imgFlags.Images.SetKeyName(64, "eh.png")
			Me.imgFlags.Images.SetKeyName(65, "england.png")
			Me.imgFlags.Images.SetKeyName(66, "er.png")
			Me.imgFlags.Images.SetKeyName(67, "es.png")
			Me.imgFlags.Images.SetKeyName(68, "et.png")
			Me.imgFlags.Images.SetKeyName(69, "europeanunion.png")
			Me.imgFlags.Images.SetKeyName(70, "fam.png")
			Me.imgFlags.Images.SetKeyName(71, "fi.png")
			Me.imgFlags.Images.SetKeyName(72, "fj.png")
			Me.imgFlags.Images.SetKeyName(73, "fk.png")
			Me.imgFlags.Images.SetKeyName(74, "fm.png")
			Me.imgFlags.Images.SetKeyName(75, "fo.png")
			Me.imgFlags.Images.SetKeyName(76, "fr.png")
			Me.imgFlags.Images.SetKeyName(77, "ga.png")
			Me.imgFlags.Images.SetKeyName(78, "gb.png")
			Me.imgFlags.Images.SetKeyName(79, "gd.png")
			Me.imgFlags.Images.SetKeyName(80, "ge.png")
			Me.imgFlags.Images.SetKeyName(81, "gf.png")
			Me.imgFlags.Images.SetKeyName(82, "gh.png")
			Me.imgFlags.Images.SetKeyName(83, "gi.png")
			Me.imgFlags.Images.SetKeyName(84, "gl.png")
			Me.imgFlags.Images.SetKeyName(85, "gm.png")
			Me.imgFlags.Images.SetKeyName(86, "gn.png")
			Me.imgFlags.Images.SetKeyName(87, "gp.png")
			Me.imgFlags.Images.SetKeyName(88, "gq.png")
			Me.imgFlags.Images.SetKeyName(89, "gr.png")
			Me.imgFlags.Images.SetKeyName(90, "gs.png")
			Me.imgFlags.Images.SetKeyName(91, "gt.png")
			Me.imgFlags.Images.SetKeyName(92, "gu.png")
			Me.imgFlags.Images.SetKeyName(93, "gw.png")
			Me.imgFlags.Images.SetKeyName(94, "gy.png")
			Me.imgFlags.Images.SetKeyName(95, "hk.png")
			Me.imgFlags.Images.SetKeyName(96, "hm.png")
			Me.imgFlags.Images.SetKeyName(97, "hn.png")
			Me.imgFlags.Images.SetKeyName(98, "hr.png")
			Me.imgFlags.Images.SetKeyName(99, "ht.png")
			Me.imgFlags.Images.SetKeyName(100, "hu.png")
			Me.imgFlags.Images.SetKeyName(101, "id.png")
			Me.imgFlags.Images.SetKeyName(102, "ie.png")
			Me.imgFlags.Images.SetKeyName(103, "il.png")
			Me.imgFlags.Images.SetKeyName(104, "in.png")
			Me.imgFlags.Images.SetKeyName(105, "io.png")
			Me.imgFlags.Images.SetKeyName(106, "iq.png")
			Me.imgFlags.Images.SetKeyName(107, "ir.png")
			Me.imgFlags.Images.SetKeyName(108, "is.png")
			Me.imgFlags.Images.SetKeyName(109, "it.png")
			Me.imgFlags.Images.SetKeyName(110, "jm.png")
			Me.imgFlags.Images.SetKeyName(111, "jo.png")
			Me.imgFlags.Images.SetKeyName(112, "jp.png")
			Me.imgFlags.Images.SetKeyName(113, "ke.png")
			Me.imgFlags.Images.SetKeyName(114, "kg.png")
			Me.imgFlags.Images.SetKeyName(115, "kh.png")
			Me.imgFlags.Images.SetKeyName(116, "ki.png")
			Me.imgFlags.Images.SetKeyName(117, "km.png")
			Me.imgFlags.Images.SetKeyName(118, "kn.png")
			Me.imgFlags.Images.SetKeyName(119, "kp.png")
			Me.imgFlags.Images.SetKeyName(120, "kr.png")
			Me.imgFlags.Images.SetKeyName(121, "kw.png")
			Me.imgFlags.Images.SetKeyName(122, "ky.png")
			Me.imgFlags.Images.SetKeyName(123, "kz.png")
			Me.imgFlags.Images.SetKeyName(124, "la.png")
			Me.imgFlags.Images.SetKeyName(125, "lb.png")
			Me.imgFlags.Images.SetKeyName(126, "lc.png")
			Me.imgFlags.Images.SetKeyName(127, "li.png")
			Me.imgFlags.Images.SetKeyName(128, "lk.png")
			Me.imgFlags.Images.SetKeyName(129, "lr.png")
			Me.imgFlags.Images.SetKeyName(130, "ls.png")
			Me.imgFlags.Images.SetKeyName(131, "lt.png")
			Me.imgFlags.Images.SetKeyName(132, "lu.png")
			Me.imgFlags.Images.SetKeyName(133, "lv.png")
			Me.imgFlags.Images.SetKeyName(134, "ly.png")
			Me.imgFlags.Images.SetKeyName(135, "ma.png")
			Me.imgFlags.Images.SetKeyName(136, "mc.png")
			Me.imgFlags.Images.SetKeyName(137, "md.png")
			Me.imgFlags.Images.SetKeyName(138, "me.png")
			Me.imgFlags.Images.SetKeyName(139, "mg.png")
			Me.imgFlags.Images.SetKeyName(140, "mh.png")
			Me.imgFlags.Images.SetKeyName(141, "mk.png")
			Me.imgFlags.Images.SetKeyName(142, "ml.png")
			Me.imgFlags.Images.SetKeyName(143, "mm.png")
			Me.imgFlags.Images.SetKeyName(144, "mn.png")
			Me.imgFlags.Images.SetKeyName(145, "mo.png")
			Me.imgFlags.Images.SetKeyName(146, "mp.png")
			Me.imgFlags.Images.SetKeyName(147, "mq.png")
			Me.imgFlags.Images.SetKeyName(148, "mr.png")
			Me.imgFlags.Images.SetKeyName(149, "ms.png")
			Me.imgFlags.Images.SetKeyName(150, "mt.png")
			Me.imgFlags.Images.SetKeyName(151, "mu.png")
			Me.imgFlags.Images.SetKeyName(152, "mv.png")
			Me.imgFlags.Images.SetKeyName(153, "mw.png")
			Me.imgFlags.Images.SetKeyName(154, "mx.png")
			Me.imgFlags.Images.SetKeyName(155, "my.png")
			Me.imgFlags.Images.SetKeyName(156, "mz.png")
			Me.imgFlags.Images.SetKeyName(157, "na.png")
			Me.imgFlags.Images.SetKeyName(158, "nc.png")
			Me.imgFlags.Images.SetKeyName(159, "ne.png")
			Me.imgFlags.Images.SetKeyName(160, "nf.png")
			Me.imgFlags.Images.SetKeyName(161, "ng.png")
			Me.imgFlags.Images.SetKeyName(162, "ni.png")
			Me.imgFlags.Images.SetKeyName(163, "nl.png")
			Me.imgFlags.Images.SetKeyName(164, "no.png")
			Me.imgFlags.Images.SetKeyName(165, "np.png")
			Me.imgFlags.Images.SetKeyName(166, "nr.png")
			Me.imgFlags.Images.SetKeyName(167, "nu.png")
			Me.imgFlags.Images.SetKeyName(168, "nz.png")
			Me.imgFlags.Images.SetKeyName(169, "om.png")
			Me.imgFlags.Images.SetKeyName(170, "pa.png")
			Me.imgFlags.Images.SetKeyName(171, "pe.png")
			Me.imgFlags.Images.SetKeyName(172, "pf.png")
			Me.imgFlags.Images.SetKeyName(173, "pg.png")
			Me.imgFlags.Images.SetKeyName(174, "ph.png")
			Me.imgFlags.Images.SetKeyName(175, "pk.png")
			Me.imgFlags.Images.SetKeyName(176, "pl.png")
			Me.imgFlags.Images.SetKeyName(177, "pm.png")
			Me.imgFlags.Images.SetKeyName(178, "pn.png")
			Me.imgFlags.Images.SetKeyName(179, "pr.png")
			Me.imgFlags.Images.SetKeyName(180, "ps.png")
			Me.imgFlags.Images.SetKeyName(181, "pt.png")
			Me.imgFlags.Images.SetKeyName(182, "pw.png")
			Me.imgFlags.Images.SetKeyName(183, "py.png")
			Me.imgFlags.Images.SetKeyName(184, "qa.png")
			Me.imgFlags.Images.SetKeyName(185, "re.png")
			Me.imgFlags.Images.SetKeyName(186, "ro.png")
			Me.imgFlags.Images.SetKeyName(187, "rs.png")
			Me.imgFlags.Images.SetKeyName(188, "ru.png")
			Me.imgFlags.Images.SetKeyName(189, "rw.png")
			Me.imgFlags.Images.SetKeyName(190, "sa.png")
			Me.imgFlags.Images.SetKeyName(191, "sb.png")
			Me.imgFlags.Images.SetKeyName(192, "sc.png")
			Me.imgFlags.Images.SetKeyName(193, "scotland.png")
			Me.imgFlags.Images.SetKeyName(194, "sd.png")
			Me.imgFlags.Images.SetKeyName(195, "se.png")
			Me.imgFlags.Images.SetKeyName(196, "sg.png")
			Me.imgFlags.Images.SetKeyName(197, "sh.png")
			Me.imgFlags.Images.SetKeyName(198, "si.png")
			Me.imgFlags.Images.SetKeyName(199, "sj.png")
			Me.imgFlags.Images.SetKeyName(200, "sk.png")
			Me.imgFlags.Images.SetKeyName(201, "sl.png")
			Me.imgFlags.Images.SetKeyName(202, "sm.png")
			Me.imgFlags.Images.SetKeyName(203, "sn.png")
			Me.imgFlags.Images.SetKeyName(204, "so.png")
			Me.imgFlags.Images.SetKeyName(205, "sr.png")
			Me.imgFlags.Images.SetKeyName(206, "st.png")
			Me.imgFlags.Images.SetKeyName(207, "sv.png")
			Me.imgFlags.Images.SetKeyName(208, "sy.png")
			Me.imgFlags.Images.SetKeyName(209, "sz.png")
			Me.imgFlags.Images.SetKeyName(210, "tc.png")
			Me.imgFlags.Images.SetKeyName(211, "td.png")
			Me.imgFlags.Images.SetKeyName(212, "tf.png")
			Me.imgFlags.Images.SetKeyName(213, "tg.png")
			Me.imgFlags.Images.SetKeyName(214, "th.png")
			Me.imgFlags.Images.SetKeyName(215, "tj.png")
			Me.imgFlags.Images.SetKeyName(216, "tk.png")
			Me.imgFlags.Images.SetKeyName(217, "tl.png")
			Me.imgFlags.Images.SetKeyName(218, "tm.png")
			Me.imgFlags.Images.SetKeyName(219, "tn.png")
			Me.imgFlags.Images.SetKeyName(220, "to.png")
			Me.imgFlags.Images.SetKeyName(221, "tr.png")
			Me.imgFlags.Images.SetKeyName(222, "tt.png")
			Me.imgFlags.Images.SetKeyName(223, "tv.png")
			Me.imgFlags.Images.SetKeyName(224, "tw.png")
			Me.imgFlags.Images.SetKeyName(225, "tz.png")
			Me.imgFlags.Images.SetKeyName(226, "ua.png")
			Me.imgFlags.Images.SetKeyName(227, "ug.png")
			Me.imgFlags.Images.SetKeyName(228, "um.png")
			Me.imgFlags.Images.SetKeyName(229, "us.png")
			Me.imgFlags.Images.SetKeyName(230, "uy.png")
			Me.imgFlags.Images.SetKeyName(231, "uz.png")
			Me.imgFlags.Images.SetKeyName(232, "va.png")
			Me.imgFlags.Images.SetKeyName(233, "vc.png")
			Me.imgFlags.Images.SetKeyName(234, "ve.png")
			Me.imgFlags.Images.SetKeyName(235, "vg.png")
			Me.imgFlags.Images.SetKeyName(236, "vi.png")
			Me.imgFlags.Images.SetKeyName(237, "vn.png")
			Me.imgFlags.Images.SetKeyName(238, "vu.png")
			Me.imgFlags.Images.SetKeyName(239, "wales.png")
			Me.imgFlags.Images.SetKeyName(240, "wf.png")
			Me.imgFlags.Images.SetKeyName(241, "ws.png")
			Me.imgFlags.Images.SetKeyName(242, "ye.png")
			Me.imgFlags.Images.SetKeyName(243, "yt.png")
			Me.imgFlags.Images.SetKeyName(244, "za.png")
			Me.imgFlags.Images.SetKeyName(245, "zm.png")
			Me.imgFlags.Images.SetKeyName(246, "zw.png")
			Me.imgFlags.Images.SetKeyName(247, "xy.png")
			Me.PictureBox1.Anchor = Global.System.Windows.Forms.AnchorStyles.None
			Me.PictureBox1.Image = CType(componentResourceManager.GetObject("PictureBox1.Image"), Global.System.Drawing.Image)
			Me.PictureBox1.Location = New Global.System.Drawing.Point(158, 112)
			Me.PictureBox1.Name = "PictureBox1"
			Me.PictureBox1.Size = New Global.System.Drawing.Size(135, 113)
			Me.PictureBox1.SizeMode = Global.System.Windows.Forms.PictureBoxSizeMode.Zoom
			Me.PictureBox1.TabIndex = 20
			Me.PictureBox1.TabStop = False
			Me.State.Anchor = Global.System.Windows.Forms.AnchorStyles.None
			Me.State.BackColor = Global.System.Drawing.Color.Transparent
			Me.State.Font = New Global.System.Drawing.Font("Microsoft Sans Serif", 12F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.State.ForeColor = Global.System.Drawing.Color.White
			Me.State.Location = New Global.System.Drawing.Point(193, 147)
			Me.State.Name = "State"
			Me.State.Size = New Global.System.Drawing.Size(63, 37)
			Me.State.TabIndex = 458
			Me.State.Text = "0"
			Me.State.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Timer1.Interval = 2000
			Me.Guna2Elipse2.BorderRadius = 20
			Me.ImageList1.ImageStream = CType(componentResourceManager.GetObject("ImageList1.ImageStream"), Global.System.Windows.Forms.ImageListStreamer)
			Me.ImageList1.TransparentColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.ImageList1.Images.SetKeyName(0, "B.png")
			Me.Start.Anchor = (Global.System.Windows.Forms.AnchorStyles.Bottom Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Start.BackColor = Global.System.Drawing.Color.Transparent
			Me.Start.BorderRadius = 8
			Me.Start.CheckedState.Parent = Me.Start
			Me.Start.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Start.CustomImages.Parent = Me.Start
			Me.Start.Enabled = False
			Me.Start.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Start.FillColor2 = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Start.Font = New Global.System.Drawing.Font("Arial", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.Start.ForeColor = Global.System.Drawing.Color.White
			Me.Start.HoverState.Parent = Me.Start
			Me.Start.Location = New Global.System.Drawing.Point(310, 471)
			Me.Start.Name = "Start"
			Me.Start.ShadowDecoration.Parent = Me.Start
			Me.Start.Size = New Global.System.Drawing.Size(147, 31)
			Me.Start.TabIndex = 540
			Me.Start.Text = "Start listening"
			Me.UiLabel1.AutoSize = True
			Me.UiLabel1.BackColor = Global.System.Drawing.Color.Transparent
			Me.UiLabel1.Font = New Global.System.Drawing.Font("Microsoft YaHei", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.UiLabel1.ForeColor = Global.System.Drawing.Color.White
			Me.UiLabel1.Location = New Global.System.Drawing.Point(12, 13)
			Me.UiLabel1.Name = "UiLabel1"
			Me.UiLabel1.Size = New Global.System.Drawing.Size(105, 19)
			Me.UiLabel1.Style = Global.Sunny.UI.UIStyle.Custom
			Me.UiLabel1.TabIndex = 541
			Me.UiLabel1.Text = "Reverse Proxy"
			Me.UiLabel1.TextAlign = Global.System.Drawing.ContentAlignment.MiddleLeft
			Me.ClientInfo.AutoSize = True
			Me.ClientInfo.BackColor = Global.System.Drawing.Color.Transparent
			Me.ClientInfo.Font = New Global.System.Drawing.Font("Microsoft YaHei", 8.25F, Global.System.Drawing.FontStyle.Regular, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ClientInfo.ForeColor = Global.System.Drawing.Color.FromArgb(141, 152, 172)
			Me.ClientInfo.Location = New Global.System.Drawing.Point(13, 39)
			Me.ClientInfo.Name = "ClientInfo"
			Me.ClientInfo.Size = New Global.System.Drawing.Size(200, 16)
			Me.ClientInfo.TabIndex = 542
			Me.ClientInfo.Text = "FC / Desktop_3424 / Windows 10 pro"
			Me.Port.Animated = True
			Me.Port.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.Port.BorderColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Port.BorderRadius = 7
			Me.Port.BorderStyle = Global.System.Drawing.Drawing2D.DashStyle.Custom
			Me.Port.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.Port.DefaultText = "7055"
			Me.Port.DisabledState.BorderColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.Port.DisabledState.FillColor = Global.System.Drawing.Color.FromArgb(226, 226, 226)
			Me.Port.DisabledState.ForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.Port.DisabledState.Parent = Me.Port
			Me.Port.DisabledState.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.Port.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.Port.FocusedState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.Port.FocusedState.Parent = Me.Port
			Me.Port.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.Port.ForeColor = Global.System.Drawing.Color.White
			Me.Port.HoverState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.Port.HoverState.Parent = Me.Port
			Me.Port.Location = New Global.System.Drawing.Point(158, 405)
			Me.Port.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.Port.Name = "Port"
			Me.Port.PasswordChar = vbNullChar
			Me.Port.PlaceholderForeColor = Global.System.Drawing.Color.Gray
			Me.Port.PlaceholderText = "Port"
			Me.Port.SelectedText = ""
			Me.Port.SelectionStart = 4
			Me.Port.ShadowDecoration.Parent = Me.Port
			Me.Port.Size = New Global.System.Drawing.Size(135, 25)
			Me.Port.TabIndex = 549
			Me.Port.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.Port.Visible = False
			Me.ServerPort.Animated = True
			Me.ServerPort.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			Me.ServerPort.BorderColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ServerPort.BorderRadius = 7
			Me.ServerPort.BorderStyle = Global.System.Drawing.Drawing2D.DashStyle.Custom
			Me.ServerPort.Cursor = Global.System.Windows.Forms.Cursors.IBeam
			Me.ServerPort.DefaultText = "4877"
			Me.ServerPort.DisabledState.BorderColor = Global.System.Drawing.Color.FromArgb(208, 208, 208)
			Me.ServerPort.DisabledState.FillColor = Global.System.Drawing.Color.FromArgb(226, 226, 226)
			Me.ServerPort.DisabledState.ForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.ServerPort.DisabledState.Parent = Me.ServerPort
			Me.ServerPort.DisabledState.PlaceholderForeColor = Global.System.Drawing.Color.FromArgb(138, 138, 138)
			Me.ServerPort.FillColor = Global.System.Drawing.Color.FromArgb(26, 31, 55)
			Me.ServerPort.FocusedState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.ServerPort.FocusedState.Parent = Me.ServerPort
			Me.ServerPort.Font = New Global.System.Drawing.Font("Arial", 9.75F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ServerPort.ForeColor = Global.System.Drawing.Color.White
			Me.ServerPort.HoverState.BorderColor = Global.System.Drawing.Color.Magenta
			Me.ServerPort.HoverState.Parent = Me.ServerPort
			Me.ServerPort.Location = New Global.System.Drawing.Point(158, 233)
			Me.ServerPort.Margin = New Global.System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.ServerPort.Name = "ServerPort"
			Me.ServerPort.PasswordChar = vbNullChar
			Me.ServerPort.PlaceholderForeColor = Global.System.Drawing.Color.Gray
			Me.ServerPort.PlaceholderText = "Server Port"
			Me.ServerPort.SelectedText = ""
			Me.ServerPort.SelectionStart = 4
			Me.ServerPort.ShadowDecoration.Parent = Me.ServerPort
			Me.ServerPort.Size = New Global.System.Drawing.Size(135, 25)
			Me.ServerPort.TabIndex = 550
			Me.ServerPort.TextAlign = Global.System.Windows.Forms.HorizontalAlignment.Center
			Me.StateConnection.BackColor = Global.System.Drawing.Color.Transparent
			Me.StateConnection.Font = New Global.System.Drawing.Font("Gadugi", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.StateConnection.ForeColor = Global.System.Drawing.Color.Silver
			Me.StateConnection.Location = New Global.System.Drawing.Point(155, 270)
			Me.StateConnection.Name = "StateConnection"
			Me.StateConnection.Size = New Global.System.Drawing.Size(138, 19)
			Me.StateConnection.TabIndex = 553
			Me.StateConnection.Text = "Not Connected"
			Me.StateConnection.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.ID.BackColor = Global.System.Drawing.Color.Transparent
			Me.ID.Font = New Global.System.Drawing.Font("Nirmala UI", 24F, Global.System.Drawing.FontStyle.Bold, Global.System.Drawing.GraphicsUnit.Point, 0)
			Me.ID.ForeColor = Global.System.Drawing.Color.Red
			Me.ID.Location = New Global.System.Drawing.Point(108, 301)
			Me.ID.Name = "ID"
			Me.ID.Size = New Global.System.Drawing.Size(230, 62)
			Me.ID.TabIndex = 554
			Me.ID.Text = "000.000.000"
			Me.ID.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.ErrorState.BackColor = Global.System.Drawing.Color.Transparent
			Me.ErrorState.Font = New Global.System.Drawing.Font("Gadugi", 8.25F, Global.System.Drawing.FontStyle.Bold)
			Me.ErrorState.ForeColor = Global.System.Drawing.Color.Red
			Me.ErrorState.Location = New Global.System.Drawing.Point(12, 377)
			Me.ErrorState.Name = "ErrorState"
			Me.ErrorState.Size = New Global.System.Drawing.Size(445, 19)
			Me.ErrorState.TabIndex = 555
			Me.ErrorState.TextAlign = Global.System.Drawing.ContentAlignment.MiddleCenter
			Me.Guna2BorderlessForm1.AnimateWindow = True
			Me.Guna2BorderlessForm1.BorderRadius = 40
			Me.Guna2BorderlessForm1.ContainerControl = Me
			Me.Guna2BorderlessForm1.DockIndicatorColor = Global.System.Drawing.Color.FromArgb(56, 37, 200)
			Me.Guna2BorderlessForm1.DragEndTransparencyValue = 0.9
			Me.Guna2BorderlessForm1.DragStartTransparencyValue = 0.55
			Me.Guna2BorderlessForm1.ShadowColor = Global.System.Drawing.Color.FromArgb(56, 37, 200)
			Me.Guna2BorderlessForm1.TransparentWhileDrag = True
			Me.Mini.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.Mini.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.Mini.Location = New Global.System.Drawing.Point(412, 12)
			Me.Mini.Name = "Mini"
			Me.Mini.Size = New Global.System.Drawing.Size(20, 20)
			Me.Mini.TabIndex = 548
			Me.Mini.Text = "ValleyMini1"
			Me.ExitForm.Anchor = (Global.System.Windows.Forms.AnchorStyles.Top Or Global.System.Windows.Forms.AnchorStyles.Right)
			Me.ExitForm.Cursor = Global.System.Windows.Forms.Cursors.Hand
			Me.ExitForm.Location = New Global.System.Drawing.Point(438, 12)
			Me.ExitForm.Name = "ExitForm"
			Me.ExitForm.Size = New Global.System.Drawing.Size(20, 20)
			Me.ExitForm.TabIndex = 546
			Me.ExitForm.Text = "ValleyClose1"
			Me.Guna2DragControl1.ContainerControl = Me
			Me.Guna2DragControl1.DockForm = True
			Me.Guna2DragControl1.DockIndicatorColor = Global.System.Drawing.Color.FromArgb(56, 37, 200)
			Me.Guna2DragControl1.DragEndTransparencyValue = 0.9
			Me.Guna2DragControl1.DragMode = Global.Guna.UI2.WinForms.Enums.DragMode.Control
			Me.Guna2DragControl1.DragStartTransparencyValue = 0.55
			Me.Guna2DragControl1.TargetControl = Me
			Me.Guna2DragControl1.TransparentWhileDrag = True
			Me.Guna2DragControl1.UseTransparentDrag = True
			MyBase.AutoScaleDimensions = New Global.System.Drawing.SizeF(96F, 96F)
			MyBase.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Dpi
			Me.BackColor = Global.System.Drawing.Color.FromArgb(7, 11, 41)
			MyBase.ClientSize = New Global.System.Drawing.Size(469, 514)
			MyBase.Controls.Add(Me.ErrorState)
			MyBase.Controls.Add(Me.ID)
			MyBase.Controls.Add(Me.StateConnection)
			MyBase.Controls.Add(Me.ServerPort)
			MyBase.Controls.Add(Me.Port)
			MyBase.Controls.Add(Me.Mini)
			MyBase.Controls.Add(Me.ExitForm)
			MyBase.Controls.Add(Me.UiLabel1)
			MyBase.Controls.Add(Me.ClientInfo)
			MyBase.Controls.Add(Me.Start)
			MyBase.Controls.Add(Me.State)
			MyBase.Controls.Add(Me.PictureBox1)
			MyBase.Controls.Add(Me.lstClients)
			MyBase.FormBorderStyle = Global.System.Windows.Forms.FormBorderStyle.None
			MyBase.Icon = CType(componentResourceManager.GetObject("$this.Icon"), Global.System.Drawing.Icon)
			MyBase.Name = "FormReverseProxy"
			Me.Text = "FormProxy"
			MyBase.TopMost = True
			CType(Me.PictureBox1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			MyBase.ResumeLayout(False)
			MyBase.PerformLayout()
		End Sub

		' Token: 0x040007FB RID: 2043
		Private components As Global.System.ComponentModel.IContainer
	End Class
End Namespace
