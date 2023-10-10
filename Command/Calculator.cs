﻿using Command.Pattern;
using Command.Pattern.Commands;

namespace Command;

// "Client"
public class Calculator
{
    ArithmeticUnit arithmeticUnit;
    ControlUnit controlUnit;

    public Calculator()
    {
        arithmeticUnit = new ArithmeticUnit();
        controlUnit = new ControlUnit();
    }

    private int Run(Pattern.Commands.Command command)
    {
        controlUnit.StoreCommand(command);
        controlUnit.ExecuteCommand();
        return arithmeticUnit.Register;
    }

    public int Add(int operand)
    {
        return Run(new Add(arithmeticUnit, operand));
    }

    public int Sub(int operand)
    {
        return Run(new Sub(arithmeticUnit, operand));
    }

    public int Mul(int operand)
    {
        return Run(new Mul(arithmeticUnit, operand));
    }

    public int Div(int operand)
    {
        return Run(new Div(arithmeticUnit, operand));
    }

    public int Undo(int levels)
    {
        controlUnit.Undo(levels);
        return arithmeticUnit.Register;
    }

    public int Redo(int levels)
    {
        controlUnit.Redo(levels);
        return arithmeticUnit.Register;
    }
}