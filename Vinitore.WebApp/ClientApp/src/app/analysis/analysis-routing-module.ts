import { AnalysisListComponent } from './list/analysis-list.component';
import { AnalysisUpsertComponent } from './upsert/analysis-upsert.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule, Route } from '@angular/router';
import { AnalysisDetailComponent } from './detail/analysis-detail.component';

export const analysisRoutes: Route = {
  path: '',
  children: [
    {
      path: '',
      component: AnalysisListComponent
    },
    {
      path: 'create',
      component: AnalysisUpsertComponent
    },
    {
      path: ':analysisId',
      children: [
        {
          path: '',
          component: AnalysisDetailComponent,
        },
        {
          path: 'edit',
          component: AnalysisUpsertComponent
        }
      ]
    },
  ]
};



@NgModule({
  exports: [RouterModule]
})
export class AnalysisRoutingModule { }

export const routableComponents = [
    AnalysisUpsertComponent,
    AnalysisDetailComponent,
    AnalysisListComponent
];