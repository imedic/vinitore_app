import { WineUpsertComponent } from './upsert/wine-upsert.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule, Route } from '@angular/router';
import { WineDetailComponent } from './detail/wine-detail.component';
import { WineComponent } from './wine.component';

export const wineRoutes: Route = {
  path: '',
  children: [
    {
      path: 'create',
      component: WineUpsertComponent
    },
    {
      path: ':wineId',
      children: [
        {
          path: '',
          component: WineDetailComponent,
        },
        {
          path: 'edit',
          component: WineUpsertComponent
        }
      ]
    },
  ]
};



@NgModule({
  exports: [RouterModule]
})
export class WineRoutingModule { }

export const routableComponents = [
  WineComponent,
  WineUpsertComponent,
  WineDetailComponent
];
