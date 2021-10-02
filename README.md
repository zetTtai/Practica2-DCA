# **Practica1 - ADI**
## **Bug Hunter** 

Una aplicación de escritorio con interfaz de usuario desarrollada con C# + Windows Form.

Simula el funcionamiento de una LBT (Local Bug Tracker).

Esta aplicación sólo funciona en Windows.

Los nuevos datos introducidos persistiran en la aplicación hasta que esta se cierre.

Si cierras y abres la aplicación todo volverá a su estado inicial (se perderán los nuevos reportes, los nuevos usuarios, ...)

# Guía
Para ejecutar esta aplicación tan sólo será necesario hacer doble click en el ejecutable: **DCA-Practica1.exe**

Una vez la aplicación se haya ejecutado, aparecerá un formulario para logearse en la aplicación.

Puedes crear tu propio usuario pulsando el botón **¡Regístrate!** o iniciar sesión con el usuario administrador:

`Correo electrónico: admin@ua`

`Contraseña: admin`

Una vez iniciado sesión se mostrarán tres opciones:

1. Notificar un error
2. Buscar errores
3. Mi cuenta (No disponible)

Además de tener la oportunidad de **cerrar sesión** para cambiar de cuenta en cualquier momento y volver a la página principal **clickando en el logo** situado en la esquina superior izquierda.

## Notificar un error

Clickando sobre la imagen de Notificar un error aparecerá un formulario en el que el usuario podrá crear un nuevo reporte el cual será añadido a la lista de reportes registrados y a su propia lista de reportes registrados.

Todos los reportes realizados por el usuario tendrán como estado el estado **pendiente**.

Además de tener un apartado en el que da la opción de comentar sobre el reporte que se muestra en ese momento. 

(no disponible por el momento)

## Buscar errores
Clickando sobre la imagen de Buscar errores el usuario podrá ver un listado de todos los reportes registrados en la aplicación.

Si es un **usuario normal** tan sólo tendrá disponible el botón de **Mostrar** el cual genera una ventana a parte con más información acerca del reporte en cuestión.

Si es un **usuario admin** podrá hacer lo anterior descrito anteriormente además de **Editar** y **Borrar** un Reporte.

Respecto a la opción de **Editar**, el administrador tan sólo podrá cambiar el estado en el que se encuentra el Reporte seleccionado.

Los distintos estados son: 

`Pendiente, Visto, Arreglando Solucionado y WONTFIX`

Por último, la opción de **Borrar** directamente borra el reporte del DataGridView, de la lista de reportesRegistrados y de la lista del usuario que publicó el reporte.




