using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2_RoundRobin
{
    class Proceso
    {
        int ID;
        int Tiempo;
        int Quantum;
        int TiempoTranscurrido;
        int TiempoLlegada;
        int TiempoRespuesta;
        int TiempoFinalizacion;
        bool Respuesta = false;

        public Proceso(int ID, int Tiempo, int Quantum)
        {
            this.ID = ID;
            this.Tiempo = Tiempo;
            this.Quantum = Quantum;
            this.TiempoTranscurrido = 0;
        }

        public int GetID()
        {
            return ID;
        }

        public int GetTiempo()
        {
            return Tiempo;
        }

        public int GetQuantum()
        {
            return Quantum;
        }

        public int GetTiempoTranscurrido()
        {
            return TiempoTranscurrido;
        }
        public void SetTiempoTranscurrido(int TT)
        {
            TiempoTranscurrido=TT;
        }
        public int GetTiempoLlegada()
        {
            return TiempoLlegada;
        }

        public void SetTiempoLlegada(int Numero)
        {
            TiempoLlegada = Numero;
        }
        public int GetTiempoRespuesta()
        {
            return TiempoRespuesta;
        }

        public void SetTiempoRespuesta(int Numero)
        {
            TiempoRespuesta = Numero;
        }

        public void SetRespuesta(bool Booleano)
        {
            Respuesta = Booleano;
        }

        public bool GetRespuesta()
        {
            return Respuesta;
        }
        public int GetTiempoFinalizacion()
        {
            return TiempoFinalizacion;
        }

        public void SetTiempoFinalizacion(int Numero)
        {
            TiempoFinalizacion = Numero;
        }
    }
}
