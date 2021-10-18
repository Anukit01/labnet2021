import { Component } from '@angular/core';

import { Categories } from './Model/category';
import { CategoriesService } from './service/categories.service';

@Component({
  selector: 'app-categories',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.css']
})
export class CategoriesComponent {

  public listCategories: Array<Categories> = []

  category: Categories;
  data: boolean = false;

  show: boolean = false;

  constructor(private categoriesService: CategoriesService) {

   }

  ngOnInit(): void {
    this.getCategories();

  }
  ngDoCheck(){
    this.getCategories();

  }

  openForm(){
    this.show = true
  }

  getCategories(){
    this.categoriesService.getCategories().subscribe(res =>{
      this.listCategories = res;
    })
    }

    edit(item : Categories){
      console.log(item)
      this.category = item
      console.log(this.category)
    }
    add(){
      var emptyCategory: Categories = {
       CategoryID: null,
       CategoryName: "name",
       Description: "description"
      }
      this.category = emptyCategory;

      console.log(this.category)
    }

    deleteCategory(category: Categories){
      this.listCategories = this.listCategories.filter(c => c !== category);
      this.categoriesService.deleteCategory(category).subscribe();
    }

    react(data: boolean){
      if(data){
        this.getCategories();
        this.data = false;
      }
    }
}
