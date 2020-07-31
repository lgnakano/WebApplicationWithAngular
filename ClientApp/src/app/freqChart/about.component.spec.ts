import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FreqChart } from './about.component';

describe('AboutComponent', () => {
  let component: FreqChart;
  let fixture: ComponentFixture<FreqChart>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FreqChart ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FreqChart);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
