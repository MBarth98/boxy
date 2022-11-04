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
  constructor(private gui:GuiService, private api : ApiService) { }

  public boxes: Box[] = []

  ngOnInit(): void {

    this.boxes = [
      {
        id: 1,
        imageUrl: "https://i.imgur.com/EJLFNOw.png",
        description: "A box",
        height: 10,
        width: 10,
        depth: 10,
        thickness: 10,
        weight: 10
      },
      {
        id: 2,
        imageUrl: "https://i.imgur.com/EJLFNOw.png",
        description: "A box",
        height: 10,
        width: 10,
        depth: 10,
        thickness: 10,
        weight: 10
      }
    ];

    this.gui.boxes = this.boxes;
  }

  onReload() {
    this.api.getBoxes().subscribe((boxes) => {
      this.gui.boxes = boxes;
    });
  }

  onSelectionUpdated(box: Box) {
    if (this.boxes.indexOf(box) >= 0) {
      this.gui.currentBox = box;
    }
  }
}
