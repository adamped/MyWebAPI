using MyWebAPI.Abstraction;
using MyWebAPI.Model;

namespace MyWebAPI.Repository
{
    public class DataRepository: IDataRepository
    {

        public void RegisterUser(User user)
        {
            // Enter into repository

            // If you are using Azure SQL, you could use Entity Framework to connect to your SQL Azure DB. But this is beyond the scope of this repo.
        }

    }
}
