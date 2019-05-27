using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;

namespace TBCurosisApp.Models
{
    class Symptom
    {
        [PrimaryKey]
        public int SymptomID { get; set; }
        public string SymptomDescription { get; set; }
        public string SymptomTypeOfTB { get; set; }
    }
}