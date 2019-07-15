import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http'
import { Observable, observable } from 'rxjs';
import { Order } from '../models/order';

@Injectable()
export class OrderService {

  constructor(private http: HttpClient) { }

  apiPath = "http://localhost:5000/api/orders"

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
    })
  };

  postOrder(order: Order): Observable<Order> {
    return this.http.post<Order>(this.apiPath, order, this.httpOptions);
  }

}
