import { MovieService } from './../../services/movie.service';
import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

 
 
@Component({
  selector: 'app-movies', 
  templateUrl: './movies.page.html',
  styleUrls: ['./movies.page.scss'],
})
export class MoviesPage implements OnInit {
 
 
  constructor(private movieService: MovieService) { }
 
  ngOnInit() { 
    this.movieService.refreshList();
    
  }
 

}