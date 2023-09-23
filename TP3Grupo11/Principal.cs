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
        double costoPastelito = 30;
        double costoDiario = 0;
        double promedioPastelitos = 0;
        double utilidadPromedio = 0;
        double acumuladorVentasDiarias = 0;
        double acumuladorUtilidad = 0;
        int limiteInf = 10;
        int limiteSup = 30;
        int acumuladorPastelitosSobrantesDiarios = 0;
        int cantDias = 0;
        int clientesDiarios = 0;
        int demandaCliente = 0;
        double precioDemandaCliente = 0;
        int acumuladorStockSobrante = 0;
        int contadorIteracionesMostradas = 0;
        double acumuladorUtilidadDiaria = 0;

        private void simulacion()
        {
            if (validarDemanda() == true) 
            {
                costoDiario = costoPastelito * stockPastelitos;
                cantDias = int.Parse(txtCantDias.Text);
                for (int i = 1; i < cantDias; i++)
                {
                    Random rand = new Random();
                    double nroRandomClientesDiarios = Math.Round(rand.NextDouble(), 4);
                    clientesDiarios = generadorClientesDiarios(nroRandomClientesDiarios);
                    stockPastelitos = 200;
                    acumuladorUtilidadDiaria = 0;
                    acumuladorVentasDiarias = 0;
                    acumuladorPastelitosSobrantesDiarios = 0;
                    if (i >= int.Parse(txtDesde.Text.ToString()) && i <= int.Parse(txtHasta.Text.ToString()) && contadorIteracionesMostradas < 100000)
                    {
                        gdrSimulacion.Rows.Add(i, nroRandomClientesDiarios ,"Clientela: " + clientesDiarios, "-", "-", "-", stockPastelitos, "-", "-", "-", "-");
                        contadorIteracionesMostradas++;
                    }
                    for (int cliente = 1;  cliente <= clientesDiarios; cliente ++)
                    {
                        double nroRndDemanda = Math.Round(rand.NextDouble(), 4);
                        demandaCliente = demandaClientes(nroRndDemanda);
                        if (demandaCliente <= stockPastelitos)
                        {
                            precioDemandaCliente = precioDemanda(demandaCliente);
                            stockPastelitos = stockPastelitos - demandaCliente;
                            acumuladorVentasDiarias += precioDemandaCliente;
                            if (i >= int.Parse(txtDesde.Text.ToString()) && i <= int.Parse(txtHasta.Text.ToString()) && contadorIteracionesMostradas < 100000)
                            {
                                gdrSimulacion.Rows.Add(i, "-" ,"Cliente " + cliente, nroRndDemanda, demandaCliente, precioDemandaCliente, stockPastelitos, "-", "-", "-", "-");
                                contadorIteracionesMostradas++;
                            }
                        }
                    }
                    acumuladorPastelitosSobrantesDiarios = stockPastelitos;
                    acumuladorUtilidadDiaria = acumuladorVentasDiarias - costoDiario;
                    acumuladorUtilidad += acumuladorUtilidadDiaria;
                    if (i >= int.Parse(txtDesde.Text.ToString()) && i <= int.Parse(txtHasta.Text.ToString()) && contadorIteracionesMostradas < 100000)
                    {
                        gdrSimulacion.Rows.Add(i, "-", "-", "-", "-", "-", "-", acumuladorPastelitosSobrantesDiarios, "-", acumuladorUtilidad, "-");
                        contadorIteracionesMostradas++;
                    }
                    acumuladorStockSobrante += acumuladorPastelitosSobrantesDiarios;
                }
                utilidadPromedio = Math.Round((acumuladorUtilidad / cantDias),4);
                promedioPastelitos = (acumuladorStockSobrante / cantDias);
                gdrSimulacion.Rows.Add("Fin", "-", "-", "-", "-", "-", "-", "-", promedioPastelitos, "-", utilidadPromedio);
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
            acumuladorPastelitosSobrantesDiarios = 0;
            promedioPastelitos = 0;
            utilidadPromedio = 0;
            clientesDiarios = 0;
            contadorIteracionesMostradas = 0;
            promedioPastelitos = 0;
            utilidadPromedio = 0;
            acumuladorStockSobrante = 0;
            acumuladorUtilidad = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private bool validarDemanda()
        {
            double cant = Convert.ToDouble(txtProb1.Text.ToString()) + Convert.ToDouble(txtProb2.Text.ToString()) + Convert.ToDouble(txtProb5.Text.ToString()) + Convert.ToDouble(txtProb6.Text.ToString()) + Convert.ToDouble(txtProb7.Text.ToString()) + Convert.ToDouble(txtProb8.Text.ToString()) + Convert.ToDouble(txtProb10.Text.ToString());
            if (cant == 1.0)
            {
                return true;
            }
            return false;
        } 

        private int generadorClientesDiarios(double rndRandomClientesDiarios)
        {
            int cantClientesDiarios = 0;
            Random rand = new Random();
            double nroRnd = rndRandomClientesDiarios;
            cantClientesDiarios = (int)(limiteInf + nroRnd * (limiteSup - limiteInf));
            return cantClientesDiarios;
        }

        private int demandaClientes(double nroRandomDemanda) 
        {
            int demanda = 0;
            double nroRnd = nroRandomDemanda;
            double p1, p2, p5, p6, p7, p8, p10 = 0;
            p1 = Convert.ToDouble(txtProb1.Text.ToString());
            p2 = Convert.ToDouble(txtProb2.Text.ToString()) + p1;
            p5 = Convert.ToDouble(txtProb5.Text.ToString()) + p2;
            p6 = Convert.ToDouble(txtProb6.Text.ToString()) + p5;
            p7 = Convert.ToDouble(txtProb7.Text.ToString()) + p6;
            p8 = Convert.ToDouble(txtProb5.Text.ToString()) + p7;
            p10 = Convert.ToDouble(txtProb5.Text.ToString()) + p8;
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
                precio = demanda * double.Parse(txtPrecio1.Text.ToString());
            }
            else if (demanda == 2)
            {
                precio = demanda * double.Parse(txtPrecio2.Text.ToString());
            }
            else if (demanda == 5)
            {
                precio = demanda * double.Parse(txtPrecio5.Text.ToString());
            }
            else if (demanda == 6)
            {
                precio = demanda * double.Parse(txtPrecio6.Text.ToString());
            }
            else if (demanda == 7)
            {
                precio = demanda * double.Parse(txtPrecio7.Text.ToString());
            }
            else if (demanda == 8)
            {
                precio = demanda * double.Parse(txtPrecio8.Text.ToString());
            }
            else
            {
                precio = demanda * double.Parse(txtPrecio10.Text.ToString());
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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            simulacion();
        }
    }
}
