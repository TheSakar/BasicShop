import { Product } from './product';
import { Order } from './order';

export class OrderAddModel {
    products: Product[] = [];
    order: Order = new Order();

}

