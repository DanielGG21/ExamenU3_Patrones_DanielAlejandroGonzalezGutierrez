# 🏠 Sistema de Casa Inteligente – Patrones Decorator y Composite

**Autor:** Daniel Alejandro González Gutiérrez  
**Proyecto:** Control y Decoración de Dispositivos del Hogar  
**Materia:** Patrones de Diseño – Examen Unidad 3  

---

## 🧠 Descripción Breve del Funcionamiento

Este proyecto implementa **dos patrones de diseño estructurales**:

- **Decorator**: Permite agregar funcionalidades extra a los dispositivos (como *Ahorro de Energía* y *Modo Nocturno*) sin modificar sus clases originales.  
- **Composite**: Permite agrupar dispositivos en estructuras jerárquicas (Sala, Cocina, Cuarto, Casa) y controlarlos de forma uniforme mediante una sola interfaz.

El usuario puede:
1. **Decorar dispositivos** con dos decoradores distintos.  
2. **Organizarlos en grupos** mediante Composite.  
3. **Encender y apagar** dispositivos individuales o grupos completos.  
4. **Ver el estado** de cada dispositivo y sus decoradores aplicados.  

El objetivo es simular una **casa inteligente**, donde los dispositivos pueden ser decorados y controlados por zonas de forma dinámica y flexible.

---

## ⚙️ Tecnologías Utilizadas
- Lenguaje: **C# (.NET)**
- Programación orientada a objetos
- Consola interactiva

---

## 🧩 Patrones Aplicados

### 🎨 Decorator  
Usado para añadir funcionalidades extra a dispositivos sin modificar su implementación original.

Clases principales:
- `IDispositivo`  
- `DispositivoSimple`  
- `DispositivoDecorador`  
- `DecoradorAhorroEnergia`  
- `DecoradorModoNocturno`

### 🌳 Composite  
Permite agrupar dispositivos y tratar grupos como si fueran un único objeto.

Clases principales:
- `GrupoDispositivos`  
- `ConstructorCasa`  
- `ControladorGrupos`

---

## ▶️ Cómo ejecutar el programa

### 🖥️ Requisitos previos
- **.NET SDK 8.0** o superior  
  👉 Descargar: https://dotnet.microsoft.com/download  
- Entorno recomendado:
  - **Visual Studio 2022**
  - **Visual Studio Code** con extensión C#

---

### 🚀 Ejecución desde Visual Studio
1. Abrir la solución:  
   `ExamenU3_Patrones_DanielAlejandroGonzalezGutierrez.sln`
2. Ejecutar con **Ctrl + F5**.
3. El menú mostrará:
   - Lista de dispositivos disponibles  
   - Opciones para decorar  
   - Control de grupos  
   - Visualización de estado  

---

### ⚙️ Ejecución desde consola (.NET CLI)
En la carpeta raíz del proyecto:

```bash
dotnet build
dotnet run
```

---

## 💡 Ejemplo de Ejecución

```
==== Dispositivos disponibles para decorar ====

1. Televisor
2. Bocinas
3. Foco sala
...
8. Terminar decoración

Seleccione un dispositivo:
Seleccione decorador para Televisor
1. Ahorro de energía
2. Modo nocturno
3. Terminar decoración

Encendiendo....
- Televisor : Encendido (Ahorro de energía, Modo nocturno)
- Bocinas : Encendido
...
```

---

© 2025 Daniel Alejandro González Gutiérrez – Instituto Tecnológico de Tijuana
