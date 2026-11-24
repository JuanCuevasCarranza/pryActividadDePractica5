namespace pryActividadDePractica5
{
    partial class frmSistemaDeGestiónDeReservas
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
            grpReserva = new GroupBox();
            lblTipoCabana = new Label();
            cmbTipocabana = new ComboBox();
            lblHuesped = new Label();
            txtHuesped = new TextBox();
            lblNroReserva = new Label();
            txtNroReserva = new TextBox();
            txtDias = new TextBox();
            lblDias = new Label();
            btnRegistrar = new Button();
            dgvReservas = new DataGridView();
            colNroReserva = new DataGridViewTextBoxColumn();
            colHuesped = new DataGridViewTextBoxColumn();
            colTipoCabana = new DataGridViewTextBoxColumn();
            colDias = new DataGridViewTextBoxColumn();
            colMontoTotal = new DataGridViewTextBoxColumn();
            btnCalcularTotal = new Button();
            lblTotalRecaudado = new Label();
            txtTotalRecaudado = new TextBox();
            grpReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).BeginInit();
            SuspendLayout();
            // 
            // grpReserva
            // 
            grpReserva.Controls.Add(btnRegistrar);
            grpReserva.Controls.Add(lblDias);
            grpReserva.Controls.Add(txtDias);
            grpReserva.Controls.Add(lblTipoCabana);
            grpReserva.Controls.Add(cmbTipocabana);
            grpReserva.Controls.Add(lblHuesped);
            grpReserva.Controls.Add(txtHuesped);
            grpReserva.Controls.Add(lblNroReserva);
            grpReserva.Controls.Add(txtNroReserva);
            grpReserva.Location = new Point(12, 12);
            grpReserva.Name = "grpReserva";
            grpReserva.Size = new Size(349, 157);
            grpReserva.TabIndex = 0;
            grpReserva.TabStop = false;
            grpReserva.Text = "Datos de la Reserva";
            // 
            // lblTipoCabana
            // 
            lblTipoCabana.AutoSize = true;
            lblTipoCabana.Location = new Point(225, 19);
            lblTipoCabana.Name = "lblTipoCabana";
            lblTipoCabana.Size = new Size(95, 15);
            lblTipoCabana.TabIndex = 4;
            lblTipoCabana.Text = "Tipo de Cabaña :";
            // 
            // cmbTipocabana
            // 
            cmbTipocabana.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipocabana.FormattingEnabled = true;
            cmbTipocabana.Items.AddRange(new object[] { "Simple ($15.000/día)", "Doble ($25.000/día)", "Premium ($40.000/día)" });
            cmbTipocabana.Location = new Point(203, 48);
            cmbTipocabana.Name = "cmbTipocabana";
            cmbTipocabana.Size = new Size(140, 23);
            cmbTipocabana.TabIndex = 3;
            // 
            // lblHuesped
            // 
            lblHuesped.AutoSize = true;
            lblHuesped.Location = new Point(18, 76);
            lblHuesped.Name = "lblHuesped";
            lblHuesped.Size = new Size(60, 15);
            lblHuesped.TabIndex = 2;
            lblHuesped.Text = "Huesped :";
            // 
            // txtHuesped
            // 
            txtHuesped.Location = new Point(84, 73);
            txtHuesped.Name = "txtHuesped";
            txtHuesped.Size = new Size(100, 23);
            txtHuesped.TabIndex = 1;
            // 
            // lblNroReserva
            // 
            lblNroReserva.AutoSize = true;
            lblNroReserva.Location = new Point(18, 30);
            lblNroReserva.Name = "lblNroReserva";
            lblNroReserva.Size = new Size(70, 15);
            lblNroReserva.TabIndex = 1;
            lblNroReserva.Text = "N° Reserva :";
            // 
            // txtNroReserva
            // 
            txtNroReserva.Location = new Point(94, 27);
            txtNroReserva.MaxLength = 5;
            txtNroReserva.Name = "txtNroReserva";
            txtNroReserva.Size = new Size(84, 23);
            txtNroReserva.TabIndex = 0;
            // 
            // txtDias
            // 
            txtDias.Location = new Point(62, 118);
            txtDias.MaxLength = 2;
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(100, 23);
            txtDias.TabIndex = 5;
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(18, 121);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(35, 15);
            lblDias.TabIndex = 6;
            lblDias.Text = "Dias :";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Enabled = false;
            btnRegistrar.Location = new Point(268, 107);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 44);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar Reserva";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // dgvReservas
            // 
            dgvReservas.AllowUserToAddRows = false;
            dgvReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservas.Columns.AddRange(new DataGridViewColumn[] { colNroReserva, colHuesped, colTipoCabana, colDias, colMontoTotal });
            dgvReservas.Location = new Point(12, 175);
            dgvReservas.Name = "dgvReservas";
            dgvReservas.ReadOnly = true;
            dgvReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservas.Size = new Size(349, 150);
            dgvReservas.TabIndex = 1;
            // 
            // colNroReserva
            // 
            colNroReserva.HeaderText = "N° Reserva";
            colNroReserva.Name = "colNroReserva";
            colNroReserva.ReadOnly = true;
            // 
            // colHuesped
            // 
            colHuesped.HeaderText = "Huésped";
            colHuesped.Name = "colHuesped";
            colHuesped.ReadOnly = true;
            // 
            // colTipoCabana
            // 
            colTipoCabana.HeaderText = "Tipo Cabaña";
            colTipoCabana.Name = "colTipoCabana";
            colTipoCabana.ReadOnly = true;
            // 
            // colDias
            // 
            colDias.HeaderText = "Días";
            colDias.Name = "colDias";
            colDias.ReadOnly = true;
            // 
            // colMontoTotal
            // 
            colMontoTotal.HeaderText = "Monto Total ($)";
            colMontoTotal.Name = "colMontoTotal";
            colMontoTotal.ReadOnly = true;
            // 
            // btnCalcularTotal
            // 
            btnCalcularTotal.Location = new Point(228, 345);
            btnCalcularTotal.Name = "btnCalcularTotal";
            btnCalcularTotal.Size = new Size(133, 41);
            btnCalcularTotal.TabIndex = 2;
            btnCalcularTotal.Text = "Calcular Recaudación Total";
            btnCalcularTotal.UseVisualStyleBackColor = true;
            // 
            // lblTotalRecaudado
            // 
            lblTotalRecaudado.AutoSize = true;
            lblTotalRecaudado.Location = new Point(12, 358);
            lblTotalRecaudado.Name = "lblTotalRecaudado";
            lblTotalRecaudado.Size = new Size(111, 15);
            lblTotalRecaudado.TabIndex = 3;
            lblTotalRecaudado.Text = "Total Recaudado ($)";
            // 
            // txtTotalRecaudado
            // 
            txtTotalRecaudado.Location = new Point(129, 355);
            txtTotalRecaudado.Name = "txtTotalRecaudado";
            txtTotalRecaudado.ReadOnly = true;
            txtTotalRecaudado.Size = new Size(93, 23);
            txtTotalRecaudado.TabIndex = 4;
            // 
            // frmSistemaDeGestiónDeReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 394);
            Controls.Add(txtTotalRecaudado);
            Controls.Add(lblTotalRecaudado);
            Controls.Add(btnCalcularTotal);
            Controls.Add(dgvReservas);
            Controls.Add(grpReserva);
            Name = "frmSistemaDeGestiónDeReservas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Complejo Turístico El Sauce - Registro de Reservas";
            grpReserva.ResumeLayout(false);
            grpReserva.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpReserva;
        private Label lblNroReserva;
        private TextBox txtNroReserva;
        private Label lblHuesped;
        private TextBox txtHuesped;
        private Label lblTipoCabana;
        private ComboBox cmbTipocabana;
        private Button btnRegistrar;
        private Label lblDias;
        private TextBox txtDias;
        private DataGridView dgvReservas;
        private DataGridViewTextBoxColumn colNroReserva;
        private DataGridViewTextBoxColumn colHuesped;
        private DataGridViewTextBoxColumn colTipoCabana;
        private DataGridViewTextBoxColumn colDias;
        private DataGridViewTextBoxColumn colMontoTotal;
        private Button btnCalcularTotal;
        private Label lblTotalRecaudado;
        private TextBox txtTotalRecaudado;
    }
}