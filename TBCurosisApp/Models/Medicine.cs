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
    class Medicine
    {
        [PrimaryKey]
        public int MedicineID { get; set; }
        public string MedicineName { get; set; }
        public string MedicineDescription { get; set; }
        public double MedicineEstimatedPrice { get; set; }
        public string MedicineTypeOfTB { get; set; }
    }
}