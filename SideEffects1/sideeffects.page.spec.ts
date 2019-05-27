import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SideEffectsPage } from './sideeffects.page';

describe('SideEffectsPage', () => {
  let component: SideEffectsPage;
  let fixture: ComponentFixture<SideEffectsPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SideEffectsPage ],
      schemas: [CUSTOM_ELEMENTS_SCHEMA],
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SideEffectsPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
