using System;
using System.Windows.Forms;

namespace pryActividadDePractica5 // Asegúrate de que coincida con el namespace de tu proyecto
{
    // Si en tu proyecto el formulario se llama Form1, cambia "frmReservas" por "Form1" aquí y en el constructor
    public partial class frmSistemaDeGestiónDeReservas : Form
    {
        // =========================================================================
        // 1. ESTRUCTURA (struct) Y ARREGLO UNIDIMENSIONAL
        // =========================================================================
        public struct RESERVA
        {
            public int NroReserva;
            public string Huesped;
            public string TipoCabana;
            public int Dias;
            public float MontoTotal;
        }

        // Arreglo unidimensional instanciado con tamaño fijo (50 elementos)
        private RESERVA[] listaReservas = new RESERVA[50];
        private int contadorReservas = 0;

        public frmSistemaDeGestiónDeReservas()
        {
            InitializeComponent();

            // Como los ítems ya se cargaron en el Diseñador (Colección Items),
            // únicamente seleccionamos la primera opción al iniciar la ventana
            if (cmbTipoCabana.Items.Count > 0)
            {
                cmbTipoCabana.SelectedIndex = 0;
            }
        }

        // =========================================================================
        // 2. VALIDACIÓN DE ENTRADAS EN TIEMPO REAL (KeyPress)
        // =========================================================================
        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite dígitos numéricos y la tecla Backspace (borrar)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Cancela la escritura de la tecla presionada
            }
        }

        // =========================================================================
        // 3. HABILITACIÓN DINÁMICA DE CONTROLES (TextChanged)
        // =========================================================================
        private void ValidarEntrada_TextChanged(object sender, EventArgs e)
        {
            // El botón se habilita únicamente cuando las 3 cajas de texto contienen datos
            btnRegistrar.Enabled = (txtNroReserva.Text != "" &&
                                    txtHuesped.Text != "" &&
                                    txtDias.Text != "");
        }

        // =========================================================================
        // 4. REGISTRO DE RESERVA (btnRegistrar_Click)
        // =========================================================================
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (contadorReservas < listaReservas.Length)
            {
                int dias = 0;
                if (!int.TryParse(txtDias.Text, out dias))
                {
                    MessageBox.Show("Ingrese una cantidad de días válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                float tarifaDiaria = 0;

                // Evalúa el índice seleccionado en el ComboBox según el orden del Diseñador
                switch (cmbTipoCabana.SelectedIndex)
                {
                    case 0: tarifaDiaria = 15000; break; // Simple
                    case 1: tarifaDiaria = 25000; break; // Doble
                    case 2: tarifaDiaria = 40000; break; // Premium
                    default: tarifaDiaria = 15000; break;
                }

                // Carga de la estructura RESERVA
                RESERVA nuevaReserva;
                nuevaReserva.NroReserva = int.Parse(txtNroReserva.Text);
                nuevaReserva.Huesped = txtHuesped.Text;
                nuevaReserva.TipoCabana = cmbTipoCabana.Text;
                nuevaReserva.Dias = dias;
                nuevaReserva.MontoTotal = dias * tarifaDiaria;

                // Almacenamiento en el arreglo de estructuras
                listaReservas[contadorReservas] = nuevaReserva;
                contadorReservas++;

                // Agregado de fila en la grilla DataGridView
                dgvReservas.Rows.Add(
                    nuevaReserva.NroReserva,
                    nuevaReserva.Huesped,
                    nuevaReserva.TipoCabana,
                    nuevaReserva.Dias,
                    nuevaReserva.MontoTotal.ToString("0.00")
                );

                // Limpieza de campos de texto y reubicación del foco
                txtNroReserva.Clear();
                txtHuesped.Clear();
                txtDias.Clear();
                if (cmbTipoCabana.Items.Count > 0)
                {
                    cmbTipoCabana.SelectedIndex = 0;
                }
                txtNroReserva.Focus();
            }
            else
            {
                MessageBox.Show("Capacidad máxima de 50 reservas alcanzada.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // =========================================================================
        // 5. CÓMPUTO DE RECAUDACIÓN TOTAL (btnCalcularTotal_Click)
        // =========================================================================
        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            float acumulado = 0;

            // Recorrido acumulativo del arreglo de estructuras
            for (int i = 0; i < contadorReservas; i++)
            {
                acumulado += listaReservas[i].MontoTotal;
            }

            // Muestra el resultado en el TextBox de solo lectura
            txtTotalRecaudado.Text = acumulado.ToString("0.00");
        }
    }
}