import { Component } from '@angular/core';
import { MatCardModule } from '@angular/material/card';
import { Subject, takeUntil } from 'rxjs';
import { MotoqueirosResult } from '../models/request/motoqueiros-result.interface';
import { MatTableDataSource } from '@angular/material/table';
import { CommonModule } from '@angular/common';
import { HomeService } from './home.service';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [
    MatCardModule,
    CommonModule
  ],

  templateUrl: './home.component.html',
})
export class HomeComponent {
  constructor(private _inicioService: HomeService) {}

  dataSource = new MatTableDataSource<MotoqueirosResult>();
  private _unsubscribeAll: Subject<any> = new Subject<any>();
  motoqueiros: MotoqueirosResult[] = [];

  ngOnInit() {
    this._inicioService.getAll().subscribe();

    this._inicioService.motoqueiro$
      .pipe(takeUntil(this._unsubscribeAll))
      .subscribe((motoqueiros) => {
        this.motoqueiros = motoqueiros;
        this.dataSource.data = motoqueiros;
      });
  }
}
