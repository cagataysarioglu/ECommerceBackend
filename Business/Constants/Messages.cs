using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string Added = "Item is added successfully.";
        public static string Deleted = "Item that you selected is deleted.";
        public static string Updated = "Item that you selected is updated.";
        public static string Listed = "Items that you requested are listed..";
        public static string NameInvalid = "Item name is invalid.";
        public static string MaintenanceTime = "Service is unavailable.";
        public static string ProductCountOfCategoryError = "Out of category count limit.";
        public static string ProductNameAlreadyExists = "Product name already exists.";
        public static string CategoryCountBoundExceeded = "Category count bound exceeded.";
        public static string ProductAmountIsInsufficient = "Stock amount of product is insufficient.";
        public static string AuthorizationDenied = "Authorization denied.";
        public static string UserRegistered;
        public static string UserNotFound;
        public static string AccessTokenCreated;
        public static string UserAlreadyExists;
        public static string PasswordError;
        public static string SuccessfulLogin;
    }
}
