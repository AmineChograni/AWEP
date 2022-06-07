import { Component, OnInit } from '@angular/core';
import * as $ from "jquery";

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent implements OnInit {

  constructor() { }
  ngOnInit(): void {

    $(".menu-toggle-btn").click(function(){
      $(this).toggleClass("fa-times");
      $(".navigation-menu").toggleClass("active");
    });

  }

}
