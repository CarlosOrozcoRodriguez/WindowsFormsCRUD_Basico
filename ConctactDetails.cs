using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTestVideo
{
    public partial class ConctactDetails : Form
    {
        private BussinesLogicLayer _bussinesLogicLayer;

        private Contact _contact;

        public ConctactDetails()
        {
            InitializeComponent();
            _bussinesLogicLayer = new BussinesLogicLayer();
            
        }

        public ConctactDetails(Contact contacto)
        {
            InitializeComponent();
            _bussinesLogicLayer = new BussinesLogicLayer();
            LoadContactInForm(contacto);

        }


        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            SalirDetalles();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            SaveContact();
            SalirDetalles();
            ((Main)this.Owner).PopulateContacts();
        }

        private void SalirDetalles()
        {
            this.Close();
        }

        private void SaveContact()
        {
            Contact contact = new Contact();
            contact.Nombre = textBoxNombre.Text;
            contact.Apellido = textBoxApellido.Text;
            contact.Direccion = textBoxDireccion.Text;
            contact.Telefono = textBoxTelefono.Text;

            contact.Id = _contact != null ? _contact.Id : 0;

            _bussinesLogicLayer.Save(contact);
        }

        private void LoadContactInForm(Contact contact)
        {
            _contact = contact;

            textBoxNombre.Text = contact.Nombre;
            textBoxApellido.Text = contact.Apellido;
            textBoxDireccion.Text = contact.Direccion;
            textBoxTelefono.Text = contact.Telefono;
        }
    }
}
