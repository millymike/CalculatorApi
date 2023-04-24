Feature: SimpleCalculator
In order to perform basic arithmetic operations
As a developer
I want to use the concrete SimpleCalculator class

    Scenario Outline: Add two numbers
        When I call Add with arguments <a> and <b>
        Then the returned value should be <c>

        Examples:
          | a     | b     | c     |
          | 2     | 3     | 5     |
          | 0     | 0     | 0     |
          | 0.5   | 0.5   | 1     |
          | -1    | 1     | 0     |
          | -2    | -3    | -5    |
          | 10000 | 20000 | 30000 |

    Scenario Outline: Subtract two numbers
        When I call Subtract with arguments <a> and <b>
        Then the returned value should be <c>

        Examples:
          | a     | b     | c     |
          | 2     | 3     | -1    |
          | 0     | 0     | 0     |
          | 0.5   | 0.5   | 0     |
          | -1    | 1     | -2    |
          | -2    | -3    | 1     |
          | 20000 | 10000 | 10000 |

    Scenario Outline: Multiply two numbers
        When I call Multiply with arguments <a> and <b>
        Then the returned value should be <c>

        Examples:
          | a     | b   | c    |
          | 2     | 3   | 6    |
          | 0     | 0   | 0    |
          | 0.5   | 0.5 | 0.25 |
          | -1    | 1   | -1   |
          | -2    | -3  | 6    |
          | 10000 | 0   | 0    |

    Scenario Outline: Divide two numbers
        When I call Divide with arguments <a> and <b>
        Then the returned value should be <c>

        Examples:
          | a     | b   | c    |
          | 6     | 3   | 2    |
          | 0     | 1   | 0    |
          | 0.5   | 0.5 | 1    |
          | -1    | 1   | -1   |
          | -6    | -3  | 2    |
          | 10000 | 2   | 5000 |

    Scenario Outline: Divide by zero
        When I call Divide with arguments <a> and 0
        Then a DivideByZeroException should be thrown

        Examples:
          | a     |
          | 2     |
          | 0     |
          | 0.5   |
          | -1    |
          | -6    |
          | 10000 |
