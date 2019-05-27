import { Component, OnInit } from '@angular/core';
import { MovieService } from 'src/app/services/movie.service';

@Component({
  selector: 'app-doctorscontacts',
  templateUrl: './doctorscontacts.page.html',
  styleUrls: ['./doctorscontacts.page.scss'],
})
export class DoctorscontactsPage implements OnInit {

  constructor(private doctorsService: MovieService) { }

  ngOnInit() {
    this.doctorsService.refreshDoctors();
  }

}
