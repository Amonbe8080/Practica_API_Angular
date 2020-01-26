import { InscripcionService } from './inscripcion.service';
import { Component, OnInit } from '@angular/core';
import { CarreraService } from '../carreras/carrera.service';
import { CentroService } from '../centroestudios/centro.service';
import { CentroEstudiosModel } from '@modelos/Centro_Estudios';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { DatePipe } from "@angular/common";

@Component({
  selector: 'app-inscripcion',
  templateUrl: './inscripcion.component.html',
  styleUrls: ['./inscripcion.component.css']
})
export class InscripcionComponent implements OnInit {

  constructor(
    private _carrera : CarreraService, 
    private _ce : CentroService,
    private inscripcion : InscripcionService,
    private builder : FormBuilder,
    private datePipe: DatePipe
    ) {
      this._carrera.getAllCarreras().subscribe(car => this.carreras = car, err => this.cargarDatos = false)
      this._ce.getAllCentros().subscribe((res : CentroEstudiosModel) => this.centros = res, err => this.cargarDatos = false)  

      const fecha_actual: Date = new Date();

      const fecha: any = this.datePipe.transform(fecha_actual,"yyyy-MM-dd")

      this.inscripcionForm = this.builder.group({
        id: ['', {
          // Validadores Sincronos
          validators: [Validators.required, Validators.minLength(6), Validators.maxLength(12), Validators.pattern('[0-9]*')]
        }],
        nombre: ['', {
          // Validadores Sincronos
          validators: [Validators.required, Validators.pattern('[a-zA-Z ]*')]
        }],
        apellido: ['',{
          // Validadores Sincronos
          validators: [Validators.required, Validators.pattern('[a-zA-Z ]*')]
        }],
        edad: ['', {
          // Validadores Sincronos
          validators: [Validators.required, Validators.max(150), Validators.min(6), Validators.pattern('[0-9 ]*')]
        }],
        genero: [''],
        fecha_ingreso: [fecha],
        estado: ['Activo'],
        codigo_carrera: [null,[Validators.required]],
        codigo_centro: [null, [Validators.required]]
      })
   }

   get edad() { return this.inscripcionForm.get('edad') }
   get nombre(){ return this.inscripcionForm.get('nombre') }
   get apellido(){ return this.inscripcionForm.get('apellido') }
   get id(){ return this.inscripcionForm.get('id') }
   get carrera(){ return this.inscripcionForm.get('codigo_carrera') }
   get centro(){ return this.inscripcionForm.get('codigo_centro') }

  carreras : object
  centros : CentroEstudiosModel
  inscripcionForm : FormGroup

  cargarDatos : boolean = true
   
  FileName:string="Seleccionar foto ";
  FileToUpload:File=null;
  ImageURL:string ="../../../assets/mortarboard.png";
  
  UpdateControls(e):void{
    this.FileToUpload = e.target.files[0];
    this.FileName = this.FileToUpload.name;

    var reader = new FileReader();

    reader.onload=(event:any)=>{
      this.ImageURL=event.target.result;
    }
    reader.readAsDataURL(this.FileToUpload);
  }


  ngOnInit() {
    
  }

  enviar(inscripcionForm){
    this.inscripcion.addUser(inscripcionForm, this.FileToUpload).subscribe(data => console.log(data))
  }
}
