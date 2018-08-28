import { Component, OnInit } from '@angular/core';
import { WineService } from '../wine.service';
import { WineType } from '../wine';

@Component({
    selector: 'wine-list',
    templateUrl: 'wine-list.component.html'
})

export class WineListComponent implements OnInit {
    wines = [];

    tableView = "list";
    
    constructor(private wineService: WineService) {
        wineService.getWines().subscribe(result => {
            this.wines = result;
        })
     }

     mapWineTypeEnumToString(type: WineType) {
        switch (type) {
            case WineType.Dry:
                return "Dry";
            case WineType.MediumDry:
                return "Medium Dry";
            case WineType.MediumSweet:
                return "Medium Sweet";
            case WineType.Sweet:
                return "Sweet";
            default:
                return "N/A";
        }
     }

    ngOnInit() { }
}