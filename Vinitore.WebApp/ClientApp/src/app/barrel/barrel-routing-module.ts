import { BarrelListComponent } from './list/barrel-list.component';
import { BarrelUpsertComponent } from './upsert/barrel-upsert.component';
import { NgModule } from '@angular/core';
import { Routes, RouterModule, Route } from '@angular/router';
import { BarrelDetailComponent } from './detail/barrel-detail.component';

export const barrelRoutes: Route = {
  path: '',
  children: [
    {
      path: '',
      component: BarrelListComponent
    },
    {
      path: 'create',
      component: BarrelUpsertComponent
    },
    {
      path: ':barrelId',
      children: [
        {
          path: '',
          component: BarrelDetailComponent,
        },
        {
          path: 'edit',
          component: BarrelUpsertComponent
        }
      ]
    },
  ]
};



@NgModule({
  exports: [RouterModule]
})
export class BarrelRoutingModule { }

export const routableComponents = [
    BarrelUpsertComponent,
    BarrelDetailComponent,
    BarrelListComponent
];
