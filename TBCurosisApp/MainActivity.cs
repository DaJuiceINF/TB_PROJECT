using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using SQLite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using TBCurosisApp.Models;
using System;
using System.IO;
using Xamarin.Android;
using System.Collections.Generic;

namespace TBCurosisApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener
    {
        TextView textMessage;
        SQLiteConnection db;

        //Patient[] patients = {}
        //C:\\Users\\guest1\\Documents\\Visual Studio 2019\\Projects\\TBCurosisApp\\
        //C:/Users/guest1/Documents/Visual Studio 2019/Projects/TBCurosisApp/TBCurosisApp/Database

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            textMessage = FindViewById<TextView>(Resource.Id.message);
            //foreach (var i in patient)
            //textMessage.Text = "Hello, " + patient.PatientFullName;
            try
            {
                Patient p = new Patient();
                p.PatientFullName = "William Tandwe";
                p.PatientGender = "Male";
                p.PatientStatus = "Active";
                p.PatientAddress = "Pretoria";
                p.PatientNationality = "Malawian";
                Patient p1 = new Patient();
                p1.PatientFullName = "Kgotso Bogatsu";
                p1.PatientGender = "Male";
                p1.PatientStatus = "Active";
                p1.PatientAddress = "Pretoria";
                p1.PatientNationality = "South African";
                Patient p2 = new Patient();
                p2.PatientFullName = "Phindulo";
                p2.PatientGender = "Male";
                p2.PatientStatus = "Active";
                p2.PatientAddress = "Pretoria";
                p2.PatientNationality = "South African";

                Symptom s = new Symptom();
                s.SymptomDescription = "Chest Pains";
                s.SymptomTypeOfTB = "Latent";
                Symptom s1 = new Symptom();
                s1.SymptomDescription = "Coughing Blood";
                s1.SymptomTypeOfTB = "Active";
                Symptom s2 = new Symptom();
                s2.SymptomDescription = "Chills";
                s2.SymptomTypeOfTB = "Active";
                Symptom s3 = new Symptom();
                s3.SymptomDescription = "Coughing";
                s3.SymptomTypeOfTB = "All";
                Symptom s4 = new Symptom();
                s4.SymptomDescription = "Fatigue";
                s4.SymptomTypeOfTB = "Active";

                Medicine m = new Medicine();
                m.MedicineName = "Isoniazid";
                m.MedicineDescription = "";
                m.MedicineEstimatedPrice = 250.00;
                m.MedicineTypeOfTB = "All";
                Medicine m1 = new Medicine();
                m1.MedicineName = "Rifampin";
                m1.MedicineDescription = "Rimactane,Rifanid";
                m1.MedicineEstimatedPrice = 235.00;
                m1.MedicineTypeOfTB = "All";
                Medicine m2 = new Medicine();
                m2.MedicineName = "Ethambutol";
                m2.MedicineDescription = "Myambutol";
                m2.MedicineEstimatedPrice = 170.00;
                m2.MedicineTypeOfTB = "All";
                Medicine m3 = new Medicine();
                m3.MedicineName = "Pyrazinamide";
                m3.MedicineDescription = "";
                m3.MedicineEstimatedPrice = 355.00;
                m3.MedicineTypeOfTB = "All";
                Medicine m4 = new Medicine();
                m4.MedicineName = "Bedaquiline";
                m4.MedicineDescription = "Sirturo";
                m4.MedicineEstimatedPrice = 95.00;
                m4.MedicineTypeOfTB = "All";
                Medicine m5 = new Medicine();
                m5.MedicineName = "Linezolid";
                m5.MedicineDescription = "Zyvox";
                m5.MedicineEstimatedPrice = 115.00;
                m5.MedicineTypeOfTB = "All";

                Doctor d = new Doctor();
                d.DoctorMedicalCenter = "Die Wilgers Hospital";
                d.DoctorName = "Michael Jackson";
                d.DoctorNumber = "0123456789";
                d.DoctorOtherDetails = "";
                Doctor d1 = new Doctor();
                d1.DoctorMedicalCenter = "Faerie Glen Hospital";
                d1.DoctorName = "Edinson Cavani";
                d1.DoctorNumber = "0123456789";
                d1.DoctorOtherDetails = "Also works at Die Wilgers";
                Doctor d2 = new Doctor();
                d2.DoctorMedicalCenter = "Pretoria East Hospital";
                d2.DoctorName = "Sadio Mane";
                d2.DoctorNumber = "0123456789";
                d2.DoctorOtherDetails = "";
                Doctor d3 = new Doctor();
                d3.DoctorMedicalCenter = "Jakaranda Hospital";
                d3.DoctorName = "Don Cheaddle";
                d3.DoctorNumber = "0123456788";
                d3.DoctorOtherDetails = "Also works at Faerie Glen";
                Doctor d4 = new Doctor();
                d4.DoctorMedicalCenter = "Montana Hospital";
                d4.DoctorName = "Doctor Khumalo";
                d4.DoctorNumber = "0123456795";
                d4.DoctorOtherDetails = "";

                PatientMedicine pm = new PatientMedicine();
                pm.PatientID = 1;
                pm.MedicineID = 2;
                PatientMedicine pm1 = new PatientMedicine();
                pm1.PatientID = 1;
                pm1.MedicineID = 3;
                PatientMedicine pm2 = new PatientMedicine();
                pm2.PatientID = 2;
                pm2.MedicineID = 1;
                PatientMedicine pm3 = new PatientMedicine();
                pm3.PatientID = 2;
                pm3.MedicineID = 2;
                PatientMedicine pm4 = new PatientMedicine();
                pm4.PatientID = 2;
                pm4.MedicineID = 4;
                PatientMedicine pm5 = new PatientMedicine();
                pm5.PatientID = 3;
                pm5.MedicineID = 1;
                PatientMedicine pm6 = new PatientMedicine();
                pm6.PatientID = 4;
                pm6.MedicineID = 1;
                PatientMedicine pm7 = new PatientMedicine();
                pm7.PatientID = 4;
                pm7.MedicineID = 3;
                PatientMedicine pm8 = new PatientMedicine();
                pm8.PatientID = 4;
                pm8.MedicineID = 4;
                PatientMedicine pm9 = new PatientMedicine();
                pm9.PatientID = 4;
                pm9.MedicineID = 5;
                PatientMedicine pm10 = new PatientMedicine();
                pm10.PatientID = 5;
                pm10.MedicineID = 3;
                PatientMedicine pm11 = new PatientMedicine();
                pm11.PatientID = 5;
                pm11.MedicineID = 4;

                PatientSymptom pr = new PatientSymptom();
                pr.PatientID = 1;
                pr.SymptomID = 2;
                PatientSymptom pr1 = new PatientSymptom();
                pr1.PatientID = 1;
                pr1.SymptomID = 3;
                PatientSymptom pr2 = new PatientSymptom();
                pr2.PatientID = 2;
                pr2.SymptomID = 1;
                PatientSymptom pr3 = new PatientSymptom();
                pr3.PatientID = 2;
                pr3.SymptomID = 2;
                PatientSymptom pr4 = new PatientSymptom();
                pr4.PatientID = 2;
                pr4.SymptomID = 4;
                PatientSymptom pr5 = new PatientSymptom();
                pr5.PatientID = 3;
                pr5.SymptomID = 1;
                PatientSymptom pr6 = new PatientSymptom();
                pr6.PatientID = 4;
                pr6.SymptomID = 1;
                PatientSymptom pr7 = new PatientSymptom();
                pr7.PatientID = 4;
                pr7.SymptomID = 3;
                PatientSymptom pr8 = new PatientSymptom();
                pr8.PatientID = 4;
                pr8.SymptomID = 4;
                PatientSymptom pr9 = new PatientSymptom();
                pr9.PatientID = 4;
                pr9.SymptomID = 5;
                PatientSymptom pr10 = new PatientSymptom();
                pr10.PatientID = 5;
                pr10.SymptomID = 3;
                PatientSymptom pr11 = new PatientSymptom();
                pr11.PatientID = 5;
                pr11.SymptomID = 4;

                Patient[] ps = new Patient[3];
                ps[0] = p;
                ps[1] = p1;
                ps[2] = p2;
                Symptom[] ss = new Symptom[5];
                ss[0] = s;
                ss[1] = s1;
                ss[2] = s2;
                ss[3] = s3;
                ss[4] = s4;
                Medicine[] ms = new Medicine[6];
                ms[0] = m;
                ms[1] = m1;
                ms[2] = m2;
                ms[3] = m3;
                ms[4] = m4;
                ms[5] = m5;
                Doctor[] ds = new Doctor[5];
                ds[0] = d;
                ds[1] = d1;
                ds[2] = d2;
                ds[3] = d3;
                ds[4] = d4;
                PatientSymptom[] pss = new PatientSymptom[12];
                pss[0] = pr;
                pss[1] = pr1;
                pss[2] = pr2;
                pss[3] = pr3;
                pss[4] = pr4;
                pss[5] = pr5;
                pss[6] = pr6;
                pss[7] = pr7;
                pss[8] = pr8;
                pss[9] = pr9;
                pss[10] = pr10;
                pss[11] = pr11;
                PatientMedicine[] pms = new PatientMedicine[12];
                pms[0] = pm;
                pms[1] = pm1;
                pms[2] = pm2;
                pms[3] = pm3;
                pms[4] = pm4;
                pms[5] = pm5;
                pms[6] = pm6;
                pms[7] = pm7;
                pms[8] = pm8;
                pms[9] = pm9;
                pms[10] = pm10;
                pms[11] = pm11;

                var path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                path = Path.Combine(path, "Curosis.db");
                db = new SQLiteConnection(path);
                db.CreateTable<Patient>();
                db.CreateTable<Symptom>();
                db.CreateTable<Medicine>();
                db.CreateTable<Doctor>();
                db.CreateTable<PatientSymptom>();
                db.CreateTable<PatientMedicine>();

                foreach (Doctor x in ds)
                {
                    db.Insert(x);
                }

                foreach (Medicine x in ms)
                {
                    db.Insert(x);
                }

                foreach (Symptom x in ss)
                {
                    db.Insert(x);
                }

                foreach (Patient x in ps)
                {
                    db.Insert(x);
                }

                foreach (PatientSymptom x in pss)
                {
                    db.Insert(x);
                }

                foreach (PatientMedicine x in pms)
                {
                    db.Insert(x);
                }
                
                //db = Depe
                /**/
            }
            catch (Exception e)
            {
                textMessage.Text = e.Message;
            }
            BottomNavigationView navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);
            navigation.SetOnNavigationItemSelectedListener(this);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        public bool OnNavigationItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.navigation_home:
                    //textMessage.SetText(Resource.String.title_home);
                    
                    try
                    {
                        
                        //var i = db.Execute("SELECT * FROM Patient");
                        var patients = db.Table<Patient>();
                        
                        textMessage.Text = "";
                        foreach (Patient x in patients)
                        {
                            textMessage.Text += x.PatientFullName + ",";
                        }
                    }
                    catch (Exception e)
                    {
                        textMessage.Text = "Error: "+ e.Message;
                    }
                   
                    return true;
                case Resource.Id.navigation_dashboard:
                    //textMessage.SetText(Resource.String.title_dashboard);
                    try
                    {
                        var Symptoms = db.Table<Symptom>();
                        textMessage.Text = "Symptoms: ";
                        foreach (Symptom i in Symptoms)
                        {
                            textMessage.Text += i.SymptomDescription + " ";
                        }
                    }
                    catch (Exception e)
                    {
                        textMessage.Text = "Error: " + e.Message;
                    }
                    
                    return true;
                case Resource.Id.navigation_notifications:
                    try
                    {
                        var doctors = db.Table<Doctor>();
                        textMessage.Text = "Doctors: ";
                        foreach (Doctor i in doctors)
                        {
                            textMessage.Text += "Dr. " + i.DoctorName + " ";
                        }
                    }
                    catch (Exception e)
                    {
                        textMessage.Text = "Error: " + e.Message;
                    }
                    return true;
            }
            return false;
        }
    }
}

