﻿

using System.ComponentModel.DataAnnotations;

namespace MovieLibrary;

public class ObjectValidator
{
    public static bool TryValidate ( IValidatableObject value, out IEnumerable<ValidationResult> results )
    {
        var context = new ValidationContext(value);
        var items = new System.Collections.ObjectModel.Collection<ValidationResult>();

        if (Validator.TryValidateObject(value, context, items, true))
        {
            results = new ValidationResult[0];
            return true;
        }
        results = items;
        return false;

    }
    public static void Validate(IValidatableObject value )
    {
        var context = new ValidationContext(value);
        Validator.ValidateObject(value, context,true);
    }




}
