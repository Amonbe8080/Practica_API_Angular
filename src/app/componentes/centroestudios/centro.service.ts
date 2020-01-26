import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CentroEstudiosModel } from '@modelos/Centro_Estudios';


@Injectable({
  providedIn: 'root'
})
export class CentroService {

  constructor(private centro: HttpClient) { }

  private url : string = "https://localhost:5001/api/centro_estudio"

  getAllCentros(){
    return this.centro.get<CentroEstudiosModel>(this.url)
  }

}
