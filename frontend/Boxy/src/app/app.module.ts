import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http'
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule} from '@angular/forms'
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatTabsModule} from '@angular/material/tabs'

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BoxCardComponent } from './components/box-card/box-card.component';
import { BoxCatalogueComponent } from './components/box-catalogue/box-catalogue.component';
import { EditFormComponent } from './components/edit-form/edit-form.component';
import { CreateFormComponent } from './components/create-form/create-form.component';


@NgModule({
  declarations: [
    AppComponent,
    BoxCardComponent,
    BoxCatalogueComponent,
    EditFormComponent,
    CreateFormComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    BrowserAnimationsModule,
    MatTabsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
