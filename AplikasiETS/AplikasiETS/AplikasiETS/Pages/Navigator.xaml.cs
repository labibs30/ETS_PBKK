﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AplikasiETS.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Navigator : Shell
    {
        public Navigator()
        {
            InitializeComponent();
            Routing.RegisterRoute("registration", typeof(SignupPage));
        }
    }
}