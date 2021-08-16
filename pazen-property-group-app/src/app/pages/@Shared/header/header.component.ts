import { Component, EventEmitter, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {
  @Output() homeClicked: EventEmitter<boolean> = new EventEmitter();
  @Output() aboutClicked: EventEmitter<boolean> = new EventEmitter();
  @Output() contactClicked: EventEmitter<boolean> = new EventEmitter();
  @Output() savedClicked: EventEmitter<boolean> = new EventEmitter();
  @Output() profileClicked: EventEmitter<boolean> = new EventEmitter();
  constructor() { }

  ngOnInit(): void {
  }

  homeClick(){
    this.homeClicked.emit(true);
  }

  aboutClick(){
    this.aboutClicked.emit(true);
  }

  contactClick(){
    this.contactClicked.emit(true);
  }

  savedClick(){
    this.savedClicked.emit(true);
  }

  profileClick(){
    this.profileClicked.emit(true);
  }


}
