import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { InMemoryDbService } from 'angular-in-memory-web-api';
import { environment } from 'src/environments/environment';

import { Observable } from 'rxjs/internal/Observable';
import { catchError, map, tap } from 'rxjs/operators';


import { Categories } from '../Model/category';
import { BehaviorSubject, of } from 'rxjs';
import { MessageService } from '../../messages/service/message.service';


@Injectable({
  providedIn: 'root'
})

export class CategoriesService {

  private listCategoriesUrl = 'api/listCategories';
  endPoint: string = "/categories";

  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  constructor (private http: HttpClient,
    private messageService: MessageService) {
    // this.getCategories();
  }

  private log(message: string) {
    this.messageService.add(`CategoriesService: ${message}`);
  }

  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
      console.error(error);
      this.log(`${operation} failed: ${error.message}`);
      return of(result as T);
    };
  }

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
    // let url = environment.apiCategories + this.endPoint + '/getById' + /{id};
    // return this.http.get<Categories>(url, category).pipe(
      //   map(category => category[0]),
      //   tap(c => {
      //     const outcome = c ? `fetched` : `did not find`;
      //     this.log(`${outcome} category id=${id}`);
      //   }),
      //   catchError(this.handleError<Categories>(`getCategory id=${id}`))
      // );

      const url = `${this.listCategoriesUrl}/?id=${id}`;
      return this.http.get<Categories[]>(url)
        .pipe(
          map(category => category[0]),
          tap(c => {
            const outcome = c ? `fetched` : `did not find`;
            this.log(`${outcome} category id=${id}`);
          }),
          catchError(this.handleError<Categories>(`getCategory id=${id}`))
        );
  }

  public updateCategory(category: Categories):  Observable<any>{
    // let url = environment.apiCategories + this.endPoint + '/update';
    // return this.http.put(url, category).pipe(
    // tap(_ => this.log(`updated category id=${category.CategoryID}`)),
    // catchError(this.handleError<any>('updateCategory'))
    //  );

    return this.http.put(this.listCategoriesUrl, category, this.httpOptions).pipe(
    tap(_ => this.log(`updated category id=${category.CategoryID}`)),
    catchError(this.handleError<any>('updateCategory'))
    );
  }

  addCategory(category: Categories): Observable<Categories> {
     // let url = environment.apiCategories + this.endPoint + '/add';
    // return this.http.post<Categories>(url, category).pipe(
    // tap(_ => this.log(`updated category id=${category.CategoryID}`)),
    // catchError(this.handleError<any>('updateCategory'))
    //  );


    return this.http.post<Categories>(this.listCategoriesUrl, category, this.httpOptions).pipe(
      tap((newCategory: Categories) => this.log(`added category w/ CategoryID=${newCategory.CategoryID}`)),
      catchError(this.handleError<Categories>('addcategory'))
    );
  }

  deleteCategory(category: Categories | number): Observable<Categories> {

    // const id = typeof category === 'number' ? category : category.CategoryID;
    // let url=environment.apiCategories + this.endPoint + delete?id={category.id} ;
    // let answer=this.http.delete<any>(url);
    // return answer;

    const id = typeof category === 'number' ? category : category.CategoryID;
    const url = `${this.listCategoriesUrl}/${id}`;
     return this.http.delete<Categories>(url, this.httpOptions).pipe(
       tap(_ => this.log(`deleted category id=${id}`)),
       catchError(this.handleError<Categories>('deletecategories'))
      );
    }
}
