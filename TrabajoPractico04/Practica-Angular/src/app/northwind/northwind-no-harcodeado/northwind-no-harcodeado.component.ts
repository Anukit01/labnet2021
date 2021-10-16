import { Component, OnInit } from '@angular/core';
import { Categories } from '../categories/Model/category';
import { CategoriesService } from '../categories/service/categories.service';

@Component({
  selector: 'app-northwind-no-harcodeado',
  templateUrl: './northwind-no-harcodeado.component.html',
  styleUrls: ['./northwind-no-harcodeado.component.css']
})
export class NorthwindNoHarcodeadoComponent implements OnInit {

  public listCategories: Array<Categories> = []
  constructor(private categoriesService: CategoriesService) { }

  ngOnInit(): void {
    this.getCategories()
  }
  getCategories(){
    this.categoriesService.getCategoriesUno().subscribe(res =>{
        this.listCategories = res;
        console.log(this.listCategories)
    })
  }
}
