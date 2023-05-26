using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFACADESTRUC
{
    public class CEstructura
    {
        // Para conexión
        private string sIp;
        private string sUsuario;
        private string sPass;
        private string sBaseDeDatos;
        private Int32 nPuerto;

        // Usuario
        private Int32 nAtributo;
        private Int32 nIdEmpleado;
        private string sNombreUsuario;

        // Operar sistema
        private string sIpMaquina;
        private Int32 nAccederMenu;
        private Int32 nOpcion;

        public string Ip { get => sIp; set => sIp = value; }
        public string Usuario { get => sUsuario; set => sUsuario = value; }
        public string Pass { get => sPass; set => sPass = value; }
        public string BaseDeDatos { get => sBaseDeDatos; set => sBaseDeDatos = value; }
        public int Puerto { get => nPuerto; set => nPuerto = value; }
        public int Atributo { get => nAtributo; set => nAtributo = value; }
        public int IdEmpleado { get => nIdEmpleado; set => nIdEmpleado = value; }
        public string NombreUsuario { get => sNombreUsuario; set => sNombreUsuario = value; }
        public string IpMaquina { get => sIpMaquina; set => sIpMaquina = value; }
        public int AccederMenu { get => nAccederMenu; set => nAccederMenu = value; }
        public int Opcion { get => nOpcion; set => nOpcion = value; }
    }

}
