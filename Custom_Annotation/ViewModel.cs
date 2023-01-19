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

            Collection.Add(new Model() { XValue = "David", YValue = 15 });
            Collection.Add(new Model() { XValue = "Steve", YValue = 20 });
            Collection.Add(new Model() { XValue = "Jack", YValue = 16 });
            Collection.Add(new Model() { XValue = "Roger", YValue = 25 });
            Collection.Add(new Model() { XValue = "John", YValue = 22 });
        }
    }

    public class Model
    {
        public double YValue { get; set; }
        public string? XValue { get; set; }
    }
}
