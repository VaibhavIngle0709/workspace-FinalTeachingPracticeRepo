import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ListmovieComponent } from './listmovie/listmovie.component';
import { FindComponent } from './find/find.component';
import { AddmovieComponent } from './addmovie/addmovie.component';
import { EditmovieComponent } from './editmovie/editmovie.component';
import { DeletemovieComponent } from './deletemovie/deletemovie.component';


const routes: Routes = [
  {path:'listmovies',component:ListmovieComponent},
  {path:'find/:id',component:FindComponent},
  {path:'addmovies',component:AddmovieComponent},
  {path:'edit/:id',component:EditmovieComponent},
  {path:'delete/:id',component:DeletemovieComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
