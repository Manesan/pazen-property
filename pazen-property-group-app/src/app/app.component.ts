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
    window.scroll(0,0);
    if($event){
      if(this.flipped){
        this.flipped = !this.flipped
      }
    }
  }


  toggleAbout($event: any){
    window.scroll(0,0);
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
    window.scroll(0,0);
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
    window.scroll(0,0);
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
    window.scroll(0,0);
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
    window.scroll(0,0);
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
