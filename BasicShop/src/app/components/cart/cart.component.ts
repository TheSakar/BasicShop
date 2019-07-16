import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Product } from 'src/app/models/product';
import { OrderService } from 'src/app/services/order.service';
import { Order } from 'src/app/models/order';
import { OrderProduct } from 'src/app/models/orderproducts';
import { MatSnackBar } from '@angular/material';
import { OrderAddModel } from 'src/app/models/orderaddmodel';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css'],
  providers: [OrderService]
})
export class CartComponent implements OnInit {

  constructor(private orderService: OrderService, private snackBar: MatSnackBar) { }

  @Input() catchedProducts: Product[] = [];

  @Input() totalPrice: number = 0;

  @Output() removeFromParent = new EventEmitter();

  ngOnInit() {
  }


  removeFromCart(product) {
    let index = this.catchedProducts.indexOf(product);
    if (index > -1) {
      this.removeFromParent.emit(product);
    }
  }

  buy() {
    let orderAddModel = new OrderAddModel();
    orderAddModel.order.userId = 2;
    orderAddModel.products = this.catchedProducts;
    console.log(orderAddModel)
    this.orderService.postOrder(orderAddModel).subscribe(() => {
      this.snackBar.open("Siparişiniz alındı.", "X", { duration: 4000 });
    }
    )

  }

}

