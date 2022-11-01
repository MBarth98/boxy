import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { Box } from '../types/Box';

@Injectable({
  providedIn: 'root'
})

export class GuiService {

  public selectedBox: Observable<Box> = new Observable();
  public availableBoxes: Observable<Box[]> = new Observable();


  constructor() { }

}
