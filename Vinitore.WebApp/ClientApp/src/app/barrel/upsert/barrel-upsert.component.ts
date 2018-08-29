import { WineSummary } from './../../wine/wine';
import { BarrelService } from './../barrel.service';
import { Component, OnInit } from '@angular/core';
import { BarrelType, BarrelCommand } from '../barrel';
import { FormGroup, FormBuilder } from '@angular/forms';
import { WineService } from '../../wine/wine.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
    selector: 'barrel-upsert',
    templateUrl: 'barrel-upsert.component.html'
})

export class BarrelUpsertComponent implements OnInit {
    isLoading = true;
    
    form: FormGroup;
    BarrelType = BarrelType;

    isButtonDisabled = false;
    isEditMode = false;

    barrelId: number;
    barrel: BarrelCommand = null;
    
    barrelTypeOptions = [
        {value: BarrelType.Inox, label: "Inox"},
        {value: BarrelType.Plastic, label: "Plastic"},
        {value: BarrelType.Wood, label: "Wood"}
    ];

    wineOptions: WineSummary[] = [];

    constructor(
        private fb: FormBuilder,
        private wineService: WineService,
        private barrelService: BarrelService,
        private route: ActivatedRoute,
        private router: Router
    ) {
        this.wineService.getWineSummary().subscribe(result => {
            this.wineOptions = result;

            this.form = this.fb.group({
                name: "",
                capacity: null,
                currentCapacity: null,
                barrelType: 0,
                wine: null
            });
            
            this.isLoading = false;

            this.route.params.subscribe(params => {
                this.isEditMode = !!params.barrelId;
                this.barrelId = this.isEditMode ? params.barrelId : null;
          
                if (this.isEditMode) {
                    this.getDataAndPopulateForm();
                }
              });
        })

     }

    ngOnInit() { }

    getDataAndPopulateForm() {
        this.barrelService.getBarrel(this.barrelId).subscribe(result => {
            this.barrel = result;

            this.form = this.fb.group({
                name: this.barrel.name,
                capacity: this.barrel.capacity,
                currentCapacity: this.barrel.currentCapacity,
                barrelType: this.barrel.type,
                wine: this.barrel.wineId
            });
        })
    }

    submit() {
        const barrel:BarrelCommand = {
            name: this.form.value.name,
            capacity: this.form.value.capacity,
            currentCapacity: this.form.value.currentCapacity,
            type: this.form.value.type,
            wineId: this.form.value.wine
        }

        if (this.isEditMode) {
            this.barrelService.updateBarrel(this.barrelId, barrel).subscribe(result => {
                this.router.navigate(['../'], {
                    relativeTo: this.route
                });
            })
        }
        else {
            this.barrelService.addBarrel(barrel).subscribe(result => {
                this.router.navigate(['../'], {
                    relativeTo: this.route
                });
            })
        }
    }
}