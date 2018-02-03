using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labsheet1_01
{
    public partial class MainForm : Form
    {
        class Car { }
        class Airplane { }
        class MotorBike { }


        List<Object> listOfObjects;


        public MainForm()
        {
            InitializeComponent();
        }

        void btnShow_Click(object sender, EventArgs e)
        {
            _ShowObjectNameHandler();
        }

        void _ShowObjectNameHandler()
        {
            if (listOfObjects == null)
            {
                var dialogResult = MessageBox.Show(
                    "Create new object now?",
                    "Warning",
                    MessageBoxButtons.YesNo
                );

                if (DialogResult.Yes == dialogResult)
                {
                    _Initialize();
                }
                else
                {
                    return;
                }
            }

            _ShowAllObjectName();
        }

        void _Initialize()
        {
            listOfObjects = new List<Object>();
            listOfObjects.Add(new Car());
            listOfObjects.Add(new Airplane());
            listOfObjects.Add(new MotorBike());
        }

        void _ShowAllObjectName()
        {
            var result = string.Empty;

            foreach (var obj in listOfObjects)
            {
                result += string.Format("{0}\n",  obj.ToString());
            }

            MessageBox.Show(result, "Result");
        }
    }
}
