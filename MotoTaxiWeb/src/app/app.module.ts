import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { provideAnimationsAsync } from '@angular/platform-browser/animations/async';
import { HeaderComponent } from './header/header.component';
import { MotoqueirosComponent } from './motoqueiros/motoqueiros.component';
import { HttpClientModule } from '@angular/common/http';
import { AddMotoqueiroComponent } from './motoqueiros/add-motoqueiro/add-motoqueiro.component';
import { HomeComponent } from './home/home.component';

@NgModule({
  declarations: [AppComponent, HomeComponent],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HeaderComponent,
    MotoqueirosComponent,
    AddMotoqueiroComponent,
    HttpClientModule 
  ],
  providers: [provideAnimationsAsync()],
  bootstrap: [AppComponent],
})
export class AppModule {}
