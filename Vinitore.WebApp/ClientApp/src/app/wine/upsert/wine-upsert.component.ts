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
    isEditMode = false;
    wineId;
    wine = null;
    
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

        this.route.params.subscribe(params => {
            this.isEditMode = !!params.wineId;
            this.wineId = this.isEditMode ? params.wineId : null;
      
            if (this.isEditMode) {
                this.getDataAndPopulateForm();
            }
            else {
                this.createEmptyForm();
            }
          });
    }

    createEmptyForm() {
        this.form = this.fb.group({
            name: "",
            year: null,
            wineType: 0
        });
    }

    getDataAndPopulateForm() {
        this.wineService.getWine(this.wineId).subscribe(result => {
            this.wine = result;

            this.form = this.fb.group({
                name: this.wine.name,
                year: this.wine.year,
                wineType: this.wine.type
            });
        })
    }

    submit() {
        this.isButtonDisabled = true;

        const wine: Wine = {
            name: this.form.value.name,
            year: this.form.value.year,
            type: this.form.value.wineType
        };

        if (this.isEditMode) {
            const wineUpdated = Object.assign({}, this.wine, wine);

            this.wineService.updateWine(this.wineId, wineUpdated).subscribe(result => {
                this.router.navigate(['../'], {
                    relativeTo: this.route
                });
            })
        }
        else {
            this.wineService.addWine(wine).subscribe(result => {
                this.router.navigate(['../'], {
                    relativeTo: this.route
                });
            });
        }
    }
        
    ngOnInit() {
    }
}