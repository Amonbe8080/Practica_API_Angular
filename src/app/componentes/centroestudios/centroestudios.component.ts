import { Component, OnInit } from '@angular/core';
import { CentroService } from './centro.service';
import { CentroEstudiosModel } from '@modelos/Centro_Estudios';

@Component({
  selector: 'app-centroestudios',
  templateUrl: './centroestudios.component.html',
  styleUrls: ['./centroestudios.component.css']
})
export class CentroestudiosComponent implements OnInit {

  // Este componente usa un modelo al momento de cargar los datos
  constructor(private centro:CentroService) { 
    // Obtiene los datos y los asigna a un objeto de tipo CentroEstudios
    this.centro.getAllCentros().subscribe((res : CentroEstudiosModel) => this.ce = res, err => this.cargarDatos = false)
  }

  cargarDatos : boolean = true
  public ce : CentroEstudiosModel

  ngOnInit() {
  }
}
