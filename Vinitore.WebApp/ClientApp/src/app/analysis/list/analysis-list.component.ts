import { Component, OnInit } from '@angular/core';
import { AnalysisService } from '../analysis.service';

@Component({
    selector: 'analysis-list',
    templateUrl: 'analysis-list.component.html'
})

export class AnalysisListComponent implements OnInit {
    analyses = [];

    constructor(private analysisService: AnalysisService) {
        analysisService.getAnalyses().subscribe(result => {
            this.analyses = result;
        });
     }

    ngOnInit() { }
}