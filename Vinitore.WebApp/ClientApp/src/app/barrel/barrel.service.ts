import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";

import { Observable } from "rxjs";
import { Barrel, BarrelDetail, BarrelCommand, BarrelType } from "./barrel";

const httpOptions = {
  headers: new HttpHeaders({ "Content-Type": "application/json" })
};

@Injectable()
export class BarrelService {
  private barrelUrl = "api/barrel";

  constructor(private http: HttpClient) {}

  getBarrels(): Observable<Barrel[]> {
    return this.http.get<Barrel[]>(this.barrelUrl);
  }

  getBarrel(id: number): Observable<BarrelDetail> {
    const url = `${this.barrelUrl}/${id}`;
    return this.http.get<BarrelDetail>(url);
  }

  addBarrel(barrel: BarrelCommand): Observable<BarrelCommand> {
    return this.http.post<BarrelCommand>(this.barrelUrl, barrel, httpOptions);
  }

  deleteBarrel(id: number): Observable<any> {
    const url = `${this.barrelUrl}/${id}`;

    return this.http.delete(url, httpOptions);
  }

  updateBarrel(id: number, barrel: BarrelCommand): Observable<any> {
    return this.http.put(`${this.barrelUrl}/${id}`, barrel, httpOptions);
  }

  mapBarrelTypeFromEnumToText(type: BarrelType) {
    switch (type) {
      case BarrelType.Inox:
        return "Inox";
      case BarrelType.Plastic:
        return "Plastic";
      case BarrelType.Wood:
        return "Wood";
      default:
        return "N/A";
    }
  }
}
