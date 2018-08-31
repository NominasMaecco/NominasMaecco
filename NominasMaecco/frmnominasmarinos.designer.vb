<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmnominasmarinos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlCatalogo = New System.Windows.Forms.Panel()
        Me.cboTipoNomina = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboserie = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkgrupo = New System.Windows.Forms.CheckBox()
        Me.chkinter = New System.Windows.Forms.CheckBox()
        Me.cbobancos = New System.Windows.Forms.ComboBox()
        Me.chkSindicato = New System.Windows.Forms.CheckBox()
        Me.chkAll = New System.Windows.Forms.CheckBox()
        Me.cmdlayouts = New System.Windows.Forms.Button()
        Me.dtgDatos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboperiodo = New System.Windows.Forms.ComboBox()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.pnlProgreso = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pgbProgreso = New System.Windows.Forms.ProgressBar()
        Me.cMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarDeLaListaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarTrabajadoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.reporteSindicato = New System.Windows.Forms.Button()
        Me.layoutTimbrado = New System.Windows.Forms.Button()
        Me.cmdexcel = New System.Windows.Forms.Button()
        Me.cmdPersonalNomina = New System.Windows.Forms.Button()
        Me.cmdSindicatoTodos = New System.Windows.Forms.Button()
        Me.cmdEmpleados = New System.Windows.Forms.Button()
        Me.cmdSindicato = New System.Windows.Forms.Button()
        Me.cmdreiniciar = New System.Windows.Forms.Button()
        Me.cmdincidencias = New System.Windows.Forms.Button()
        Me.cmdrecibosA = New System.Windows.Forms.Button()
        Me.cmdguardarfinal = New System.Windows.Forms.Button()
        Me.cmdguardarnomina = New System.Windows.Forms.Button()
        Me.cmdcalcular = New System.Windows.Forms.Button()
        Me.cmdverdatos = New System.Windows.Forms.Button()
        Me.pnlCatalogo.SuspendLayout()
        CType(Me.dtgDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProgreso.SuspendLayout()
        Me.cMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCatalogo
        '
        Me.pnlCatalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCatalogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlCatalogo.Controls.Add(Me.cmdexcel)
        Me.pnlCatalogo.Controls.Add(Me.cmdPersonalNomina)
        Me.pnlCatalogo.Controls.Add(Me.cmdSindicatoTodos)
        Me.pnlCatalogo.Controls.Add(Me.cmdEmpleados)
        Me.pnlCatalogo.Controls.Add(Me.cmdSindicato)
        Me.pnlCatalogo.Controls.Add(Me.cboTipoNomina)
        Me.pnlCatalogo.Controls.Add(Me.Label4)
        Me.pnlCatalogo.Controls.Add(Me.cboserie)
        Me.pnlCatalogo.Controls.Add(Me.Label3)
        Me.pnlCatalogo.Controls.Add(Me.chkgrupo)
        Me.pnlCatalogo.Controls.Add(Me.chkinter)
        Me.pnlCatalogo.Controls.Add(Me.cbobancos)
        Me.pnlCatalogo.Controls.Add(Me.chkSindicato)
        Me.pnlCatalogo.Controls.Add(Me.chkAll)
        Me.pnlCatalogo.Controls.Add(Me.cmdreiniciar)
        Me.pnlCatalogo.Controls.Add(Me.cmdincidencias)
        Me.pnlCatalogo.Controls.Add(Me.cmdlayouts)
        Me.pnlCatalogo.Controls.Add(Me.cmdrecibosA)
        Me.pnlCatalogo.Controls.Add(Me.cmdguardarfinal)
        Me.pnlCatalogo.Controls.Add(Me.cmdguardarnomina)
        Me.pnlCatalogo.Controls.Add(Me.cmdcalcular)
        Me.pnlCatalogo.Controls.Add(Me.dtgDatos)
        Me.pnlCatalogo.Controls.Add(Me.cmdverdatos)
        Me.pnlCatalogo.Controls.Add(Me.Label1)
        Me.pnlCatalogo.Controls.Add(Me.cboperiodo)
        Me.pnlCatalogo.Location = New System.Drawing.Point(0, 1)
        Me.pnlCatalogo.Name = "pnlCatalogo"
        Me.pnlCatalogo.Size = New System.Drawing.Size(1357, 481)
        Me.pnlCatalogo.TabIndex = 26
        '
        'cboTipoNomina
        '
        Me.cboTipoNomina.FormattingEnabled = True
        Me.cboTipoNomina.Items.AddRange(New Object() {"Abordo", "Descanso"})
        Me.cboTipoNomina.Location = New System.Drawing.Point(151, 34)
        Me.cboTipoNomina.Name = "cboTipoNomina"
        Me.cboTipoNomina.Size = New System.Drawing.Size(134, 27)
        Me.cboTipoNomina.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(109, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 19)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Tipo:"
        '
        'cboserie
        '
        Me.cboserie.FormattingEnabled = True
        Me.cboserie.Items.AddRange(New Object() {"A", "B", "C", "D", "E"})
        Me.cboserie.Location = New System.Drawing.Point(47, 34)
        Me.cboserie.Name = "cboserie"
        Me.cboserie.Size = New System.Drawing.Size(59, 27)
        Me.cboserie.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 19)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Serie:"
        '
        'chkgrupo
        '
        Me.chkgrupo.AutoSize = True
        Me.chkgrupo.BackColor = System.Drawing.Color.Transparent
        Me.chkgrupo.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkgrupo.Location = New System.Drawing.Point(871, 85)
        Me.chkgrupo.Name = "chkgrupo"
        Me.chkgrupo.Size = New System.Drawing.Size(65, 22)
        Me.chkgrupo.TabIndex = 19
        Me.chkgrupo.Text = "Grupo"
        Me.chkgrupo.UseVisualStyleBackColor = False
        '
        'chkinter
        '
        Me.chkinter.AutoSize = True
        Me.chkinter.BackColor = System.Drawing.Color.Transparent
        Me.chkinter.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkinter.Location = New System.Drawing.Point(426, 86)
        Me.chkinter.Name = "chkinter"
        Me.chkinter.Size = New System.Drawing.Size(110, 22)
        Me.chkinter.TabIndex = 18
        Me.chkinter.Text = "Interbancario"
        Me.chkinter.UseVisualStyleBackColor = False
        '
        'cbobancos
        '
        Me.cbobancos.FormattingEnabled = True
        Me.cbobancos.Location = New System.Drawing.Point(541, 82)
        Me.cbobancos.Name = "cbobancos"
        Me.cbobancos.Size = New System.Drawing.Size(252, 27)
        Me.cbobancos.TabIndex = 17
        '
        'chkSindicato
        '
        Me.chkSindicato.AutoSize = True
        Me.chkSindicato.BackColor = System.Drawing.Color.Transparent
        Me.chkSindicato.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSindicato.Location = New System.Drawing.Point(343, 86)
        Me.chkSindicato.Name = "chkSindicato"
        Me.chkSindicato.Size = New System.Drawing.Size(84, 22)
        Me.chkSindicato.TabIndex = 16
        Me.chkSindicato.Text = "Sindicato"
        Me.chkSindicato.UseVisualStyleBackColor = False
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.BackColor = System.Drawing.Color.Transparent
        Me.chkAll.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAll.Location = New System.Drawing.Point(59, 85)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(107, 22)
        Me.chkAll.TabIndex = 15
        Me.chkAll.Text = "Marcar todos"
        Me.chkAll.UseVisualStyleBackColor = False
        '
        'cmdlayouts
        '
        Me.cmdlayouts.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdlayouts.Location = New System.Drawing.Point(799, 83)
        Me.cmdlayouts.Name = "cmdlayouts"
        Me.cmdlayouts.Size = New System.Drawing.Size(66, 27)
        Me.cmdlayouts.TabIndex = 11
        Me.cmdlayouts.Text = "Layout"
        Me.cmdlayouts.UseVisualStyleBackColor = True
        '
        'dtgDatos
        '
        Me.dtgDatos.AllowUserToAddRows = False
        Me.dtgDatos.AllowUserToDeleteRows = False
        Me.dtgDatos.AllowUserToOrderColumns = True
        Me.dtgDatos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDatos.Location = New System.Drawing.Point(1, 128)
        Me.dtgDatos.Name = "dtgDatos"
        Me.dtgDatos.Size = New System.Drawing.Size(1349, 346)
        Me.dtgDatos.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Periodo:"
        '
        'cboperiodo
        '
        Me.cboperiodo.FormattingEnabled = True
        Me.cboperiodo.Location = New System.Drawing.Point(73, 3)
        Me.cboperiodo.Name = "cboperiodo"
        Me.cboperiodo.Size = New System.Drawing.Size(212, 27)
        Me.cboperiodo.TabIndex = 3
        '
        'btnReporte
        '
        Me.btnReporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnReporte.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte.Location = New System.Drawing.Point(11, 493)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(130, 28)
        Me.btnReporte.TabIndex = 24
        Me.btnReporte.Text = "Reporte Contador"
        Me.btnReporte.UseVisualStyleBackColor = True
        '
        'pnlProgreso
        '
        Me.pnlProgreso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pnlProgreso.Controls.Add(Me.Label2)
        Me.pnlProgreso.Controls.Add(Me.pgbProgreso)
        Me.pnlProgreso.Location = New System.Drawing.Point(454, 224)
        Me.pnlProgreso.Name = "pnlProgreso"
        Me.pnlProgreso.Size = New System.Drawing.Size(449, 84)
        Me.pnlProgreso.TabIndex = 27
        Me.pnlProgreso.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Procesando..."
        '
        'pgbProgreso
        '
        Me.pgbProgreso.Location = New System.Drawing.Point(17, 12)
        Me.pgbProgreso.Name = "pgbProgreso"
        Me.pgbProgreso.Size = New System.Drawing.Size(413, 30)
        Me.pgbProgreso.TabIndex = 0
        '
        'cMenu
        '
        Me.cMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarDeLaListaToolStripMenuItem, Me.AgregarTrabajadoresToolStripMenuItem, Me.EditarEmpleadoToolStripMenuItem})
        Me.cMenu.Name = "cMenu"
        Me.cMenu.Size = New System.Drawing.Size(187, 70)
        '
        'EliminarDeLaListaToolStripMenuItem
        '
        Me.EliminarDeLaListaToolStripMenuItem.Name = "EliminarDeLaListaToolStripMenuItem"
        Me.EliminarDeLaListaToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.EliminarDeLaListaToolStripMenuItem.Text = "Eliminar de la Lista"
        '
        'AgregarTrabajadoresToolStripMenuItem
        '
        Me.AgregarTrabajadoresToolStripMenuItem.Name = "AgregarTrabajadoresToolStripMenuItem"
        Me.AgregarTrabajadoresToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.AgregarTrabajadoresToolStripMenuItem.Text = "Agregar Trabajadores"
        '
        'EditarEmpleadoToolStripMenuItem
        '
        Me.EditarEmpleadoToolStripMenuItem.Name = "EditarEmpleadoToolStripMenuItem"
        Me.EditarEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.EditarEmpleadoToolStripMenuItem.Text = "Editar Empleado"
        '
        'reporteSindicato
        '
        Me.reporteSindicato.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.reporteSindicato.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reporteSindicato.Location = New System.Drawing.Point(147, 493)
        Me.reporteSindicato.Name = "reporteSindicato"
        Me.reporteSindicato.Size = New System.Drawing.Size(130, 28)
        Me.reporteSindicato.TabIndex = 25
        Me.reporteSindicato.Text = "Reporte Sindicato"
        Me.reporteSindicato.UseVisualStyleBackColor = True
        '
        'layoutTimbrado
        '
        Me.layoutTimbrado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.layoutTimbrado.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.layoutTimbrado.Location = New System.Drawing.Point(283, 493)
        Me.layoutTimbrado.Name = "layoutTimbrado"
        Me.layoutTimbrado.Size = New System.Drawing.Size(130, 28)
        Me.layoutTimbrado.TabIndex = 28
        Me.layoutTimbrado.Text = "Layout Timbrado"
        Me.layoutTimbrado.UseVisualStyleBackColor = True
        '
        'cmdexcel
        '
        Me.cmdexcel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexcel.Image = Global.NominasMaecco.My.Resources.Resources.if_excel_2726972
        Me.cmdexcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdexcel.Location = New System.Drawing.Point(871, 3)
        Me.cmdexcel.Name = "cmdexcel"
        Me.cmdexcel.Size = New System.Drawing.Size(93, 58)
        Me.cmdexcel.TabIndex = 29
        Me.cmdexcel.Text = "Enviar a Excel"
        Me.cmdexcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdexcel.UseVisualStyleBackColor = True
        '
        'cmdPersonalNomina
        '
        Me.cmdPersonalNomina.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPersonalNomina.Image = Global.NominasMaecco.My.Resources.Resources.if_rotation_job_seeker_employee_unemployee_work_2620504
        Me.cmdPersonalNomina.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPersonalNomina.Location = New System.Drawing.Point(1177, 3)
        Me.cmdPersonalNomina.Name = "cmdPersonalNomina"
        Me.cmdPersonalNomina.Size = New System.Drawing.Size(111, 57)
        Me.cmdPersonalNomina.TabIndex = 28
        Me.cmdPersonalNomina.Text = "Personal nomina"
        Me.cmdPersonalNomina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPersonalNomina.UseVisualStyleBackColor = True
        '
        'cmdSindicatoTodos
        '
        Me.cmdSindicatoTodos.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSindicatoTodos.Image = Global.NominasMaecco.My.Resources.Resources.if_icon_68_667365
        Me.cmdSindicatoTodos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSindicatoTodos.Location = New System.Drawing.Point(805, 3)
        Me.cmdSindicatoTodos.Name = "cmdSindicatoTodos"
        Me.cmdSindicatoTodos.Size = New System.Drawing.Size(67, 57)
        Me.cmdSindicatoTodos.TabIndex = 27
        Me.cmdSindicatoTodos.Text = "Sindicato"
        Me.cmdSindicatoTodos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSindicatoTodos.UseVisualStyleBackColor = True
        '
        'cmdEmpleados
        '
        Me.cmdEmpleados.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEmpleados.Image = Global.NominasMaecco.My.Resources.Resources.if_personal_14472
        Me.cmdEmpleados.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdEmpleados.Location = New System.Drawing.Point(566, 3)
        Me.cmdEmpleados.Name = "cmdEmpleados"
        Me.cmdEmpleados.Size = New System.Drawing.Size(75, 57)
        Me.cmdEmpleados.TabIndex = 26
        Me.cmdEmpleados.Text = "Empleados"
        Me.cmdEmpleados.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdEmpleados.UseVisualStyleBackColor = True
        '
        'cmdSindicato
        '
        Me.cmdSindicato.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSindicato.Image = Global.NominasMaecco.My.Resources.Resources.if_receipt_35832722
        Me.cmdSindicato.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdSindicato.Location = New System.Drawing.Point(639, 3)
        Me.cmdSindicato.Name = "cmdSindicato"
        Me.cmdSindicato.Size = New System.Drawing.Size(92, 57)
        Me.cmdSindicato.TabIndex = 25
        Me.cmdSindicato.Text = "Sindicato XT"
        Me.cmdSindicato.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSindicato.UseVisualStyleBackColor = True
        '
        'cmdreiniciar
        '
        Me.cmdreiniciar.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdreiniciar.Image = Global.NominasMaecco.My.Resources.Resources.if_rebuild_18879
        Me.cmdreiniciar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdreiniciar.Location = New System.Drawing.Point(1068, 3)
        Me.cmdreiniciar.Name = "cmdreiniciar"
        Me.cmdreiniciar.Size = New System.Drawing.Size(111, 57)
        Me.cmdreiniciar.TabIndex = 14
        Me.cmdreiniciar.Text = "Reiniciar Nomina"
        Me.cmdreiniciar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdreiniciar.UseVisualStyleBackColor = True
        '
        'cmdincidencias
        '
        Me.cmdincidencias.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdincidencias.Image = Global.NominasMaecco.My.Resources.Resources.if_data_filter_5327751
        Me.cmdincidencias.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdincidencias.Location = New System.Drawing.Point(961, 3)
        Me.cmdincidencias.Name = "cmdincidencias"
        Me.cmdincidencias.Size = New System.Drawing.Size(111, 57)
        Me.cmdincidencias.TabIndex = 13
        Me.cmdincidencias.Text = "Excel Incidencias"
        Me.cmdincidencias.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdincidencias.UseVisualStyleBackColor = True
        '
        'cmdrecibosA
        '
        Me.cmdrecibosA.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdrecibosA.Image = Global.NominasMaecco.My.Resources.Resources.if_receipt_33390342
        Me.cmdrecibosA.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdrecibosA.Location = New System.Drawing.Point(729, 3)
        Me.cmdrecibosA.Name = "cmdrecibosA"
        Me.cmdrecibosA.Size = New System.Drawing.Size(78, 57)
        Me.cmdrecibosA.TabIndex = 10
        Me.cmdrecibosA.Text = "Simple XT"
        Me.cmdrecibosA.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdrecibosA.UseVisualStyleBackColor = True
        '
        'cmdguardarfinal
        '
        Me.cmdguardarfinal.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdguardarfinal.Image = Global.NominasMaecco.My.Resources.Resources.if_document_save_118916
        Me.cmdguardarfinal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdguardarfinal.Location = New System.Drawing.Point(476, 3)
        Me.cmdguardarfinal.Name = "cmdguardarfinal"
        Me.cmdguardarfinal.Size = New System.Drawing.Size(92, 57)
        Me.cmdguardarfinal.TabIndex = 9
        Me.cmdguardarfinal.Text = "Guardar Final"
        Me.cmdguardarfinal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdguardarfinal.UseVisualStyleBackColor = True
        '
        'cmdguardarnomina
        '
        Me.cmdguardarnomina.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdguardarnomina.Image = Global.NominasMaecco.My.Resources.Resources.if_floppy_disk_save_1038632
        Me.cmdguardarnomina.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdguardarnomina.Location = New System.Drawing.Point(415, 3)
        Me.cmdguardarnomina.Name = "cmdguardarnomina"
        Me.cmdguardarnomina.Size = New System.Drawing.Size(63, 57)
        Me.cmdguardarnomina.TabIndex = 8
        Me.cmdguardarnomina.Text = "Guardar"
        Me.cmdguardarnomina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdguardarnomina.UseVisualStyleBackColor = True
        '
        'cmdcalcular
        '
        Me.cmdcalcular.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcalcular.Image = Global.NominasMaecco.My.Resources.Resources.if_calculator_10551023
        Me.cmdcalcular.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdcalcular.Location = New System.Drawing.Point(355, 3)
        Me.cmdcalcular.Name = "cmdcalcular"
        Me.cmdcalcular.Size = New System.Drawing.Size(63, 57)
        Me.cmdcalcular.TabIndex = 7
        Me.cmdcalcular.Text = "Calcular"
        Me.cmdcalcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdcalcular.UseVisualStyleBackColor = True
        '
        'cmdverdatos
        '
        Me.cmdverdatos.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdverdatos.Image = Global.NominasMaecco.My.Resources.Resources.if_magnifier_data_5327582
        Me.cmdverdatos.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdverdatos.Location = New System.Drawing.Point(290, 3)
        Me.cmdverdatos.Name = "cmdverdatos"
        Me.cmdverdatos.Size = New System.Drawing.Size(71, 57)
        Me.cmdverdatos.TabIndex = 5
        Me.cmdverdatos.Text = "Ver datos"
        Me.cmdverdatos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdverdatos.UseVisualStyleBackColor = True
        '
        'frmnominasmarinos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1357, 533)
        Me.Controls.Add(Me.layoutTimbrado)
        Me.Controls.Add(Me.reporteSindicato)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.pnlProgreso)
        Me.Controls.Add(Me.pnlCatalogo)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmnominasmarinos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nomina Maecco"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlCatalogo.ResumeLayout(False)
        Me.pnlCatalogo.PerformLayout()
        CType(Me.dtgDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProgreso.ResumeLayout(False)
        Me.pnlProgreso.PerformLayout()
        Me.cMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlCatalogo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cboperiodo As ComboBox
    Friend WithEvents dtgDatos As DataGridView
    Friend WithEvents cmdverdatos As Button
    Friend WithEvents cmdrecibosA As Button
    Friend WithEvents cmdguardarfinal As Button
    Friend WithEvents cmdguardarnomina As Button
    Friend WithEvents cmdcalcular As Button
    Friend WithEvents cmdlayouts As Button
    Friend WithEvents pnlProgreso As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdincidencias As Button
    Friend WithEvents cmdreiniciar As Button
    Friend WithEvents chkAll As CheckBox
    Friend WithEvents cbobancos As ComboBox
    Friend WithEvents chkSindicato As CheckBox
    Friend WithEvents chkinter As CheckBox
    Friend WithEvents chkgrupo As CheckBox
    Friend WithEvents cboserie As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EliminarDeLaListaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarEmpleadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarTrabajadoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cboTipoNomina As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents pgbProgreso As System.Windows.Forms.ProgressBar
    Friend WithEvents btnReporte As System.Windows.Forms.Button

    Friend WithEvents reporteSindicato As System.Windows.Forms.Button
    Friend WithEvents layoutTimbrado As System.Windows.Forms.Button

    Friend WithEvents cmdEmpleados As System.Windows.Forms.Button
    Friend WithEvents cmdSindicato As System.Windows.Forms.Button
    Friend WithEvents cmdSindicatoTodos As System.Windows.Forms.Button
    Friend WithEvents cmdPersonalNomina As System.Windows.Forms.Button
    Friend WithEvents cmdexcel As System.Windows.Forms.Button

End Class
