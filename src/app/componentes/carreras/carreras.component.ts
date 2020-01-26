import { Component, OnInit } from '@angular/core';
import { CarreraService } from './carrera.service';

@Component({
  selector: 'app-carreras',
  templateUrl: './carreras.component.html',
  styleUrls: ['./carreras.component.css']
})
export class CarrerasComponent implements OnInit {

  // Este componente utiliza un objeto para leer los datos, sin basarse en ningun modelo.
  constructor(private serv:CarreraService) {
    // Obtener los datos y asignarlos a una variable local
    this.serv.getAllCarreras().subscribe(res => this.carreras = res, err => this.cargarDatos = false)
  }

  cargarDatos : boolean = true
  private carreras : object
 
  ngOnInit() {
  }
}
