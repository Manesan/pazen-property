import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NbAutocompleteModule, NbButtonModule, NbCardModule, NbIconModule, NbInputModule, NbListModule, NbSearchModule, NbSelectModule, NbSidebarModule, NbTabsetModule, NbTooltipModule } from '@nebular/theme';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
  ],
  exports: [
    NbButtonModule,
    NbCardModule,
    NbIconModule,
    NbInputModule,
    NbTabsetModule,
    NbSelectModule,
    NbAutocompleteModule,
    NbSearchModule,
    NbSidebarModule,
    NbTooltipModule,
    NbListModule
  ]
})
export class NebularImportsModule { }
