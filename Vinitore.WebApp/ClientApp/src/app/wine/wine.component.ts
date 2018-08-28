import { WineService } from './wine.service';
import { Component, OnInit } from '@angular/core';
import { Wine } from './wine';

@Component({
    selector: 'wine',
    templateUrl: 'wine.component.html'
})

export class WineComponent implements OnInit {
    constructor() { }

    ngOnInit() { }
}