using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploVentanas.Models
{
    public class Estudiante
    {
        public int id {  get; set; }
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNacimiento;
        private bool _pregrado;
        private float _promedio;
        
        public string nombre
        {
            get {
                return _nombre;
            }
            set { 
                if(value.Length > 2 && value.Length < 20)
                    _nombre = value;
            }
        }
        public string apellido
        {
            get
            {
                return _apellido;
            }
            set
            {
                if (value.Length > 2 && value.Length < 20)
                    _apellido = value;
            }
        }
        public bool pregrado
        {
            get
            {
                return _pregrado;
            }
            set
            {
                _pregrado = value;
            }
        }
        public float promedio
        {
            get
            {
                return _promedio;
            }
            set
            {
                if(value >= 0 && value <= 100)
                _promedio = value;
            }
        }
        public DateTime fechaNacimiento
        {
            get
            {
                return _fechaNacimiento;
            }
            set
            {
                if (value < DateTime.Now)
                    _fechaNacimiento = value;
            }
        }
    }
}
