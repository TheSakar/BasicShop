import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { Product } from 'src/app/models/product';
import { ProductsService } from 'src/app/services/products.service';
import { CategoriesService } from 'src/app/services/categories.service';
import { Category } from 'src/app/models/category';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css'],
  providers: [ProductsService, CategoriesService]
})
export class ProductsComponent implements OnInit {

  products: Product[];
  categories: Category[];

  @Output()
  passProduct = new EventEmitter();
  
  constructor(private productsService: ProductsService, private categoriesService: CategoriesService) { }

  ngOnInit() {
    this.getProducts();
    this.getCategories();
  }


  addToCart(product){
    this.passProduct.emit(product);
  }


  getByCategoryId(category) {
    this.productsService.getProductsByCategory(category.id).subscribe(data => {
      this.products = data;
    })
  }

  getCategories() {
    this.categoriesService.getCategories().subscribe(data => {
      this.categories = data;
    });
  }

  getProducts() {
    return this.productsService.getProducts().subscribe(data => {
      this.products = data;
    });
  }

  
}
