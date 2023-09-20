using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3Grupo11
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        int stockPastelitos = 200;
        int costoPastelito = 30;
        double promedioPastelitos = 0;
        double utilidadPromedio = 0;
        int limiteInf = 10;
        int limiteSup = 30;
        int acumuladorPastelitosSobrantes = 0;
        int cantDias = 0;
        int clientesDiarios = 0;
        int demandaCliente = 0;
        double precioDemandaCliente = 0;
        int acumuladorStockSobrante = 0;

        private void simulacion()
        {
            if (validarDemanda() == true) 
            {
                cantDias = int.Parse(txtCantDias.Text);
                for (int i = 0; i < cantDias; i++)
                {
                    gdrSimulacion.Rows.Add(i, "-", "-", "-", "-", stockPastelitos, "-", "-");
                    clientesDiarios = generadorClientesDiarios();
                    for (int cliente = 1;  cliente <= clientesDiarios; cliente ++)
                    {
                        demandaCliente = demandaClientes();
                        if (demandaCliente <= stockPastelitos)
                        {
                            precioDemandaCliente = precioDemanda(demandaCliente);
                            stockPastelitos = stockPastelitos - demandaCliente;

                        }    
                        

                    }
                    acumuladorPastelitosSobrantes = stockPastelitos;
                }
            }
            else
            {
                MessageBox.Show("Las probabilidades de la demanda no son correctas. Ingrese otros valores.");
            }
        }


        public void limpiar()
        {
            txtCantDias.Clear();
            txtDesde.Clear();
            txtHasta.Clear();
            txtProb1.Clear();
            txtProb2.Clear();
            txtProb5.Clear();
            txtProb6.Clear();
            txtProb7.Clear();
            txtProb8.Clear();
            txtProb10.Clear();
            txtPrecio1.Clear();
            txtPrecio2.Clear();
            txtPrecio5.Clear();
            txtPrecio6.Clear();
            txtPrecio7.Clear();
            txtPrecio8.Clear();
            txtPrecio10.Clear();
            gdrSimulacion.Rows.Clear();
            cantDias = 0;
            acumuladorPastelitosSobrantes = 0;
            promedioPastelitos = 0;
            utilidadPromedio = 0;
            clientesDiarios = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private bool validarDemanda()
        {
            float cant = float.Parse(txtProb1.ToString()) + float.Parse(txtProb2.ToString()) + float.Parse(txtProb5.ToString()) + float.Parse(txtProb6.ToString()) + float.Parse(txtProb7.ToString()) + float.Parse(txtProb8.ToString()) + float.Parse(txtProb10.ToString());
            if (cant == 1.0)
            {
                return true;
            }
            return false;
        } 

        private int generadorClientesDiarios()
        {
            Random rand = new Random();
            int cantClientesDiarios = 0;
            double nroRnd = Math.Round(rand.NextDouble(), 4);
            cantClientesDiarios = (int)(limiteInf + nroRnd * (limiteSup - limiteInf));
            return cantClientesDiarios;
        }

        private int demandaClientes() 
        {
            int demanda = 0;
            Random rand = new Random();
            double nroRnd = Math.Round(rand.NextDouble(), 4);
            double p1, p2, p5, p6, p7, p8, p10 = 0;
            p1 = Convert.ToDouble(txtProb1.ToString());
            p2 = Convert.ToDouble(txtProb2.ToString()) + p1;
            p5 = Convert.ToDouble(txtProb5.ToString()) + p2;
            p6 = Convert.ToDouble(txtProb6.ToString()) + p5;
            p7 = Convert.ToDouble(txtProb7.ToString()) + p6;
            p8 = Convert.ToDouble(txtProb5.ToString()) + p7;
            p10 = Convert.ToDouble(txtProb5.ToString()) + p8;
            if (nroRnd < p1)
            {
                demanda = 1;
            }
            else if (nroRnd < p2)
            {
                demanda = 2;
            }
            else if (nroRnd < p5)
            {
                demanda = 5;
            }
            else if (nroRnd < p6)
            {
                demanda = 6;
            }
            else if (nroRnd < p7)
            {
                demanda = 7;
            }
            else if (nroRnd < p8)
            {
                demanda = 8;
            }
            else
            {
                demanda = 10;
            }
            return demanda;
        }

        private double precioDemanda(int demanda) 
        {
            double precio = 0;
            if (demanda == 1)
            {
                precio = demanda * double.Parse(txtPrecio1.ToString());
            }
            else if (demanda == 2)
            {
                precio = demanda * double.Parse(txtPrecio2.ToString());
            }
            else if (demanda == 5)
            {
                precio = demanda * double.Parse(txtPrecio5.ToString());
            }
            else if (demanda == 6)
            {
                precio = demanda * double.Parse(txtPrecio6.ToString());
            }
            else if (demanda == 7)
            {
                precio = demanda * double.Parse(txtPrecio7.ToString());
            }
            else if (demanda == 8)
            {
                precio = demanda * double.Parse(txtPrecio8.ToString());
            }
            else
            {
                precio = demanda * double.Parse(txtPrecio10.ToString());
            }
            return precio;
        }

        private void cargarGrilla(int desde, int hasta, int dia, string cliente, double nroRnd, int demanda, double precio, int stock, int sobrante, double utilidad)
        {
            for (int i = desde; i < hasta; i++) 
            {
                if (i <= 100000)
                {
                    gdrSimulacion.Rows.Add(dia, cliente, nroRnd, demanda, precio, stock, "-", "-");
                }
            }
            gdrSimulacion.Rows.Add("Ultima simulacion", "-", "-", "-", "-", "-", sobrante, utilidad);
        }
    }
}
