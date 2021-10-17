import { Component } from '@angular/core';
import { Categories } from './northwind/categories/Model/category';
import { CategoriesService } from './northwind/categories/service/categories.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  title = 'Practica-Angular';

}
