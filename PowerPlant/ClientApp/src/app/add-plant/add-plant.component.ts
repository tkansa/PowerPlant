import { Component, OnInit } from '@angular/core';
import { PlantService } from '../plant.service';
import { Plant } from '../interfaces/plant';

@Component({
  selector: 'app-add-plant',
  templateUrl: './add-plant.component.html',
  styleUrls: ['./add-plant.component.css']
})
export class AddPlantComponent implements OnInit {

  plant: Plant = { id: 0, commonName: "", imageUrl: "" };
 
  constructor(private plantService: PlantService) { }
  

  ngOnInit() {
  }

  addPlant(): void {
    this.plantService.addPlant(this.plant).subscribe(
      (data: Plant) => {
        console.log("New plant: " + data);
      },
      (error: any) => console.log(error)
    );
  }

}
