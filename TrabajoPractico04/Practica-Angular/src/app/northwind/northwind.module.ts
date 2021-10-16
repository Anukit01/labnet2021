import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import {MatTableModule} from '@angular/material/table';
import { HttpClientModule } from '@angular/common/http';
import {MatButtonModule} from '@angular/material/button';

import { CategoriesService } from './categories/service/categories.service';
import { NorthwindNoHarcodeadoComponent } from './northwind-no-harcodeado/northwind-no-harcodeado.component';
import { CategoriesComponent } from './categories/categories.component';
import { FormCComponent } from './form-c/form-c.component';



@NgModule({
  declarations: [CategoriesComponent, FormCComponent, NorthwindNoHarcodeadoComponent],
  imports: [
    MatTableModule,
    MatButtonModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    CommonModule
  ],
  providers: [ HttpClientModule, CategoriesService],

})
export class NorthwindModule { }
