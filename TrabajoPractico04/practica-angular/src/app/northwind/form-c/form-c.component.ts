import { Component, Input, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CategoriesComponent } from '../categories/categories.component';
import { CategoriesService } from '../categories/service/categories.service';

@Component({
  selector: 'app-form-c',
  templateUrl: './form-c.component.html',
  styleUrls: ['./form-c.component.css']
})
export class FormCComponent implements OnInit {

  // @Input() sendParent: Category
  public formC: FormGroup;
  // public listCategories: Array<Categories>= []

  get nameCtrl(): AbstractControl{
    return this.formC.get("name");
  }
  get descriptionCtrl(): AbstractControl{
    return this.formC.get("description");
  }

  constructor(private readonly fb: FormBuilder, private categoriesService: CategoriesService) { }

  ngOnInit(): void {
   this.formC = this.fb.group({
    name: ["", [Validators.required, Validators.minLength(4)]],
    description: ["", Validators.required]
  })
  }

  onSubmit(): void {
    console.log (this.formC.value);
  }

  onClickClean(): void {

    this.formC.reset();
  }

  onClickSaveCategory(): void {
  }
}
