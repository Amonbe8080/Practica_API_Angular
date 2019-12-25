# API usando .Net Core
Proyecto que realice para **reforzar el conocimiento** sobre cómo crear aplicaciones usando .NET Core (Backend)

En este proyecto encontraras temas como
  - Uso de **Entity Framework** y **conexión a MySql**.
  - Operaciones basicas a la base de datos **usando Entity Framework**.
  - Uso de funciones **Async, Enrutamiento y Modelos**.
  - Consumo de **[PokéApi](https://pokeapi.co/):octocat:**.
  - Uso de [Postman](https://www.getpostman.com/) para **probar** la aplicación.
  - Manejo de **archivos y carpetas**.
    - User_Files :file_folder:
      - ID_Alumno :file_folder:
        - Imagen: milky_way:   
## Próximo a mejorar
      Generar códigos QR y IDs únicos.
      Validación de datos.
      Carga Perezosa (Lazy Loading) para cargar los más de 900 Pokemones de PokéApi.
## En este proyecto se usaron los siguientes recursos

### Un sencillo modelo de base de datos.
 ![Imagen del modelo DB](https://github.com/Amonbe8080/Practica_API_Angular/blob/backend/Screenshots/DB.png)
 
### Librerías y versionamiento de estas mismas. 
  ![Imagen librerias](https://github.com/Amonbe8080/Practica_API_Angular/blob/backend/Screenshots/Nuget.png)
  
# Comencemos con las operaciones basicas a la Base de Datos.

## Crear Alumno
 ![Imagen Postman usando Post](https://github.com/Amonbe8080/Practica_API_Angular/blob/backend/Screenshots/Post.png)
 
 Al momento de crear un alumno se pedirá **una imagen**, el sistema **creara una carpeta** con el id del alumno y **almacenara allí la imagen** con el siguiente orden
 ![Imagen de VS](https://github.com/Amonbe8080/Practica_API_Angular/blob/backend/Screenshots/Post_Files.png)
 
## Editar Alumno
 En este caso editamos la edad a 99 años.
 ![Imagen Postman usando Put](https://github.com/Amonbe8080/Practica_API_Angular/blob/backend/Screenshots/Put.png)
 
 
## Consultar Alumno
Se usa una consulta con **Inner Join** para unir los resultados de varias tablas, en este caso para **mostrar a que carrera y centro de estudio pertenece**.
 Solo consultara los alumnos que **no estén Suspendidos**.
 ![Imagen Postman usando Get(id)](https://github.com/Amonbe8080/Practica_API_Angular/blob/backend/Screenshots/Get_ID.png)
 
 
## Eliminar Alumno
 El sistema **no realizará** una acción de tipo **Delete**, usara **Update** y modificará el **campo de 'estado' a "Suspendido"**.
 Además se **borrará la carpeta** establecida **para guardar las imágenes de dicho alumno**.
 ![Imagen Postman usando Delete](https://github.com/Amonbe8080/Practica_API_Angular/blob/backend/Screenshots/Delete.png)
 
 
 #Finalizamos con el consumo de [PokéApi](https://pokeapi.co/) :octocat:
  El API originalmente nos **traerá todos estos datos**.
 ![Imagen Postman usando Get al API](https://github.com/Amonbe8080/Practica_API_Angular/blob/backend/Screenshots/Get_Pokemon_Original.png)
 
 Lo que hice fue realizar un modelo para **tomar los datos** que quería.
 ![Imagen Postman usando Get a mi API](https://github.com/Amonbe8080/Practica_API_Angular/blob/backend/Screenshots/Get_Pokemon.png)
 
 Otra forma que implemente es usar una **variable de tipo Dynamic**, con esto **no tengo que crear un Modelo** y puedo leer los datos de una manera familiar para mí.
 ![Imagen VS](https://github.com/Amonbe8080/Practica_API_Angular/blob/backend/Screenshots/Dynamic.png)
 
