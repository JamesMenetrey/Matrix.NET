# Matrix.NET
A .NET implementation of matrices and their operations.

## Mathematical definition

> In mathematics, a matrix (plural matrices) is a rectangular array of numbers, symbols, or expressions, arranged in rows and columns.
> *from [Wikipedia](https://en.wikipedia.org/wiki/Matrix_(mathematics))*

Matrices are commonly written in box brackets or large parentheses:

![matrix definition image](https://upload.wikimedia.org/math/b/9/7/b9783fc03537756fb8e065c055f73d93.png "Matrix definition")

## Features

### Matrices creation

#### Static values
A matrix can be created using a multidimentional array of values.

```
var values = new[,]
{
    {1, 0, 0},
    {0, 1, 0},
    {0, 0, 1}
};

matrix = new Matrix<int>(values);
```

This creates an identity matric of size 3.



#### Builder method
A matrix can be created using a builder method, delegating the process of creating the set of values to another object.

```
Func<int, int, int> delegateBuilder = (i, j) => i == j ? 1 : 0;

matrix = new Matrix<int>(3, 3, delegateBuilder);
```

This creates an identity matric of size 3.


## Code convention
The project is written in respect of the rules normalized by Microsoft for C# programming and ReSharper convention. Please, be compliant to those rules when contributing.

## Testing
The project is written in respect of the principles of [Test Driven Development](https://en.wikipedia.org/wiki/Test-driven_development). Please, think to add unit tests for your code when contributing.

## Author
The code is written J�mes M�n�trey (aka ZenLulz) in the context of mathematics courses teached in the [University of Applied Sciences Western Switzerland](http://www.hes-so.ch/).