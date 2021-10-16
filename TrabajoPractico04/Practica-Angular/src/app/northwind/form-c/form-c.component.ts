import { Component, Input, OnInit, Output, EventEmitter } from '@angular/core';
import { AbstractControl, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { CategoriesComponent } from '../categories/categories.component';
import { CategoriesService } from '../categories/service/categories.service';
import { Categories } from '../categories/Model/category';
// import { EventEmitter } from 'stream';

@Component({
  selector: 'app-form-c',
  templateUrl: './form-c.component.html',
  styleUrls: ['./form-c.component.css']
})
export class FormCComponent implements OnInit {

  @Input() categoryToUpDate: Categories;
  @Output() changed = new EventEmitter<Categories>()

  // public categoryToAdd: Categories;
  public categoryUpdated: Categories;
  public categoryPrueba: Categories;
  // public sendCategory: Category

  form: FormGroup;

  // CategoryName = new FormControl('');
  // Description = new FormControl('');

  get nameCtrl(): AbstractControl{
    return this.form.get("CategoryName");
  }
  get descriptionCtrl(): AbstractControl{
    return this.form.get("Description");
  }

  constructor(private fb: FormBuilder, private categoriesService: CategoriesService)
  {

  }


  ngOnInit(): void {
    this.form =  this.fb.group({
      CategoryName: [''],
      Description: ['']
    });
    this.form.reset();
  }

  ngOnChange(): void{
    if (this.categoryToUpDate != null){

      console.log(this.categoryToUpDate);
    }
    else {
      console.log("NOOOO");
    }
  }


  onSubmit(): void {
      this.form.getRawValue()
      this.categoryToUpDate = this.form.getRawValue();
     this.changed.emit(this.categoryToUpDate)

     console.log(this.form.value)
     console.log(this.categoryToUpDate)

      // this.categoriesService.
    }


  onClickClean(): void {

    this.form.reset();
  }

  // get f() {return this.formC.controls; }


}
