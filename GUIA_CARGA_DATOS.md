# 📚 Guía de Carga de Datos - GestionBiblioteca

## ✅ Requisitos Importantes

### **DNI**
- **Formato**: Exactamente **8 dígitos** (número entero positivo)
- **Rango válido**: **10,000,000 a 99,999,999**
- **Ejemplos válidos**: `38456789`, `12345678`, `99999999`, `10000000`
- **Ejemplos inválidos**: 
  - `1234567` (7 dígitos)
  - `123456789` (9 dígitos) 
  - `-38456789` (negativo)
  - `0` (no es 8 dígitos)
- **Si recibís error**: Verifica que el número sea exactamente 8 dígitos entre 10,000,000 y 99,999,999

### **Nombre**
- **Longitud**: Entre 2 y 100 caracteres
- **Ejemplos**: `Juan Carlos García`, `María`, `Dr. Pedro Rodríguez López`

### **Materia (Profesores)**
- **Longitud**: Entre 2 y 100 caracteres
- **Ejemplos**: `Matemáticas`, `Historia`, `Programación II`

### **Carrera (Estudiantes)**
- **Longitud**: Entre 2 y 100 caracteres
- **Ejemplos**: `Ingeniería en Sistemas`, `Medicina`, `Administración`

### **Título del Libro**
- **Longitud**: Entre 2 y 200 caracteres
- **Ejemplos**: `El Quijote`, `Estructura de Datos`, `Harry Potter`

### **Autor**
- **Longitud**: Entre 2 y 100 caracteres
- **Ejemplos**: `Miguel de Cervantes`, `Donald Knuth`

### **Editorial**
- **Longitud**: Entre 2 y 100 caracteres
- **Ejemplos**: `Alfaguara`, `Pearson`, `McGraw-Hill`

### **Año de Publicación**
- **Formato**: Número entre 1000 y 9999
- **Ejemplos**: `1605`, `2023`, `1999`

### **Edición**
- **Formato**: Número positivo (1 a 999)
- **Ejemplos**: `1`, `3`, `5`

---

## 📝 Ejemplos de JSON para cada endpoint

### 1️⃣ Crear Profesor
**POST** `/api/library/create-professor`

```json
{
  "dni": 38456789,
  "name": "Juan Carlos García",
  "subject": "Matemáticas Avanzadas"
}
```

### 2️⃣ Crear Estudiante
**POST** `/api/library/create-student`

```json
{
  "dni": 45123789,
  "name": "María Rodríguez López",
  "degree": "Ingeniería en Sistemas"
}
```

### 3️⃣ Crear Libro
**POST** `/api/book/create`

```json
{
  "title": "El Quijote",
  "author": "Miguel de Cervantes",
  "editorial": "Alfaguara",
  "year": 1605,
  "edition": 3
}
```

### 4️⃣ Prestar Libro a Profesor
**POST** `/api/loan/lend-professor`

```json
{
  "dni": 38456789,
  "bookId": 1
}
```

### 5️⃣ Prestar Libro a Estudiante
**POST** `/api/loan/lend-student`

```json
{
  "dni": 45123789,
  "bookId": 1
}
```

### 6️⃣ Buscar Profesor
**GET** `/api/library/38456789/search-professor`
(No requiere body)

### 7️⃣ Buscar Estudiante
**GET** `/api/library/45123789/search-student`
(No requiere body)

### 8️⃣ Buscar Libro
**GET** `/api/book/1`
(No requiere body)

### 9️⃣ Devolver Libro
**PATCH** `/api/loan/20240706114530/devolver`
(No requiere body - usa el ID del préstamo)

---

## 🔍 Solución de Problemas

### Error: "El formato es incorrecto"
- **Causa**: DNI no tiene exactamente 8 dígitos
- **Solución**: Verifica que el DNI tenga 8 dígitos exactos

### Error: "El nombre no puede estar vacío"
- **Causa**: Nombre vacío o con solo espacios
- **Solución**: Ingresa un nombre entre 2 y 100 caracteres

### Error: "El nombre debe tener entre 2 y 100 caracteres"
- **Causa**: Nombre muy corto o muy largo
- **Solución**: Asegúrate de que tenga entre 2 y 100 caracteres

### Error 500 (Internal Server Error)
- **Causa**: Datos inválidos o falta de validación
- **Solución**: Verifica que todos los datos cumplan los requisitos arriba indicados

---

## 💾 Datos de Prueba Recomendados

### Profesor
```json
{
  "dni": 38456789,
  "name": "Dr. Juan García",
  "subject": "Algoritmos"
}
```

### Estudiante
```json
{
  "dni": 45123456,
  "name": "Laura Martínez",
  "degree": "Ingeniería en Sistemas"
}
```

### Libro
```json
{
  "title": "Algoritmos",
  "author": "Thomas Cormen",
  "editorial": "MIT Press",
  "year": 2009,
  "edition": 3
}
```

---

## ✨ Notas Importantes

1. Los datos se almacenan en **memoria** (no persisten al reiniciar)
2. El **DNI debe ser único** (no se pueden duplicar)
3. Los **IDs de libros** se asignan automáticamente (0, 1, 2, ...)
4. Los **IDs de préstamos** se generan automáticamente
5. Todos los campos son **obligatorios** (Required)

¡Listo! Ahora deberías poder cargar datos sin problemas.
