namespace Command.Pattern.Commands
{
    class Sub : Pattern.Commands.Command
    {
        public Sub(ArithmeticUnit unit, int operand)
        {
            this.unit = unit;
            this.operand = operand;
        }

        public override void Execute()
        {
            unit.Run('-', operand);
        }

        public override void UnExecute()
        {
            unit.Run('+', operand);
        }
    }
}
