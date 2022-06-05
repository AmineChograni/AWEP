import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { StaticRoutingModule } from './static-routing.module';
import { StaticComponent } from './static.component';
import { FooterComponent } from './components/footer/footer.component';
import { NavbarComponent } from './components/navbar/navbar.component';


@NgModule({
  declarations: [StaticComponent, FooterComponent, NavbarComponent],
  imports: [
    CommonModule,
    StaticRoutingModule
  ]
})
export class StaticModule { }
