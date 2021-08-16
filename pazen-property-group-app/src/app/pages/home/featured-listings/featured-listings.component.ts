import { Component, EventEmitter, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-featured-listings',
  templateUrl: './featured-listings.component.html',
  styleUrls: ['./featured-listings.component.scss']
})
export class FeaturedListingsComponent implements OnInit {
  @Output() viewClicked: EventEmitter<boolean> = new EventEmitter();
  constructor() { }

  ngOnInit(): void {
  }

  viewPropertyClick(){
    this.viewClicked.emit(true)
  }

}
