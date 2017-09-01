using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Anmiation.Resources;
using System.Threading.Tasks;

namespace Anmiation
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            Loaded += async (s, e) =>
            {
                await Task.Delay(500);
                CircularWarningAnimation1.Begin();
            };
        }        
    }
}