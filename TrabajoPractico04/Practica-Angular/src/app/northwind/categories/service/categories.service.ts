import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { InMemoryDbService } from 'angular-in-memory-web-api';
import { catchError, map, tap } from 'rxjs/operators';


import { Observable } from 'rxjs/internal/Observable';
import { Categories } from '../Model/category';
import { BehaviorSubject, of } from 'rxjs';
import { ValueConverter } from '@angular/compiler/src/render3/view/template';
import { MessageService } from '../../messages/service/message.service';


@Injectable({
  providedIn: 'root'
})

export class CategoriesService implements InMemoryDbService {
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


  endPoint: string = "/categories";

  constructor (private http: HttpClient,
    private messageService: MessageService) {
    this.getCategories();
  }
  private log(message: string) {
    this.messageService.add(`CategoriesService: ${message}`);
  }

  private listCategoriesUrl = 'api/categories';

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      console.error(error);
      this.log(`${operation} failed: ${error.message}`);
      return of(result as T);
    };
  }

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };



  public getCategories(): Observable<Array<Categories>>{
    // let url = environment.apiCategories + this.endPoint + '/getall';
    // return this.http.get<Array<Categories>>(url).pipe(
        // tap(_ => this.log('fetched categories')),
        // catchError(this.handleError<Categories[]>('getCategories', []))

      return this.http.get<Categories[]>(this.listCategoriesUrl)
      .pipe(
        tap(_ => this.log('fetched categories')),
        catchError(this.handleError<Categories[]>('getCategories', []))
      );
  }

  getCategoryById(id: number): Observable<Categories> {
    // let url = environment.apiCategories + this.endPoint + '/getById';
    // return this.http.get<Categories>(url, category);


    const url = `${this.listCategoriesUrl}/${id}`;
    return this.http.get<Categories>(url).pipe(
      tap(_ => this.log(`fetched category id=${id}`)),
      catchError(this.handleError<Categories>(`getCategory id=${id}`))
    );
  }

  public updateCategory(category: Categories):  Observable<any>{
  //   // let url = environment.apiCategories + this.endPoint + '/add';
  //   // return this.http.post(url, category);

    return this.http.put(this.listCategoriesUrl, category, this.httpOptions).pipe(
    tap(_ => this.log(`updated hero id=${category.CategoryID}`)),
    catchError(this.handleError<any>('updateHero'))
  );
  }

  // public UpdateCategory(category){
  //   // let url = environment.apiCategories + this.endPoint + '/update';
  //   // return this.http.post(url, category);

  //   this.listCategories.push(category)
  // }




}



