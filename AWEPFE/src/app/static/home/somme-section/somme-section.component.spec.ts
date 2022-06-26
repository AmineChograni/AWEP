import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SommeSectionComponent } from './somme-section.component';

describe('SommeSectionComponent', () => {
  let component: SommeSectionComponent;
  let fixture: ComponentFixture<SommeSectionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SommeSectionComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SommeSectionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
