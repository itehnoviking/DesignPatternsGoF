namespace Builder
{
    public class Director
    {
        Abstractions.Builder builder;

        public Director(Abstractions.Builder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
        }

    }
}