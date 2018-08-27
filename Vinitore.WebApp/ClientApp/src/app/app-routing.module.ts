import { analysisRoutes } from './analysis/analysis-routing-module';
import { AnalysisComponent } from './analysis/analysis.component';
import { BarrelComponent } from './barrel/barrel.component';
import { WineComponent } from './wine/wine.component';
import { AppComponent } from './app.component';

import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { wineRoutes } from './wine/wine-routing-module';
import { barrelRoutes } from './barrel/barrel-routing-module';
    

const routes: Routes = [
    { path: '', redirectTo: '/wines', pathMatch: 'full' },
    { path: 'wines', component: WineComponent, children: [wineRoutes]},
    { path: 'barrels', component: BarrelComponent, children: [barrelRoutes]},
    { path: 'analysis', component: AnalysisComponent, children: [analysisRoutes]}
]


@NgModule({
    imports: [RouterModule.forRoot(routes, { enableTracing: false, useHash: true })],
    exports: [RouterModule]
    })
    export class AppRoutingModule { }
    
    export const routableComponents = [AppComponent];
      