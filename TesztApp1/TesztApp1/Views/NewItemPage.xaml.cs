﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using TesztApp1.Models;
using TesztApp1.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TesztApp1.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}