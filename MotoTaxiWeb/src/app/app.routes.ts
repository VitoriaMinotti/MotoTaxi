import { inject } from '@angular/core';
import { Routes } from '@angular/router';
import { MotoqueirosComponent } from './motoqueiros/motoqueiros.component';
import { MotoqueirosService } from './motoqueiros/motoqueiros.service';
import { HomeComponent } from './home/home.component';

export const routes: Routes = [
  {
    path: 'motoqueiros',
    component: MotoqueirosComponent,
    data: { breadcrumb: 'Motoqueiros' },
    resolve: {
      motoqueiros: () => inject(MotoqueirosService).getAll(),
    },
  },
  {
    path: 'home',
    component: HomeComponent,
    data: { breadcrumb: 'Home' },
  },
];
