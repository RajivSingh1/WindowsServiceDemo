using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace WindowsServiceDemo
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            //The InitializeComponent method contains the logic which creates and initializes the user interface objects dragged
            //on the forming surface and provided the Property Grid of Form Designer.
            InitializeComponent();
        }
    }
}
