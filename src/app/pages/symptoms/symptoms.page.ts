import { Component, OnInit } from '@angular/core';
import { MovieService } from 'src/app/services/movie.service';

@Component({
  selector: 'app-symptoms',
  templateUrl: './symptoms.page.html',
  styleUrls: ['./symptoms.page.scss'],
})
export class SymptomsPage implements OnInit {

  constructor(private symptomService: MovieService) { }

  ngOnInit() {
    this.symptomService.refreshSymptoms();
  }
 
}
