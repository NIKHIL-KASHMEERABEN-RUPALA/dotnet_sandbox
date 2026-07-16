namespace GrievanceManagementSystem.Constants
{
    /// <summary>
    /// Contains application-wide constant values.
    /// Avoid hardcoding strings throughout the application.
    /// </summary>
    public static class AppConstants
    {
        // TempData Keys
        public const string SuccessMessage = "Success";
        public const string ErrorMessage = "Error";
        public const string WarningMessage = "Warning";
        public const string InfoMessage = "Info";

        // Common Status Values
        public const string Active = "Active";
        public const string Inactive = "Inactive";

        // Common Messages
        public const string RecordAdded = "Record added successfully.";
        public const string RecordUpdated = "Record updated successfully.";
        public const string RecordDeleted = "Record deleted successfully.";
        public const string RecordNotFound = "Record not found.";
    }
}