using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    class Myclass
    {
        public string Name = "Eddie";
        //public string name
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
        //name = Name;
        protected int Age = 49;
        protected void ShowMessage(string Message)
        {
            MessageBox.Show(Message);
        }
    }
    class MySecondClass : Myclass
    {
        public string HairColour = "Brown";
        public void MesssageBoxSpecial()
        {
            //MessageBox.Show(base.Age.ToString());
            base.ShowMessage(base.Age.ToString());
        }
    }
}
