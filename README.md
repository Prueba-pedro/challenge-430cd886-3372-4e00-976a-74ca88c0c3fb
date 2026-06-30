# Desarrollo de una Web API con ASP.NET Core

El equipo de desarrollo de una fintech necesita implementar una Web API que permita la gestión de usuarios y sus transacciones. La API debe ser capaz de registrar nuevos usuarios, listar todos los usuarios, obtener detalles de un usuario específico, registrar transacciones para un usuario y listar las transacciones de un usuario. La API debe ser idempotente en la creación de usuarios y transacciones, y debe manejar adecuadamente los errores de validación y de conexión con la base de datos. Los usuarios tienen un identificador único, nombre y email. Las transacciones tienen un identificador único, monto, fecha y están asociadas a un usuario.

## Informacion General

| Campo | Valor |
|-------|-------|
| **Tema** | aspnetcore |
| **Nivel** | junior-l1 |
| **Tipo** | practical |
| **Tiempo estimado** | 8 horas |

## Fases del Reto

### Fase 0: Configuración del Proyecto

**Objetivo:** Obtener el proyecto base funcional enviando el Código Base a un asistente de IA, que lo analizará, corregirá errores y generará un ZIP listo para usar.

**Tiempo estimado:** 15-30 minutos

**Instrucciones:**

- Asegúrate de tener instalado para ejecutar el proyecto: Un IDE o editor de código.
- Copia todo el contenido del campo **Código Base** de este reto — incluyendo el texto de instrucciones que aparece al inicio.
- Abre un asistente de IA (Claude en claude.ai, ChatGPT o Gemini — se recomienda Claude), pega el contenido copiado en el chat y envíalo.
- El asistente analizará los archivos, corregirá errores y generará un archivo ZIP descargable. Descárgalo y extráelo en la carpeta donde quieras trabajar.
- Verifica que el proyecto arranca sin errores.

**Entregable:** El proyecto compila/arranca sin errores.

<details>
<summary>Pistas de conocimiento</summary>

- Copia el Código Base completo incluyendo el texto de instrucciones al inicio — esas instrucciones le indican al asistente exactamente qué hacer con los archivos.
- Si el asistente no genera el ZIP automáticamente al terminar el análisis, escríbele: "genera el ZIP ahora".
- Si el proyecto tiene errores al arrancar, comparte el mensaje de error con el mismo asistente para que lo corrija.

</details>

### Fase 1: Registro de usuarios

**Objetivo:** Implementar la funcionalidad para registrar nuevos usuarios de manera idempotente.

**Tiempo estimado:** 2 horas

**Instrucciones:**

- Diseñar el modelo de datos para los usuarios.
- Implementar el endpoint para registrar un nuevo usuario.
- Asegurar que la operación de registro sea idempotente.

**Entregable:** Endpoint funcional para registrar usuarios con idempotencia.

<details>
<summary>Pistas de conocimiento</summary>

- Considera cómo garantizar la unicidad del identificador de usuario.
- Piensa en cómo manejar los errores de validación del email.

</details>

### Fase 2: Listado y detalles de usuarios

**Objetivo:** Implementar los endpoints para listar todos los usuarios y obtener detalles de un usuario específico.

**Tiempo estimado:** 2 horas

**Instrucciones:**

- Implementar el endpoint para listar todos los usuarios.
- Implementar el endpoint para obtener detalles de un usuario específico.

**Entregable:** Endpoints funcionales para listar usuarios y obtener detalles de un usuario.

<details>
<summary>Pistas de conocimiento</summary>

- Considera cómo paginar la lista de usuarios si hay muchos.
- Piensa en cómo manejar la situación donde el usuario solicitado no existe.

</details>

### Fase 3: Registro y listado de transacciones

**Objetivo:** Implementar la funcionalidad para registrar transacciones para un usuario y listar las transacciones de un usuario.

**Tiempo estimado:** 2 horas

**Instrucciones:**

- Diseñar el modelo de datos para las transacciones.
- Implementar el endpoint para registrar una transacción para un usuario.
- Implementar el endpoint para listar las transacciones de un usuario.

**Entregable:** Endpoints funcionales para registrar y listar transacciones de un usuario.

<details>
<summary>Pistas de conocimiento</summary>

- Considera cómo garantizar la unicidad del identificador de transacción.
- Piensa en cómo manejar los errores de conexión con la base de datos.

</details>

### Fase 4: Documentación con Swagger

**Objetivo:** Documentar la API utilizando Swagger.

**Tiempo estimado:** 2 horas

**Instrucciones:**

- Configurar Swagger para documentar la API.
- Asegurar que todos los endpoints estén correctamente documentados.

**Entregable:** API documentada con Swagger.

<details>
<summary>Pistas de conocimiento</summary>

- Considera cómo describir claramente cada endpoint y sus posibles respuestas.
- Piensa en cómo organizar la documentación para que sea fácil de navegar.

</details>

## Dimensiones Evaluadas

- **queEs**: ¿Qué es un endpoint idempotente y por qué es importante en este contexto?
- **paraQueSirve**: ¿Para qué sirve documentar una API con Swagger?
- **comoSeUsa**: ¿Cómo se usa un modelo de datos en una aplicación ASP.NET Core?
- **erroresComunes**: ¿Cuáles son los errores comunes al registrar usuarios y cómo se manejan?
- **queDecisionesImplica**: ¿Qué decisiones implica el diseño de una API idempotente?

## Criterios de Evaluacion

- Implementar un endpoint idempotente para registrar usuarios.
- Implementar endpoints para listar y obtener detalles de usuarios.
- Implementar endpoints para registrar y listar transacciones de un usuario.
- Documentar la API con Swagger.

---

*Reto generado automaticamente por Challenge Generator - Pragma*
