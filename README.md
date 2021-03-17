<h1>Plataforma de Compromiso Social y Aprendizaje Servicio</h1>
<h4>
Proyecto realizado por:

Javier Blanco Navarro

Adrián Corrales Moreno

María Gálvez Manceras

David Gerena Comino

Yeray Ruiz Suárez

</h4>

- - -

<h3>Índice<h4/>

- [1. Introducción](#1-introducción)
  - [1.1 Objetivos](#11-objetivos)
  - [1.2 Alcance](#12-alcance)
  - [1.3 Definiciones, acrónimos y abreviaturas](#13-definiciones-acrónimos-y-abreviaturas)
  - [1.4 Referencias](#14-referencias)
  - [1.5 Resumen](#15-resumen)
- [2 Directivas del proyecto](#2-directivas-del-proyecto)
  - [2.1 Descripción del problema](#21-descripción-del-problema)
  - [2.2 Descripción del producto](#22-descripción-del-producto)
- [3 Descripción de participantes y usuarios](#3-descripción-de-participantes-y-usuarios)
  - [3.1 Resumen de los participantes](#31-resumen-de-los-participantes)
  - [3.2 Resumen y entorno de los usuarios](#32-resumen-y-entorno-de-los-usuarios)
  - [3.3 Perfiles de los participantes](#33-perfiles-de-los-participantes)
  - [3.4 Perfiles de usuarios](#34-perfiles-de-usuarios)
  - [3.5 Alternativas y competencia](#35-alternativas-y-competencia)
- [4 Visión general del producto](#4-visión-general-del-producto)
  - [4.1 Entorno de despliegue](#41-entorno-de-despliegue)
  - [4.2 Resumen de características](#42-resumen-de-características)
  - [4.3 Suposiciones y dependencias](#43-suposiciones-y-dependencias)
  - [4.4 Precio y coste](#44-precio-y-coste)
  - [4.5 Licencias e instalación](#45-licencias-e-instalación)
- [5 Requisitos funcionales](#5-requisitos-funcionales)
- [6 Precedencia y prioridad](#6-precedencia-y-prioridad)
- [7 Requisitos no funcionales](#7-requisitos-no-funcionales)

## 1. Introducción

### 1.1 Objetivos

El objetivo de este documento es recoger, analizar y definir las características y necesidades de alto nivel del sistema PCSAS: Plataforma de Compromiso Social y Aprendizaje Servicio. Se centrará en describir las expectativas de cada una de las partes del proyecto y de los usuarios finales y por qué estas necesidades existen. Los detalles de cómo PCSAS: Plataforma de Compromiso Social y Aprendizaje Servicio cumple estas necesidades se detallan en los casos de uso y en las especificaciones adicionales.

### 1.2 Alcance

El documento está relacionado tanto con el ámbito de la medicina como con el ámbito de la ingeniería pues afecta principalmente a cómo los estudiantes de entornos más desfavorecidos necesitan comunicarse con otras personas que están lejos de cara a poder complementar la formación de los estudiantes mediante el aprendizaje basado en servicios, para poder facilitar esta comunicación es necesario el desarrollo de un proyecto software. 

Hay que destacar que está enmarcado en el contexto de la asignatura de “Ingeniería de Requisitos” del grado de Ingeniería de Software de la UMA. Concretamente es el resultado de una colaboración con los estudiantes de la facultad de Medicina, ayudando así a su asignatura optativa “Farmacoterapéutica en entornos desfavorecidos”, impartida por la profesora María Cabello quien nos ha propuesto la idea de proyecto.

### 1.3 Definiciones, acrónimos y abreviaturas

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

### 1.4 Referencias

En este documento se hará referencia al BOE ya que en el BOE se regula cómo debe ser el aprendizaje basado en servicios y que debe cumplir.

Referencia al [BOE-A-2017-10811](https://www.boe.es/diario_boe/txt.php?id=BOE-A-2017-10811) donde se regula el ApS.

[1] [Blog de Roser Batlle](https://roserbatlle.net/)

[2] [National Youth Leadership Council – NYLC](https://www.nylc.org/)

[3] [Centro Latinoamericano de Aprendizaje Servicio Solidario](http://www.clayss.org.ar/)

[4] [Google Classroom](https://classroom.google.com/)

[5] [Ley General de Protección de Datos](https://www.boe.es/eli/es/lo/2018/12/05/3)

### 1.5 Resumen


Este documento se encuentra estructurado según como se explica en el índice. El punto 2 define el problema que se presenta, así como la solución que planteamos. En el apartado 3 se describen los participantes y los usuarios propios del proyecto. La sección 4 cubre el funcionamiento y las características de la aplicación. El apartado 5 describe todos los requisitos funcionales del proyecto. El punto 6 trata acerca de la preferencia y la prioridad que se establecerá en el proyecto. Por último, en la sección 7 se cubre todo lo relacionado con los requisitos no funcionales.

## 2 Directivas del proyecto

### 2.1 Descripción del problema

El problema de no poder comunicarse presencialmente ya sea debido a la distancia o a otros problemas de salud, afecta a aquellos que recibían ayudas sociales mediante actividades, tanto en educación como en apoyo moral. El impacto de ese problema se ve reflejado directamente en que estas labores de aprendizajes-servicios a la comunidad no se pueden realizar. 

Una solución satisfactoria sería crear un sistema de aprendizaje-servicio que proporcione contenidos formativos, informativos, de difusión y sensibilización a sus usuarios, disponible para cualquier dispositivo con conexión a internet.

Así, se lograría unir a los centros educativos más desfavorecidos y apoyar a los alumnos con un sistema que  sea interactivo y pedagógico que permita compartir contenidos en directo y/o diferido además de contener numerosos recursos lúdicos para mejorar el aprendizaje de los alumnos de estos centros.

Cabe destacar que a la vez que los alumnos de los centros aprenden, los alumnos de la UMA implicados en este proyecto se forman y adquieren competencias que con otro tipo de formación no podrían adquirir.

### 2.2 Descripción del producto


Para la comunidad educativa, empresas y ONG, quienes tienen una necesidad de formarse en aspectos sociales, el sistema es un software que ofrece una solución al problema planteado. El objetivo principal de la aplicación es crear un entorno de unión entre los alumnos más desfavorecidos y profesores implicados de todo el mundo, ofrecer actividades formativas para estos estudiantes a la vez que los estudiantes de la UMA se forman mediante la adquisición de competencias transversales y experiencia laboral.  Por tanto, incluiremos el sistema en un mercado en el que no hay otro competidor actualmente por lo que nuestro producto cubrirá unas necesidades que a día de hoy nadie las satisface.

## 3 Descripción de participantes y usuarios

### 3.1 Resumen de los participantes

Nombre | Rol
------------ | -------------
ONG’s externas | Usarán el sistema para anunciar sus proyectos, teniendo así un altavoz para llegar a la comunidad educativa con mayor facilidad.
UMA  | Usará el sistema para anunciar sus proyectos, de forma similar a como lo harán las ONG’s externas.
Empresas | Las empresas podrán prestarse también a promocionar distintos proyectos, siempre que sean con finalidades similares a las de las ONG’s.
María Cabello | Coordinadora de la asignatura que usará el sistema y encargada de aportar la idea e interés en el proyecto.
Facultad de Medicina | Facultad que usará nuestro sistema para una asignatura optativa.

### 3.2 Resumen y entorno de los usuarios

Nombre | Descripción | Participante
------------ | ------------- | -------------
Profesores | Tendrán la oportunidad de usar estas herramientas en clase para mejorar su rendimiento. | Están relacionados con las ONG’s que financian el proyecto.
ONG | Propondrán diversas actividades para que los usuarios participen. | Están relacionados con las ONG’s que financian el proyecto, ellas mismas.
Alumnos | Son los beneficiarios del sistema y que utilizan la plataforma para aprender. | Realizan las actividades que promueven las ONG’s.
Administradores | Gestionan el sistema y se aseguran de que todos los recursos y funcionalidades funcionan correctamente. | Serán contratados por las entidades que financien el proyecto.
Invitado | Podrán consultar las actividades propuestas en el calendario y ver contenidos del sistema. | Ven una parte de los contenidos que promueven las ONG’s.

### 3.3 Perfiles de los participantes

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

### 3.4 Perfiles de usuarios

**Alumnos**

| | |
|-|-|
Representante | Representante de estudiantes.
Descripción | Los alumnos usarán el sistema para cumplimentar la formación mediante el servicio a la comunidad.
Tipo | Cualquier tipo de alumno desde alumnos de primaria hasta alumnos de las distintas facultades de la UMA.
Responsabilidades | Ser responsable de las tareas asignadas, ya que pueden necesitar ser realizadas con cuidado.
Criterio de éxito | Que los alumnos aprendan mediante los servicios y que puedan desempeñar con éxito la tarea asignada.

**Profesores**

| | |
|-|-|
Representante | Representante de los profesores.
Tipo | Son los alumnos de la asignatura anteriormente mencionada aunque el uso del sistema se podría ampliar a profesionales titulados en educación y que tengan un conocimiento mínimo de tecnología.
Responsabilidades | Deberán impartir a los alumnos los contenidos de los cursos.
Criterio de éxito | Su objetivo es enseñar lo mejor posible a sus alumnos.
Entregables | Las valoraciones y el conocimiento de los alumnos.

**ONG**

| | |
|-|-|
Representante | Representante de las ONG.
Tipo | Son colaboradores o voluntarios de las distintas ONG con conocimiento específico sobre el campo donde se desarrollan las actividades.
Responsabilidades | Propondrán las distintas actividades y se harán cargo de la organización y planificación de las mismas.
Criterio de éxito | Que las actividades sociales y benéficas tengan una gran aceptación y se lleven a cabo con éxito.
Entregables | Las valoraciones de los asistentes a la actividad social cuestión.

**Administradores**

| | |
|-|-|
Representante | Project Leader.
Tipo | Deben ser profesionales titulados capaces de gestionar el proyecto y su mantenimiento.
Responsabilidades | Tienen que escribir un código limpio y optimizado para evitar ineficiencias y estar realmente implicados con el proyecto.
Criterio de éxito | Su objetivo es crear el sistema y mantenerlo con todas las funcionalidades prometidas en un inicio.
Entregables | El proyecto y diferentes informes y documentación.

**Invitados**

| | |
|-|-|
Representante | Cada uno de los invitados.
Tipo | Usuarios no registrados en el sistema.
Responsabilidades | Responsabilidad de no difundir los contenidos a los que pueden acceder en el sistema.
Criterio de éxito | Al invitado le llama la atención el sistema y se registra como usuario.
Entregables | No tienen.

### 3.5 Alternativas y competencia

Se pueden considerar como alternativas, pero no presentan un sistema para realizar actividades programadas, simplemente son blogs/webs que disponen de información para la información y formación de usuarios en el ApS.

**[1] Blog de Roser Batlle:** Página con gran cantidad de recursos sobre aprendizaje servicios, en la que se encuentran infinidad de recursos e informaciones sobre esta metodología. Destacan los materiales y las guías que ayudarán al profesorado que se quiera iniciar en esta metodología y también al que desee adquirir mayor destreza. También contiene información sobre las modalidades de cursos de formación o asesoramientos que su responsable ofrece a centros, entidades y profesorado.

**[2] National Youth Leadership Council – NYLC:**  Es una página con una fuente inagotable de información y de ideas para seguir avanzando en la aplicación del aprendizaje servicio en nuestros centros educativos, entidades sociales y municipios. También se puede encontrar información sobre un importante encuentro anual de participantes en actividades de aprendizaje servicio, el Annual National Service-Learning Conference.

**[3] Centro Latinoamericano de Aprendizaje Servicio Solidario:** Una página de referencia del ApS, en especial para América Latina y cada vez con mayor presencia en África y Europa. Ofrece información relevante sobre los programas de difusión del aprendizaje servicio en los que está colaborando. También ofrece programas de formación adecuados a distintas necesidades y, por último, es muy relevante la documentación en abierto que pone a disposición y que se convierte en una biblioteca básica sobre aprendizaje servicio.

La principal diferencia que tenemos con el CLAYSS es que operamos además de en América Latina, en España. Además la página web visualmente no es muy atractiva, en cambio dentro del proyecto haremos que esto sea una prioridad.

**[4] Google Classroom:** una plataforma principalmente orientada a la enseñanza en entornos académicos, si bien incorpora diversas funcionalidades como pueden ser videollamadas grupales, foros donde todos los participantes pueden colgar sus dudas y comentar entradas del resto de usuarios… Esta plataforma no termina de cumplir con las necesidades planteadas por el cliente ya que no existe un papel diferenciado entre usuarios invitados, alumnos, profesores y otros participantes.


## 4 Visión general del producto

### 4.1 Entorno de despliegue

La aplicación está pensada como una aplicación de escritorio para ser desarrollada en lenguaje C# usando el framework de .NET y usando una base de datos relacional de MySQL  alojada en la plataforma de AWS si bien actualmente (marzo 2021) ya no está disponible la información alojada en dicha base de datos.

### 4.2 Resumen de características

Beneficios para el cliente | Características de soporte
------------ | -------------
Mayor facilidad para formarse en el llamado aprendizaje - servicio. | Implementar recursos interactivos para educar e instruir a todo aquel que quiera en este ámbito.
Posibilidad de formarse a distancia.  | Implementar un sistema de vídeo para poder seguir los cursos.
Comunicación directa entre personas del sistema. | Implementar un servicio de mensajería interna dentro del propio sistema, así como un chat.
Acceso directo a las actividades del sistema. | Implementar una barra de búsqueda en la que se acceda a la base de datos donde se encuentre almacenada la información relativas a las actividades.

### 4.3 Suposiciones y dependencias

Las principales dependencias a las que se somete este proyecto son:

- **Dependencia total del sistema informático:** Cualquier fallo en la aplicación o en el servicio de internet perjudica bastante a nuestro sistema.
- **Dependencia de la proposición activa de proyectos y actividades:** Es necesario que haya un equipo de profesores y entidades que organicen eventos regularmente para que el sistema tenga vida.
- **Suposición de conocimiento del usuario:** Suponemos que los usuarios que utilicen el sistema tienen unas nociones básicas para utilizar el mismo.

### 4.4 Precio y coste

En principio la aplicación está pensada para que sea gratuita, ya que la idea es que sea una aplicación a la que todo el mundo pueda tener acceso. No tendremos en cuenta ningún tipo de coste físico, ya que se trata de una aplicación software. Sin embargo, puede que necesitemos adquirir alguna licencia de algún programa en específico o conseguir alguna certificación especial para asegurarnos de la calidad del producto.

Los costes dependen del tipo de programadores y líderes de proyecto que se contraten, cuanta más experiencia y más rápido y con menos fallos se hará. Si se opta por programadores noveles puede ser más barato pero se prolongará más el desarrollo. En principio estimamos que el coste por hora de trabajo es de 10€.
Si trabajamos un equipo de 5 desarrolladores un total de 8 horas diarias durante 25 días (más o menos fue el tiempo real de implementación) estimamos unos costes de 2.000€ en mano de obra, si aparte necesitásemos adquirir software o alquilar de servidores, esto sería un coste extra.


### 4.5 Licencias e instalación

Usaremos entornos de trabajo que en principio son gratuitos como MySQL (para la base de datos) y Visual Studio 2019, si bien para plantear el diagrama de clases del proyecto y el modelo del sistema, usaremos MagicDraw donde será necesaria una licencia. Para cuestiones organizativas usaremos Trello, un bloc de notas digital donde iremos marcando los objetivos y cómo el proyecto va avanzando de forma que el cliente también puede ver el progreso que sigue el proyecto.

## 5 Requisitos funcionales

## 6 Precedencia y prioridad

## 7 Requisitos no funcionales

