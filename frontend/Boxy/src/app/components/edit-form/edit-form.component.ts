import { Component, OnInit } from '@angular/core';
import { Subscriber, Subscription } from 'rxjs';
import { ApiService } from 'src/app/services/api.service';
import { GuiService } from 'src/app/services/gui.service';
import { Box } from 'src/app/types/Box';

@Component({
  selector: 'app-edit-form',
  templateUrl: './edit-form.component.html',
  styleUrls: ['./edit-form.component.scss']
})
export class EditFormComponent implements OnInit {

  constructor(public gui: GuiService, private api: ApiService) {}

  ngOnInit(): void {}

  onSave() {
    console.log('edit');

    if (this.gui.currentBox) {
      this.api.updateBox(this.gui.currentBox!.id, this.gui.currentBox!).subscribe((box) => {
        console.log(box);
        this.gui.currentBox = box;
      });
    }
  }

  doTextareaValueChange(ev : any) {
    try {
      this.gui.currentBox!.description = ev.target.value;
    } catch(e) {
      console.info('could not set textarea-value');
    }
  }
}
