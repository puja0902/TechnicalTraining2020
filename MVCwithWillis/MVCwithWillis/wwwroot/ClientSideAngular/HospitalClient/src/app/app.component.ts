import { Component } from '@angular/core';
import {Patient, PatientProblem} from "./app.model";
import {HttpClient} from '@angular/common/http';
import { observable, of, Observable } from 'rxjs';
import { filter, distinct } from 'rxjs/operators';
import { TitleCasePipe } from '@angular/common';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  title = 'HospitalClient';
  patientobj : Patient = new Patient();//represents single patient
  patientObjs :Array<Patient> = new Array<Patient>();

  constructor(public httpObj : HttpClient){

  }

  AddInMemory(){
    this.patientObjs.push(this.patientobj);
    this.patientobj = new Patient(); 
  }

  Add(){

    //this.patientsObjs send it to WebApi
    var observable = this.httpObj.post("https://localhost:44366/api/PatientApi", this.patientObjs);
    observable.pipe(distinct((p:Patient)=>p.name));
    observable.subscribe(res=>this.Success(res), res=>this.Error(res));
  }

  Success(res){

    this.patientObjs = res;
   
  }
  Error(res){

    console.log(res);

  }

}
