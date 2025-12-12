# DSW1_T2_CONTRERASQUINTANA_API

## Descripción
Este proyecto corresponde a la API del Sistema de Información Integrado de la Biblioteca.  
Permite gestionar libros, autores y préstamos mediante endpoints RESTful.  
Desarrollado en **.NET 8** usando **C#**, con base de datos **MySQL** y patrones de arquitectura **Clean Architecture**.

---

## Requisitos
- Visual Studio 2022
- .NET 8 SDK
- MySQL 8 o superior
- navegador para probar endpoints

---

## Base de datos
Se utiliza MySQL como motor de base de datos.

### Crear la base de datos
CREATE DATABASE library_api_db;
USE library_api_db;

### Configurar conexion a la bd
"ConnectionStrings": {
  "DefaultConnection": "server=localhost;database=library_api_db;user=root;password=TU_CONTRASEÑA;"
}
