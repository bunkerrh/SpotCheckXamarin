﻿using System.Collections.Generic;
using Xamarin.Forms.Maps;
namespace SpotCheck.Models
{
    public class CustomMap : Map
    {
        public List<CustomPin> CustomPins { get; set; }
    }
}