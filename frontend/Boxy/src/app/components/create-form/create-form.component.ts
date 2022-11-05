import { Component, OnInit } from '@angular/core';
import { ApiService } from 'src/app/services/api.service';
import { GuiService } from 'src/app/services/gui.service';
import {Box} from '../../types/Box';

@Component({
  selector: 'app-create-form',
  templateUrl: './create-form.component.html',
  styleUrls: ['./create-form.component.scss']
})
export class CreateFormComponent implements OnInit {

  constructor(private api: ApiService, private gui: GuiService) { }

  ngOnInit(): void {
  }

  height!: number;
  width!: number;
  depth!: number;
  thickness!: number;
  weight!: number;
  imageUrl!: string;
  description!: string;

  onSave() {
    const box  = {
      height: this.height,
      width: this.width,
      depth: this.depth,
      thickness: this.thickness,
      weight: this.weight,
      imageUrl: this.imageUrl,
      description: this.description
    }

    this.api.createBox(box).subscribe((box) => {
      console.log(box);
      this.gui.boxes.push(box);
      this.gui.currentBox = box;
    });
  }
}
