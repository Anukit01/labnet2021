import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

import { Observable } from 'rxjs/internal/Observable';
import { Categories } from '../Model/category';

@Injectable({
  providedIn: 'root'
})
export class CategoriesService {

  endPoint: string = "categories";
  constructor(private http: HttpClient) { }

  public creatCategory(categoriesRequest: Categories):  Observable<any>{

    let url = environment.apiCategories + this.endPoint;
    return this.http.post(url, categoriesRequest);
  }
  public getCategories(): Observable<Array<Categories>>{
    let url = environment.apiCategories + this.endPoint;
    return this.http.get<Array<Categories>>(url);

  }
}
