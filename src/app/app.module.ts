// Librerias necesarias
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { Routes, RouterModule} from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DatePipe } from "@angular/common";
import { HttpClientModule } from '@angular/common/http';

// Componentes
import { MainComponent } from './componentes/main/main.component';
import { InscripcionComponent } from './componentes/inscripcion/inscripcion.component';
import { PageNotFoundComponent } from './componentes/page-not-found/page-not-found.component';
import { CarrerasComponent } from './componentes/carreras/carreras.component';
import { CentroestudiosComponent } from './componentes/centroestudios/centroestudios.component';
import { CabeceraComponent } from './componentes/cabecera/cabecera.component';
import { AppComponent } from './app.component';
import { HeaderComponent } from './componentes/header/header.component';
import { FooterComponent } from './componentes/footer/footer.component';
import { NotContentComponent } from './componentes/not-content/not-content.component';


// Creacion de rutas
const routes: Routes = [
  {path: '', component: MainComponent },
  {path: 'cabecera', component: HeaderComponent },
  {path: 'carreras', component: CarrerasComponent },
  {path: 'centro', component: CentroestudiosComponent },
  {path: 'inscripcion', component: InscripcionComponent},
  {path: '**', component: PageNotFoundComponent }
];

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    CabeceraComponent,
    MainComponent,
    InscripcionComponent,
    PageNotFoundComponent,
    CarrerasComponent,
    CentroestudiosComponent,
    FooterComponent,
    NotContentComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    FormsModule,
    HttpClientModule,
    RouterModule.forRoot(routes),
    ReactiveFormsModule
  ],
  providers: [DatePipe],
  bootstrap: [AppComponent]
})
export class AppModule { }
