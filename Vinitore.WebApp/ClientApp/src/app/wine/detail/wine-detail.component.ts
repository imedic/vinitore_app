import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { WineDetails } from '../wine';
import { WineService } from '../wine.service';

@Component({
    selector: 'wine-detail',
    templateUrl: 'wine-detail.component.html'
})

export class WineDetailComponent implements OnInit {
    wineId: number;
    wine: WineDetails;

    constructor(
        private route: ActivatedRoute,
        private wineService: WineService) {
        this.route.params.subscribe(params => {
            this.wineId = params.wineId;
      
            this.fetchWine();
          });
     }

    ngOnInit() { }

    fetchWine() {
        this.wineService.getWine(this.wineId).subscribe(result => {
            console.log(result);
            this.wine = result;
        })
    }
}