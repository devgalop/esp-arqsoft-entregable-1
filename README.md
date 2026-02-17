# Exposición sobre principios de diseño de software

Los principios seleccionados para realizar la exposición son: **Dependency Inversion Principle (DIP)** + **Low Coupling (GRASP)**.

## Tabla de contenido

1. [Dominio](#dominio)
2. [Problema](#problema)
3. [Principios Aplicados](#principios-aplicados)
4. [Justificación](#justificación)
5. [Lecturas recomendadas](#lecturas-recomendadas)

## Dominio

El contexto de la exposición será un software encargado de realizar facturación electronica. Especificamente nos centraremos en el paso que realiza el aplicativo emitiendo el documento ante un organizmo gubernamental.

## Problema

Se presenta un código funcional para el proceso de emision de factura ante la DIAN, sin embargo, el código tiene dos problemas principales que chocan directamente con los principios seleccionados para estudio. [ver más](./Sample/bad_design/bad_design.md)

## Principios Aplicados

- **Dependency Inversion Principle (DIP)**

    El principio de diseño de inversión de dependencias es uno de los principios SOLID definidos por [Robert C. Martin](https://en.wikipedia.org/wiki/Robert_C._Martin). Este principio se enfoca en **reducir el alto acoplamiento entre módulos** mediante el uso de abstracciones (interfaces o clases abstractas).

    Este principio permite que el **código sea más flexible y fácil de mantener**, ya que los cambios en las **implementaciones no afectan la lógica de alto nivel**.

    Los puntos clave de este principio son:
  - Los **módulos de alto nivel no deben depender directamente de los módulos de bajo nivel**. Ambos deben depender de abstracciones.
  - Las **abstracciones no deben depender de los detalles**. En cambio, los detalles (implementaciones concretas) deben depender de las abstracciones.

- **Low Coupling (GRASP)**

    Este principio se enfoca en **minimizar las dependencias entre clases** dentro de un sistema orientado a objetos. En otras palabras, busca reducir la cantidad de conocimiento que una clase tiene sobre otras clases.

    Este principio busca **reducir la afectación sobre otras clases**, permitiendo así, un **código fácil de mantener y adaptar**.

    Los puntos clave de este principio son:
  - Una clase con bajo acoplamiento tiene menos dependencias hacia otras clases.
  - Cambios en una clase no deberían afectar directamente a otras clases.
  - El bajo acoplamiento facilita el mantenimiento y la adaptabilidad del código
  
## Justificación

## Lecturas recomendadas

- [Dependency Inversion Principle](https://www.geeksforgeeks.org/system-design/dependecy-inversion-principle-solid/)
- [Software Design Principles](https://www.scaler.com/topics/software-design-principles/)
- [Principles of Software Development: SOLID, DRY, KISS, and more](https://scalastic.io/en/solid-dry-kiss/#dependency-inversion-principle-dip)
- [Low Coupling in GRASP](https://patrickkarsh.medium.com/low-coupling-in-grasp-db972161b4ec)
- [GRASP Design Principles in OOAD](https://www.geeksforgeeks.org/system-design/grasp-design-principles-in-ooad/)
