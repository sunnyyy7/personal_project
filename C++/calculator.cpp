#include <iostream>
#include <vector>
#include <stdexcept>

using namespace std;

// Function to perform addition
double add(double a, double b) {
    return a + b;
}

// Function to perform subtraction
double subtract(double a, double b) {
    return a - b;
}

// Function to perform multiplication
double multiply(double a, double b) {
    return a * b;
}

// Function to perform division
double divide(double a, double b) {
    if (b == 0) {
        throw invalid_argument("Division by zero");
    }
    return a / b;
}

int main() {
    char op;
    double operand1, operand2;
    
    cout << "Enter operator (+, -, *, /): ";
    cin >> op;
    
    cout << "Enter two operands: ";
    cin >> operand1 >> operand2;
    
    try {
        double result;
        switch(op) {
            case '+':
                result = add(operand1, operand2);
                break;
            case '-':
                result = subtract(operand1, operand2);
                break;
            case '*':
                result = multiply(operand1, operand2);
                break;
            case '/':
                result = divide(operand1, operand2);
                break;
            default:
                throw invalid_argument("Invalid operator");
        }
        cout << "Result: " << result << endl;
    } catch (const invalid_argument& e) {
        cerr << "Error: " << e.what() << endl;
    }
    
    return 0;
}