import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

import { Observable } from 'rxjs/internal/Observable';
import { Categories } from '../Model/category';
import { BehaviorSubject } from 'rxjs';
// import { AnyRecord } from 'dns';
import { ValueConverter } from '@angular/compiler/src/render3/view/template';

@Injectable({
  providedIn: 'root'
})

export class CategoriesService {

  // public sender = new BehaviorSubject<Categories>();
  // public sender$ = this.sender.asObservable
  public listCategories: Array<Categories> = [];
  endPoint: string = "/categories";
  constructor (private http: HttpClient) {
    this.getCategories();
  }

  public creatCategoryUno(categoriesRequest: Categories):  Observable<any>{
    let url = this.endPoint + '/add';
    return this.http.post(url, categoriesRequest);
  }
  public getCategoriesUno(): Observable<Array<Categories>>{
    let url = this.endPoint + '/getall';
    return this.http.get<Array<Categories>>(url)
  }

  public getCategories() {
      this.listCategories = [
      {
        CatedoryID: 100000,
        CategoryName: 'Salad',
        Description: 'Cesar Salad'
      },
      {
        CatedoryID: 100001,
        CategoryName: 'Cocktail',
        Description: 'Sex on the Beach'
      },
      {
        CatedoryID: 100002,
        CategoryName: 'Exotic food',
        Description: 'Sushi'
      }]
  }
  upDateCategory(x){
    // this.categoryToUpDate = this.listCategories[x];
    //  this.listCategories.forEach(( item, index) =>{
    //   if(item.CatedoryID === cat.CatedoryID)
    //   this.listCategories.splice(index,1);}
    // );
    // this.listCategories.push(cat)
  }

  public addCategory(cat){
    this.listCategories.push(cat)
  }
}



