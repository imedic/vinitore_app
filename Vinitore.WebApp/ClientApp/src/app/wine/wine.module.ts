import { WineComponent } from './wine.component';
import { WineService } from './wine.service';
import { NgModule } from '@angular/core';
import { HttpModule } from '@angular/http';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { WineRoutingModule, routableComponents } from './wine-routing-module';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    WineComponent,
    routableComponents
  ],
  imports: [
    HttpModule,
    HttpClientModule,
    CommonModule,
    RouterModule,
    WineRoutingModule
  ],
  providers:[
    WineService
  ],
  exports: [
    WineRoutingModule
  ]
})
export class WineModule {}
