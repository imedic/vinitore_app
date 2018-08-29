import { BarrelService } from './../barrel.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BarrelDetail } from '../barrel';
import { NgxSmartModalService } from 'ngx-smart-modal';

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
        private barrelService : BarrelService,
        private ngxSmartModalService: NgxSmartModalService
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

    openConfirmationModal() {
        this.ngxSmartModalService.getModal('myModal').open();
    }

    deleteBarrel() {
        this.barrelService.deleteBarrel(this.barrelId).subscribe(result => {
            this.router.navigate(['/barrels']);
        });
    }
}