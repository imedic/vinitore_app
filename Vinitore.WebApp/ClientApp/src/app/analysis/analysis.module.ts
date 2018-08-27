import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { routableComponents, AnalysisRoutingModule } from './analysis-routing-module';
import { HttpClientModule } from '@angular/common/http';
import { HttpModule } from '@angular/http';
import { AnalysisComponent } from './analysis.component';

@NgModule({
  declarations: [
    AnalysisComponent,
    routableComponents
  ],
  imports: [
    HttpModule,
    HttpClientModule,
    CommonModule,
    RouterModule,
    AnalysisRoutingModule
  ],
  providers:[
  ],
  exports: [
    AnalysisRoutingModule
  ]
})
export class AnalysisModule {}
