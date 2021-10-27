
namespace WindowsFormsControlLibrary1
{
    partial class DlgProyectoFinal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DlgProyectoFinal));
            this.MstPrincipal = new System.Windows.Forms.MenuStrip();
            this.MitArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.MitNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.MitGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.MitEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.MitVer = new System.Windows.Forms.ToolStripMenuItem();
            this.MitAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.SstEstado = new System.Windows.Forms.StatusStrip();
            this.TsslProyecto = new System.Windows.Forms.ToolStripStatusLabel();
            this.TstPrincipal = new System.Windows.Forms.ToolStrip();
            this.TsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.Tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.Tss2 = new System.Windows.Forms.ToolStripSeparator();
            this.TsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.Tss3 = new System.Windows.Forms.ToolStripSeparator();
            this.TsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.Tss4 = new System.Windows.Forms.ToolStripSeparator();
            this.PnlFotografia = new System.Windows.Forms.Panel();
            this.TbcPrincipal = new System.Windows.Forms.TabControl();
            this.TpgClientes = new System.Windows.Forms.TabPage();
            this.BtnGeneraArchivo = new System.Windows.Forms.Button();
            this.LblEstadoCivil = new System.Windows.Forms.Label();
            this.CbxEstadoCivil = new System.Windows.Forms.ComboBox();
            this.TbxLugarProcedencia = new System.Windows.Forms.TextBox();
            this.LblLugarProcedencia = new System.Windows.Forms.Label();
            this.TbxFechaNacimiento = new System.Windows.Forms.TextBox();
            this.LblFechaNacimiento = new System.Windows.Forms.Label();
            this.TbxCodigo = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.TbxApellidoM = new System.Windows.Forms.TextBox();
            this.TbxCorreo = new System.Windows.Forms.TextBox();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.TbxTelefonoMovil = new System.Windows.Forms.TextBox();
            this.LblTelefonoMovil = new System.Windows.Forms.Label();
            this.LblApellidoM = new System.Windows.Forms.Label();
            this.TbxApellidoP = new System.Windows.Forms.TextBox();
            this.LblApellidoP = new System.Windows.Forms.Label();
            this.TbxNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.PbxFondoClientes = new System.Windows.Forms.PictureBox();
            this.TpgReservaciones = new System.Windows.Forms.TabPage();
            this.BtnDibujarPoligono = new System.Windows.Forms.Button();
            this.BtnDibujarRectangulo = new System.Windows.Forms.Button();
            this.BtnDibujarCirculo = new System.Windows.Forms.Button();
            this.BtnDibujarCuadrado = new System.Windows.Forms.Button();
            this.PbxFondoReservaciones = new System.Windows.Forms.PictureBox();
            this.TpgInventario = new System.Windows.Forms.TabPage();
            this.BtnGeneraKML = new System.Windows.Forms.Button();
            this.TbxLugar = new System.Windows.Forms.TextBox();
            this.LblLugar = new System.Windows.Forms.Label();
            this.TbxLongitud = new System.Windows.Forms.TextBox();
            this.LblLongitud = new System.Windows.Forms.Label();
            this.TbxLatitud = new System.Windows.Forms.TextBox();
            this.LblLatitud = new System.Windows.Forms.Label();
            this.TbxDescripcion = new System.Windows.Forms.TextBox();
            this.LblDescripcion = new System.Windows.Forms.Label();
            this.BtnObtenerCoordenadas = new System.Windows.Forms.Button();
            this.MstPrincipal.SuspendLayout();
            this.SstEstado.SuspendLayout();
            this.TstPrincipal.SuspendLayout();
            this.TbcPrincipal.SuspendLayout();
            this.TpgClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFondoClientes)).BeginInit();
            this.TpgReservaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFondoReservaciones)).BeginInit();
            this.TpgInventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // MstPrincipal
            // 
            this.MstPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MstPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MitArchivo,
            this.MitEditar,
            this.MitVer,
            this.MitAyuda});
            this.MstPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MstPrincipal.Name = "MstPrincipal";
            this.MstPrincipal.Size = new System.Drawing.Size(1182, 28);
            this.MstPrincipal.TabIndex = 0;
            this.MstPrincipal.Text = "menuStrip1";
            // 
            // MitArchivo
            // 
            this.MitArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MitNuevo,
            this.MitGuardar});
            this.MitArchivo.Name = "MitArchivo";
            this.MitArchivo.Size = new System.Drawing.Size(73, 24);
            this.MitArchivo.Text = "Archivo";
            // 
            // MitNuevo
            // 
            this.MitNuevo.Name = "MitNuevo";
            this.MitNuevo.Size = new System.Drawing.Size(145, 26);
            this.MitNuevo.Text = "Nuevo";
            // 
            // MitGuardar
            // 
            this.MitGuardar.Name = "MitGuardar";
            this.MitGuardar.Size = new System.Drawing.Size(145, 26);
            this.MitGuardar.Text = "Guardar";
            // 
            // MitEditar
            // 
            this.MitEditar.Name = "MitEditar";
            this.MitEditar.Size = new System.Drawing.Size(62, 24);
            this.MitEditar.Text = "Editar";
            // 
            // MitVer
            // 
            this.MitVer.Name = "MitVer";
            this.MitVer.Size = new System.Drawing.Size(44, 24);
            this.MitVer.Text = "Ver";
            // 
            // MitAyuda
            // 
            this.MitAyuda.Name = "MitAyuda";
            this.MitAyuda.Size = new System.Drawing.Size(65, 24);
            this.MitAyuda.Text = "Ayuda";
            // 
            // SstEstado
            // 
            this.SstEstado.BackColor = System.Drawing.SystemColors.Control;
            this.SstEstado.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SstEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsslProyecto});
            this.SstEstado.Location = new System.Drawing.Point(0, 747);
            this.SstEstado.Name = "SstEstado";
            this.SstEstado.Size = new System.Drawing.Size(1182, 26);
            this.SstEstado.TabIndex = 1;
            this.SstEstado.Text = "statusStrip1";
            // 
            // TsslProyecto
            // 
            this.TsslProyecto.Name = "TsslProyecto";
            this.TsslProyecto.Size = new System.Drawing.Size(221, 20);
            this.TsslProyecto.Text = "Proyecto Final - SSPP21B - NJSA";
            // 
            // TstPrincipal
            // 
            this.TstPrincipal.AutoSize = false;
            this.TstPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(207)))), ((int)(((byte)(206)))));
            this.TstPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TstPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsbNuevo,
            this.Tss1,
            this.TsbGuardar,
            this.Tss2,
            this.TsbEliminar,
            this.Tss3,
            this.TsbCerrar,
            this.Tss4});
            this.TstPrincipal.Location = new System.Drawing.Point(0, 28);
            this.TstPrincipal.Name = "TstPrincipal";
            this.TstPrincipal.Size = new System.Drawing.Size(1182, 60);
            this.TstPrincipal.TabIndex = 2;
            this.TstPrincipal.Text = "toolStrip1";
            // 
            // TsbNuevo
            // 
            this.TsbNuevo.AutoSize = false;
            this.TsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("TsbNuevo.Image")));
            this.TsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbNuevo.Name = "TsbNuevo";
            this.TsbNuevo.Size = new System.Drawing.Size(136, 60);
            this.TsbNuevo.Text = "Nuevo";
            this.TsbNuevo.Click += new System.EventHandler(this.TsbNuevo_Click);
            // 
            // Tss1
            // 
            this.Tss1.Name = "Tss1";
            this.Tss1.Size = new System.Drawing.Size(6, 60);
            // 
            // TsbGuardar
            // 
            this.TsbGuardar.AutoSize = false;
            this.TsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("TsbGuardar.Image")));
            this.TsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbGuardar.Name = "TsbGuardar";
            this.TsbGuardar.Size = new System.Drawing.Size(150, 60);
            this.TsbGuardar.Text = "Guardar";
            this.TsbGuardar.Click += new System.EventHandler(this.TsbGuardar_Click);
            // 
            // Tss2
            // 
            this.Tss2.Name = "Tss2";
            this.Tss2.Size = new System.Drawing.Size(6, 60);
            // 
            // TsbEliminar
            // 
            this.TsbEliminar.AutoSize = false;
            this.TsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("TsbEliminar.Image")));
            this.TsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbEliminar.Name = "TsbEliminar";
            this.TsbEliminar.Size = new System.Drawing.Size(150, 60);
            this.TsbEliminar.Text = "Eliminar";
            this.TsbEliminar.Click += new System.EventHandler(this.TsbEliminar_Click);
            // 
            // Tss3
            // 
            this.Tss3.Name = "Tss3";
            this.Tss3.Size = new System.Drawing.Size(6, 60);
            // 
            // TsbCerrar
            // 
            this.TsbCerrar.AutoSize = false;
            this.TsbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("TsbCerrar.Image")));
            this.TsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbCerrar.Name = "TsbCerrar";
            this.TsbCerrar.Size = new System.Drawing.Size(150, 60);
            this.TsbCerrar.Text = "Cerrar";
            this.TsbCerrar.Click += new System.EventHandler(this.TsbCerrar_Click);
            // 
            // Tss4
            // 
            this.Tss4.Name = "Tss4";
            this.Tss4.Size = new System.Drawing.Size(6, 60);
            // 
            // PnlFotografia
            // 
            this.PnlFotografia.BackColor = System.Drawing.Color.White;
            this.PnlFotografia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlFotografia.BackgroundImage")));
            this.PnlFotografia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlFotografia.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlFotografia.Location = new System.Drawing.Point(0, 88);
            this.PnlFotografia.Name = "PnlFotografia";
            this.PnlFotografia.Size = new System.Drawing.Size(200, 659);
            this.PnlFotografia.TabIndex = 3;
            // 
            // TbcPrincipal
            // 
            this.TbcPrincipal.Controls.Add(this.TpgClientes);
            this.TbcPrincipal.Controls.Add(this.TpgReservaciones);
            this.TbcPrincipal.Controls.Add(this.TpgInventario);
            this.TbcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbcPrincipal.ItemSize = new System.Drawing.Size(150, 35);
            this.TbcPrincipal.Location = new System.Drawing.Point(200, 88);
            this.TbcPrincipal.Name = "TbcPrincipal";
            this.TbcPrincipal.SelectedIndex = 0;
            this.TbcPrincipal.Size = new System.Drawing.Size(982, 659);
            this.TbcPrincipal.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TbcPrincipal.TabIndex = 4;
            // 
            // TpgClientes
            // 
            this.TpgClientes.Controls.Add(this.BtnGeneraArchivo);
            this.TpgClientes.Controls.Add(this.LblEstadoCivil);
            this.TpgClientes.Controls.Add(this.CbxEstadoCivil);
            this.TpgClientes.Controls.Add(this.TbxLugarProcedencia);
            this.TpgClientes.Controls.Add(this.LblLugarProcedencia);
            this.TpgClientes.Controls.Add(this.TbxFechaNacimiento);
            this.TpgClientes.Controls.Add(this.LblFechaNacimiento);
            this.TpgClientes.Controls.Add(this.TbxCodigo);
            this.TpgClientes.Controls.Add(this.LblCodigo);
            this.TpgClientes.Controls.Add(this.TbxApellidoM);
            this.TpgClientes.Controls.Add(this.TbxCorreo);
            this.TpgClientes.Controls.Add(this.LblCorreo);
            this.TpgClientes.Controls.Add(this.TbxTelefonoMovil);
            this.TpgClientes.Controls.Add(this.LblTelefonoMovil);
            this.TpgClientes.Controls.Add(this.LblApellidoM);
            this.TpgClientes.Controls.Add(this.TbxApellidoP);
            this.TpgClientes.Controls.Add(this.LblApellidoP);
            this.TpgClientes.Controls.Add(this.TbxNombre);
            this.TpgClientes.Controls.Add(this.LblNombre);
            this.TpgClientes.Controls.Add(this.PbxFondoClientes);
            this.TpgClientes.Location = new System.Drawing.Point(4, 39);
            this.TpgClientes.Name = "TpgClientes";
            this.TpgClientes.Padding = new System.Windows.Forms.Padding(3);
            this.TpgClientes.Size = new System.Drawing.Size(974, 616);
            this.TpgClientes.TabIndex = 0;
            this.TpgClientes.Text = "Clientes";
            this.TpgClientes.UseVisualStyleBackColor = true;
            // 
            // BtnGeneraArchivo
            // 
            this.BtnGeneraArchivo.Location = new System.Drawing.Point(687, 170);
            this.BtnGeneraArchivo.Name = "BtnGeneraArchivo";
            this.BtnGeneraArchivo.Size = new System.Drawing.Size(141, 80);
            this.BtnGeneraArchivo.TabIndex = 20;
            this.BtnGeneraArchivo.Text = "Generar Archivo";
            this.BtnGeneraArchivo.UseVisualStyleBackColor = true;
            this.BtnGeneraArchivo.Click += new System.EventHandler(this.BtnGeneraArchivo_Click);
            // 
            // LblEstadoCivil
            // 
            this.LblEstadoCivil.AutoSize = true;
            this.LblEstadoCivil.ForeColor = System.Drawing.Color.DimGray;
            this.LblEstadoCivil.Location = new System.Drawing.Point(23, 271);
            this.LblEstadoCivil.Name = "LblEstadoCivil";
            this.LblEstadoCivil.Size = new System.Drawing.Size(81, 17);
            this.LblEstadoCivil.TabIndex = 19;
            this.LblEstadoCivil.Text = "Estado Civil";
            // 
            // CbxEstadoCivil
            // 
            this.CbxEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxEstadoCivil.FormattingEnabled = true;
            this.CbxEstadoCivil.Items.AddRange(new object[] {
            "Soltero(a)",
            "Casado(a)"});
            this.CbxEstadoCivil.Location = new System.Drawing.Point(26, 295);
            this.CbxEstadoCivil.Name = "CbxEstadoCivil";
            this.CbxEstadoCivil.Size = new System.Drawing.Size(181, 24);
            this.CbxEstadoCivil.TabIndex = 18;
            // 
            // TbxLugarProcedencia
            // 
            this.TbxLugarProcedencia.Location = new System.Drawing.Point(233, 228);
            this.TbxLugarProcedencia.Name = "TbxLugarProcedencia";
            this.TbxLugarProcedencia.Size = new System.Drawing.Size(340, 22);
            this.TbxLugarProcedencia.TabIndex = 17;
            // 
            // LblLugarProcedencia
            // 
            this.LblLugarProcedencia.AutoSize = true;
            this.LblLugarProcedencia.ForeColor = System.Drawing.Color.DimGray;
            this.LblLugarProcedencia.Location = new System.Drawing.Point(230, 207);
            this.LblLugarProcedencia.Name = "LblLugarProcedencia";
            this.LblLugarProcedencia.Size = new System.Drawing.Size(148, 17);
            this.LblLugarProcedencia.TabIndex = 16;
            this.LblLugarProcedencia.Text = "Lugar de Procedencia";
            // 
            // TbxFechaNacimiento
            // 
            this.TbxFechaNacimiento.Location = new System.Drawing.Point(26, 228);
            this.TbxFechaNacimiento.Name = "TbxFechaNacimiento";
            this.TbxFechaNacimiento.Size = new System.Drawing.Size(181, 22);
            this.TbxFechaNacimiento.TabIndex = 15;
            // 
            // LblFechaNacimiento
            // 
            this.LblFechaNacimiento.AutoSize = true;
            this.LblFechaNacimiento.ForeColor = System.Drawing.Color.DimGray;
            this.LblFechaNacimiento.Location = new System.Drawing.Point(23, 207);
            this.LblFechaNacimiento.Name = "LblFechaNacimiento";
            this.LblFechaNacimiento.Size = new System.Drawing.Size(141, 17);
            this.LblFechaNacimiento.TabIndex = 14;
            this.LblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // TbxCodigo
            // 
            this.TbxCodigo.Location = new System.Drawing.Point(26, 56);
            this.TbxCodigo.Name = "TbxCodigo";
            this.TbxCodigo.Size = new System.Drawing.Size(181, 22);
            this.TbxCodigo.TabIndex = 13;
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.ForeColor = System.Drawing.Color.DimGray;
            this.LblCodigo.Location = new System.Drawing.Point(23, 35);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(52, 17);
            this.LblCodigo.TabIndex = 12;
            this.LblCodigo.Text = "Código";
            // 
            // TbxApellidoM
            // 
            this.TbxApellidoM.Location = new System.Drawing.Point(597, 111);
            this.TbxApellidoM.Name = "TbxApellidoM";
            this.TbxApellidoM.Size = new System.Drawing.Size(231, 22);
            this.TbxApellidoM.TabIndex = 11;
            // 
            // TbxCorreo
            // 
            this.TbxCorreo.Location = new System.Drawing.Point(233, 170);
            this.TbxCorreo.Name = "TbxCorreo";
            this.TbxCorreo.Size = new System.Drawing.Size(340, 22);
            this.TbxCorreo.TabIndex = 10;
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.ForeColor = System.Drawing.Color.DimGray;
            this.LblCorreo.Location = new System.Drawing.Point(230, 149);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(51, 17);
            this.LblCorreo.TabIndex = 9;
            this.LblCorreo.Text = "Correo";
            // 
            // TbxTelefonoMovil
            // 
            this.TbxTelefonoMovil.Location = new System.Drawing.Point(26, 170);
            this.TbxTelefonoMovil.Name = "TbxTelefonoMovil";
            this.TbxTelefonoMovil.Size = new System.Drawing.Size(181, 22);
            this.TbxTelefonoMovil.TabIndex = 8;
            // 
            // LblTelefonoMovil
            // 
            this.LblTelefonoMovil.AutoSize = true;
            this.LblTelefonoMovil.ForeColor = System.Drawing.Color.DimGray;
            this.LblTelefonoMovil.Location = new System.Drawing.Point(23, 149);
            this.LblTelefonoMovil.Name = "LblTelefonoMovil";
            this.LblTelefonoMovil.Size = new System.Drawing.Size(100, 17);
            this.LblTelefonoMovil.TabIndex = 7;
            this.LblTelefonoMovil.Text = "Teléfono Móvil";
            // 
            // LblApellidoM
            // 
            this.LblApellidoM.AutoSize = true;
            this.LblApellidoM.ForeColor = System.Drawing.Color.DimGray;
            this.LblApellidoM.Location = new System.Drawing.Point(594, 90);
            this.LblApellidoM.Name = "LblApellidoM";
            this.LblApellidoM.Size = new System.Drawing.Size(114, 17);
            this.LblApellidoM.TabIndex = 5;
            this.LblApellidoM.Text = "Apellido Materno";
            // 
            // TbxApellidoP
            // 
            this.TbxApellidoP.Location = new System.Drawing.Point(342, 111);
            this.TbxApellidoP.Name = "TbxApellidoP";
            this.TbxApellidoP.Size = new System.Drawing.Size(231, 22);
            this.TbxApellidoP.TabIndex = 4;
            // 
            // LblApellidoP
            // 
            this.LblApellidoP.AutoSize = true;
            this.LblApellidoP.ForeColor = System.Drawing.Color.DimGray;
            this.LblApellidoP.Location = new System.Drawing.Point(339, 90);
            this.LblApellidoP.Name = "LblApellidoP";
            this.LblApellidoP.Size = new System.Drawing.Size(112, 17);
            this.LblApellidoP.TabIndex = 3;
            this.LblApellidoP.Text = "Apellido Paterno";
            // 
            // TbxNombre
            // 
            this.TbxNombre.Location = new System.Drawing.Point(26, 111);
            this.TbxNombre.Name = "TbxNombre";
            this.TbxNombre.Size = new System.Drawing.Size(293, 22);
            this.TbxNombre.TabIndex = 2;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.ForeColor = System.Drawing.Color.DimGray;
            this.LblNombre.Location = new System.Drawing.Point(23, 90);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(75, 17);
            this.LblNombre.TabIndex = 1;
            this.LblNombre.Text = "Nombre(s)";
            // 
            // PbxFondoClientes
            // 
            this.PbxFondoClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbxFondoClientes.BackgroundImage")));
            this.PbxFondoClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxFondoClientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PbxFondoClientes.Location = new System.Drawing.Point(3, 423);
            this.PbxFondoClientes.Name = "PbxFondoClientes";
            this.PbxFondoClientes.Size = new System.Drawing.Size(968, 190);
            this.PbxFondoClientes.TabIndex = 0;
            this.PbxFondoClientes.TabStop = false;
            // 
            // TpgReservaciones
            // 
            this.TpgReservaciones.Controls.Add(this.BtnDibujarPoligono);
            this.TpgReservaciones.Controls.Add(this.BtnDibujarRectangulo);
            this.TpgReservaciones.Controls.Add(this.BtnDibujarCirculo);
            this.TpgReservaciones.Controls.Add(this.BtnDibujarCuadrado);
            this.TpgReservaciones.Controls.Add(this.PbxFondoReservaciones);
            this.TpgReservaciones.Location = new System.Drawing.Point(4, 39);
            this.TpgReservaciones.Name = "TpgReservaciones";
            this.TpgReservaciones.Padding = new System.Windows.Forms.Padding(3);
            this.TpgReservaciones.Size = new System.Drawing.Size(974, 614);
            this.TpgReservaciones.TabIndex = 1;
            this.TpgReservaciones.Text = "Reservaciones";
            this.TpgReservaciones.UseVisualStyleBackColor = true;
            // 
            // BtnDibujarPoligono
            // 
            this.BtnDibujarPoligono.Location = new System.Drawing.Point(691, 125);
            this.BtnDibujarPoligono.Name = "BtnDibujarPoligono";
            this.BtnDibujarPoligono.Size = new System.Drawing.Size(220, 48);
            this.BtnDibujarPoligono.TabIndex = 4;
            this.BtnDibujarPoligono.Text = "Dibujar Polígono";
            this.BtnDibujarPoligono.UseVisualStyleBackColor = true;
            this.BtnDibujarPoligono.Click += new System.EventHandler(this.BtnDibujarPoligono_Click);
            // 
            // BtnDibujarRectangulo
            // 
            this.BtnDibujarRectangulo.Location = new System.Drawing.Point(691, 191);
            this.BtnDibujarRectangulo.Name = "BtnDibujarRectangulo";
            this.BtnDibujarRectangulo.Size = new System.Drawing.Size(220, 48);
            this.BtnDibujarRectangulo.TabIndex = 3;
            this.BtnDibujarRectangulo.Text = "Dibujar Rectangulo";
            this.BtnDibujarRectangulo.UseVisualStyleBackColor = true;
            this.BtnDibujarRectangulo.Click += new System.EventHandler(this.BtnDibujarRectangulo_Click);
            // 
            // BtnDibujarCirculo
            // 
            this.BtnDibujarCirculo.Location = new System.Drawing.Point(691, 257);
            this.BtnDibujarCirculo.Name = "BtnDibujarCirculo";
            this.BtnDibujarCirculo.Size = new System.Drawing.Size(220, 48);
            this.BtnDibujarCirculo.TabIndex = 2;
            this.BtnDibujarCirculo.Text = "Dibujar Círculo";
            this.BtnDibujarCirculo.UseVisualStyleBackColor = true;
            this.BtnDibujarCirculo.Click += new System.EventHandler(this.BtnDibujarCirculo_Click);
            // 
            // BtnDibujarCuadrado
            // 
            this.BtnDibujarCuadrado.Location = new System.Drawing.Point(691, 321);
            this.BtnDibujarCuadrado.Name = "BtnDibujarCuadrado";
            this.BtnDibujarCuadrado.Size = new System.Drawing.Size(220, 48);
            this.BtnDibujarCuadrado.TabIndex = 1;
            this.BtnDibujarCuadrado.Text = "Dibujar Cuadrado";
            this.BtnDibujarCuadrado.UseVisualStyleBackColor = true;
            this.BtnDibujarCuadrado.Click += new System.EventHandler(this.BtnDibujar_Click);
            // 
            // PbxFondoReservaciones
            // 
            this.PbxFondoReservaciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbxFondoReservaciones.BackgroundImage")));
            this.PbxFondoReservaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbxFondoReservaciones.Location = new System.Drawing.Point(691, 385);
            this.PbxFondoReservaciones.Name = "PbxFondoReservaciones";
            this.PbxFondoReservaciones.Size = new System.Drawing.Size(220, 200);
            this.PbxFondoReservaciones.TabIndex = 0;
            this.PbxFondoReservaciones.TabStop = false;
            // 
            // TpgInventario
            // 
            this.TpgInventario.Controls.Add(this.BtnObtenerCoordenadas);
            this.TpgInventario.Controls.Add(this.BtnGeneraKML);
            this.TpgInventario.Controls.Add(this.TbxLugar);
            this.TpgInventario.Controls.Add(this.LblLugar);
            this.TpgInventario.Controls.Add(this.TbxLongitud);
            this.TpgInventario.Controls.Add(this.LblLongitud);
            this.TpgInventario.Controls.Add(this.TbxLatitud);
            this.TpgInventario.Controls.Add(this.LblLatitud);
            this.TpgInventario.Controls.Add(this.TbxDescripcion);
            this.TpgInventario.Controls.Add(this.LblDescripcion);
            this.TpgInventario.Location = new System.Drawing.Point(4, 39);
            this.TpgInventario.Name = "TpgInventario";
            this.TpgInventario.Size = new System.Drawing.Size(974, 616);
            this.TpgInventario.TabIndex = 2;
            this.TpgInventario.Text = "Inventario";
            this.TpgInventario.UseVisualStyleBackColor = true;
            // 
            // BtnGeneraKML
            // 
            this.BtnGeneraKML.Location = new System.Drawing.Point(48, 233);
            this.BtnGeneraKML.Name = "BtnGeneraKML";
            this.BtnGeneraKML.Size = new System.Drawing.Size(141, 80);
            this.BtnGeneraKML.TabIndex = 22;
            this.BtnGeneraKML.Text = "Genera KML";
            this.BtnGeneraKML.UseVisualStyleBackColor = true;
            this.BtnGeneraKML.Click += new System.EventHandler(this.BtnGeneraKML_Click);
            // 
            // TbxLugar
            // 
            this.TbxLugar.Location = new System.Drawing.Point(48, 64);
            this.TbxLugar.Name = "TbxLugar";
            this.TbxLugar.Size = new System.Drawing.Size(378, 22);
            this.TbxLugar.TabIndex = 21;
            // 
            // LblLugar
            // 
            this.LblLugar.AutoSize = true;
            this.LblLugar.ForeColor = System.Drawing.Color.DimGray;
            this.LblLugar.Location = new System.Drawing.Point(45, 43);
            this.LblLugar.Name = "LblLugar";
            this.LblLugar.Size = new System.Drawing.Size(45, 17);
            this.LblLugar.TabIndex = 20;
            this.LblLugar.Text = "Lugar";
            // 
            // TbxLongitud
            // 
            this.TbxLongitud.Location = new System.Drawing.Point(303, 183);
            this.TbxLongitud.Name = "TbxLongitud";
            this.TbxLongitud.Size = new System.Drawing.Size(231, 22);
            this.TbxLongitud.TabIndex = 19;
            // 
            // LblLongitud
            // 
            this.LblLongitud.AutoSize = true;
            this.LblLongitud.ForeColor = System.Drawing.Color.DimGray;
            this.LblLongitud.Location = new System.Drawing.Point(300, 162);
            this.LblLongitud.Name = "LblLongitud";
            this.LblLongitud.Size = new System.Drawing.Size(63, 17);
            this.LblLongitud.TabIndex = 18;
            this.LblLongitud.Text = "Longitud";
            // 
            // TbxLatitud
            // 
            this.TbxLatitud.Location = new System.Drawing.Point(48, 183);
            this.TbxLatitud.Name = "TbxLatitud";
            this.TbxLatitud.Size = new System.Drawing.Size(231, 22);
            this.TbxLatitud.TabIndex = 17;
            // 
            // LblLatitud
            // 
            this.LblLatitud.AutoSize = true;
            this.LblLatitud.ForeColor = System.Drawing.Color.DimGray;
            this.LblLatitud.Location = new System.Drawing.Point(45, 162);
            this.LblLatitud.Name = "LblLatitud";
            this.LblLatitud.Size = new System.Drawing.Size(51, 17);
            this.LblLatitud.TabIndex = 16;
            this.LblLatitud.Text = "Latitud";
            // 
            // TbxDescripcion
            // 
            this.TbxDescripcion.Location = new System.Drawing.Point(48, 119);
            this.TbxDescripcion.Name = "TbxDescripcion";
            this.TbxDescripcion.Size = new System.Drawing.Size(486, 22);
            this.TbxDescripcion.TabIndex = 15;
            // 
            // LblDescripcion
            // 
            this.LblDescripcion.AutoSize = true;
            this.LblDescripcion.ForeColor = System.Drawing.Color.DimGray;
            this.LblDescripcion.Location = new System.Drawing.Point(45, 98);
            this.LblDescripcion.Name = "LblDescripcion";
            this.LblDescripcion.Size = new System.Drawing.Size(82, 17);
            this.LblDescripcion.TabIndex = 14;
            this.LblDescripcion.Text = "Descripción";
            // 
            // BtnObtenerCoordenadas
            // 
            this.BtnObtenerCoordenadas.Location = new System.Drawing.Point(570, 179);
            this.BtnObtenerCoordenadas.Name = "BtnObtenerCoordenadas";
            this.BtnObtenerCoordenadas.Size = new System.Drawing.Size(187, 30);
            this.BtnObtenerCoordenadas.TabIndex = 23;
            this.BtnObtenerCoordenadas.Text = "Obtener Coordenadas";
            this.BtnObtenerCoordenadas.UseVisualStyleBackColor = true;
            // 
            // DlgProyectoFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(1182, 773);
            this.Controls.Add(this.TbcPrincipal);
            this.Controls.Add(this.PnlFotografia);
            this.Controls.Add(this.TstPrincipal);
            this.Controls.Add(this.SstEstado);
            this.Controls.Add(this.MstPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MstPrincipal;
            this.Name = "DlgProyectoFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestión de Cabañas - San Sebastián";
            this.MstPrincipal.ResumeLayout(false);
            this.MstPrincipal.PerformLayout();
            this.SstEstado.ResumeLayout(false);
            this.SstEstado.PerformLayout();
            this.TstPrincipal.ResumeLayout(false);
            this.TstPrincipal.PerformLayout();
            this.TbcPrincipal.ResumeLayout(false);
            this.TpgClientes.ResumeLayout(false);
            this.TpgClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxFondoClientes)).EndInit();
            this.TpgReservaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxFondoReservaciones)).EndInit();
            this.TpgInventario.ResumeLayout(false);
            this.TpgInventario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MstPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MitArchivo;
        private System.Windows.Forms.ToolStripMenuItem MitNuevo;
        private System.Windows.Forms.ToolStripMenuItem MitGuardar;
        private System.Windows.Forms.ToolStripMenuItem MitEditar;
        private System.Windows.Forms.ToolStripMenuItem MitVer;
        private System.Windows.Forms.ToolStripMenuItem MitAyuda;
        private System.Windows.Forms.StatusStrip SstEstado;
        private System.Windows.Forms.ToolStripStatusLabel TsslProyecto;
        private System.Windows.Forms.ToolStrip TstPrincipal;
        private System.Windows.Forms.ToolStripButton TsbNuevo;
        private System.Windows.Forms.ToolStripButton TsbGuardar;
        private System.Windows.Forms.ToolStripButton TsbEliminar;
        private System.Windows.Forms.ToolStripSeparator Tss1;
        private System.Windows.Forms.ToolStripSeparator Tss2;
        private System.Windows.Forms.ToolStripSeparator Tss3;
        private System.Windows.Forms.ToolStripButton TsbCerrar;
        private System.Windows.Forms.Panel PnlFotografia;
        private System.Windows.Forms.ToolStripSeparator Tss4;
        private System.Windows.Forms.TabControl TbcPrincipal;
        private System.Windows.Forms.TabPage TpgClientes;
        private System.Windows.Forms.TabPage TpgReservaciones;
        private System.Windows.Forms.TabPage TpgInventario;
        private System.Windows.Forms.PictureBox PbxFondoClientes;
        private System.Windows.Forms.TextBox TbxApellidoM;
        private System.Windows.Forms.TextBox TbxCorreo;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.TextBox TbxTelefonoMovil;
        private System.Windows.Forms.Label LblTelefonoMovil;
        private System.Windows.Forms.Label LblApellidoM;
        private System.Windows.Forms.TextBox TbxApellidoP;
        private System.Windows.Forms.Label LblApellidoP;
        private System.Windows.Forms.TextBox TbxNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.PictureBox PbxFondoReservaciones;
        private System.Windows.Forms.Label LblEstadoCivil;
        private System.Windows.Forms.ComboBox CbxEstadoCivil;
        private System.Windows.Forms.TextBox TbxLugarProcedencia;
        private System.Windows.Forms.Label LblLugarProcedencia;
        private System.Windows.Forms.TextBox TbxFechaNacimiento;
        private System.Windows.Forms.Label LblFechaNacimiento;
        private System.Windows.Forms.TextBox TbxCodigo;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Button BtnDibujarCuadrado;
        private System.Windows.Forms.Button BtnDibujarCirculo;
        private System.Windows.Forms.Button BtnDibujarRectangulo;
        private System.Windows.Forms.Button BtnDibujarPoligono;
        private System.Windows.Forms.Button BtnGeneraArchivo;
        private System.Windows.Forms.TextBox TbxLugar;
        private System.Windows.Forms.Label LblLugar;
        private System.Windows.Forms.TextBox TbxLongitud;
        private System.Windows.Forms.Label LblLongitud;
        private System.Windows.Forms.TextBox TbxLatitud;
        private System.Windows.Forms.Label LblLatitud;
        private System.Windows.Forms.TextBox TbxDescripcion;
        private System.Windows.Forms.Label LblDescripcion;
        private System.Windows.Forms.Button BtnGeneraKML;
        private System.Windows.Forms.Button BtnObtenerCoordenadas;
    }
}