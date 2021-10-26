import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Plant } from './interfaces/plant';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PlantService {

  constructor(private httpClient: HttpClient) { }

  getPlants(): Observable<Plant[]> {   
    return this.httpClient.get<Plant[]>('api/plant');
  }

  addPlant(plant: Plant): Observable<Plant> {
    return this.httpClient.post<Plant>('api/plant', plant, {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      })
    });
  }
}
