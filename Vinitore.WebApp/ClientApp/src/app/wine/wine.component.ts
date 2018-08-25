import { WineService } from './wine.service';
import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'wine',
    templateUrl: 'wine.component.html'
})

export class WineComponent implements OnInit {
    constructor(
        private wineService: WineService
    ) {
        wineService.getWines().subscribe(result => {
            console.log(result);
        })
     }

    ngOnInit() { }
}