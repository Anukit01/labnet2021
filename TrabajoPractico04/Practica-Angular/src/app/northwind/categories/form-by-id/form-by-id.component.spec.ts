import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FormByIDComponent } from './form-by-id.component';

describe('FormByIDComponent', () => {
  let component: FormByIDComponent;
  let fixture: ComponentFixture<FormByIDComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FormByIDComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FormByIDComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
