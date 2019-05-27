import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Medicine } from '../medicine';
import { Symptom } from '../symptom';
import { Doctors } from '../doctors';
import { Patient } from '../patient';
 

@Injectable({ 
  providedIn: 'root' 
}) 
export class MovieService {
  
  list : Medicine[];
   symptoms : Symptom[];
   doctors : Doctors[];


   formData : Patient;
  readonly rootUrl = "http://localhost:52362/api";


  postPatient(formData : Patient)//this is then the function mentioned above...
  {
    return this.http.post(this.rootUrl+'/Patients',formData);
  }

  refreshList()
  {
    this.http.get(this.rootUrl+'/Medicines')
    .toPromise().then(res=>this.list = res as Medicine[]);
    
  }
  refreshSymptoms()
  {
    this.http.get(this.rootUrl+'/Symptoms')
    .toPromise().then(res=>this.symptoms = res as Symptom[]);
    
  }

  refreshDoctors()
  {
    this.http.get(this.rootUrl+'/Employeemasters')
    .toPromise().then(res=>this.doctors = res as Doctors[]);
    
  }

   
 
  constructor(private http: HttpClient) { }
  
}