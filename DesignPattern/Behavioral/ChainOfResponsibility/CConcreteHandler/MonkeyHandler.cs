using DesignPattern.Behavioral.ChainOfResponsibility.CAHandler;

namespace DesignPattern.Behavioral.ChainOfResponsibility.CConcreteHandler
{
    public class MonkeyHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Banana")
            {
                return $"Monkey: I'll eat the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
