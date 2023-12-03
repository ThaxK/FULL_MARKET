using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CL_capaNegocios
{
    public class Validaciones
    {
        Regex regexNombreApellidos = new Regex("^[a-zA-Záéíóú\\s]{0,50}$");
        Regex regexTelefono = new Regex("^[3][0-9]{9}$");
        Regex regexDocumento = new Regex("^[0-9]{10,11}$");
        Regex regexCorreo = new Regex("^[a-zA-Z0-9-_]{0,50}[@][a-zA-Z0-9.]{0,50}$");
        Regex regexDireccion = new Regex("^[a-zA-Z0-9.#\\s-]{0,100}$");
        Regex regexWeb = new Regex("^[a-zA-Z0-9/.]{0,100}$");
        Regex regexNit = new Regex("^[0-9-]{12}$");
        Regex regexNumeros = new Regex("^[0-9]{0,7}$");

        public bool NombreApellidos(string palabra)
        {
            if(regexNombreApellidos.Match(palabra).Success) 
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Telefono(string palabra)
        {
            if (regexTelefono.Match(palabra).Success)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Documento(string palabra)
        {
            if (regexDocumento.Match(palabra).Success)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Correo(string palabra)
        {
            if (regexCorreo.Match(palabra).Success)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Direccion(string palabra)
        {
            if (regexDireccion.Match(palabra).Success)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Web(string palabra)
        {
            if (regexWeb.Match(palabra).Success)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Nit(string palabra)
        {
            if (regexNit.Match(palabra).Success)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Numeros(string palabra)
        {
            if (regexNumeros.Match(palabra).Success)
            {
                return true;
            }
            else
            {
                return false;
            }

        }public bool Numeross(string palabra)
        {
            if (regexNumeros.Match(palabra).Success)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
