import { WineService } from './wine.service';
import { Component, OnInit } from '@angular/core';
import { Wine } from './wine';

@Component({
    selector: 'wine',
    templateUrl: 'wine.component.html'
})

export class WineComponent implements OnInit {
    constructor(
        private wineService: WineService
    ) {
        let wine:Wine = {
            name: "prvoklasno vino",
            year: 2018,
            type: 1
        }
        // wineService.addWine(wine).subscribe(result => {
        //     console.log(result);
        // })
     }

    ngOnInit() { }
}