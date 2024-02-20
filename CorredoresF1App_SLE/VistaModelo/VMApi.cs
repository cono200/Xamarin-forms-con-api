using CorredoresF1App_SLE.Modelo;
using Newtonsoft.Json;
using System;
//using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace CorredoresF1App_SLE.VistaModelo
{
    public class VMAPi : BaseViewModel //ESTE ES EL CORREDOR DEL EJEMPLO DEL PROFE
    {
        #region VARIABLES
         private string _Id;
        private  string _Name;
        private  string _Team;
        private  int _Number;
        #endregion
        #region CONSTRUCTOR
        public VMAPi(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        public string Id
        {
            get { return _Id; }
            set { SetValue(ref _Id, value); }
        } 
        public string Name
        {
            get { return _Name; }
            set { SetValue(ref _Name, value); }
        } 
        public string Team
        {
            get { return _Team; }
            set { SetValue(ref _Team, value); }
        }
        public int Number
        {
            get { return _Number; }
            set { SetValue(ref _Number, value); }
        }
        #endregion
        #region PROCESOS
        public async Task Insertar()
        {
            Mcorredor mcorredor = new Mcorredor
            {
               // Id = Id, //IZQUIERDA  ES EL NOMBRE QUE VA EN EL MODELO
                Name = Name,
                Team = Team,
                Number = Number
            };

            Uri RequestUri = new
                Uri("http://www.CorredoresFormCono.somee.com/Api/Drivers"); //VERIFICAR EL LINK, SUBIR VERSION DE GIT CORREGIDO D:
            var client = new HttpClient();
            var json = JsonConvert.SerializeObject(mcorredor);
            var contentJson = new StringContent(json, Encoding.UTF8, "application/json");
               var response =  await client.PostAsync(RequestUri, contentJson);

            if (response.StatusCode == HttpStatusCode.Created)
            {
                await DisplayAlert("Mensaje", "Registrado", "Ok");
            }
            else
            {
                await DisplayAlert("Mensaje", "No se registro", "Ok");
            }
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand InsertarCorredorCommand => new Command(async () => await Insertar());
        public ICommand ProcesoSimpCommand => new Command(ProcesoSimple);
        #endregion

    }
}
