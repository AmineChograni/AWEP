import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DiplomesSectionComponent } from './diplomes-section.component';

describe('DiplomesSectionComponent', () => {
  let component: DiplomesSectionComponent;
  let fixture: ComponentFixture<DiplomesSectionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DiplomesSectionComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DiplomesSectionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
