import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';

import { CategoriesService } from '../categories/service/categories.service';
import { Categories } from '../categories/Model/category';
import { Observer } from 'rxjs';

@Component({
  selector: 'app-form-c',
  templateUrl: './form-c.component.html',
  styleUrls: ['./form-c.component.css']
})
export class FormCComponent implements OnInit {

  @Input() category: Categories;
  @Output() react = new EventEmitter<boolean>();

  form: FormGroup;

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
      CategoryName: ['', [Validators.required, Validators.minLength(4), Validators.maxLength(15)]],
      Description: ['', Validators.required]
    });
  }

  ngOnChange(){
    this.category
  }

  onSubmit(): void {
    }

  saveCategory(): void{
    if (this.category.CategoryID != null)
      {
        console.log(this.category);

        this.category.CategoryName = this.form.get("CategoryName").value;
        this.category.Description = this.form.get("Description").value;

        console.log(this.category)

        this.categoriesService.updateCategory(this.category).subscribe(res =>{
         console.log(res)
         if(res != null){
         this.form.reset();
        }})
      }
     else
      {
        this.category.CategoryName =this.form.get("CategoryName").value;
        this.category.Description = this.form.get("Description").value;

        this.categoriesService.addCategory(this.category).subscribe(res => {
        if(res != null){
        this.form.reset()
        this.categoriesService.getCategories().subscribe(res=>{
          console.log(res)

        });
        this.react.emit(true);

        console.log(res)
      }})
      }
    }

  onClickClean(): void {
    this.form.reset();
  }

}
