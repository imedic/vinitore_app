import { AnalysisCommand } from './../analysis';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { BarrelService } from '../../barrel/barrel.service';
import { ActivatedRoute, Router } from '@angular/router';
import { AnalysisService } from '../analysis.service';
import { Barrel } from '../../barrel/barrel';

@Component({
    selector: 'analysis-upsert',
    templateUrl: 'analysis-upsert.component.html'
})

export class AnalysisUpsertComponent implements OnInit {
    isLoading = true;
    
    form: FormGroup;

    isButtonDisabled = false;

    barrelOptions: Barrel[] = [];

    constructor(
        private fb: FormBuilder,
        private analysisService: AnalysisService,
        private barrelService: BarrelService,
        private route: ActivatedRoute,
        private router: Router
    ) {
        barrelService.getBarrels().subscribe(result => {
            this.barrelOptions = result;

            this.form = this.fb.group({
                barrel: null,
                alcohol: null,
                acid: null,
                volatileAcid: null,
                totalDryExtract: null,
                totalSulphurDioxide: null,
                freeSulphurDioxide: null,
                ph: null
            });

            this.isLoading = false;
        })
     }

    ngOnInit() { }

    submit() {
        const analysis:AnalysisCommand = {
            barrelId: this.form.value.barrel,
            wineId: this.barrelOptions.find(b => b.Id = this.form.value.barrel).wineId,
            acid: this.form.value.acid,
            alcohol: this.form.value.acid,
            freeSulphurDioxide: this.form.value.freeSulphurDioxide,
            ph: this.form.value.ph,
            totalDryExtract: this.form.value.totalDryExtract,
            totalSulphurDioxide: this.form.value.totalSulphurDioxide,
            volatileAcid: this.form.value.volatileAcid
        }

        this.analysisService.addAnalysis(analysis).subscribe(result => {
            this.router.navigate(['../'], {
                relativeTo: this.route
            });
        })

    }
}



