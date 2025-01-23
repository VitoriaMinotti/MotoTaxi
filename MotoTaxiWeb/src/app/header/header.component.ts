import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import {MatIconModule} from '@angular/material/icon';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-header',
  standalone: true,
  imports: [
    MatIconModule,
    CommonModule,
    RouterLink
  ],
  templateUrl: './header.component.html',
})
export class HeaderComponent {
  isSidebarOpen: boolean = false; 
  cashier = {
    name: 'John Doe',
    email: 'johndoe@example.com'
  };

  toggleSidebar(): void {
    this.isSidebarOpen = !this.isSidebarOpen;
  }

  closeSidebar(): void {
    this.isSidebarOpen = false;
  }

  logout(): void {
    console.log('Usuário saiu.');
  }

}
