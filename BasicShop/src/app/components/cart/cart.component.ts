import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Product } from 'src/app/models/product';
import { OrderService } from 'src/app/services/order.service';
import { Order } from 'src/app/models/order';
import { OrderProduct } from 'src/app/models/orderproducts';
import { MatSnackBar } from '@angular/material';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css'],
  providers:[OrderService]
})
export class CartComponent implements OnInit {

  constructor(private orderService: OrderService, private snackBar: MatSnackBar) { }

  @Input() catchedProducts: Product[] = []

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
    let order = new Order();
    this.catchedProducts.forEach(product => {
	let orderProduct = new OrderProduct();
	orderProduct.productId = product.id;
      order.orderProducts.push(orderProduct);
	console.log(orderProduct);
    });
    this.orderService.postOrder(order).subscribe(() => {
      this.snackBar.open("Siparişiniz alındı.", "X", { duration: 4000 });
    }
    )

  }

}

