import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Product } from 'src/app/models/product';
import { OrderService } from 'src/app/services/order.service';
import { Order } from 'src/app/models/order';
import { OrderProduct } from 'src/app/models/orderproducts';
import { MatSnackBar } from '@angular/material';
import { OrderAddModel } from 'src/app/models/orderaddmodel';
import { Cart } from 'src/app/models/cart';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css'],
  providers: [OrderService]
})
export class CartComponent implements OnInit {

  constructor(private orderService: OrderService, private snackBar: MatSnackBar) { }

  @Input() catchedProducts: Cart = new Cart();

  @Input() totalPrice: number = 0;

  @Output() removeFromParent = new EventEmitter();

  @Output() removeAllCartItems = new EventEmitter();

  ngOnInit() {
  }


  removeFromCart(cartItem) {


    let index = this.catchedProducts.cartItems.indexOf(cartItem);
    if (index > -1) {
      this.removeFromParent.emit(cartItem);
    }
  }

  buy() {

    if(this.catchedProducts.cartItems.length<1){
      this.snackBar.open("Sepetiniz Boş.", "X", { duration: 4000 });
      return;
    }

    let orderAddModel = new OrderAddModel();
    orderAddModel.order.userId = 2;
    
    this.catchedProducts.cartItems.forEach((cartItem,index) => {
      orderAddModel.cart.cartItems[index] = cartItem;
    });

    console.log(orderAddModel)
    this.orderService.postOrder(orderAddModel).subscribe(() => {
      this.snackBar.open("Siparişiniz alındı.", "X", { duration: 4000 });
      this.removeAllCartItems.emit(new Cart());
    }
    )

  }

}

