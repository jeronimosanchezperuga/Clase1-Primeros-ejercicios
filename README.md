# ClickToSelect
## Consignas
### Analizar la escena
. Empezar en "01 Escena Para Armar" que se encuentra en la carpeta Scenes.

. Observar la pestaña Hierarchy. Tenemos un objeto Main Camera y otro Piso que no vamos a tocar. Luego están Seleccionable y TRI. Por último un objeto llamado [OBJECTSELECTIONMANAGER].

. Si ejecutamos la escena, veremos que Seleccionable cae y queda apoyado en Piso. 
### Instrucciones de uso
. Al hacer click sobre el objeto Seleccionable en la pestaña Game con la escena en ejecución podremos mover el objeto por el escenario con las flechas del teclado o WASD. Si volvemos a hacer click sobre él volverá a caer desde la posición en la que lo dejamos.

. Si al mover Seleccionable chocamos a TRI podemos ver que lo empujamos.

### Actividades
1. Cambiar el color de los sprites de la escena
2. Duplicar el objeto Seleccionable y probar manejar ambos objetos en la escena
3. Arrastrar desde el proyecto el sprite CUAD a la escena y agregarle los componentes Box Collider 2D y Rigidbody2D. Se comportará igual que TRI.
4. Duplicar CUAD y quitarle el componente Rigidbody2D para usarlo como un "estante" (no puede ser atravesado por los objetos Seleccionable pero no cae). Modificar su tamaño con la herramienta "Rect Tool" (se activa con la T) y rotarlo para crear un plano inclinado (la herramienta Rotate se activa con la letra E).
5. Crear un sprite Circle y añadirlo a la escena. Agregarle los componentes Circle Collider 2D y Rigidbody2D. Ubicarlo en la escena de manera que al ejecutarse ruede sobre el plano inclinado.
6. Añadir al sprite Circle el script SelectOnClick que se encuentra en la carpeta Scripts y utilizarlo como a Seleccionable.

Experimenten todo lo que quieran.

 
