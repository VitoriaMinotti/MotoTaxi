import { Component, ViewChild } from '@angular/core';
import { MatPaginator, MatPaginatorModule } from '@angular/material/paginator';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';
import { MatTableDataSource, MatTableModule } from '@angular/material/table';
import { Subject, takeUntil } from 'rxjs';
import { MotoqueirosService } from './motoqueiros.service';
import { MotoqueirosResult } from '../models/request/motoqueiros-result.interface';
import { CommonModule } from '@angular/common';
import { MatIconModule } from '@angular/material/icon';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatDialog } from '@angular/material/dialog';
import { AddMotoqueiroComponent } from './add-motoqueiro/add-motoqueiro.component';
@Component({
  selector: 'app-motoqueiros',
  standalone: true,
  imports: [
    MatPaginatorModule,
    MatSlideToggleModule,
    MatTableModule,
    CommonModule,
    MatIconModule,
    MatFormFieldModule,
  ],
  templateUrl: './motoqueiros.component.html',
})
export class MotoqueirosComponent {
  displayedColumns: string[] = ['apelido', 'nome', 'aniversario'];
  dataSource = new MatTableDataSource<MotoqueirosResult>();
  constructor(
    private _motoqueirosService: MotoqueirosService,
    private dialog: MatDialog
  ) {}

  private _unsubscribeAll: Subject<any> = new Subject<any>();

  motoqueiros: MotoqueirosResult[] = [];

  @ViewChild(MatPaginator) paginator!: MatPaginator;

  ngOnInit() {
    this._motoqueirosService.getAll().subscribe();

    this._motoqueirosService.motoqueiro$
      .pipe(takeUntil(this._unsubscribeAll))
      .subscribe((motoqueiros) => {
        this.motoqueiros = motoqueiros;
        this.dataSource.data = motoqueiros;
      });
  }

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
  }

  addMotoqueiro() {
    this.dialog.open(AddMotoqueiroComponent, {
      width: '900px',
      height: '500px',
    });
  }
}
