import { BarrelService } from './../barrel.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BarrelDetail } from '../barrel';

@Component({
    selector: 'barrel-detail',
    templateUrl: 'barrel-detail.component.html'
})

export class BarrelDetailComponent implements OnInit {
    barrelId: number;
    barrel: BarrelDetail;
    isLoading = true;

    constructor(
        private route: ActivatedRoute,
        private router: Router,
        private barrelService : BarrelService
    ) {
        this.route.params.subscribe(params => {
            this.barrelId = params.barrelId;
      
            this.fetchBarrel();
        });

     }

    ngOnInit() { }

    fetchBarrel() {
        this.barrelService.getBarrel(this.barrelId).subscribe(result => {
            this.isLoading = false;
            this.barrel = result;
        })
    }

    getBarrelType() {
        return this.barrelService.mapBarrelTypeFromEnumToText(this.barrel.type);
    }
}