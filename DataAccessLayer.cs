using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppTestVideo
{
    class DataAccessLayer
    {
        private  SqlConnection conn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WinformContacts;Data Source=DESKTOP-BUOLOPA\SQLEXPRESS
");
        public void InsertContact (Contact contact)
        {
            string query = @"
                                INSERT INTO Contacts (Nombre, Apellido, Telefono, Direccion)
                                VALUES (@Nombre, @Apellido, @Telefono, @Direccion)
                                ";
            ToDataBase(contact, query);
        }

        internal List<Contact> GetContacts(string filter = null)
        {
            List<Contact> contactos = new List<Contact>();
            try
            {
                conn.Open();
                string query = filter==null 
                                ? @"SELECT Id, Nombre, Apellido, Telefono, Direccion
                                    FROM Contacts" 
                                : @"SELECT Id, Nombre, Apellido, Telefono, Direccion
                                    FROM Contacts 
                                    WHERE Nombre = @Nombre" ;
                

                SqlCommand sqlCommand = new SqlCommand(query, conn);
                SqlParameter parameter = new SqlParameter("Nombre", filter??"");
                sqlCommand.Parameters.Add(parameter);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Contact contacto = new Contact
                    {
                        Id = int.Parse(reader["Id"].ToString()),
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        Telefono = reader["Telefono"].ToString(),
                        Direccion = reader["Direccion"].ToString()
                    };
                    contactos.Add(contacto);
                }
                return contactos;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public void Delete(Contact contact)
        {
            string query = @"
                            DELETE FROM Contacts
                                    WHERE Id = @Id
                            ";
            ToDataBase(contact, query);
        }

        public void UpdateContact (Contact contact)
        {
            string query = @"
                                UPDATE Contacts SET 
                                        Nombre = @Nombre, 
                                        Apellido = @Apellido, 
                                        Telefono = @Telefono,
                                        Direccion = @Direccion
                                    WHERE Id = @Id
                                ";
            ToDataBase(contact, query);
        }

        private void ToDataBase (Contact contact, string query)
        {
            try
            {
                conn.Open();

                SqlParameter sqlParameterNombre = new SqlParameter("@Nombre", contact.Nombre);
                SqlParameter sqlParameterApellido = new SqlParameter("@Apellido", contact.Apellido);
                SqlParameter sqlParameterTelefono = new SqlParameter("@Telefono", contact.Telefono);
                SqlParameter sqlParameterDireccion = new SqlParameter("@Direccion", contact.Direccion);
                SqlParameter sqlParameterId = new SqlParameter("@Id", contact.Id);

                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.Add(sqlParameterNombre);
                command.Parameters.Add(sqlParameterApellido);
                command.Parameters.Add(sqlParameterTelefono);
                command.Parameters.Add(sqlParameterDireccion);
                command.Parameters.Add(sqlParameterId);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
