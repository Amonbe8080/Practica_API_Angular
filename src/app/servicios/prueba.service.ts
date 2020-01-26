import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from '@modelos/User.model';

@Injectable({
  providedIn: 'root'
})
export class PruebaService {

  constructor(private httpclient: HttpClient) { }

  url:string = "https://jsonplaceholder.typicode.com/todos"

  getAll(){
    return this.httpclient.get(this.url)
  }
}
