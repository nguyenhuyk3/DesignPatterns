using DesignPattern.Behavioral.ChainOfResponsibility.CAHandler;

namespace DesignPattern.Behavioral.ChainOfResponsibility.CConcreteHandler
{
    public class DogHandler : AbstractHandler
    { 
        public override object Handle(object request)
        {
            if (request.ToString() == "MeatBall")
            {
                return $"Dog: I'll eat the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
