using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp35
{
    class User
    {
        public string _userName;
        public string _password;

        public string Username 
        {
            get 
            {
                return _userName;

                
                
            }
            set 
            {
                if (value.Length >= 8)
                {
                    _userName = Username;
                }
                else
                {
                    Console.WriteLine("Duzgun daxil et");
                }
            
            
            
            }
            
        
        
        }
        public string Password 
        {
            get 
            {
                return _password;
            
            }
            set 
            {
                if (value.Length >= 8)
                {
                    _password = Password;

                    foreach (char item in _password)
                    {
                        if (char.IsUpper(item))
                        {

                        }
                    }
                }
                else
                {
                    Console.WriteLine("duzgun daxil edin");
                }
            
            
            }
        
        
        
        }
    }
}
