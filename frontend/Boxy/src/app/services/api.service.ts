import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { Observable } from 'rxjs';
import { Box } from '../types/Box';

@Injectable({
  providedIn: 'root'
})

export class ApiService {
  constructor(private client: HttpClient) { }

  public getBoxes() {
    return this.client.get<Box[]>('http://localhost:5252/box');
  }

  public getBox(id:number) {
    return this.client.get<Box>('http://localhost:5252/box/' + id);
  }

  public createBox(box:Box | object) {
    return this.client.post<Box>('http://localhost:5252/box', box);
  }

  public updateBox(id:number, box:Box) {
    return this.client.put<Box>('http://localhost:5252/box/' + id, box);
  }

  public deleteBox(id:number) {
    return this.client.delete<Box>('http://localhost:5252/box/' + id);
  }
}
