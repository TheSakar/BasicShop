import { Order } from './order';
import { Product } from './product';

export class Cart{

    cartItems:CartItem[] = []

}

export class CartItem{

    quantity:number=0;
    product:Product=new Product();

}