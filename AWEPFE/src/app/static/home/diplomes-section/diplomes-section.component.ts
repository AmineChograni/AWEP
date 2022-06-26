import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-diplomes-section',
  templateUrl: './diplomes-section.component.html',
  styleUrls: ['./diplomes-section.component.scss']
})
export class DiplomesSectionComponent implements OnInit {

  constructor() { }

  array: {title: string, imgURL: string }[] = [
    { "title": "Master" , "imgURL": "../../../../assets/images/fedeL.png" },
    { "title": "LP" ,"imgURL": "../../../../assets/images/fedeL.png" },
    { "title": "TS" , "imgURL": "../../../../assets/images/accredites.png" },
    {  "title": "T" ,"imgURL": "../../../../assets/images/accredites.png" },
  ];

  ngOnInit(): void {
  }

}
