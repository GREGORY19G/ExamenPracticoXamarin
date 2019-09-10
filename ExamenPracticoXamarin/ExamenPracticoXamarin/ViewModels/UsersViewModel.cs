using ExamenPracticoXamarin.Models;
using ExamenPracticoXamarin.Process;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPracticoXamarin.ViewModels
{
    public class UsersViewModel: User
    {
        private LoadUsers Data = new LoadUsers();
        public List<User> ListaUsuarios = new List<User>();

        public UsersViewModel()
        {
            ListaUsuarios = Data.ListaUsuarios();
        }

    }
}
