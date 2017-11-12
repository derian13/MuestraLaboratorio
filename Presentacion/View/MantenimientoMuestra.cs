using BusinessLogicApi.Business;
using BusinessLogicApi.DTO;
using BusinessLogicImpl.BusinessImpl;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.ViewModels
{
    public class MantenimientoMuestraVM : INotifyPropertyChanged
    {
        private Muestra _muestra;
        public Muestra muestra
        {
            get { return _muestra; }
            set
            {
                _muestra = value;
                this.OnPropertyChanged("muestra");
            }
        }
        public Muestra Selected { get; set; }

        private IMuestraBusiness muestraBusiness;
        public ObservableCollection<Muestra> Muestras { get; set; }

        public MantenimientoMuestraVM()
        {
            _muestra = new Muestra();
            muestraBusiness = new MuestraBusiness();
            Muestras = new ObservableCollection<Muestra>();
        }

        public void CreateMuestra()
        {
            Muestra retrievedMuestra = muestraBusiness.FindById(_muestra.Id);
            bool isEdit = retrievedMuestra == null;
            _muestra.FechaDeToma = DateTime.Now;

            if (isEdit)
            {
                muestraBusiness.Create(_muestra);
            }
            else
            {
                muestraBusiness.Update(_muestra);
            }
            LoadMuestras();
            muestra = new Muestra();
        }

        internal void Clear()
        {
            muestra = new Muestra();
        }

        internal void Edit()
        {
            muestra = new Muestra
            {
                Id = Selected.Id,
                FechaDeToma = Selected.FechaDeToma,
                NombrePersonaMuestreada = Selected.NombrePersonaMuestreada,
                NombrePersonaTomaMuestra = Selected.NombrePersonaTomaMuestra
            };
        }

        public void DeleteMuestra()
        {
            muestraBusiness.Remove(Selected.Id);
            Clear();
            LoadMuestras();
        }

        public void LoadMuestras()
        {
            Muestras.Clear();
            muestraBusiness.FindAll().ForEach(Muestras.Add);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
