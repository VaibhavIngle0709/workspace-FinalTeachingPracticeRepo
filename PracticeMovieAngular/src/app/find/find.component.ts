import { Component, OnInit } from '@angular/core';
import { MovieserviceService } from '../services/movieservice.service';
import { ActivatedRoute, Router } from '@angular/router';
import { IMovie } from '../model/imovie';
import { IDetail } from '../model/idetail';

@Component({
  selector: 'app-find',
  templateUrl: './find.component.html',
  styleUrls: ['./find.component.css']
})
export class FindComponent implements OnInit {

  constructor(private ms:MovieserviceService,private ar:ActivatedRoute,private route:Router) { }
  moviedata:IMovie
  //moviedetail:IDetail
  id:number

  Save()
  {
    this.route.navigate(['\listmovies'])
  }
  ngOnInit() {
    const tid=this.ar.snapshot.paramMap.get('id')
    this.id=Number(tid)
    this.ms.getMovie(this.id).subscribe((data:IMovie)=>{this.moviedata=data;console.log(this.moviedata)})

   // this.ms.getDetail(this.id).subscribe((data2:IDetail)=>{this.moviedetail=data2;console.log(this.moviedetail)})
  }

}
