# ASESOFTWARE
prueba tecnica asesoftware

## instalación

1. Descargar el repositorio 

´´´
git clone https://github.com/djmedinapk/Asesoftware
´´´

2. Abrir la solucion *Asesoftware.sln*  con visual studio y compilar la solucion
3. abrir una consola de windows dentro de la ruta *Asesoftware/asesoftware/* y ejecutar el siguiente comando en la consola

´´´
npm start
´´´


## Descripción del Proyecto

 ### Arquitectura
actualmente el sistema consiste en una arquitectura API REST que permite conectar múltiples servicios de la aplicación, esta solucion  de software está dividida en 2 secciones:

1. .NET core 
    Es una solución realizada en c# con.NET core 5, encargada de manejar las peticiones realizadas a la api y dar una solución a la petición realizada. en este caso es traer los datos de los usuarios

    esta sección estará dividida en tres proyectos a los cuales se les asignará tareas con alcances específicos tal como se realizaria en un preoyecto real. los proyectos son los siguientes: 

    - Core: un proyecto de tipo biblioteca de clases, este se encargará de gestionar los datos de usuarios en este caso quemados, pero en un real caso desde una base de datos
    - Lógica: un proyecto de tipo biblioteca de clases, este se encargará de manejar las interfaces que permiten conectar con las entidades creadas en el proyecto core, es decir este manejara las transacciones de datos y la persistencia de los mismos, creando métodos que realicen tareas específicas.
    - webAapi: un proyecto de tipo ASP .Net core Web API, se encarga de recibir y exponer las url donde se ralizaran las consultas desde el cliente ReactJs.

2. ReactJS
    es una aplicacion en al que utilizamos ReactJs Hooks para mostrar la informacion en una tabla y ver en detalle cada registro
