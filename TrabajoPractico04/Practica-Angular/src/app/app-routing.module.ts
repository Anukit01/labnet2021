import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { WelcomeComponent } from './inicio/welcome/welcome.component';
import { CategoriesComponent } from './northwind/categories/categories.component';
import { FormCComponent } from './northwind/form-c/form-c.component';
import { NorthwindNoHarcodeadoComponent } from './northwind/northwind-no-harcodeado/northwind-no-harcodeado.component';

const routes: Routes = [
  {
    path: 'northwind',
    component: CategoriesComponent
  },
  {
    path: 'form',
    component: FormCComponent
  },
  {
    path: 'nohardcode',
    component: NorthwindNoHarcodeadoComponent
  },
  {
    path: '',
    component: WelcomeComponent
  }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes)

  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
