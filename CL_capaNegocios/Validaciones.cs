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
        Regex regexCiencuentaCaracteres = new Regex("^[a-zA-Záéíóú\\s]{0,50}$");
        Regex regexTelefono = new Regex("^[3][0-9]{9}$");
        Regex regexCorreo = new Regex("^[a-zA-Z0-9-_]{0,50}[@][a-zA-Z0-9.]{0,50}$");
        Regex regexDireccion = new Regex("^[a-zA-Z0-9.#\\s-]{0,100}$");
        Regex regexWeb = new Regex("^[a-zA-Z0-9/.]{0,200}$");
        Regex regexNit = new Regex("^[0-9-]{14}$");
        Regex regexSeisDigitos = new Regex("^1\\d{0, 5}$");
        Regex regexOnceDigitos = new Regex("^1\\d{0, 10}$");
        Regex regexDoscientosCaracteres = new Regex("^[a-zA-Záéíóú\\s]{20,200}$");

        public bool CincuentaCaracteres(string cincuentaCaracteres)
        {
            if(regexCiencuentaCaracteres.Match(cincuentaCaracteres).Success) 
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool SeisDigitos(string seisDigitos)
        {
            if (regexSeisDigitos.Match(seisDigitos).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool OnceDigitos(string onceDigitos)
        {
            if (regexOnceDigitos.Match(onceDigitos).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DoscientosCaracteres(string doscientos)
        {
            if (regexDoscientosCaracteres.Match(doscientos).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CorreoElectronico(string correo)
        {
            if (regexCorreo.Match(correo).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Direccion(string direccion)
        {
            if (regexDireccion.Match(direccion).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Telefono(string telefono)
        {
            if (regexTelefono.Match(telefono).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Nit(string nit)
        {
            if (regexNit.Match(nit).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Web(string web)
        {
            if (regexWeb.Match(web).Success)
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
