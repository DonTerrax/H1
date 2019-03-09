﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;

namespace sletmig
{
    class Userinformation
    {
        public class UserInformation
        {
            public bool GetUserInfo(out List<string> userInformation, string userName)
            {
                userInformation = new List<string>();
                var valueReturn = false;
                try
                {

                    const string pathNameDomain = "LDAP://Miljø.dk";

                    var direcotyEntry = new DirectoryEntry(pathNameDomain);


                    var directorySearcher = new DirectorySearcher(direcotyEntry)
                    {
                        Filter = "(&(objectClass=user)(sAMAccountName=" + userName + "))"
                    };

                    var searchResults = directorySearcher.FindAll();

                    valueReturn = searchResults.Count > 0;

                    foreach (SearchResult searchResult in searchResults)
                    {

                        foreach (var valueCollection in searchResult.Properties.PropertyNames)
                        {
                            userInformation.Add(valueCollection.ToString() + " = " + searchResult.Properties[valueCollection.ToString()][0].ToString());
                        }
                    }

                    direcotyEntry.Dispose();
                    directorySearcher.Dispose();
                    searchResults.Dispose();
                }
                catch (InvalidOperationException iOe)
                {
                }
                catch (NotSupportedException nSe)
                {
                }
                finally
                {
                }
                return valueReturn;
            }
        }
    }
}
