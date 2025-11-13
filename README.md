# Servicio_Escolar

Repositorio: KadirQuintero03/Servicio_Escolar

Descripción
- Aplicación de escritorio desarrollada en C# con .NET para la gestión de servicios escolares. No es una aplicación web; la funcionalidad se organiza en capas y está orientada a interfaces de usuario de escritorio.

Estructura del repositorio
- Servicios_Escolares_Proyecto.sln
  - Archivo de solución principal (.sln) que contiene los proyectos del sistema.
  - Ruta en el repositorio: /Servicios_Escolares_Proyecto.sln

- Datos/
  - Carpeta destinada al acceso y persistencia de datos (capas/archivos relacionados con acceso a bases de datos o almacenamiento).
  - Ruta en el repositorio: /Datos

- Entidades/
  - Carpeta con las clases de dominio o modelos (representación de las entidades del sistema: alumnos, materias, etc.).
  - Ruta en el repositorio: /Entidades

- Logica/
  - Carpeta con la lógica de negocio (servicios, reglas y operaciones que implementan el comportamiento de la aplicación).
  - Ruta en el repositorio: /Logica

- PresentacionGPU/
  - Carpeta que contiene la capa de presentación para interfaces de escritorio (el proyecto responsable de la interfaz de usuario).
  - Ruta en el repositorio: /PresentacionGPU

Archivos visibles en la raíz
- README.md (este archivo)
  - Ruta: /README.md
- Servicios_Escolares_Proyecto.sln
  - Ruta: /Servicios_Escolares_Proyecto.sln

Requisitos y compilación
- Entorno: Proyectos escritos en C# y estructurados como solución .NET. Abra la solución Servicios_Escolares_Proyecto.sln con Visual Studio (o el IDE compatible que soporte soluciones C#/.NET).
- Compilar: Restaurar dependencias si las hay y compilar la solución desde el IDE o mediante herramientas de línea de comando compatibles con la versión de .NET usada.
- Ejecutar: Establecer como proyecto de inicio el proyecto de presentación (PresentacionGPU) si corresponde y ejecutar desde el IDE.

Notas adicionales
- La organización en carpetas sigue una arquitectura por capas (Entidades, Datos, Lógica, Presentación).
- No se incluyen en este README suposiciones sobre versiones concretas de .NET o paquetes adicionales; revise los archivos de proyecto dentro de cada carpeta para obtener detalles exactos de framework y dependencias.
- El repositorio tiene habilitadas las issues y proyectos en GitHub (si se requiere reportar o coordinar trabajo).

Contacto / Autor
- Propietario del repositorio: KadirQuintero03
- Enlace al repositorio: https://github.com/KadirQuintero03/Servicio_Escolar
