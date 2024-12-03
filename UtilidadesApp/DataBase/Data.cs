using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilidadesApp.DataBase
{
    public class Data
    {
        public Data()
        {
            DataItems = new List<DataItem>();
        }
        public string NombreMetodo;
        public List<DataItem> DataItems;
    }
}
