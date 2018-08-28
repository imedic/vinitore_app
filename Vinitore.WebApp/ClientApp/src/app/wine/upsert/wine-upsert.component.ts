import { Component, OnInit } from '@angular/core';
import { WineType, Wine } from '../wine';
import { FormGroup, FormBuilder } from '@angular/forms';
import { WineService } from '../wine.service';
import { Router, ActivatedRoute } from '@angular/router';


@Component({
    selector: 'wine-upsert',
    templateUrl: 'wine-upsert.component.html'
})

export class WineUpsertComponent implements OnInit {
    form: FormGroup;
    WineType = WineType;
    isButtonDisabled = false;
    
    wineTypeOptions = [
        {value: WineType.Dry, label: "Dry"},
        {value: WineType.MediumDry, label: "Medium Dry"},
        {value: WineType.MediumSweet, label: "Medium Sweet"},
        {value: WineType.Sweet, label: "Sweet"}
    ];
    
    constructor(
        private fb: FormBuilder,
        private wineService: WineService,
        private route: ActivatedRoute,
        private router: Router,
    ) {
        this.form = this.fb.group({
            name: "",
            year: null,
            wineType: 0
        });
    }

    submit() {
        this.isButtonDisabled = true;

        const wine: Wine = {
            name: this.form.value.name,
            year: this.form.value.year,
            type: this.form.value.wineType
        }
        this.wineService.addWine(wine).subscribe(result => {
            this.router.navigate(['../'], {
                relativeTo: this.route
            });
        });
    }
        
    ngOnInit() {
    }
}