import { Injectable } from "@angular/core";
import { BehaviorSubject, catchError, Observable, of, tap } from "rxjs";
import { MotoqueirosDTO } from "../models/dtos/motoqueiros.dtos.interface";
import { HttpClient } from "@angular/common/http";
import { MotoqueiroEndpoints } from "../endpoints/motoqueiro.endpoint";
import { ApplicationSettings } from "../endpoints/api.url";
import { MotoqueirosResult } from "../models/request/motoqueiros-result.interface";


@Injectable({
  providedIn: 'root'
})
export class MotoqueirosService {

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

  addMotoqueiro(motoqueiro: MotoqueirosDTO): Observable<MotoqueirosDTO> {
    return this._http.post<MotoqueirosDTO>(MotoqueiroEndpoints.endpoints.create(ApplicationSettings.URL), motoqueiro).pipe(
      tap((response) => {
        const current = this._motoqueiro.value;
        this._motoqueiro.next([...current, response]);
      })
    );
  }

}
