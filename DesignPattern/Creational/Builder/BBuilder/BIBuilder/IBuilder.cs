namespace DesignPattern.Creational.Builder.BBuilder.BIBuilder
{
    // The Builder interface specifies methods
    // for creating the different parts
    // of the Product objects.
    public interface IBuilder
    {
        void BuildPartA();

        void BuildPartB();

        void BuildPartC();
    }
}
