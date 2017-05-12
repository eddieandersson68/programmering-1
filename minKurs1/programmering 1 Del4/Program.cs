using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace programmering_1_Del4
{
    class Myclass
    {

        private string Name = "Eddie";
        private string Name02 = "Andersson";

        public int Age = 49;
        public void ShowMessage(string Message)
        {
            System.Windows.Forms.MessageBox.Show(Message);
        }
    }
    class MySecondClass : Myclass
    {
        public string HairColour = "Brown";
        public void MesssageBoxSpecial()
        {
            MessageBox.Show(base.Age.ToString());
        }
    }
}

