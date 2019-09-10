using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ExamenPracticoXamarin.ViewModels;
using ExamenPracticoXamarin.Models;

namespace ExamenPracticoXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsuariosMainPage : ContentPage
    {
        private UsersViewModel ViewModel = new UsersViewModel();
        public UsuariosMainPage()
        {
            InitializeComponent();

            MyListView.BindingContext = ViewModel;
            MyListView.ItemsSource = ViewModel.ListaUsuarios;
            MyListView.ItemSelected += MyListView_ItemSelected;
        }

        private void MyListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new Detalle(e.SelectedItem as User));
        }
    }
}
