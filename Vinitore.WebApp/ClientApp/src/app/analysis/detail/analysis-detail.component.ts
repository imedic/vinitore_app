import { AnalysisService } from './../analysis.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
    selector: 'analysis-detail',
    templateUrl: 'analysis-detail.component.html'
})

export class AnalysisDetailComponent implements OnInit {
    isLoading = true;
    analysis = null;

    constructor(
        analysisService: AnalysisService,
        private route: ActivatedRoute
    ) {
        
        route.params.subscribe(params => {
            analysisService.getAnalysis(params.analysisId).subscribe(result => {
                this.analysis = result;
                this.isLoading = false;
            })

        })
     }

    ngOnInit() { }
}