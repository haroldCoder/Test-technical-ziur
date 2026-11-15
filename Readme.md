# Prueba tecnica Ziur

El objetivo de esta prueba, es que con la ayuda de la tecnologia de blazor, crear una interfaz grafica, para consumir una api creada por ziur,
Esta api contiene la informcacion sobre movimientos de inventario.

## Ver que nos devuelve la api.

El primer paso que se dio en esta prueba tecnica, fue la de la exploracion y observacion de dicho enpoind de la api, en una plataforma parecida
a postman para testear apis, la cual se llama bruno y nos sirve para ver la estructura y lo que nos devuelve el endpoind, esto es importante
para ver como se va a construir nuestro negocio por asi decirlo, ademas de tener una base de lo que se necesita.

![Captura de pantalla 2026 11 14 231202](wwwroot/Captura%20de%20pantalla%202026-11-14%20231202.png)

## Aquitectura del proyecto

Para este proyecto se eligio una arquitectura de tipo hexagonal, donde todo lo que se cree dependera del dominio, el cual sera la base
para arrancar en el proyecto y en el cual el mismo proyecto de tipo frontend, se va a basar; esta seria la definicion de la reparticion:

**dominio**: Todo lo que viene a ser logica pura, no depende de artefactos externos, como lo son librerias, frameworks o recursos exteriores.

**infrastructure**: Es lo que se puede conectar con recursos externos, llamese apis, bases de datos, servicios web, u otras cosa que no sea de
caracter propio.

**core**: el core se refiere a todo lo que puede ser compartido en todo el proyecto, llamese utils, helpers, constantes o componentes reutilizables.

**application**: aqui se nos podemos referir a todo el tema de el funcionamiento del sistema, llamese casos de uso, orquestaciones,
inclusive politicas de negocio es decir del funcionamiento, en muchas ocaciones a lo largo del ciclo de vida del software.

## Seguridad.

Por la parte de seguridad, se decidio que el bearer token pasado en la prueba tecnica, es un recurso que solo lo deberian de acceder
el aspirante de la vacante y el equipo de ziur, por lo cual se decide guardar este bearer token en una variable de entorno, donde se
pueda acceder a este recurso y mas adelante cambiarlo segun sea la necesidad.

## Ejecucion del proyecto.

### 1. Clonar el repositorio

```bash
git clone https://github.com/haroldCoder/Test-technical-ziur
```

### 2. Entrar a la carpeta del proyecto

```bash
cd Test-technical-ziur
```

### 3. Configurar las variables de entorno

Copia el archivo de ejemplo y completa tus valores:

```bash
# Windows (cmd)
copy .env.example .env

# Linux / Mac / PowerShell
cp .env.example .env
```

Luego edita el archivo `.env`:

```
API_BEARER_TOKEN=tu_token_aqui
```

> El archivo `.env` debe quedar en la misma carpeta que el `.csproj`.
> No subas el `.env` al repositorio: ya está incluido en el `.gitignore`.

### 4. Ejecutar el proyecto

**Con Visual Studio:** abre la solución y presiona el botón verde de play (▶).

**Con la terminal:**

```bash
dotnet run
```


## Conclusion.

Esta prueba tecnica, se logro resolver con exito, entendiendo bien el codigo usado, y sobre todo entendiendo las bases, para cambiarlo
al dia de mañana si ese es el siguiente paso, ya que esta construido con una infrastructura organizada e intuitiva para mi persona y
para el desarrollador comun, es una prueba costruida con la tecnologia mas actualizada de blazor y c# de manera que es una version 
estable y con buen soporte.


