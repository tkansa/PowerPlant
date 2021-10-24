import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Plant } from './interfaces/plant';

@Injectable({
  providedIn: 'root'
})
export class PlantService {

  plantUrl = "https://localhost:44308/api/plant";

  constructor(private httpClient: HttpClient) { }

  getPlants() {
    return this.httpClient.get<Plant>(this.plantUrl);
  }
}
