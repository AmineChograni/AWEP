import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HomeRoutingModule } from './home-routing.module';
import { HomeComponent } from './home.component';
import { HeroSectionComponent } from './hero-section/hero-section.component';
import { EncoreSectionComponent } from './encore-section/encore-section.component';


//ngzerro
import { NzGridModule } from 'ng-zorro-antd/grid';
import { NzButtonModule } from 'ng-zorro-antd/button';
import { NzIconModule } from 'ng-zorro-antd/icon';
import { SommeSectionComponent } from './somme-section/somme-section.component';
import { DiplomesSectionComponent } from './diplomes-section/diplomes-section.component';



@NgModule({
  declarations: [HomeComponent, HeroSectionComponent, EncoreSectionComponent, SommeSectionComponent, DiplomesSectionComponent],
  imports: [
    CommonModule,
    HomeRoutingModule,
    NzGridModule,
    NzButtonModule,
    NzIconModule
  ]
})
export class HomeModule { }
