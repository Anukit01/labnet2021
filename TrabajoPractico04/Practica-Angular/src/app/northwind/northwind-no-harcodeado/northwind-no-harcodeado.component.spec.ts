import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NorthwindNoHarcodeadoComponent } from './northwind-no-harcodeado.component';

describe('NorthwindNoHarcodeadoComponent', () => {
  let component: NorthwindNoHarcodeadoComponent;
  let fixture: ComponentFixture<NorthwindNoHarcodeadoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NorthwindNoHarcodeadoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NorthwindNoHarcodeadoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
