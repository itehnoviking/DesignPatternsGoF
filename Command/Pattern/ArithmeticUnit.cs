namespace Command.Pattern
{
    // "Receiver" (Получатель) - Арифметическое устройство (АУ)
    class ArithmeticUnit
    {
        public int Register { get; private set; }

        public void Run(char operationCode, int operand)
        {
            switch (operationCode)
            {
                case '+':
                    Register += operand;
                    break;
                case '-':
                    Register -= operand;
                    break;
                case '*':
                    Register *= operand;
                    break;
                case '/':
                    Register /= operand;
                    break;
            }
        }
    }
}
