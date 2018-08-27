import { Component, OnInit } from '@angular/core';

@Component({
    selector: 'wine-list',
    templateUrl: 'wine-list.component.html'
})

export class WineListComponent implements OnInit {
    wines = [
        {name: "Žilavka", year: 2015, type: "Suho vino"},
        {name: "Žilavka", year: 2013, type: "Polu suho vino"},
        {name: "Blatina", year: 2017, type: "Suho vino"},
        {name: "Prošek", year: 2016, type: "Slatko vino"}
    ];

    tableView = "list";
    
    constructor() { }

    ngOnInit() { }
}