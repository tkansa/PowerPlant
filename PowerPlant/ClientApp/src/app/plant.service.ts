import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Plant } from './interfaces/plant';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PlantService {

  constructor(private httpClient: HttpClient) { }

  private readonly plantApiUrl: string = 'api/plant';

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  getPlants(): Observable<Plant[]> {   
    return this.httpClient.get<Plant[]>(this.plantApiUrl);
  }

  getPlant(id: number): Observable<Plant> {
    const url: string = `${this.plantApiUrl}/${id}`;
    return this.httpClient.get<Plant>(url);
  }

  addPlant(plant: Plant): Observable<Plant> {
    return this.httpClient.post<Plant>(this.plantApiUrl, plant, this.httpOptions);
  }

  updatePlant(plant: Plant): Observable<any> {
    return this.httpClient.put(this.plantApiUrl, plant, this.httpOptions);
  }

  deletePlant(id: number): Observable<Plant> {
    return this.httpClient.delete<Plant>(this.plantApiUrl + '/' + id, this.httpOptions);
  }
}
