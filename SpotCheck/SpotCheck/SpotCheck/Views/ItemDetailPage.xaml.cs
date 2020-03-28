﻿using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using SpotCheck.Models;
using SpotCheck.ViewModels;

namespace SpotCheck.Views
{
   // Learn more about making custom code visible in the Xamarin.Forms previewer
   // by visiting https://aka.ms/xamarinforms-previewer
   [DesignTimeVisible(false)]
   public partial class ItemDetailPage : ContentPage
   {
      ItemDetailViewModel viewModel;

      public ItemDetailPage(ItemDetailViewModel viewModel)
      {
         InitializeComponent();

         BindingContext = this.viewModel = viewModel;
      }

      public ItemDetailPage()
      {
         InitializeComponent();
         var item = new Item
         {
            Text = "Item 1",
            Description = "Ryan Bunker is the fucking best around"
         };

         viewModel = new ItemDetailViewModel(item);
         BindingContext = viewModel;
      }
   }
}