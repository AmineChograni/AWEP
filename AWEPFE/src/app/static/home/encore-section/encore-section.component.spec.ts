import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EncoreSectionComponent } from './encore-section.component';

describe('EncoreSectionComponent', () => {
  let component: EncoreSectionComponent;
  let fixture: ComponentFixture<EncoreSectionComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EncoreSectionComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EncoreSectionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
