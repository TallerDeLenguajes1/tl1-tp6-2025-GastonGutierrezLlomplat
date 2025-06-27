## Ejercicio 4

### ¿`string` es un tipo por valor o un tipo por referencia?

En C#, `string` es un **tipo por referencia**, ya que internamente es una clase (`System.String`). Sin embargo, se comporta de manera especial porque es **inmutable**: una vez creada, su contenido no se puede modificar. Si se realiza una "modificación", en realidad se crea una nueva instancia con el nuevo valor.

---

### ¿Qué secuencias de escape tiene el tipo `string`?

Las secuencias de escape permiten incluir caracteres especiales dentro de una cadena. Algunas de las más comunes son:

| Secuencia | Significado               |
| --------- | ------------------------- |
| `\n`      | Salto de línea            |
| `\r`      | Retorno de carro          |
| `\t`      | Tabulación                |
| `\\`      | Barra invertida (`\`)     |
| `\'`      | Comilla simple (`'`)      |
| `\"`      | Comilla doble (`"`)       |
| `\0`      | Carácter nulo (null char) |

Estas se usan dentro de strings delimitados con comillas dobles (`"`).

---

### ¿Qué sucede cuando se utiliza el carácter `@` y `$` antes de una cadena de texto?

En C#, se pueden usar los prefijos `@` y `$` para modificar el comportamiento de una cadena:

- **`@` (Verbatim string):**
  Permite escribir una cadena tal como está, sin procesar secuencias de escape. Es útil para rutas de archivos o textos multilínea.

- **`$` (Interpolated string):**
  Permite insertar expresiones o variables directamente dentro de la cadena usando llaves `{}`.
