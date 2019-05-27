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
    class Patient
    {
        [PrimaryKey,AutoIncrement]
        public int PatientID { get; set; }
        public string PatientFullName { get; set; }
        public string PatientGender { get; set; }
        public string PatientStatus { get; set; }
        public string PatientNumber { get; set; }
        public string PatientAddress { get; set; }
        public string PatientNationality { get; set; }
    }
}