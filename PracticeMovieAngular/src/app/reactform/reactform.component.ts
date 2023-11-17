import { Component, OnInit } from '@angular/core';
import { IMovie } from '../model/imovie';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-reactform',
  templateUrl: './reactform.component.html',
  styleUrls: ['./reactform.component.css']
})
export class ReactformComponent implements OnInit {
  moviedata:IMovie
  constructor(private fb:FormBuilder) { }
  movieform=this.fb.group({
    name:['',Validators.required],
    yearrelease:['',[Validators.min(2000),Validators.max[2023]]],
    rating:['',[Validators.required,Validators.min(1),Validators.max(5)]]
  })
  savedata():void
  {
    this.moviedata=this.movieform.value
    if(this.moviedata.rating>5)
    {
      alert('Error in ratings')
      return
    }
    console.log(this.moviedata);

  }

  ngOnInit() {
  }

}
