using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;

/// <summary>
/// Summary description for clsDamanTestSecurity
/// </summary>
public class clsDamanTestSecurity
{
    public clsDamanTestSecurity()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    //create SignUp here

    //Create GetHashString here
    public string SignUp(string Email, string Password, string PasswordConfirm)
    //public method allowing the user to sign up for an account
    {
        //var to store any errors
        string ErrorMsg = "";
        //if the two passwords match
        if (Password == PasswordConfirm)
        {
            //get the hash of the plain text password
            string HashPassword = GetHashString(Password + Email);
            //add the record to the database
            clsDataConnection DB = new clsDataConnection("select * from Users");
            DB.NewRecord["Email"] = Email;
            DB.NewRecord["UserPassword"] = HashPassword;
            DB.AddNewRecord();
            DB.SaveChanges();
        }
        //if the passwords do not match
        else
        {
            //generate an error message
            ErrorMsg = "The passwords do not match.";
        }
        //return the error message (if there is one)
        return ErrorMsg;
    }
    private string GetHashString(string SomeText)
    {
        if (SomeText != "")//if there is text to process
        {
            //create an instance of the hash generator
            SHA256Managed HashGenerator = new SHA256Managed();
            //var to store the final hash
            string HashString;
            //array to store the bytes of the orignal text
            byte[] TextBytes;
            //array to store the byptes of the new hash
            byte[] HashBytes;
            //convert the text in the string to an array of bytes
            TextBytes = System.Text.Encoding.UTF8.GetBytes(SomeText);
            //generate the has based on the array of bytes
            HashBytes = HashGenerator.ComputeHash(TextBytes);
            //generate the hash string replacing blank characters with -
            HashString = BitConverter.ToString(HashBytes).Replace("-", " ");
            return HashString;

        }
        else      //if there is nothing to process
        {
            //return a blank string
            return "";
        }
    }
    public Boolean Login(string EMail, string Password)
    {
        //convert the plain text password to a hash code
        Password = GetHashString(Password + EMail);
        //find the record mataching the users email address and password
        clsDataConnectionOLDB UserAccount = new clsDataConnectionOLDB();
        //add the parmeters
        UserAccount.AddParameter("@EMail", EMail);
        UserAccount.AddParameter("@UserPassword", Password);
        //execute the query
        UserAccount.Execute("qry_Users_FilterByEmailAndPassword");
        //if there is only one record found then return true
        if (UserAccount.Count >= 1)
        {
            return true;
        }
        else //otherwise reutn false
        {
            return false;
        }
    }
}

