import { Component, Input, OnInit, Output, EventEmitter } from '@angular/core';
import { AbstractControl, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';

import { CategoriesService } from '../categories/service/categories.service';
import { CategoriesComponent } from '../categories/categories.component';
import { Categories } from '../categories/Model/category';

@Component({
  selector: 'app-form-c',
  templateUrl: './form-c.component.html',
  styleUrls: ['./form-c.component.css']
})
export class FormCComponent implements OnInit {

  @Input() categoryToUpDate: Categories;


  // public categoryToAdd: Categories;
  public category: Categories;


  // public sendCategory: Category

  form: FormGroup;

  get IDCtrl(): AbstractControl{
    return this.form.get("CategoryID");
  }
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

  onSubmit(): void {
    this.category.CategoryID = this.form.get("CategoryID").value;
    this.category.CategoryName = this.form.get("CategoryName").value;
    this.category.Description = this.form.get("Description").value;
    console.log(this.category)

    // this.categoriesService.updateCategory(this.category).subscribe(res =>{
    //   this.form.reset();
    //   console.log("Succesfull save.")
    //   this.goBack();
    // });
    }


  onClickClean(): void {

    this.form.reset();
  }

  // add(nameCtrl: string, descriptionCtrl: string): void{
  // nameCtrl = nameCtrl.trim();
  // if (!nameCtrl) { return; }
  // this.categoriesService.addCategory({ nameCtrl, descriptionCtrl } as Categories)
  //   .subscribe(hero => {
  //     this..push(hero);
  //   });
  // get f() {return this.formC.controls; }


}
