using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Threading;

namespace Actividad_2_RoundRobin
{
    public partial class Main : Form
    {
        List<Proceso> Nuevo = new List<Proceso>();
        List<Proceso> Listo = new List<Proceso>();
        List<Proceso> Ejecucion = new List<Proceso>();
        List<Proceso> Bloqueado = new List<Proceso>();
        List<Proceso> Terminado = new List<Proceso>(); //Listas que representan cada etapa del sistema operativo
        int ID = 1;
        int NumProcesos;
        int TiempoTotal=0;
        int Idle = 0;
        int Ocupado = 0;
        bool B = false;

        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtNumProcesos.Text.Equals(""))
            {
                MessageBox.Show("Campos Vacios");
                return;
            }
            if (!int.TryParse(TxtNumProcesos.Text, out NumProcesos))
            {
                MessageBox.Show("Numero de Procesos Inaceptable");
                return; //Saber si es un numero
            }
            Random Aleatorio = new Random();
            for (int i=0; i < NumProcesos; i++)
            {
                int Tiempo;
                int Quantum;
                Tiempo = Aleatorio.Next(0, 25);
                Quantum = Aleatorio.Next(1, 25);
                Proceso Hilo = new Proceso(ID, Tiempo, Quantum);
                Nuevo.Add(Hilo);
                ListBoxNuevo.Items.Add("ID: " + Hilo.GetID() + " " + "Tiempo: " + Hilo.GetTiempo() + " " + "Quantum: " + Hilo.GetQuantum());
                ListBoxNuevo.Refresh();
                Thread.Sleep(100); // Quantum y Tiempo aleatorio como maximo 25
                ID++;
            }
            Ejecutar();
        }

        public async void Ejecutar()
        {
            for (int i = 0; i < Nuevo.Count; i++)
            {
                if (Listo.Count == 2)
                    break;
                else
                {
                    Nuevo[i].SetTiempoLlegada(TiempoTotal);
                    Listo.Add(Nuevo[i]);
                    Nuevo.RemoveAt(i);
                    ListBoxNuevo.Items.RemoveAt(0);
                    ListBoxNuevo.Refresh();
                    Thread.Sleep(400);
                    ListBoxListo.Items.Add("ID: " + Listo[Listo.Count - 1].GetID() + " " + "Tiempo: " + Listo[Listo.Count - 1].GetTiempo() + " " + "Quantum: " + Listo[Listo.Count - 1].GetQuantum());
                    ListBoxListo.Refresh();
                    Thread.Sleep(400);//Meto 2 procesos a listo
                    i--;
                }
            }
            Ejecucion.Add(Listo[0]);
            Listo.RemoveAt(0);//Uno se  va directamente a ejecucion
            while (Terminado.Count != NumProcesos)
            {
                bool Bandera = false;
                ListBoxListo.Items.RemoveAt(0);
                ListBoxListo.Refresh();
                int Contador = 0;
                for (int Time = Ejecucion[0].GetTiempoTranscurrido(); Time != Ejecucion[0].GetTiempo(); Time++)
                {
                    await Teclazo();
                    if (B)
                    {
                        Bandera = true;
                        break;//Toma su tiempo transcurrido y lo compara hasta que llegue a el tiempo esperado
                    }
                    if (Contador == Ejecucion[0].GetQuantum())
                    {
                        Nuevo.Add(Ejecucion[0]);
                        ListBoxNuevo.Items.Add("ID: " + Ejecucion[0].GetID() + " " + "Tiempo: " + Ejecucion[0].GetTiempo() + " " + "Quantum: " + Ejecucion[0].GetQuantum());
                        ListBoxNuevo.Refresh();
                        Ejecucion.RemoveAt(0);
                        ListBoxEjecucion.Items.Clear();//Revisa si se llego al Quantum
                        ListBoxEjecucion.Refresh();
                        Bandera = true;
                        Thread.Sleep(500);
                        break;
                    }
                    Ejecucion[0].SetTiempoTranscurrido(Ejecucion[0].GetTiempoTranscurrido() + 1);

                    ListBoxEjecucion.Items.Clear();
                    ListBoxEjecucion.Items.Add("ID " + Ejecucion[0].GetID());
                    ListBoxEjecucion.Items.Add("Tiempo: " + Ejecucion[0].GetTiempo());
                    ListBoxEjecucion.Items.Add("Quantum: " + Ejecucion[0].GetQuantum());
                    ListBoxEjecucion.Items.Add("Tiempo Transcurrido: " + Ejecucion[0].GetTiempoTranscurrido());
                    ListBoxEjecucion.Refresh(); //Informacion de Ejecucion
                    
                    if (Ejecucion[0].GetRespuesta() == false)
                    {
                        Ejecucion[0].SetRespuesta(true);
                        Ejecucion[0].SetTiempoRespuesta(TiempoTotal - Ejecucion[0].GetTiempoLlegada());
                    }
                    Contador++;
                    TiempoTotal++;
                    if (Nuevo.Count != 0 && Listo.Count != 0)
                        Ocupado++;
                    Idle = TiempoTotal - Ocupado;
                    LbTiempo.Text = TiempoTotal.ToString();
                    LbIdle.Text = Idle.ToString();
                    LbOcupado.Text = Ocupado.ToString();
                    LbIdle.Refresh();
                    LbOcupado.Refresh(); //Actualizacion de etiquetas de CPU
                    LbTiempo.Refresh();
                    Thread.Sleep(400);
                }
                if (B)
                {
                    Bloqueado.Add(Ejecucion[0]);
                    DataGridViewRow FilaBloqueada = new DataGridViewRow();
                    this.TablaBloqueados.DefaultCellStyle.Font = new Font("Arial", 14);
                    FilaBloqueada.CreateCells(TablaBloqueados);
                    FilaBloqueada.Cells[0].Value = Ejecucion[0].GetID();
                    FilaBloqueada.Cells[1].Value = Ejecucion[0].GetTiempo();
                    TablaBloqueados.Rows.Add(FilaBloqueada);
                    TablaBloqueados.Update(); //Si se presiono la B añade fila a la tabla
                    Ejecucion.Remove(Ejecucion[0]);
                    ListBoxEjecucion.Items.Clear();
                    B = false;
                }
                if (Bandera == false)
                {
                    ListBoxTerminado.Items.Add("ID: " + Ejecucion[0].GetID() + " " + "Tiempo: " + Ejecucion[0].GetTiempo() + " " + "Quantum: " + Ejecucion[0].GetQuantum());
                    Ejecucion[0].SetTiempoFinalizacion(TiempoTotal);
                    Terminado.Add(Ejecucion[0]);
                    Ejecucion.RemoveAt(0);
                    ListBoxEjecucion.Items.Clear();
                    ListBoxEjecucion.Refresh(); //Para evitar que terminen procesos cuando no se desea
                    ListBoxTerminado.Refresh();
                }
                if(Nuevo.Count==0 && Listo.Count==0 && Ejecucion.Count==0 && Bloqueado.Count != 0)
                {
                    while(Nuevo.Count == 0 && Listo.Count == 0 && Ejecucion.Count == 0)
                    {
                        await Teclazo();
                        Contador++;
                        TiempoTotal++;
                        if (Nuevo.Count != 0 && Listo.Count != 0)
                            Ocupado++;
                        Idle = TiempoTotal - Ocupado;
                        LbTiempo.Text = TiempoTotal.ToString();
                        LbIdle.Text = Idle.ToString();
                        LbOcupado.Text = Ocupado.ToString();
                        LbIdle.Refresh();
                        LbOcupado.Refresh(); //Si todo lo que queda son bloqueados
                        LbTiempo.Refresh();
                        Thread.Sleep(400);
                    }
                }
                if (Listo.Count != 0 && Nuevo.Count == 0)
                {
                    Ejecucion.Add(Listo[0]);
                    Listo.RemoveAt(0);
                    Thread.Sleep(500); //Si no hay nuevos
                    continue;
                }
                if (Nuevo.Count != 0)
                {
                    Nuevo[0].SetTiempoLlegada(TiempoTotal);
                    Listo.Add(Nuevo[0]);
                    ListBoxNuevo.Items.RemoveAt(0);
                    ListBoxNuevo.Refresh();
                    ListBoxListo.Items.Add("ID: " + Nuevo[0].GetID() + " " + "Tiempo: " + Nuevo[0].GetTiempo() + " " + "Quantum: " + Nuevo[0].GetQuantum());
                    ListBoxListo.Refresh();
                    Nuevo.RemoveAt(0);
                    Ejecucion.Add(Listo[0]); //Si hay nuevos
                    Listo.RemoveAt(0);
                    Thread.Sleep(500);
                    continue;
                }
            }
            int Max = 0, Min = 64684648, Suma = 0;
            double Resultado;

            List<double> Desviacion = new List<double>();
            foreach (Proceso i in Terminado)
            {
                if (i.GetTiempoRespuesta() < Min)
                    Min = i.GetTiempoRespuesta();
                if (i.GetTiempoRespuesta() > Max)
                    Max = i.GetTiempoRespuesta();
                Suma = Suma + i.GetTiempoRespuesta();
                double Valor = (double)i.GetTiempoRespuesta();
                Desviacion.Add(Valor);
            }
            Suma = Suma / Terminado.Count;
            Resultado = getStandardDeviation(Desviacion); //Formulas para los datos
            LbRespuestaMin.Text = Min.ToString();
            LbRespuestaMax.Text = Max.ToString();
            LbRespuestaMedia.Text = Suma.ToString();
            LbRespuestaDesviacion.Text = Resultado.ToString();

            Desviacion.Clear();
            foreach (Proceso i in Terminado)
            {
                if (i.GetTiempoFinalizacion()-i.GetTiempoLlegada() < Min)
                    Min = i.GetTiempoFinalizacion() - i.GetTiempoLlegada();
                if (i.GetTiempoFinalizacion() - i.GetTiempoLlegada() > Max)
                    Max = i.GetTiempoFinalizacion() - i.GetTiempoLlegada();
                Suma = Suma + i.GetTiempoFinalizacion() - i.GetTiempoLlegada();
                double Valor = (double)(i.GetTiempoFinalizacion() - i.GetTiempoLlegada());
                Desviacion.Add(Valor);
            }
            Suma = Suma / Terminado.Count;
            Resultado = getStandardDeviation(Desviacion);
            LbRetornoMin.Text = Min.ToString();
            LbRetornoMax.Text = Max.ToString();
            LbRetornoMedio.Text = Suma.ToString();
            LbRetornoDesviacion.Text = Resultado.ToString();
        }
        private async Task Teclazo()
        {
            await Task.Delay(500);
        }
        private double getStandardDeviation(List<double> doubleList)//Metodo de desviacion Estandar
        {
            double average = doubleList.Average();
            double sumOfDerivation = 0;
            foreach (double value in doubleList)
            {
                sumOfDerivation += (value) * (value);
            }
            double sumOfDerivationAverage = sumOfDerivation / (doubleList.Count - 1);
            return Math.Sqrt(sumOfDerivationAverage - (average * average));
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'B')
            {
                B = true;
            }
        }

        private void TablaBloqueados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Bloqueado.Count != 0)//Sacar los bloqueados de la tabla
            {
                Nuevo.Add(Bloqueado[e.RowIndex]);
                ListBoxNuevo.Items.Add("ID: " + Bloqueado[e.RowIndex].GetID() + " " + "Tiempo: " + Bloqueado[e.RowIndex].GetTiempo() + " " + "Quantum: " + Bloqueado[e.RowIndex].GetQuantum());
                ListBoxNuevo.Refresh();
                Bloqueado.RemoveAt(e.RowIndex);
                TablaBloqueados.Rows.RemoveAt(e.RowIndex);
                TablaBloqueados.Update();
            }
            ActiveControl = button1;
        }
    }
}
