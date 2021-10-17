import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { TouchSequence } from 'selenium-webdriver';
import { Categories } from './Model/category';
import { CategoriesService } from './service/categories.service';
import { MessageService } from '../messages/service/message.service';
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

  show: false;

  constructor(private categoriesService: CategoriesService) {

   }

  ngOnInit(): void {
    this.getCategories();
  }

  getCategories(){
    this.categoriesService.getCategories().subscribe(res =>{
      this.listCategories = res;
    })
    }

  // edit(nameCtrl: string, descriptionCtrl: String){
  //   console.log("xxx" ),
  //   console.log(this.listCategories[x]);
  //   this.categoryToUpDate = this.listCategories[x];
  //   console.log(this.categoryToUpDate)

  //   this.categoriesService.updateCategory(this.categoryToUpDate)
  //   .subscribe(() => this.goBack());

  // }
  updateToForm(cat: Categories){
    // console.log(cat)
    // this.listCategories.indexOf(cat);
    // this.listCategories.find


    // this.listCategories.push(cat)
    // console.log(cat);
    // this.listCategories.forEach(( item, index) =>{
    //   if(item.CatedoryID === cat.CatedoryID)
    //   this.listCategories.splice(index,1);}
    // );
    // this.listCategories.push(cat)

  }


}
