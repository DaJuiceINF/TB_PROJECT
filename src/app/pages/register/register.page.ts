import { Component, OnInit } from '@angular/core';
import { MovieService } from 'src/app/services/movie.service';
import {NgForm} from '@angular/forms';
 
@Component({
  selector: 'app-register',
  templateUrl: './register.page.html',
  styleUrls: ['./register.page.scss'],
})
export class RegisterPage implements OnInit {

  constructor(private patientService : MovieService) { }

  ngOnInit() {
    this.resetForm();
  }

  resetForm(form? : NgForm)
  {
    if(form!=null)
    form.resetForm();
    this.patientService.formData ={
      patientID: null,
      patientFullName:'',
      patientGenderID:null,
      patientStatus:'',
      contactNumber: null,
      patientAddress: '',
      patientNationality: ''
    }
  }

  onSubmit(form: NgForm)
  {
  //if(form.value.medicineID == null)
  this.insertRecord(form); 
  }
  options = [{id:1,text:"Male"},
             {id:2,text:"Female"}]
             patientGenderID: Number = 1;
  
  insertRecord(form: NgForm) {
    this.patientService.postPatient(form.value).subscribe(res => {     
      this.resetForm(form);          
    });
  } 

}
