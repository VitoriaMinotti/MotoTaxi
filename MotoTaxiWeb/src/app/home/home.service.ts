import { HttpClient } from "@angular/common/http";
import { BehaviorSubject, Observable, tap, catchError, of } from "rxjs";
import { ApplicationSettings } from "../api.url";
import { MotoqueirosDTO } from "../models/dtos/motoqueiros.dtos.interface";
import { MotoqueirosResult } from "../models/request/motoqueiros-result.interface";
import { MotoqueiroEndpoints } from "../motoqueiros/motoqueiro.endpoint";
import { Injectable } from "@angular/core";

@Injectable({
  providedIn: 'root'
})

export class HomeService {

    private _motoqueiro: BehaviorSubject<MotoqueirosResult[]> = new BehaviorSubject<MotoqueirosResult[]>([]);

  get motoqueiro$(): Observable<MotoqueirosResult[]> {
    return this._motoqueiro.asObservable();
  }

  constructor(
    private _http: HttpClient
  ) { }

  getAll(): Observable<MotoqueirosDTO[]> {
    return this._http.get<MotoqueirosDTO[]>(MotoqueiroEndpoints.endpoints.getAll(ApplicationSettings.URL)).pipe(
      tap((response: MotoqueirosDTO[]) => {
        this._motoqueiro.next(response);
      }),
      catchError((error) => {
        console.error('Erro ao buscar motoqueiros:', error);
        return of([]);
      })
    );
  }


}
