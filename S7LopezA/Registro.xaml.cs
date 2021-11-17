﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using S7LopezA.Models;

namespace S7LopezA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        private SQLiteAsyncConnection con;
        public Registro()
        {
            InitializeComponent();
            con = DependencyService.Get<DataBase>().GetConnection();
        }

        private void btnAgregar_Clicked(object sender, EventArgs e)
        {
            try
            {
                var Registros = new Estudiante { Nombre = txtNombre.Text, Usuario = txtUsuario.Text, password = txtPassword.Text };
                con.InsertAsync(Registros);
                DisplayAlert("Alerta", "Dato Ingresado", "Ok");
                txtNombre.Text = "";
                txtPassword.Text = "";
                txtUsuario.Text = "";
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", "ERROR" + ex.Message, "OK");
            }
        }
    }
}