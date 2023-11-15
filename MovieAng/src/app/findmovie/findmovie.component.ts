import { Component, OnInit } from '@angular/core';
import { MovieService } from '../MovieService/movie.service';
import { IMovie } from '../model/imovie';

@Component({
  selector: 'app-findmovie',
  templateUrl: './findmovie.component.html',
  styleUrls: ['./findmovie.component.css']
})
export class FindmovieComponent implements OnInit {
  movie:IMovie
  id:number
  constructor(private movieservice:MovieService) {
    this.movieservice.getMovies().subscribe(data=>{this.moviedata.push(...data)})
    console.log(this.moviedata)
   }

  ngOnInit() {
  }

}
