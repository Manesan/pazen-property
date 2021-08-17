import { Component, EventEmitter, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  @Output() viewClicked: EventEmitter<boolean> = new EventEmitter();
  @Output() aboutClicked: EventEmitter<boolean> = new EventEmitter();

  constructor() { }

  ngOnInit() {
  }

  viewPropertyClick($event: any){
    if($event){
      this.viewClicked.emit(true);
    }
  }

  goToAbout($event: any){
    this.aboutClicked.emit(true);
  }

}
