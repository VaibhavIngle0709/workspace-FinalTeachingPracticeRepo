import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ListmovieComponent } from './listmovie/listmovie.component';
import { FindComponent } from './find/find.component';
import { HttpClientModule } from '@angular/common/http';

import { MenuComponent } from './menu/menu.component';

import { AddmovieComponent } from './addmovie/addmovie.component';
import { FormsModule,ReactiveFormsModule} from '@angular/forms';
import { EditmovieComponent } from './editmovie/editmovie.component';
import { DeletemovieComponent } from './deletemovie/deletemovie.component';
import { ReactformComponent } from './reactform/reactform.component';
import { CreatedetailsComponent } from './createdetails/createdetails.component';
@NgModule({
  declarations: [
    AppComponent,
    ListmovieComponent,
    FindComponent,
    
    MenuComponent,
    
    AddmovieComponent,
    
    EditmovieComponent,
    
    DeletemovieComponent,
    
    ReactformComponent,
    
    CreatedetailsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
    

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
