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
    class Doctor
    {
        [PrimaryKey]
        public int DoctorID { get; set; }
        public string DoctorMedicalCenter { get; set; }
        public string DoctorName { get; set; }
        public string DoctorNumber { get; set; }
        public string DoctorOtherDetails { get; set; }
    }
}