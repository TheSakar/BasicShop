import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { Observable } from 'rxjs';
import { Category } from '../models/category';

@Injectable()
export class CategoriesService {

  constructor(private http:HttpClient) { }

  apiPath="http://localhost:5000/api/categories"

getCategories():Observable<Category[]>{
return this.http.get<Category[]>(this.apiPath);
}

}
