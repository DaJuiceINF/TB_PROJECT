using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;
using Crud.Model;
using Android.Locations;

namespace Crud
{
    public partial class MainPage : ContentPage
    {
        private SQLiteConnection conn;
        public Patient patient;
        public MainPage()
        {
            InitializeComponent();
            conn = DependencyService.Get<ISQLite>().GetConnection();
            conn.CreateTable<Patient>(); 
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {

            patient = new Patient();
            patient.Name = Name.Text;
            patient.Address = address.Text;
            conn.Insert(patient);
            Name.Text = "";
            address.Text = "";
        }

        private void ShowButton_Clicked(object sender, EventArgs e)
        {
            var data = (from pat in conn.Table<Patient>() select pat);
            Datalist.ItemsSource = data;
        }
    }
}
