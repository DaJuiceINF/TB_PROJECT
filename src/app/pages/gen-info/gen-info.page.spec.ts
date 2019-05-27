import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { GenInfoPage } from './gen-info.page';

describe('GenInfoPage', () => {
  let component: GenInfoPage;
  let fixture: ComponentFixture<GenInfoPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ GenInfoPage ],
      schemas: [CUSTOM_ELEMENTS_SCHEMA],
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(GenInfoPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
