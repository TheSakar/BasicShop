import { OrderProduct } from './orderproducts';

export class Order{
    id? :number;
    orderProducts:OrderProduct[]=[];
    userId:number=1;
}