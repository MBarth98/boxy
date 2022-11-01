import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http'
import { BrowserModule } from '@angular/platform-browser';
import {} from '@angular/forms'
import {} from '@angular/material'

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BoxCardComponent } from './components/box-card/box-card.component';
import { BoxCatalogueComponent } from './components/box-catalogue/box-catalogue.component';
import { CreateEditFormComponent } from './components/create-edit-form/create-edit-form.component';

@NgModule({
  declarations: [
    AppComponent,
    BoxCardComponent,
    BoxCatalogueComponent,
    CreateEditFormComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
