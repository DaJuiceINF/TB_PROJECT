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
    class PatientMedicine
    {
        [PrimaryKey]
        public int PatientMedicineID { get; set; }
        public int PatientID { get; set; }
        public int MedicineID { get; set; }
    }
}