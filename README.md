# MiniERP_API

API REST desarrollada en ASP.NET Core 8 con Entity Framework Core y base de datos SQLite. Pensada como backend de un sistema tipo ERP, permite la gestión de clientes, productos, facturas y sus respectivos detalles.

## 🚀 Tecnologías utilizadas

- ASP.NET Core 6
- Entity Framework Core
- SQLite
- Swagger (OpenAPI)
- Postman (para pruebas)

## 📦 Funcionalidades principales

- CRUD de clientes
- CRUD de productos
- CRUD de facturas
- CRUD de detalles de factura (líneas de productos en una factura)
- Cálculo automático de totales
- Relaciones entre entidades
- Validaciones automáticas
- API navegable desde Swagger

## 📂 Estructura del proyecto

```
/Controllers         → Controladores de la API
/Models              → Clases de entidad (Cliente, Producto, etc.)
/Data/AppDbContext   → Configuración de EF y SQLite
/BBDD                → Base de datos SQLite (MiniERP_API.db)
```

## ▶️ Cómo ejecutar el proyecto

1. Clona el repositorio:
   ```bash
   git clone https://github.com/juanAnronio/MiniERP_API.git
   ```

2. Abre la solución en Visual Studio

3. Ejecuta las migraciones:
   ```
   Update-Database
   ```

4. Presiona F5 para iniciar el proyecto

5. La API se abrirá automáticamente en Swagger:
   ```
   http://localhost:PUERTO/swagger
   ```

## 🧪 Endpoints disponibles

- `GET /api/clientes`
- `POST /api/clientes`
- `PUT /api/clientes/{id}`
- `DELETE /api/clientes/{id}`
- `GET /api/productos`
- `POST /api/productos`
- `PUT /api/productos/{id}`
- `DELETE /api/productos/{id}`
- `GET /api/facturas`
- `POST /api/facturas`
- `PUT /api/facturas/{id}`
- `DELETE /api/facturas/{id}`
- `GET /api/facturadetalles`
- `POST /api/facturadetalles`
- `PUT /api/facturadetalles/{id}`
- `DELETE /api/facturadetalles/{id}`

## 🔗 Autor

Desarrollado por Juan Antonio Ferrer Del Campo

Mi perfil del Linkedin: https://www.linkedin.com/in/juan-antonio-ferrer-del-campo-83905a19b/
