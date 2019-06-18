import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { InsuranceComponent } from './components/insurance/insurance.component';
import { HomeComponent } from './components/home/home.component';
import { AdminModule } from './module/admin/admin.module';
import { AdminComponent } from './components/admin/admin.component';
import { HttpRequestService } from './services/http-request.service';
import { HttpClient } from 'selenium-webdriver/http';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { TextboxComponent } from './components/widgets/textbox/textbox.component';
import { RadioButtonsComponent } from './components/widgets/radio-buttons/radio-buttons.component';

@NgModule({
  declarations: [
    AppComponent,
    InsuranceComponent,
    HomeComponent,
    AdminComponent,
    TextboxComponent,
    RadioButtonsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
