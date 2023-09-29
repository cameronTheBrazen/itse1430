namespace MovieLibrary
{/// <summary>
/// base class for validation
/// </summary>
    public class ValidatableObject
    {

        /// <summary>
        ///  determines validity
        /// </summary>
        public bool IsValid { get { return TryValidate(out var _); } }

        public virtual bool TryValidate ( out string message )
        {
            message= "";
            return true;

        }
        /// <summary>
        /// validates the movie isntance
        /// </summary>
        /// <returns>error message if invalid or empty string otherwise</returns>
        public string Validate ()
        {
            if (!TryValidate(out var message))
            {
                return message;
            }


            return "";
        }
    }
}