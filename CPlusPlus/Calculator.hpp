using namespace std;
#include <tuple>
#include <cmath>
class Calculator {
    private:
        double _a, _c, _d;

    public:
        double getA() const{
            return _a;
        }
        double getC() const{
            return _c;
        }
        double getD() const{
            return _d;
        }

        public: Calculator(double a, double c, double d);

        public: double CalculateLogarithm(double value);

        public: double CalculateFullExpression();


};