import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { WelcomeComponent } from './inicio/welcome/welcome.component';
import { CategoriesComponent } from './northwind/categories/categories.component';
import { FormByIDComponent } from './northwind/categories/form-by-id/form-by-id.component';
import { FormCComponent } from './northwind/form-c/form-c.component';

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
    path: 'getByID',
    component: FormByIDComponent
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
