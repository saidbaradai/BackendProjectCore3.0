using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded   = "Product has been ADDED successfuly";
        public static string ProductUpdated = "Product has been UPDATED successfuly";
        public static string ProductDeleted = "Product has been DELETED successfuly";

        public static string UserNotFound   = "User not found";

        public static string PasswordIncorrect = "Password is incorrect";
        public static string SuccessfulLogin = "Successful login";
        public static string UserAlreadyExists = "User already exists";
        public static string UserAddSuccessfuly = "User add successfuly";
        public static string AccessTokenCreated = "Access token created";
    }
}

