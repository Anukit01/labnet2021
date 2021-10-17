import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import {MatTableModule} from '@angular/material/table';
import { HttpClientModule } from '@angular/common/http';
import {MatButtonModule} from '@angular/material/button';

import { CategoriesService } from './categories/service/categories.service';
import { MessageService } from './messages/service/message.service';
import { NorthwindNoHarcodeadoComponent } from './northwind-no-harcodeado/northwind-no-harcodeado.component';
import { CategoriesComponent } from './categories/categories.component';
import { FormCComponent } from './form-c/form-c.component';
import { MessagesComponent } from './messages/messages.component';



@NgModule({
  declarations: [CategoriesComponent, FormCComponent, NorthwindNoHarcodeadoComponent, MessagesComponent],
  imports: [
    MatTableModule,
    MatButtonModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    CommonModule
  ],
  providers: [ HttpClientModule, CategoriesService, MessageService],

})
export class NorthwindModule { }
