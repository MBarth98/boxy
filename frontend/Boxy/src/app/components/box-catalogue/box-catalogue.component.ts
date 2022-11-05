import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { of } from 'rxjs';
import { ApiService } from 'src/app/services/api.service';
import { GuiService } from 'src/app/services/gui.service';

import { Box } from '../../types/Box';

@Component({
  selector: 'app-box-catalogue',
  templateUrl: './box-catalogue.component.html',
  styleUrls: ['./box-catalogue.component.scss']
})

export class BoxCatalogueComponent implements OnInit {
  constructor(public gui:GuiService, private api : ApiService) { }

  ngOnInit(): void {
    this.onReload();
  }

  onReload() {
    this.api.getBoxes().subscribe((boxes) => {
      this.gui.boxes = boxes;
    });
  }

  onSelectionUpdated(box: Box) {
    if (this.gui.boxes.indexOf(box) >= 0) {
      this.gui.currentBox = box;
    }
  }
}
