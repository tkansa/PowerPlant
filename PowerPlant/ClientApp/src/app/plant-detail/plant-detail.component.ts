import { Component, OnInit, Input } from '@angular/core';
import { Plant } from '../interfaces/plant';
import { PlantService } from '../plant.service';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';

@Component({
  selector: 'app-plant-detail',
  templateUrl: './plant-detail.component.html',
  styleUrls: ['./plant-detail.component.css']
})
export class PlantDetailComponent implements OnInit {

  plant: Plant | undefined;

  constructor(private route: ActivatedRoute, private plantService: PlantService) { }

  ngOnInit() {
    this.getPlant();
  }

  getPlant(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.plantService.getPlant(id).subscribe(plant => this.plant = plant);
  }

}
