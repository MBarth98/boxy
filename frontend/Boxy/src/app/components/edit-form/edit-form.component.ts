import { Component, OnInit } from '@angular/core';
import { Subscriber, Subscription } from 'rxjs';
import { GuiService } from 'src/app/services/gui.service';
import { Box } from 'src/app/types/Box';

@Component({
  selector: 'app-edit-form',
  templateUrl: './edit-form.component.html',
  styleUrls: ['./edit-form.component.scss']
})
export class EditFormComponent implements OnInit {

  constructor(public gui: GuiService) {}

  ngOnInit(): void {}


  onSave() {
    console.log("editor: " + JSON.stringify(this.gui.currentBox));
  }

  doTextareaValueChange(ev : any) {
    try {
      this.gui.currentBox!.description = ev.target.value;
    } catch(e) {
      console.info('could not set textarea-value');
    }
  }
}
