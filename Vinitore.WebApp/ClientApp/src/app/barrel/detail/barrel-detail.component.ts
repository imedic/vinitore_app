import { AnalysisService } from './../../analysis/analysis.service';
import { BarrelService } from './../barrel.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { BarrelDetail } from '../barrel';
import { NgxSmartModalService } from 'ngx-smart-modal';
import { FormBuilder, FormGroup } from '@angular/forms';

@Component({
    selector: 'barrel-detail',
    templateUrl: 'barrel-detail.component.html'
})

export class BarrelDetailComponent implements OnInit {
    barrelId: number;
    barrel: BarrelDetail;
    isLoading = true;
    form: FormGroup;

    transfers = [];
    analyses = [];

    compatibleBarrels = null;
    selectedBarrel = null;
    transferTo = true;

    constructor(
        private route: ActivatedRoute,
        private router: Router,
        private barrelService : BarrelService,
        private analysisService : AnalysisService,
        private ngxSmartModalService: NgxSmartModalService,
        private fb: FormBuilder,
    ) {
        this.route.params.subscribe(params => {
            this.barrelId = params.barrelId;

            this.fetchAnalyses();
            this.fetchTransfers();
            this.fetchBarrel(true);
        });

        this.form = this.fb.group({
            barrelTo: null,
            amount: 0
        });

        this.form.get('barrelTo').valueChanges.subscribe(val => {
            this.selectedBarrel = this.compatibleBarrels.filter(b => b.id == val)[0];
        });
     }

    ngOnInit() { }

    fetchBarrel(fetchTransferBarrels: boolean = false) {
        this.barrelService.getBarrel(this.barrelId).subscribe(result => {
            this.barrel = result;
            
            if (fetchTransferBarrels) {
                this.barrelService.getBarrelsForTransfer(this.barrelId, this.barrel.wineId).subscribe(transferBarrels => {
                    this.compatibleBarrels = transferBarrels;
                    this.isLoading = false;
                })
            }
        })
    }

    fetchAnalyses() {
        this.analysisService.getAnalysesFromBarrel(this.barrelId).subscribe(result => {
            this.analyses = result;
        })
    }

    fetchTransfers() {
        this.barrelService.getTransfers(this.barrelId).subscribe(result => {
            this.transfers = result;
        })
    }

    getBarrelType() {
        return this.barrelService.mapBarrelTypeFromEnumToText(this.barrel.type);
    }

    openConfirmationModal() {
        this.ngxSmartModalService.getModal('myModal').open();
    }

    openTransferModal() {
        this.ngxSmartModalService.getModal('transferModal').open();
    }

    deleteBarrel() {
        this.barrelService.deleteBarrel(this.barrelId).subscribe(result => {
            this.router.navigate(['/barrels']);
        });
    }

    transferWine() {
        if (this.transferTo) {
            const command = {
                barrelFromid: this.barrelId,
                barrelToId: this.form.value.barrelTo,
                wineId: this.barrel.wineId,
                amount: this.form.value.amount
            }

            this.barrelService.addTransfer(command).subscribe(result => {
                this.fetchTransfers();
                this.ngxSmartModalService.getModal('transferModal').close()
            })
        }
        else {
            const command = {
                barrelFromid: this.form.value.barrelTo,
                barrelToId: this.barrelId,
                wineId: this.barrel.wineId,
                amount: this.form.value.amount
            }

            this.barrelService.addTransfer(command).subscribe(result => {
                this.fetchTransfers();
                this.fetchBarrel();
                this.ngxSmartModalService.getModal('transferModal').close()
            })
        }
    }
}