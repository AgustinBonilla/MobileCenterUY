# MobileCenterUY


|Platform|Status|
| ------------------- | :-----------: |
|Android|![](https://build.mobile.azure.com/v0.1/apps/dcf38054-7dd9-43a5-a2fd-5a53360e1f12/branches/feature%2FiOSUpload/badge)|
|iOS|![](https://build.mobile.azure.com/v0.1/apps/3ef7e7d3-f86c-4bd9-bd5a-dec16e2ce425/branches/feature%2FiOSUpload/badge)|

En este workshop haremos un repaso por el nuevo Visual Studio Mobile Center y luego llevaremos a cabo la configuración de un proceso DevOps Mobile totalmente automatizado para el ciclo de vida de nuestras aplicaciones de forma más rápida y simple. 

Utilizaremos un proyecto Xamarin Forms en GitHub para integrarlo a Mobile Center en donde configuraremos las etapas de Build, Test, Distribution, Analytics y Crashes. 
En la primera parte del workshop todos podrán distribuir de forma automatizada una aplicación simple e instalarla en sus dispositivos y luego en la segunda parte, en conjunto a una aplicación con mejoras, estaremos viendo más funcionalidades vinculadas a la plataforma. 

## Paso a paso

**1er Parte**

Hablamos sobre DevOps y Mobile Center

Fork y Clone de Proyecto Xamarin en GitHub

Login en MC y crear nueva App

Chequeamos Distribución

Hablamos sobre BUILD

Configuramos el Build (utilizando los certificados en el repo y configuracion Release)

Lanzar Build manualmente desde MC.
 
**2da Parte**

Instalaremos la aplicación y comentamos la app básica.

Cargamos keys de MC para analytics y Crashes, descomentamos la magia y push al repo

Hablamos sobre CRASHES & ANALYTICS

Hablamos sobre DISTRIBUTION

Sobre TEST y PUSH (no aplica al workshop)

Instalamos aplicación y comentamos la app magica.

Revisamos crashes y analytics en MC



## Aclaraciones para iOS

-  Los certificados de iOS se encuentran en el root del repo > Certificates > iOS

-  Dado que utilizamos un certificado In House de Apple, debemos confiar en dicho certificado: Configuration > General > Device Management > tecnoliv.sa > Trust "tecnoliv.sa"

-  Password del certificado: 123456



## Aclaraciones para Android

-  El certificado de Android se encuentran en el root del repo > Certificates > Android

-  Para permitir correr la app en Android activar Origenes desconocidos: Configuración > Seguridad > Orígenes desconocidos

-  Key Alias para keystore de Android: MobileCenterUY-adhoc

-  Password del keystore y key password: 123456


## Links

Mobile Center: https://mobile.azure.com

