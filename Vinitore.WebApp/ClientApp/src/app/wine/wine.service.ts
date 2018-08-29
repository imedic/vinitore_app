import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";

import { Observable } from "rxjs";
import { Wine, WineDetails, WineType, WineSummary } from "./wine";

const httpOptions = {
  headers: new HttpHeaders({ "Content-Type": "application/json" })
};

@Injectable()
export class WineService {
  private wineUrl = "api/wine";

  constructor(private http: HttpClient) {}

  getWines(): Observable<Wine[]> {
    return this.http.get<Wine[]>(this.wineUrl);
  }

  getWine(id: number): Observable<WineDetails> {
    const url = `${this.wineUrl}/${id}`;
    return this.http.get<WineDetails>(url);
  }

  getWineSummary(): Observable<WineSummary[]> {
    return this.http.get<WineSummary[]>(`${this.wineUrl}/summary`);
  }

  addWine(wine: Wine): Observable<Wine> {
    return this.http.post<Wine>(this.wineUrl, wine, httpOptions);
  }

  deleteWine(id: number): Observable<any> {
    const url = `${this.wineUrl}/${id}`;

    return this.http.delete(url, httpOptions);
  }

  updateWine(id: number, wine: Wine): Observable<any> {
    return this.http.put(`${this.wineUrl}/${id}`, wine, httpOptions);
  }

  mapWineTypeFromEnumToText(type: WineType) {
    switch (type) {
      case WineType.Dry:
        return "Dry";
      case WineType.MediumDry:
        return "Medium Dry";
      case WineType.MediumSweet:
        return "Medium Sweet";
      case WineType.Sweet:
        return "Sweet";
      default:
        return "N/A";
    }
  }
}
