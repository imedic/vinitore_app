import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { WineDetails, WineType } from '../wine';
import { WineService } from '../wine.service';
import { NgxSmartModalService } from 'ngx-smart-modal';

@Component({
    selector: 'wine-detail',
    templateUrl: 'wine-detail.component.html'
})

export class WineDetailComponent implements OnInit {
    wineId: number;
    wine: WineDetails;
    isLoading = true;

    constructor(
        private route: ActivatedRoute,
        private router: Router,
        private wineService: WineService,
        private ngxSmartModalService: NgxSmartModalService) {

        this.route.params.subscribe(params => {
            this.wineId = params.wineId;
      
            this.fetchWine();
          });
     }

    ngOnInit() { }

    fetchWine() {
        this.wineService.getWine(this.wineId).subscribe(result => {
            this.wine = result;
            this.isLoading = false;
        })
    }

    deleteWine() {
        this.wineService.deleteWine(this.wineId).subscribe(result => {
            this.router.navigate(['/wines']);
        })
    }

    openConfirmationModal() {
        this.ngxSmartModalService.getModal('myModal').open()
    }

    getWineType(type: WineType) {
        return this.wineService.mapWineTypeFromEnumToText(type);
    }
}