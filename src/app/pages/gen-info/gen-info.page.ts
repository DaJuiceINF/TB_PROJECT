import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-gen-info',
  templateUrl: './gen-info.page.html',
  styleUrls: ['./gen-info.page.scss'],
})
export class GenInfoPage implements OnInit {

  eventSource = [];

  calendar = {
   mode: 'month',
   currentDate: new Date()
  }

  onEventSelected(){

  }

  onViewTitledChanged(){

  }

  onTimeSelected(){

  }


  constructor() { }

  ngOnInit() {
  }

}
