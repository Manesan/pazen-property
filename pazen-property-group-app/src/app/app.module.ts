import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NbThemeModule, NbLayoutModule, NbButtonModule, NbCardModule } from '@nebular/theme';
import { NbEvaIconsModule } from '@nebular/eva-icons';
import { HeaderComponent } from './pages/@Shared/header/header.component';
import { NebularImportsModule } from 'src/environments/nebular-imports/nebular-imports.module';
import { SearchBarComponent } from './pages/home/search-bar/search-bar.component';
import { HomeComponent } from './pages/home/home.component';
import { FeaturedListingsComponent } from './pages/home/featured-listings/featured-listings.component';
import { AboutComponent } from './pages/about/about.component';
import { ContactComponent } from './pages/contact/contact.component';
import { SavedComponent } from './pages/saved/saved.component';
import { ProfileComponent } from './pages/profile/profile.component';
import { ViewPropertyComponent } from './pages/view-property/view-property.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    SearchBarComponent,
    HomeComponent,
    FeaturedListingsComponent,
    AboutComponent,
    ContactComponent,
    SavedComponent,
    ProfileComponent,
    ViewPropertyComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    NbThemeModule.forRoot({ name: 'default' }),
    NbLayoutModule,
    NbEvaIconsModule,
    NebularImportsModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
