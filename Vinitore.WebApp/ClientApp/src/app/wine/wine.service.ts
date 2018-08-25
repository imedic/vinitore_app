import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';
import { Wine } from './wine';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable({ providedIn: 'root' })
export class WineService {

  private wineUrl = 'api/wine';

  constructor(
    private http: HttpClient) { }


  getWines (): Observable<Wine[]> {
    return this.http.get<Wine[]>(this.wineUrl)
      .pipe(
        tap(wines => console.log('fetched wines', wines)),
        catchError(this.handleError('getWines', []))
      );
  }

  getWine(id: number): Observable<Wine> {
    const url = `${this.wineUrl}/?id=${id}`;

    return this.http.get<Wine>(url)
      .pipe(
        tap(wine => {
          console.log("Wine:", wine);
        }),
        catchError(this.handleError<Wine>(`getWine id=${id}`))
      );
  }


  addWine (wine: Wine): Observable<Wine> {
    return this.http.post<Wine>(this.wineUrl, wine, httpOptions).pipe(
      tap((wine: Wine) => console.log("added wine", wine)),
      catchError(this.handleError<Wine>('addWine'))
    );
  }

  deleteWine (wine: Wine | number): Observable<Wine> {
    const id = typeof wine === 'number' ? wine : wine.id;
    const url = `${this.wineUrl}/${id}`;

    return this.http.delete<Wine>(url, httpOptions).pipe(
      tap(_ => console.log("deleted wine", id)),
      catchError(this.handleError<Wine>('deleteWine'))
    );
  }

  updateWine (wine: Wine): Observable<any> {
    return this.http.put(this.wineUrl, wine, httpOptions).pipe(
      tap(_ => console.log(`updated wine id=${wine.id}`)),
      catchError(this.handleError<any>('updateWine'))
    );
  }


  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      console.error(error); 

      return of(result as T);
    };
  }
}


/*
Copyright 2017-2018 Google Inc. All Rights Reserved.
Use of this source code is governed by an MIT-style license that
can be found in the LICENSE file at http://angular.io/license
*/