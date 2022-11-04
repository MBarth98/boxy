import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { Box } from '../types/Box';

@Injectable({
  providedIn: 'root'
})

export class GuiService {

  public currentBox: Box | undefined;
  public boxes: Box[] = [];

  constructor() {}

}
