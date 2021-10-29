import { Component, Inject, OnInit } from '@angular/core';
import { PlantService } from '../plant.service';
import { Plant } from '../interfaces/plant';

@Component({
  selector: 'app-plants',
  templateUrl: './plants.component.html',
  styleUrls: ['./plants.component.css']
})
export class PlantsComponent implements OnInit {

  public plants: Plant[];

  constructor(private plantService: PlantService) { }

  ngOnInit() {
    this.getPlants();
  }
  
  getPlants(): void {
    this.plantService.getPlants().subscribe(
      result => this.plants = result,
      error => console.error(error)
    );
  }

  deletePlant(plant: Plant): void {
    this.plants = this.plants.filter(p => p != plant);
    this.plantService.deletePlant(plant.id).subscribe();
  }
}
