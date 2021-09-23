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
    public partial class Main : Form
    {
        private BussinesLogicLayer _bussinesLogicLayer;
        public Main()
        {
            InitializeComponent();
            _bussinesLogicLayer = new BussinesLogicLayer();
        }

        #region eventos
        private void ButtonAniadir_Click(object sender, EventArgs e)
        {
            OpenDialog();
        }
        #endregion

        #region private methods
        private void OpenDialog()
        {
            ConctactDetails conctactDetails = new ConctactDetails();
            conctactDetails.ShowDialog(this);
        }
        private void OpenDialog(Contact contacto)
        {
            ConctactDetails conctactDetails = new ConctactDetails(contacto);
            conctactDetails.ShowDialog(this);
        }


        #endregion

        private void Main_Load(object sender, EventArgs e)
        {
            PopulateContacts();
        }

        public void PopulateContacts()
        {
            try
            {
                List<Contact> contacList = _bussinesLogicLayer.GetContacts();
                dataGridviewXXX.DataSource = contacList;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void dataGridviewXXX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string editarText = "Editar";
            string eliminarText = "Eliminar";
            int editarIndex = dataGridviewXXX.Columns.IndexOf
                                (dataGridviewXXX.Columns.Cast<DataGridViewColumn>()
                                .FirstOrDefault(columna => columna.Name == editarText));
            int eliminarIndex = dataGridviewXXX.Columns.IndexOf
                    (dataGridviewXXX.Columns.Cast<DataGridViewColumn>()
                    .FirstOrDefault(columna => columna.Name == eliminarText));
            int fila = e.RowIndex; //prescindible??

            Contact contact =
                        new Contact
                        {
                            Id = int.Parse(dataGridviewXXX.Rows[e.RowIndex].Cells[(int)Contact.ContactEnum.idIndex].Value.ToString()),
                            Nombre = dataGridviewXXX.Rows[e.RowIndex].Cells[(int)Contact.ContactEnum.nombreIndex].Value.ToString(),
                            Apellido = dataGridviewXXX.Rows[e.RowIndex].Cells[(int)Contact.ContactEnum.apellidoIndex].Value.ToString(),
                            Direccion = dataGridviewXXX.Rows[e.RowIndex].Cells[(int)Contact.ContactEnum.direccionIndex].Value.ToString(),
                            Telefono = dataGridviewXXX.Rows[e.RowIndex].Cells[(int)Contact.ContactEnum.telefonoIndex].Value.ToString()
                        };

            if (e.ColumnIndex == editarIndex)
            {
                OpenDialog(contact);
            }

            if (e.ColumnIndex == eliminarIndex)
            {
                _bussinesLogicLayer.Delete(contact);
                PopulateContacts();
            }
        }
    }
}
