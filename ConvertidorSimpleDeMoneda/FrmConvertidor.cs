using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConvertidorSimpleDeMoneda.CustomControlItem;
using BusinessLayer;

namespace ConvertidorSimpleDeMoneda
{
    public partial class FrmConvertidor : Form
    {

        public bool IsCalculate { get; set; } = false;
        public FrmConvertidor()
        {
            InitializeComponent();
        }

        private void FrmConvertidor_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            ConvertirMoneda();
        }

        private void CbxMonedaOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsCalculate)
            {
                ConvertirMoneda();
            }
           
        }

        private void CbxMonedaDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsCalculate)
            {
                ConvertirMoneda();
            }
        }


        private void ConvertirMoneda()
        {
            try
            {
                ComboBoxItem seleccionadoMonedaOrigen = CbxMonedaOrigen.SelectedItem as ComboBoxItem;
                ComboBoxItem seleccionadoMonedaDestino = CbxMonedaDestino.SelectedItem as ComboBoxItem;

                if (seleccionadoMonedaOrigen.Value == null)
                {
                    MessageBox.Show("Debe seleccionar una moneda de origen", "Advertencia");
                }
                else if (seleccionadoMonedaDestino.Value == null)
                {
                    MessageBox.Show("Debe seleccionar una moneda de destino", "Advertencia");
                }
                else if (string.IsNullOrEmpty(TxtCantidad.Text))
                {
                    MessageBox.Show("Debe colocar una cantidad", "Advertencia");
                }
                else
                {
                    Convertidor conversor = new Convertidor();

                    int monedaOrigen = (int) seleccionadoMonedaOrigen.Value;
                    int monedaDestino = (int) seleccionadoMonedaDestino.Value;
                    int cantidad = Convert.ToInt32(TxtCantidad.Text);

                    double resultado = conversor.Convertir(monedaOrigen, monedaDestino, cantidad);

                    TxtResultado.Text = resultado.ToString();

                    IsCalculate = true;
                }


            }
            catch (Exception e)
            {
                MessageBox.Show("Debe colocar una cantidad numerica", "Advertencia");
            }

        }

        private void LoadComboBox()
        {
            ComboBoxItem opcionPorDefecto = new ComboBoxItem
            {
                Text = "Seleccione una opcion",
                Value = null
            };

            ComboBoxItem dolarOpcion = new ComboBoxItem
            {
                Text = "Dolar (USD)",
                Value = (int)EnumMoneda.DOLAR
            };

            ComboBoxItem euroOpcion = new ComboBoxItem
            {
                Text = "Euro (EUR)",
                Value = (int)EnumMoneda.EURO
            };

            ComboBoxItem pesoOpcion = new ComboBoxItem
            {
                Text = "Peso dominicano (DOP)",
                Value = (int)EnumMoneda.PESOS
            };

            CbxMonedaOrigen.Items.Add(opcionPorDefecto);
            CbxMonedaOrigen.Items.Add(dolarOpcion);
            CbxMonedaOrigen.Items.Add(euroOpcion);
            CbxMonedaOrigen.Items.Add(pesoOpcion);
            CbxMonedaOrigen.SelectedItem = opcionPorDefecto;

            CbxMonedaDestino.Items.Add(opcionPorDefecto);
            CbxMonedaDestino.Items.Add(dolarOpcion);
            CbxMonedaDestino.Items.Add(euroOpcion);
            CbxMonedaDestino.Items.Add(pesoOpcion);
            CbxMonedaDestino.SelectedItem = opcionPorDefecto;

        }

       
    }
}
