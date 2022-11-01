import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Box } from '../../types/Box';


@Component({
  selector: 'app-box-card',
  templateUrl: './box-card.component.html',
  styleUrls: ['./box-card.component.scss']
})
export class BoxCardComponent implements OnInit {

  @Input() box?: Box;

  @Output() boxSelected = new EventEmitter();

  constructor() { }

  ngOnInit(): void {

  }

  onBoxSelected() {
    this.boxSelected.emit();
  }
}
