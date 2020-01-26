import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Alumno } from '@modelos/Alumno.model';
import { DatePipe } from "@angular/common";

@Injectable({
  providedIn: 'root'
})
export class InscripcionService {

  constructor(
    private ins : HttpClient
  ) { }

  getUser(id : number){
    this.ins.get("https://localhost:5001/api/Alumnos/"+ id)
  }

  addUser(alumnos: any, file: File){

    let formToPost = new FormData();

    let requesToPost = JSON.stringify({
        id: alumnos.id,
        nombre: alumnos.nombre,
        apellido: alumnos.apellido,
        edad: alumnos.edad,
        genero: alumnos.genero,
        fecha_ingreso: alumnos.fecha_ingreso,
        estado: "Activo",
        codigo_carrera: alumnos.codigo_carrera,
        codigo_centro: alumnos.codigo_centro,
        file: file
    });

    formToPost.append('usuario', requesToPost)
    formToPost.append('file', file)
    
    console.log(requesToPost);
    

    return this.ins.post("https://localhost:5001/api/Alumnos", requesToPost)
  }
}
