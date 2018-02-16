using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantiT.Forms.Host.Models
{
    public class ConnectionViewModel : INotifyPropertyChanged
    {
        private readonly CollectionView mvItems;
        private readonly CollectionView mvGroups;        
          
        public ConnectionViewModel()
        {
            MeasuredViewRepository mvRepo = new MeasuredViewRepository();
            mvItems = new CollectionView( mvRepo.MessuredViews);
            mvGroups = new CollectionView(mvRepo.MessuredViewGroups);
        }

        public CollectionView MeasuredViews
        {
            get { return mvItems; }
        }

        public CollectionView MeasuredViewGroups
        { 
            get { return mvGroups; }
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
