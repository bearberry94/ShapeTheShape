Tasks to do:
1. Create a class called Point with the following:
	1.1 Fields- int x, y
	1.2 Constructors to create objects with:
		1.2.1 With coordinates (0, 0)
		1.2.2 With specified coordinates
	1.3 Methods allowing to:
		1.3.1 display the coordinates on-screen
		1.3.2 Calculate the distance from the origin to the point
		1.3.3 Translate the point by a vector (a, b)
	1.4 Properties that can:
		1.4.1 get-set the point's coordinates (read and write)
		1.4.2 multiply the point's coordinates by a scalar value (only write)
	1.5 Indexer that allows you to access the x-value using [0] and the y-value using [1].
		Note: It should display an error message if the index is anything other than 0 or 1.
	1.6 Overloading
		1.6.1 ++ and -- operations increase or decrease both the x and y values by 1
		1.6.2 true/false constants when addressing the class object return true if x == y
			  and false otherwise
		1.6.3 binary + adds a scalar value to both x and y values

2. Create a class called Triangle with the following:
	2.1 Fields int a, b, c
	2.2 A constructor that creates a Triangle object with specified sides
	2.3 Methods allowing to:
		2.3.1 display the triangle's sides on-screen
		2.3.2 calculate the triangle's perimeter
		2.3.2 calculate the triangle's area
	2.4 Properties that can:
		2.4.1 get-set the triangle's sides (read and write)
		2.4.2 establish whether or not there exists a triangle with such sides (read only)
	2.5 Indexer that allows to access the a-value with [0], b-value with [1], and c-value with [2].
		Note:Note: It should display an error message if the index is anything other than 0 or 1 or 2.
	2.6 Overloading
		2.6.1 ++ and -- operations increase or decrease a, b and c values by 1
		2.6.2 true/false constants when addressing the class object return true if a triangle with such sides exists,
			  otherwise return false
		2.6.3 binary * multiplies a, b and c by a scalar value


3. Create a class called Rectangle with the following:
	3.1 Fields - int a, b
	3.2 Constructor that creates a Rectangle with the specified sides
	3.3 Methods allowing:
		3.3.1 Display the rectangle's sides on-screen
		3.3.2 Calculate the perimeter
		3.3.3 Calculate the area
	3.4 Properties that can:
		3.4.1 get-set the rectangle's sides (read and write)
		3.4.2 establish whether the given rectangle is a square (read only)
	3.5 Indexer that allows you to access the a-value using [0] and the b-value using [1].
		Note: It should display an error message if the index is anything other than 0 or 1.
	3.6 Overloading:
		3.6.1 ++ and -- operations increase or decrease both the a and by values by 1
		3.6.2 true/false constants when addressing the object return true if the rectangle with
			  the given sides is a square. Otherwise, return false.
		3.6.3 * operator multiplies both a and b by a scalar.

Demonstrate the work of each class.