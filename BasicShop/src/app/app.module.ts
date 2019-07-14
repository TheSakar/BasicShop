import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { NavComponent } from './components/nav/nav.component';
import { AngularmaterialModule } from './modules/angularmaterial/angularmaterial.module';
import { BuyingComponent } from './components/buying/buying.component';
import { AppRoutingModule } from './app-routing.module';
import { CartComponent } from './components/cart/cart.component';
import { ProductsComponent } from './components/products/products.component';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    BuyingComponent,
    CartComponent,
    ProductsComponent
  ],
  imports: [
    BrowserModule,
    AngularmaterialModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
