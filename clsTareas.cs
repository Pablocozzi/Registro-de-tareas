using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroTareas.pry
{
    internal class clsTareas
    {
        private string tar;
        private string est;
        private DateTime fec;

        public string Tarea
        {
            get { return tar; }
            set { tar = value; }
        }
        public string Estado
        {
            get { return est; }
            set { est = value; }
        }
        public DateTime Fecha
        {
            get { return fec; }
            set { fec = value; }
        }

        public DateTime hoy = DateTime.Now.Date;
        public string EstadoRango;
        public DateTime Desde;
        public DateTime Hasta;
        public string EstadoUnicaFecha;
        public DateTime Unica;

        public BindingList<clsTareas> ListaTareas = new BindingList<clsTareas>();



        public void Agregar(DataGridView grilla)
        {
            ListaTareas.Add(new clsTareas { Tarea = Tarea, Estado = Estado, Fecha = Fecha });
            grilla.DataSource = ListaTareas;
        }

        public void RangoFechas(DataGridView grilla)
        {
            var tareasEnRango = ListaTareas.Where(tarea => tarea.Fecha >= Desde && tarea.Fecha <= Hasta && tarea.Estado == EstadoRango).ToList();
            BindingList<clsTareas> nuevasTareas = new BindingList<clsTareas>();
            foreach (var tarea in tareasEnRango)
            {
                nuevasTareas.Add(new clsTareas { Tarea = tarea.Tarea, Estado = tarea.Estado, Fecha = tarea.Fecha });
            }
            grilla.DataSource = tareasEnRango;
        }

        public void UnaFecha(DataGridView grilla)
        {
            var tareasEnFecha = ListaTareas.Where(tarea => tarea.Fecha == Unica && tarea.Estado == EstadoUnicaFecha).ToList();
            BindingList<clsTareas> nuevasTareas = new BindingList<clsTareas>();
            foreach (var tarea in tareasEnFecha)
            {
                nuevasTareas.Add(new clsTareas { Tarea = tarea.Tarea, Estado = tarea.Estado, Fecha = tarea.Fecha });
            }
            grilla.DataSource = tareasEnFecha;
        }

        public void Listar(DataGridView grilla)
        {
            var Listar = ListaTareas.OrderBy(tarea => tarea.Fecha).ToList();
            grilla.DataSource = Listar;
        }

    }
}
