import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HeaderComponent } from './header/header.component';
import { MotoqueirosComponent } from './motoqueiros/motoqueiros.component';

const routes: Routes = [
  { path: '', component: HeaderComponent },
  { path: 'motoqueiros', component: MotoqueirosComponent },
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
