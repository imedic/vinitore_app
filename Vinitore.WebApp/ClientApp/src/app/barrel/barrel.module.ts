import { BarrelComponent } from './barrel.component';
import { BarrelRoutingModule, routableComponents } from './barrel-routing-module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { HttpModule } from '@angular/http';

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
    BarrelRoutingModule
  ],
  providers:[
  ],
  exports: [
    BarrelRoutingModule
  ]
})
export class BarrelModule {}
