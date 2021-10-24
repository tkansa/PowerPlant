import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Plant } from './interfaces/plant';

@Injectable({
  providedIn: 'root'
})
export class PlantService {

  constructor(private httpClient: HttpClient) { }

  getPlants() {   
    return this.httpClient.get<Plant[]>('api/plant');
  }
}
