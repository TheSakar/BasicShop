import { Product } from './product';
import { Order } from './order';
import { Cart } from './cart';

export class OrderAddModel {
    cart:Cart = new Cart;
    order: Order = new Order();

}

