# WebApiDemo 🚀
> Una implementación profesional de API RESTful con ASP.NET Core.

[![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![Swagger](https://img.shields.io/badge/Swagger-85EA2D?style=for-the-badge&logo=swagger&logoColor=black)](https://swagger.io/)

Este proyecto es una demostración de una API web construida con **ASP.NET Core**. Está diseñado para ilustrar conceptos fundamentales como el manejo de rutas, controladores, modelos y respuestas HTTP estandarizadas.

---

## 📋 Características

* **Controladores RESTful:** Implementación completa de operaciones CRUD.
* **Inyección de Dependencias:** Gestión eficiente de servicios.
* **Manejo de Errores:** Respuestas HTTP claras y personalizadas.
* **Documentación Interactiva:** Integración nativa con **Swagger UI**.

---

## 🛠️ Tecnologías

* **Lenguaje:** C#
* **Framework:** .NET 10.0 
* **Herramientas:** Entity Framework Core, SQL Server, OpenAPI.
* **AutoMapper:** Para la conversión automática entre Entidades y DTOs, manteniendo el código limpio y evitando asignaciones manuales repetitivas
* **Fluent Validation / Data Annotations:** Validación de datos en los modelos de entrada
* **JWT (JSON Web Tokens):** Sistema de seguridad para proteger los endpoints de la API.

---
## Manejo Global de Excepciones

Una de las características clave es el Middleware de Excepciones Global. En lugar de usar bloques try-catch en cada controlador, el sistema utiliza un GlobalExceptionHandler:

* **Centralización:** Todos los errores de la aplicación son capturados en un solo lugar.

* **Abstracción de Errores:** Se transforman excepciones internas (como LoginFailedException o UserAlreadyExistsException) en respuestas HTTP semánticas (401 Unauthorized, 409 Conflict).

* **Seguridad:** El cliente recibe un mensaje amigable y estructurado, mientras que los detalles técnicos del error se guardan en los logs del servidor para depuración.

---
## Gestión de Roles y Permisos
El sistema implementa un control de acceso basado en roles:

* **Admin:** Tiene acceso total para crear, editar y eliminar productos, además de gestionar los roles de otros usuarios.

* **Director/Employee:** Tiene acceso total para crear, editar y eliminar productos, pero no puede gestionar los roles de otros usuarios.



La sesión del usuario se mantiene de forma segura mediante una clase estática UserSession en el cliente, sincronizada con los claims del token JWT emitido por la API.
---
## 🚀 Instalación y Uso

Sigue estos pasos para poner en marcha el proyecto:

1.  **Clonar el repositorio:**
    ```bash
    git clone [https://github.com/Gaspar-Peris/WebApiDemo.git](https://github.com/Gaspar-Peris/WebApiDemo.git)
    cd WebApiDemo/WebApiDemo
    ```

2.  **Restaurar dependencias:**
    ```bash
    dotnet restore
    ```

3.  **Ejecutar la aplicación:**
    ```bash
    dotnet run
    ```

La API estará disponible en `https://localhost:5001` (o el puerto configurado en `launchSettings.json`).
Luego de iniciar WebApiDemo debera cambiar de proyecto y iniciar WinFormsApp1

---

## 📖 Documentación de Endpoints

Para explorar y probar los endpoints de forma interactiva, accede a:
👉 `https://localhost:5001/swagger`

| Método | Endpoint | Descripción |
| :--- | :--- | :--- |
| **GET** | `/api/values` | Obtiene el listado de recursos. |
| **GET** | `/api/values/{id}` | Obtiene un recurso por ID. |
| **POST** | `/api/values` | Crea un nuevo registro. |
| **PUT** | `/api/values/{id}` | Actualiza un registro existente. |
| **DELETE** | `/api/values/{id}` | Elimina un registro del sistema. |

---

## 📂 Estructura del Proyecto

* **Controllers:** Lógica de los endpoints y manejo de peticiones.
* **Models:** Representación de las entidades de datos.
* **Data:** Configuración de persistencia (si aplica).

---

## 👤 Autor

**Gaspar Peris**
* GitHub: [@Gaspar-Peris](https://github.com/Gaspar-Peris)

