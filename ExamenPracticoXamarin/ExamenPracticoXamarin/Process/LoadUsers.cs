using System;
using System.Collections.Generic;
using System.Text;
using ExamenPracticoXamarin.Models;

namespace ExamenPracticoXamarin.Process
{
    public class LoadUsers
    {
        private List<User> Usuarios = new List<User>();
        private ConsumirApi Api = new ConsumirApi();

        private User MakeUser(Result result)
        {
            User usuario = new User();
            usuario.FirstName = result.Name.First;
            usuario.LastName = result.Name.Last;
            usuario.Phone = result.Phone;
            usuario.Picture = result.Picture.Large;
            usuario.State = result.Location.State;
            usuario.Cell = result.Cell;
            usuario.City = result.Location.City;
            usuario.Email = result.Email;

            return usuario;
        }
        public List<User> ListaUsuarios()
        {
            foreach(var item in Api.Data().Results)
            {
                Usuarios.Add(MakeUser(item));
            }
            return Usuarios;
        }

    }
}
