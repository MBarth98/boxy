import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { ApiService } from 'src/app/services/api.service';
import { GuiService } from 'src/app/services/gui.service';

import { Box } from '../../types/Box';

@Component({
  selector: 'app-box-catalogue',
  templateUrl: './box-catalogue.component.html',
  styleUrls: ['./box-catalogue.component.scss']
})

export class BoxCatalogueComponent implements OnInit {
  constructor(private gui:GuiService) { }

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
  }

  onSelectionUpdated(box: Box) {
    console.log(box);
    this.gui.selectedBox.subscribe((selectedBox: Box) => {
      selectedBox = box;
    });
  }
}
