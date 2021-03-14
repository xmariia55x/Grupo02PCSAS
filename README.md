# Plataforma de Compromiso Social y Aprendizaje Servicio
Proyecto realizado por:

Javier Blanco Navarro

Adrián Corrales Moreno

María Gálvez Manceras

David Gerena Comino

Yeray Ruiz Suárez


### Índice
1. Introducción

    1. Objetivos
    1. Alcance
    1. Definiciones, acrónimos y abreviaturas
    1. Referencias
    1. Resumen
1. Directivas del proyecto

    1. Descripción del problema
    1. Descripción del producto
1. Descripción de participantes y usuarios

    1. Resumen de los participantes
    1. Resumen y entorno de los usuarios
    1. Perfiles de los participantes
    1. Perfiles de usuarios
    1. Alternativas y competencia
1. Visión general del producto

    1. Entorno de despliegue
    1. Resumen de características
    1. Suposiciones y dependencias
    1. Precio y coste
    1. Licencias e instalación
1. Requisitos funcionales

1. Precedencia y prioridad

1. Requisitos no funcionales


***

#### Introducción

##### Objetivos

El objetivo de este documento es recoger, analizar y definir las características y necesidades de alto nivel del sistema PCSAS: Plataforma de Compromiso Social y Aprendizaje Servicio. Se centrará en describir las expectativas de cada una de las partes del proyecto y de los usuarios finales y por qué estas necesidades existen. Los detalles de cómo PCSAS: Plataforma de Compromiso Social y Aprendizaje Servicio cumple estas necesidades se detallan en los casos de uso y en las especificaciones adicionales.


##### Alcance

El documento está relacionado tanto con el ámbito de la medicina como con el ámbito de la ingeniería pues afecta principalmente a cómo los estudiantes de entornos más desfavorecidos necesitan comunicarse con otras personas que están lejos de cara a poder complementar la formación de los estudiantes mediante el aprendizaje basado en servicios, para poder facilitar esta comunicación es necesario el desarrollo de un proyecto software. 

Hay que destacar que está enmarcado en el contexto de la asignatura de “Ingeniería de Requisitos” del grado de Ingeniería de Software de la UMA. Concretamente es el resultado de una colaboración con los estudiantes de la facultad de Medicina, ayudando así a su asignatura optativa “Farmacoterapéutica en entornos desfavorecidos”, impartida por la profesora María Cabello quien nos ha propuesto la idea de proyecto .

##### Definiciones, acrónimos y abreviaturas

- ApS: Aprendizaje-Servicio.
- Aprendizaje-servicio: Aproximación a la enseñanza y al aprendizaje que integra el servicio a la comunidad con el estudio académico, cuyo objetivo es enriquecer el aprendizaje, fomentar la responsabilidad cívica de la formación, así como el fortalecimiento de las comunidades.
- ONG: Organización no gubernamental.
- PCSAS: Plataforma de Compromiso Social y Aprendizaje Servicio.
- ACOES: Asociación, colaboración y esfuerzo.
- FED: Farmacoterapéutica en entornos desfavorecidos.
- BOE: Boletín Oficial del Estado.
- Fe y Alegría: ONG fundada en Venezuela que ofrece oportunidades de estudio a los sectores más pobres de la sociedad.
- AACID: Alianzas entre actores y territorios para reducir la desigualdad.
- Farmamundi: ONG de cooperación al desarrollo, acción humanitaria y emergencia que nace en 1991 para asegurar que la salud sea un derecho básico en los países subdesarrollados.
- UMA: Universidad de Málaga.
- CV: Currículum Vitae.
- LGPD: Ley General de Protección de Datos.

##### Referencias

En este documento se hará referencia al BOE ya que en el BOE se regula cómo debe ser el aprendizaje basado en servicios y que debe cumplir.

