namespace GarageManagerAPI.Filters;

public class ExceptionGenericaFilter : ExceptionFilterAttribute
{

    public override void OnException(ExceptionContext context)
    {
        base.OnException(context);
    }
}
