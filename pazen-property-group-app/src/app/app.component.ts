import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'pazen-property-group-app';
  year: number = new Date().getFullYear();

  flipped: boolean = false;

  //card back show booleans
  //showHome: boolean = false;
  showAbout: boolean = false;
  showContact: boolean = false;
  showSaved: boolean = false;
  showProfile: boolean = false;
  showProperty: boolean = false;

  toggleHome($event: any){
    if($event){
      if(this.flipped){
        this.flipped = !this.flipped
      }
    }
  }


  toggleAbout($event: any){
    if($event){
      this.showAbout = true;
      this.showContact = false;
      this.showSaved = false;
      this.showProfile = false;
      this.showProperty = false;
      if(!this.flipped){
        this.flipped = !this.flipped
      }
    }
  }
  toggleContact($event: any){
    if($event){
      this.showAbout = false;
      this.showContact = true;
      this.showSaved = false;
      this.showProfile = false;
      this.showProperty = false;
      if(!this.flipped){
        this.flipped = !this.flipped
      }
    }
  }
  toggleSaved($event: any){
    if($event){
      this.showAbout = false;
      this.showContact = false;
      this.showSaved = true;
      this.showProfile = false;
      this.showProperty = false;
      if(!this.flipped){
        this.flipped = !this.flipped
      }
    }
  }
  toggleProfile($event: any){
    if($event){
      this.showAbout = false;
      this.showContact = false;
      this.showSaved = false;
      this.showProfile = true;
      this.showProperty = false;
      if(!this.flipped){
        this.flipped = !this.flipped
      }
    }
  }

  toggleViewProperty($event: any){
    if($event){
      this.showAbout = false;
      this.showContact = false;
      this.showSaved = false;
      this.showProfile = false;
      this.showProperty = true;
      if(!this.flipped){
        this.flipped = !this.flipped
      }
    }
  }
}
