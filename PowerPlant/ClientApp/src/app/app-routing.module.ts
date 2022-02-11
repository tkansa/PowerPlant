import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PlantsComponent } from './plants/plants.component';
import { HomeComponent } from './home/home.component';
import { AddPlantComponent } from './add-plant/add-plant.component';
import { PlantDetailComponent } from './plant-detail/plant-detail.component';

const routes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'plants', component: PlantsComponent },
  { path: 'addPlant', component: AddPlantComponent },
  { path: 'detail/:id', component: PlantDetailComponent }
]


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
