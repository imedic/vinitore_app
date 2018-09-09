import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { routableComponents, AnalysisRoutingModule } from './analysis-routing-module';
import { HttpClientModule } from '@angular/common/http';
import { HttpModule } from '@angular/http';
import { AnalysisComponent } from './analysis.component';
import { AnalysisService } from './analysis.service';

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
    AnalysisService
  ],
  exports: [
    AnalysisRoutingModule
  ]
})
export class AnalysisModule {}
