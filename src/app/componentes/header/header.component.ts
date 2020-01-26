import { Component, OnInit } from '@angular/core';

import { Alumno } from "@modelos/Alumno.model";
import { DatePipe } from "@angular/common";

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  constructor( private datePipe: DatePipe) { 
  }
  fecha_actual:Date = new Date();

  fecha: any = this.datePipe.transform(this.fecha_actual,"yyyy-MM-dd")

  public alumno:Alumno = {
    'id': 12,
    'nombre': "Felipe",
    'apellido':'Arias',
    'edad': 28,
    'genero': 'M',
    'fecha_ingreso': this.fecha,
    'estado':'Activo',
    'codigo_carrera': 28,
    'codigo_centro':12
  }
  
  nombre:string = "Sebastian"

  ngOnInit() {
    
  }
  
  arreglo = [2,2,3,4,5,6,78,8,9,1];
  
  cambiarNombre(){
    this.nombre == "Sebastian"? this.nombre = "Juan" : this.nombre = "Sebastian"
    this.arreglo.sort((a,b) => a - b)
  }
}
 