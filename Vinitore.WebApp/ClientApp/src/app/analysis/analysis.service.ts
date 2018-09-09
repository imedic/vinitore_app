import { AnalysisView, AnalysisDetailView, AnalysisCommand } from './analysis';
import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";

import { Observable } from "rxjs";

const httpOptions = {
  headers: new HttpHeaders({ "Content-Type": "application/json" })
};

@Injectable()
export class AnalysisService {
  private analysisUrl = "api/analysis";

  constructor(private http: HttpClient) {}

  getAnalyses(): Observable<AnalysisView[]> {
    return this.http.get<AnalysisView[]>(this.analysisUrl);
  }

  getAnalysis(id: number): Observable<AnalysisDetailView> {
    const url = `${this.analysisUrl}/${id}`;
    return this.http.get<AnalysisDetailView>(url);
  }

  getAnalysesFromBarrel(id: number): Observable<AnalysisDetailView[]> {
    return this.http.get<AnalysisDetailView[]>(`${this.analysisUrl}/details?fromBarrelId=${id}`)
  }

  addAnalysis(analysis: AnalysisCommand): Observable<AnalysisCommand> {
    return this.http.post<AnalysisCommand>(this.analysisUrl, analysis, httpOptions);
  }
}
