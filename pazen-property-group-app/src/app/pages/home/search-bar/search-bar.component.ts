import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-search-bar',
  templateUrl: './search-bar.component.html',
  styleUrls: ['./search-bar.component.scss']
})
export class SearchBarComponent implements OnInit {

  showAdvanced: boolean = false;
  commercialSelected: boolean = false;
  dataModel: any = {};

  constructor() { }

  ngOnInit(): void {
  }

  advancedOptionsToggle() {
    this.showAdvanced = !this.showAdvanced;
  }

  checkCommercial(event: any){
    if(event == "commercial"){
      this.commercialSelected = true;
    }
    else{
      this.commercialSelected = false;
    }
  }

  clearFilters(){
    this.dataModel = {};
  }

}
