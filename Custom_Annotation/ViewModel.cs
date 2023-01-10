using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Annotation
{
    public class ViewModel
    {
        public ObservableCollection<Model> Collection { get; set; }
        public ViewModel()
        {
            Collection = new ObservableCollection<Model>();

            Collection.Add(new Model() { XValue = "2009", YValue = 15 });
            Collection.Add(new Model() { XValue = "2010", YValue = 20 });
            Collection.Add(new Model() { XValue = "2011", YValue = 16 });
            Collection.Add(new Model() { XValue = "2012", YValue = 25 });
            Collection.Add(new Model() { XValue = "2013", YValue = 22 });
        }
    }

    public class Model
    {
        public double YValue { get; set; }
        public string? XValue { get; set; }
    }
}
