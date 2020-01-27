# Practica Frontend usando Angular 8
Proyecto que realice para **reforzar el conocimiento** sobre cómo crear aplicaciones usando Angular (Frontend)

En este proyecto encontraras temas como
  - Uso de **DatePipe** para la conversión a formato de fechas.
  - Manejo de **rutas y componentes**.
  - Manejo de **servicios y modelos**.
  - **Formulario reactivo** usando FormGroup, FormBuilder, Validators como librerias propias de Angular.
  - Uso de HttpClientModule para **petición de datos** al [Backend](https://github.com/Amonbe8080/Practica_API_Angular/tree/backend).
  - **Diseño adaptable** a móviles.
  
El sistema reconoce cuando hubo una **falla** al momento de realizar una **petición al servidor**, en caso de haber una falla **mostrara un mensaje** como "Servicio fuera de línea".
  
## Inicializando el Proyecto

Una vez clonado el proyecto deberemos tener instalado en nuestro ordenador [NodeJS](https://nodejs.org/es/) y [AngularCLI](https://cli.angular.io/) después de tenerlos usaremos los siguientes **comandos para la instalación de las librerías** de diseño. En este caso use [Material Design Bootstrap](https://mdbootstrap.com/).

**Estas librerías serán necesarias para poder correr la aplicación**

      npm install
      npm install mdbootstrap
      npm install bootstrap
      npm install jquery
      npm install popper.js
      npm install --save-dev @fortawesome/fontawesome-free

Si todo fue bien (eso espero) **podremos correr nuestra aplicación** con el comando **`ng serve`**.

# Inicio

Esta será la primera vista que tendrá el usuario de la aplicación

  ![Inicio](https://github.com/Amonbe8080/Practica_API_Angular/blob/frontend/Screenshots/Inicio.gif)

# Carreras y Centros de Formación 
  ![Carreras](https://github.com/Amonbe8080/Practica_API_Angular/blob/frontend/Screenshots/carreras.png)
  
  ![Centros](https://github.com/Amonbe8080/Practica_API_Angular/blob/frontend/Screenshots/centros.png)
  
# En caso de no cargar (Falla del servidor o el usuario no tiene internet)
  ![Carreras_OffLine](https://github.com/Amonbe8080/Practica_API_Angular/blob/frontend/Screenshots/offline.png)
  
# Inscripción

  ## Formularios inválidos

  Cuando el campo es **Requerido y ya ha hecho focus** por ese label se mostrará el siguiente error.
  
  ![Required](https://github.com/Amonbe8080/Practica_API_Angular/blob/frontend/Screenshots/Invalid-Form1.gif)
  
   Cuando el valor introducido **no corresponde al tipo de dato exigido**.
   
   ![Invalid-Type](https://github.com/Amonbe8080/Practica_API_Angular/blob/frontend/Screenshots/Invalid-Form2.gif)
   
  ## Formulario valido

  En caso de **rellenar los datos correctamente** la aplicación **habilitará** el botón de "Inscribirme"
  ![Valido](https://github.com/Amonbe8080/Practica_API_Angular/blob/frontend/Screenshots/Valid-Form.gif)
  
## Próximo a Mejorar
      Envió de datos al Backend (Error de tipo Media-Type), se debe cambiar desde el backend al momento de recibir los datos.
      Componente de Login, Home.
      Carga Perezosa en Centros de formación y Carreras.
      Filtros de búsqueda para Centros de formación y Carreras.
      Registro con varias fases:
              * Fase 1: Datos Personales.
              * Fase 2: Datos Académicos.
              * Fase 3: Datos Económicos.

      
              
       
