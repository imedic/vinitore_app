import { BarrelService } from './../barrel.service';
import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'barrel-list',
    templateUrl: 'barrel-list.component.html'
})

export class BarrelListComponent implements OnInit {
    barrels = [];

    tableView = "list";

    constructor(
        private barrelService: BarrelService
    ) {
        barrelService.getBarrels().subscribe(result => {
            this.barrels = result;
        })
     }

     mapBarrelTypeEnumToString(type) {
        return this.barrelService.mapBarrelTypeFromEnumToText(type);
     }

    ngOnInit() { }
}