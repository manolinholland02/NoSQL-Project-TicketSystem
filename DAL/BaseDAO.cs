using System;
using System.Collections.Generic;
using MongoDB.Driver;

namespace DAL
{
    public abstract class BaseDAO
    {
        private static MongoClient client;
        protected IMongoDatabase db;
        //Error messages we want to display
        private const string ErrorMsgIntro = "Sorry, but the program received the following error: ";
        protected const string CollectionFailureMessage = "Sorry, there has been a problem with fetching your desired data from our database";

        protected BaseDAO()
        {
            try
            {
                client = new MongoClient("mongodb+srv://GG-Group4:a4oj6VRsNB1T1q3t@gardengroup.nxaaurt.mongodb.net/test");
                db = client.GetDatabase("gardengroupdb");
            }
            catch (Exception e)
            {
                throw new Exception(ErrorMsgIntro, e);
            }
        }
    }
}
