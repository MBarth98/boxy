import { Component } from '@angular/core';

// input output event-emitter
// @Input() name : string;
// @Output() event = new EventEmitter();
// html <app-child (event)="onEvent()">{{title}}</app-child>

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})

export class AppComponent {

  constructor() { }

}
