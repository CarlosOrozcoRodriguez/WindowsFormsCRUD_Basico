using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppTestVideo
{
    public class Contact
    {
        public enum ContactEnum
        {
            idIndex = 0,
            nombreIndex = 1,
            apellidoIndex = 2,
            direccionIndex = 3,
            telefonoIndex = 4
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

    }
}
