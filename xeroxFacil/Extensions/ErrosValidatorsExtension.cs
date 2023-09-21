using FluentValidation;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using xeroxFacil.Models;

namespace xeroxFacil.Extensions
{
    public static class ErrosValidatorsExtension
    {
        public static string GetError<T>(this IValidator<T> validator, T model)
        {
            var errors = new List<string>();
            foreach (var error in validator.Validate(model).Errors)
            {
                return error.ErrorMessage;
            }
            return string.Empty;
        }
    }
}