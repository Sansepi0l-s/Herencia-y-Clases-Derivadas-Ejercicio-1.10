using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_10_ejercicio_1
{
    public class Empleado_por_comision
    {
        private string nombre;
        private string numeroSeguroSocial;
        private decimal ventasBrutas;
        private decimal tarifaComision;

        public Empleado_por_comision(string nombre, string nss, decimal ventas, decimal tarifas)
        {
            Nombre = nombre;
            NumeroSeguroSocial = nss;
            VentasBrutas = ventas;
            TarifaComision = tarifas;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string NumeroSeguroSocial
        {
            get { return numeroSeguroSocial; }
            set { numeroSeguroSocial = value; }
        }

        public decimal VentasBrutas
        {
            set { ventasBrutas = value; }
            get { return ventasBrutas; }
           
        }

        public decimal TarifaComision
        {
            set { tarifaComision = value; }
            get { return tarifaComision; }
           
        }

        public decimal Ingresos() { return (TarifaComision * VentasBrutas); }

        public override string ToString()
        {
            return string.Format("Empleado: {0} \nNumero de seguro: {1}\n" + "Ventas brutas: {2:F2}\nTarifa de comision: {3:F2}\n" +
            "Ingresos: {4:F2}", Nombre, NumeroSeguroSocial,
                VentasBrutas, TarifaComision, Ingresos());
        }
    }
}
