import { BarrelComponent } from './barrel.component';
import { BarrelRoutingModule, routableComponents } from './barrel-routing-module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { HttpModule } from '@angular/http';
import { BarrelService } from './barrel.service';
import { WineService } from '../wine/wine.service';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    BarrelComponent,
    routableComponents
  ],
  imports: [
    HttpModule,
    HttpClientModule,
    CommonModule,
    RouterModule,
    BarrelRoutingModule,
    FormsModule, 
    ReactiveFormsModule
  ],
  providers:[
    BarrelService,
    WineService
  ],
  exports: [
    BarrelRoutingModule
  ]
})
export class BarrelModule {}
