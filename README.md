# Matrix.NET
A .NET implementation of matrices and their operations.

## Mathematical definition

> In mathematics, a matrix (plural matrices) is a rectangular array of numbers, symbols, or expressions.
> The numbers, symbols or expressions in the matrix are called its *entries* or its *elements*. The horizontal and vertical lines of entries in a matrix are called *rows* and *columns*, respectively.
>
> *From [Wikipedia](https://en.wikipedia.org/wiki/Matrix_(mathematics)).*

Matrices are commonly written in box brackets or large parentheses:

![matrix definition image](https://upload.wikimedia.org/math/b/9/7/b9783fc03537756fb8e065c055f73d93.png "Matrix definition")

## API usage

### Matrices creation

#### Using static elements
A matrix can be created using a multidimentional array of elements.

```c#
var elements = new[,]
{
    {1, 0, 0},
    {0, 1, 0},
    {0, 0, 1}
};

matrix = new Matrix<int>(elements);
```

This creates an identity matrix of size 3.



#### Using a builder method
A matrix can be created using a builder method, delegating the process of creating the set of elements to another object.

```c#
Func<int, int, int> delegateBuilder = (i, j) => i == j ? 1 : 0;

matrix = new Matrix<int>(3, 3, delegateBuilder);
```

This creates an identity matrix of size 3.

### Interacting with elements

#### Retrieving

The elements can be reteieved using the indexer of the matrix object.

```c#
var i = 0, j = 0;

var firstElement = matrix[i, j];
```

#### Number of columns/rows

```c#
var ith = matrix.NumberOfRows;
var jth = matrix.NumberOfColumns;
```

### Basic operations

#### Addition

```c#
var sum = matrix1 + matrix2;
```


## Code convention
The project is written in respect of the rules normalized by Microsoft for C# programming and ReSharper convention. Please, be compliant to those rules when contributing.

## Testing
The project is written in respect of the principles of [Test Driven Development](https://en.wikipedia.org/wiki/Test-driven_development). Please, think to add unit tests for your code when contributing.

## Author
The code is written Jämes Ménétrey (aka ZenLulz) in the context of mathematics courses teached in the [University of Applied Sciences Western Switzerland](http://www.hes-so.ch/).