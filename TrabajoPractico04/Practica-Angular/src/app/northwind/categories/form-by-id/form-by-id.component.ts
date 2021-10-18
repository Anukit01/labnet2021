import { Component, OnInit } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { Categories } from '../Model/category';
import { CategoriesService } from '../service/categories.service';
import { debounceTime, distinctUntilChanged, switchMap } from 'rxjs/operators';
import { Observable, Subject } from 'rxjs';

@Component({
  selector: 'app-form-by-id',
  templateUrl: './form-by-id.component.html',
  styleUrls: ['./form-by-id.component.css']
})
export class FormByIDComponent implements OnInit {

  Category$: Observable<Categories[]>;
  private searchTerms = new Subject<string>();

  search(CategoryID: Number): void {
    // this.CategoriesService.get

    // next(CategoryID);
  }

  ngOnInit(): void {
  //   this.Category$ = this.searchTerms.pipe(
  //     // wait 300ms after each keystroke before considering the term
  //     debounceTime(300),

  //     // ignore new term if same as previous term
  //     distinctUntilChanged(),

  //     // switch to new search observable each time the term changes
  //     switchMap((term: string) => this.heroService.searchHeroes(term)),
  //   );
  }

}


