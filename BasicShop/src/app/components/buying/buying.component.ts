import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/models/product';

@Component({
  selector: 'app-buying',
  templateUrl: './buying.component.html',
  styleUrls: ['./buying.component.css']
})
export class BuyingComponent implements OnInit {

  constructor() { }

  cart: Product[] = [];

  totalPrice: number = 0;


  removeProduct(product) {
    let index = this.cart.indexOf(product);
    if (index > -1) {
      this.totalPrice-=product.unitPrice;
      this.cart.splice(index, 1);
    }
  }


  catchProduct(product) {
    this.cart.push(product);
    this.totalPrice += product.unitPrice
  }

  ngOnInit() {
  }

}
