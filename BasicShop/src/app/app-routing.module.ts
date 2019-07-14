import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BuyingComponent } from './components/buying/buying.component';

const routes: Routes = [
  { path: 'buy', component: BuyingComponent },
  { path: '', redirectTo: '/buy', pathMatch: 'full' },
  { path: '**', component: BuyingComponent }
]

@NgModule({
  declarations: [],
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule {

}