import { Injectable } from '@angular/core';
import{ IMovie} from '../model/imovie';
import {HttpClient,HttpErrorResponse,HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { IDetail } from '../model/idetail';
import { HttpResponse } from '@angular/common/http';
import { throwError } from 'rxjs';
import {catchError} from 'rxjs/operators'
@Injectable({
  providedIn: 'root'
})
export class MovieserviceService {
  private url="https://8080-ffbabdadcfabcaaaceeafebeccaddbefddaf.premiumproject.examly.io/Movie"
  private url2="https://8080-ffbabdadcfabcaaaceeafebeccaddbefddaf.premiumproject.examly.io/Detail"
  
  constructor(private httpclient:HttpClient) { }

  getAllMovies():Observable<any[]>
  {
    return this.httpclient.get<any[]>(`${this.url}/ListMovies`)
  }
  getMovie(id:number):Observable<IMovie>
  {
    return this.httpclient.get<IMovie>(this.url+'/ListMovies/'+id).pipe(catchError(this.handleError))
  }

  getDetail(id:number):Observable<IDetail>
  {
    return this.httpclient.get<IDetail>(this.url2+'/ListDetails/'+id).pipe(catchError(this.handleError))
  }

  httpOptions={headers:new HttpHeaders({'Content-type':'application/json'})}

  addMovie(moviedata:IMovie):Observable<IMovie>
  {
    return this.httpclient.post<IMovie>(this.url+'/AddMovies',moviedata,this.httpOptions)
  }

  editMovie(moviedata:IMovie):Observable<IMovie>
  {
    return this.httpclient.put<IMovie>(this.url+'/EditMovie/'+moviedata.id,moviedata,this.httpOptions).pipe(catchError(this.handleError))
  }
  deleteMovie(id:number):Observable<IMovie>
  {
    return this.httpclient.delete<IMovie>(this.url+'/deletemovie/'+'?id='+id).pipe(catchError(this.handleError))
  }

  addDetails(detailsdata : IDetail ): Observable<IDetail>
{
  return this.httpclient.post<IDetail>(this.url2 + '/AddDetails/',detailsdata,this.httpOptions)
}

handleError(error:HttpErrorResponse)
{
  var errmsg=error.status+'\n'+error.error
 // alert(errmsg)
  return throwError(errmsg)  
}


}
