using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace xeroxFacil.Extensions
{
    public static class ModelStateExtension
    {
        public static List<string> GetErrors(this ModelStateDictionary modelState)
        {
            return modelState.SelectMany(x => x.Value.Errors)
                .Select(x => x.ErrorMessage)
                .ToList();
        }
    }
}