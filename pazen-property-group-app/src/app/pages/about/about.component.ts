import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-about',
  templateUrl: './about.component.html',
  styleUrls: ['./about.component.scss']
})
export class AboutComponent implements OnInit {

  @Input() showServices: boolean = true;
  @Output() aboutClicked: EventEmitter<boolean> = new EventEmitter();

  constructor() { }

  ngOnInit() {
  }

  aboutClick(){
    this.aboutClicked.emit(true);
  }

}
