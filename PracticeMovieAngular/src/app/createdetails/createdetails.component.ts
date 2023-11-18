import { Component, OnInit } from '@angular/core';
import { IDetail } from '../model/idetail';
import { MovieserviceService } from '../services/movieservice.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-createdetails',
  templateUrl: './createdetails.component.html',
  styleUrls: ['./createdetails.component.css']
})
export class CreatedetailsComponent implements OnInit {
  detailsdata : IDetail={DetailId : 0,Actor: '',MovieId: 0,gender : '',Role : ''}
  showdata : any[] = []
  constructor(private ms : MovieserviceService, private router: Router) { }

  savedata(data : IDetail) : void
  {
    this.detailsdata = data
    this.ms.addDetails(this.detailsdata).subscribe(
      () => {
        alert('Record added successfully')
        this.router.navigate(['/listmovies'])
      }
    )
  }
    ngOnInit() {
      this.ms.getAllMovies().subscribe(data=>{this.showdata.push(...data)})
    }
}
