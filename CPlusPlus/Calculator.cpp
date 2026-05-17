#include <iostream>
#include "Calculator.hpp"

Calculator::Calculator(double a, double c, double d) : _a(a), _c(c), _d(d) {}

double Calculator::CalculateLogarithm(double value) {
    if (value <= 0) {
        throw std::invalid_argument("Value must be greater than zero for logarithm calculation.");
    }
    return log(value);
}

double Calculator::CalculateFullExpression() {
    double numerator = 2 * _c - _d / 23.0;
    double logArgument = 1 - _a / 4.0;
    double denominator = CalculateLogarithm(logArgument);
    return numerator / denominator;
}