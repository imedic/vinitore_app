import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable } from 'rxjs';
import { Wine, WineDetails } from './wine';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable()
export class WineService {

  private wineUrl = 'api/wine';

  constructor(
    private http: HttpClient) { }


  getWines (): Observable<Wine[]> {
    return this.http.get<Wine[]>(this.wineUrl);
  }

  getWine(id: number): Observable<WineDetails> {
    const url = `${this.wineUrl}/${id}`;
    return this.http.get<WineDetails>(url);
  }


  addWine (wine: Wine): Observable<Wine> {
    return this.http.post<Wine>(this.wineUrl, wine, httpOptions);
  }

  // deleteWine (wine: Wine | number): Observable<Wine> {
  //   const id = typeof wine === 'number' ? wine : wine.id;
  //   const url = `${this.wineUrl}/${id}`;

  //   return this.http.delete<Wine>(url, httpOptions);
  // }

  updateWine (wine: Wine): Observable<any> {
    return this.http.put(this.wineUrl, wine, httpOptions);
  }
}