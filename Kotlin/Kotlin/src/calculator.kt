import java.util.Scanner

// Demonstrating variables (mutable and immutable), expressions, conditionals, loops, functions, and classes

// Calculator class to perform arithmetic operations
class Calculator {
    // Function to add two numbers
    fun add(num1: Double, num2: Double): Double {
        return num1 + num2
    }

    // Function to subtract two numbers
    fun subtract(num1: Double, num2: Double): Double {
        return num1 - num2
    }

    // Function to multiply two numbers
    fun multiply(num1: Double, num2: Double): Double {
        return num1 * num2
    }

    // Function to divide two numbers
    fun divide(num1: Double, num2: Double): Double {
        if (num2 == 0.0) {
            throw IllegalArgumentException("Cannot divide by zero")
        }
        return num1 / num2
    }
}

fun main() {
    val scanner = Scanner(System.`in`)
    val calculator = Calculator()

    println("Welcome to Basic Calculator")

    // Loop to allow user to perform multiple calculations
    while (true) {
        println("Choose an operation:")
        println("1. Addition (+)")
        println("2. Subtraction (-)")
        println("3. Multiplication (*)")
        println("4. Division (/)")
        println("5. Exit")

        print("Enter your choice: ")
        val choice = scanner.nextInt()

        if (choice == 5) {
            println("Exiting calculator. Goodbye!")
            break
        }

        print("Enter the first number: ")
        val num1 = scanner.nextDouble()

        print("Enter the second number: ")
        val num2 = scanner.nextDouble()

        // Perform the selected operation based on user input
        val result = when (choice) {
            1 -> calculator.add(num1, num2)
            2 -> calculator.subtract(num1, num2)
            3 -> calculator.multiply(num1, num2)
            4 -> calculator.divide(num1, num2)
            else -> throw IllegalArgumentException("Invalid choice")
        }

        println("Result: $result")
    }
}