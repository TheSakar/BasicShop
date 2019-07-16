import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';
import { Product } from '../models/product';
@Injectable()
export class ProductsService {

  constructor(private http:HttpClient) { }

  apiPath = "http://localhost:5000/api/products"

  getProducts():Observable<Product[]>{
    return this.http.get<Product[]>(this.apiPath);
  }

  getProductsByCategory(categoryId:number):Observable<Product[]>{
    return this.http.get<Product[]>(this.apiPath+"/"+categoryId);
  }

}
