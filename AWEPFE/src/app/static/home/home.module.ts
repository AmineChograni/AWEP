import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HomeRoutingModule } from './home-routing.module';
import { HomeComponent } from './home.component';
import { HeroSectionComponent } from './hero-section/hero-section.component';


//ngzerro
import { NzGridModule } from 'ng-zorro-antd/grid';
import { NzButtonModule } from 'ng-zorro-antd/button';
import { EncoreSectionComponent } from './encore-section/encore-section.component';

@NgModule({
  declarations: [HomeComponent, HeroSectionComponent, EncoreSectionComponent],
  imports: [
    CommonModule,
    HomeRoutingModule,
    NzGridModule,
    NzButtonModule
  ]
})
export class HomeModule { }
