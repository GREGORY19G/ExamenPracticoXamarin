using ExamenPracticoXamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenPracticoXamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Detalle : ContentPage
	{
		public Detalle ()
		{
			InitializeComponent ();
		}
        public Detalle(User user)
        {

            InitializeComponent();
            Titulo.Text = "Detalles de " + user.FirstName + " " + user.LastName;
            Nombre.Text = user.FirstName;
            Apellido.Text = user.LastName;
            Email.Text = user.Email;
            Telefono.Text = user.Phone;
            Celular.Text = user.Cell;
            Ciudad.Text = user.City;
            Estado.Text = user.State;
            Picture.Source = user.Picture;
        }
    }
}