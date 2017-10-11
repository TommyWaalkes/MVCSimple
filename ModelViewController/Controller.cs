using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewController
{
    class Controller
    {
        Model m;
        CarModel cm; 
        View v;
        public Controller()
        {
            m = new Model();
            cm = new CarModel();
            v = new View();
        }

        public void DisplayNames()
        {
            v.DisplayNames(m.GetAllNames());

        }
    }
}
