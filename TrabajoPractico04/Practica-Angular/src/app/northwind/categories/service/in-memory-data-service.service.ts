import { Injectable } from '@angular/core';
import { InMemoryDbService } from 'angular-in-memory-web-api';
import { Categories } from '../Model/category';

@Injectable({
  providedIn: 'root'
})
export class InMemoryDataServiceService  implements InMemoryDbService{
  createDb() {
    const listCategories = [{
      CategoryID: 1,
      CategoryName: 'Salad',
      Description: 'Cesar Salad'
    },
    {
      CategoryID: 2,
      CategoryName: 'Cocktail',
      Description: 'Sex on the Beach'
    },
    {
      CategoryID: 3,
      CategoryName: 'Exotic food',
      Description: 'Sushi'
    }];
    return {listCategories};
  }
  genId(listCategories: Categories[]): number {
    return listCategories.length > 0 ? Math.max(...listCategories.map(category =>
      category.CategoryID)) + 1 : 11;
  }
  constructor() { }
}
