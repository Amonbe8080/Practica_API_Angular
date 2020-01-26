
import { Component, Input, Output, EventEmitter, Host, OnInit } from '@angular/core';
import { BreakpointObserver, Breakpoints } from '@angular/cdk/layout';
import { Observable } from 'rxjs';
import { map, shareReplay } from 'rxjs/operators';
import { PruebaService } from 'app/servicios/prueba.service';

@Component({
  selector: 'app-cabecera',
  templateUrl: './cabecera.component.html',
  styleUrls: ['./cabecera.component.css']
})
export class CabeceraComponent implements OnInit{

  isHandset$: Observable<boolean> = this.breakpointObserver.observe(Breakpoints.Handset)
    .pipe(
      map(result => result.matches),
      shareReplay()
    );  
  @Input('data') title:string
  @Input('test') prueba:string
  
  // Enviar datos al padre
    // @Output() enviar = new EventEmitter<string>()
    // @Host() private _app:AppComponent,
  
  constructor(private breakpointObserver: BreakpointObserver,private _prueba: PruebaService) {}

  logeado:boolean = false

  // Funcion para enviar
    // Enviar(title: string){
    //   this.enviar.emit(title)
    // }

   
  ngOnInit(){
  }
  
  // mostrarPadre(){
  //   console.log(this._app);
  // }  

  logout():void{
    this.logeado = false
  }
  ingresar():void{ 
    this.logeado = true
  }
}
