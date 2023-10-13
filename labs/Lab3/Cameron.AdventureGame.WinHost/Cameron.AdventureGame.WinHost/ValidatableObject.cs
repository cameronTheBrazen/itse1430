///Cameron Kingsley
///10/13/2023
///ITSE 1430
namespace Cameron.AdventureGame
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
        /// validates the Character isntance
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