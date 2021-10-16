import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { TouchSequence } from 'selenium-webdriver';
import { Categories } from './Model/category';
import { CategoriesService } from './service/categories.service';

// import { ConsoleReporter } from 'jasmine';



@Component({
  selector: 'app-categories',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.css']
})
export class CategoriesComponent {

  public listCategories: Array<Categories> = []

  public sendCategorytoUpdate: Categories

  categoryToUpDate: Categories;

  constructor(private categoriesService: CategoriesService) {

   }

  ngOnInit(): void {
    this.getCategories();
  }

  getCategories(){
    this.listCategories = this.categoriesService.listCategories;
    console.log(this.listCategories[1]);
    console.log(this.listCategories);
    }

  edit(x: number){
    console.log("xxx", x ),
    console.log(this.listCategories[x]);
    this.categoryToUpDate = this.listCategories[x];
    console.log(this.categoryToUpDate)
  }
  updateToForm(cat: Categories){
    console.log(cat)
    this.listCategories.indexOf(cat);
    this.listCategories.find


    this.listCategories.push(cat)
    // console.log(cat);
    // this.listCategories.forEach(( item, index) =>{
    //   if(item.CatedoryID === cat.CatedoryID)
    //   this.listCategories.splice(index,1);}
    // );
    // this.listCategories.push(cat)

  }


}
