import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/models/product';
import { Cart, CartItem } from 'src/app/models/cart';

@Component({
  selector: 'app-buying',
  templateUrl: './buying.component.html',
  styleUrls: ['./buying.component.css']
})
export class BuyingComponent implements OnInit {

  constructor() { }

  cart = new Cart();

  totalPrice: number = 0;


  removeProduct(cartItem) {

    let index = this.cart.cartItems.indexOf(cartItem);
    if (index > -1) {
      if (cartItem.quantity > 1) {
        this.cart.cartItems[index].quantity--;
      }
      else {
        this.cart.cartItems.splice(index, 1);
      }
    }
    this.computeTotal();
  }

  removeAllCartItems(cart){
    this.cart=cart;
    this.computeTotal();
  }

  computeTotal() {
    this.totalPrice=0;
    this.cart.cartItems.forEach(cartItem => {
      this.totalPrice += cartItem.product.unitPrice * cartItem.quantity;
    });
  }

  catchProduct(product) {


    // this.cart.cartItems.forEach(cartItem => {
    for (var i = 0; i < this.cart.cartItems.length ; i++) {


      if (this.cart.cartItems[i].product.id === product.id) {
        this.cart.cartItems[i].quantity++;
        this.computeTotal()
        return;
      }
    }
    // });
    let cartItem = new CartItem();
    cartItem.product = product;
    cartItem.quantity = 1;
    this.cart.cartItems.push(cartItem);

    this.computeTotal()
    return;
  }

  ngOnInit() {
  }

}
