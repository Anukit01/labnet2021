import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CategoriesComponent } from './categories/categories.component';
import { FormCComponent } from './form-c/form-c.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CategoriesService } from './categories/service/categories.service';

import {MatTableModule} from '@angular/material/table';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: 'northwind',
    component: CategoriesComponent
  }
];

@NgModule({
  declarations: [CategoriesComponent, FormCComponent],
  imports: [
    MatTableModule,
    RouterModule.forRoot(routes),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    CommonModule
  ],
  providers: [ HttpClientModule, CategoriesService],

})
export class NorthwindModule { }