Referencia al [BOE-A-2017-10811](https://www.boe.es/diario_boe/txt.php?id=BOE-A-2017-10811) donde se regula el ApS.

[1] [Blog de Roser Batlle](https://roserbatlle.net/)

[2] [National Youth Leadership Council – NYLC](https://www.nylc.org/)

[3] [Centro Latinoamericano de Aprendizaje Servicio Solidario](http://www.clayss.org.ar/)

[4] [Google Classroom](https://classroom.google.com/)

[5] [Ley General de Protección de Datos](https://www.boe.es/eli/es/lo/2018/12/05/3)

##### Resumen

Este documento se encuentra estructurado según como se explica en el índice. El punto 2 define el problema que se presenta, así como la solución que planteamos. En el apartado 3 se describen los participantes y los usuarios propios del proyecto. La sección 4 cubre el funcionamiento y las características de la aplicación. El apartado 5 describe todos los requisitos funcionales del proyecto. El punto 6 trata acerca de la preferencia y la prioridad que se establecerá en el proyecto. Por último, en la sección 7 se cubre todo lo relacionado con los requisitos no funcionales.

#### Directivas del proyecto

##### Descripción del problema

El problema de no poder comunicarse presencialmente ya sea debido a la distancia o a otros problemas de salud, afecta a aquellos que recibían ayudas sociales mediante actividades, tanto en educación como en apoyo moral. El impacto de ese problema se ve reflejado directamente en que estas labores de aprendizajes-servicios a la comunidad no se pueden realizar. 

Una solución satisfactoria sería crear un sistema de aprendizaje-servicio que proporcione contenidos formativos, informativos, de difusión y sensibilización a sus usuarios, disponible para cualquier dispositivo con conexión a internet.

Así, se lograría unir a los centros educativos más desfavorecidos y apoyar a los alumnos con un sistema que  sea interactivo y pedagógico que permita compartir contenidos en directo y/o diferido además de contener numerosos recursos lúdicos para mejorar el aprendizaje de los alumnos de estos centros.

Cabe destacar que a la vez que los alumnos de los centros aprenden, los alumnos de la UMA implicados en este proyecto se forman y adquieren competencias que con otro tipo de formación no podrían adquirir.

##### Descripción del producto

Para la comunidad educativa, empresas y ONG, quienes tienen una necesidad de formarse en aspectos sociales, el sistema es un software que ofrece una solución al problema planteado. El objetivo principal de la aplicación es crear un entorno de unión entre los alumnos más desfavorecidos y profesores implicados de todo el mundo, ofrecer actividades formativas para estos estudiantes a la vez que los estudiantes de la UMA se forman mediante la adquisición de competencias transversales y experiencia laboral.  Por tanto, incluiremos el sistema en un mercado en el que no hay otro competidor actualmente por lo que nuestro producto cubrirá unas necesidades que a día de hoy nadie las satisface.

#### Descripción de participantes y usuarios

##### Resumen de los participantes

Nombre | Rol
------------ | -------------
ONG’s externas | Usarán el sistema para anunciar sus proyectos, teniendo así un altavoz para llegar a la comunidad educativa con mayor facilidad.
UMA  | Usará el sistema para anunciar sus proyectos, de forma similar a como lo harán las ONG’s externas.
Empresas | Las empresas podrán prestarse también a promocionar distintos proyectos, siempre que sean con finalidades similares a las de las ONG’s.
María Cabello | Coordinadora de la asignatura que usará el sistema y encargada de aportar la idea e interés en el proyecto.
Facultad de Medicina | Facultad que usará nuestro sistema para una asignatura optativa.

##### Resumen y entorno de los usuarios

Nombre | Descripción | Participante
------------ | ------------- | -------------
Profesores | Tendrán la oportunidad de usar estas herramientas en clase para mejorar su rendimiento. | Están relacionados con las ONG’s que financian el proyecto.
ONG | Propondrán diversas actividades para que los usuarios participen. | Están relacionados con las ONG’s que financian el proyecto, ellas mismas.
Alumnos | Son los beneficiarios del sistema y que utilizan la plataforma para aprender. | Realizan las actividades que promueven las ONG’s.
Administradores | Gestionan el sistema y se aseguran de que todos los recursos y funcionalidades funcionan correctamente. | Serán contratados por las entidades que financien el proyecto.
Invitado | Podrán consultar las actividades propuestas en el calendario y ver contenidos del sistema. | Ven una parte de los contenidos que promueven las ONG’s.

##### Perfiles de los participantes

**UMA**

| | |
|-|-|
Representante | Persona anónima del Servicio Central de Informática.
Tipo | Son profesionales titulados y dedicados a la organización de eventos en Málaga.
Responsabilidades | Organización de eventos, conectar a gente de otras partes del mundo para poder realizar labores de voluntariado.
Criterio de éxito | La realización de proyectos dentro y fuera de España, promover la participación de jóvenes en métodos basados en ApS.
Entregables | Documento con una descripción detallada de cómo será cada evento.

**Empresas**

| | |
|-|-|
Representante | El representante de la empresa en este ámbito.
Tipo | Empresas con proyectos similares a una ONG.
Responsabilidades | Aportar proyectos para que los alumnos puedan apuntarse a actividades de la plataforma.
Criterio de éxito | Un éxito podría considerarse que un proyecto de la empresa tuviese mucha acogida por parte de la comunidad educativa.
Entregables | Una lista con los principales proyectos.

**ONG´s externas**

| | |
|-|-|
Representante | Representante de la ONG en este ámbito.
Tipo | Organización No Gubernamental de iniciativa social con fines humanitarios, sin ánimo de lucro.
Responsabilidades | Organizar actividades sociales para el voluntariado.
Criterio de éxito | La mayor participación posible de los usuarios en las actividades que proponen.
Entregables | Una lista con los principales proyectos de la ONG.

**María Cabello**

| | |
|-|-|
Representante | María Cabello.
Tipo | Patrocinadora del proyecto.
Responsabilidades | Presentar el proyecto y sus características con la mayor eficacia posible para su elaboración.
Criterio de éxito | Realizar el proyecto con éxito.
Entregables | Una lista con los principales proyectos.
Comentarios | Vicedecana de estudiantes, movilidad y cooperación. Coordinadora de la optativa “Farmacoterapéutica en entornos desfavorecidos” de la Facultad de Medicina. 

**Facultad de Medicina**

| | |
|-|-|
Representante | Decano de la Facultad de Medicina.
Tipo | Facultad universitaria que propone estas actividades como formación para sus alumnos.
Responsabilidades | Realización de actividades como formación para su posterior evaluación en algunas de las asignaturas de Medicina, como por ejemplo, la optativa “Farmacoterapéutica en entornos desfavorecidos”.
Criterio de éxito | Tener una gran cantidad de alumnos realizando estas actividades del proyecto.
Entregables | Una lista con los principales proyectos.




