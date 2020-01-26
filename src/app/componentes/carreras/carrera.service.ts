import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CarreraService {

  constructor(private carrera: HttpClient) { }

  url : string = "https://localhost:5001/api/carreras"
  imgUrl : string="https://source.unsplash.com/random/?"

  getAllCarreras(){
    return this.carrera.get(this.url)
  }

  getCarrera(id : number){
    return this.carrera.get(this.url +" / "+ id)
  }
}
