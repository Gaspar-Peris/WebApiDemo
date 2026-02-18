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

